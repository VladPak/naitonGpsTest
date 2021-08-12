using NaitonGps.Models;
using Newtonsoft.Json;
using SimpleWSA;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace NaitonGps.Services
{
    public static class ApiService
    {
        public static async Task<bool> GetWebService(string webserviceLink)
        {
            string webservice = String.Format("https://connectionprovider.naiton.com/DataAccess/{0}/restservice/address", webserviceLink);

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(webservice);
            var responseContent = await response.Content.ReadAsStringAsync();
            var rsToString = responseContent.ToString();
            Preferences.Set("webservicelink", rsToString);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public class WebServiceSuccessResponse<TSuccess, TError>
        {
            public TSuccess Success { get; set; }

            public TError Error { get; set; }
        }

        public class WebServiceSuccessResponse<TSuccess> : WebServiceSuccessResponse<TSuccess, WebServiceErrorContent>
        { }

        public class WebServiceErrorContent
        {
            public string Message { get; set; }
            public string ErrorCode { get; set; }
        }

        public class InitializeSessionResponseContent
        {
            public string Function { get; set; }
            public string Token { get; set; }
        }

        public static async Task<bool> Login(string email, string password)
        {
            var domain = Preferences.Get("loginCompany", string.Empty);
            var webserviceLink = Preferences.Get("webservicelink", string.Empty);
            string getTokenLink = String.Format(webserviceLink + "InitializeSession?domain={0}&login={1}&password={2}", domain, email, password);

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(getTokenLink);
            var responseContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<WebServiceSuccessResponse<InitializeSessionResponseContent>>(responseContent);
            var tokenItself = content.Success.Token;
            //var rsToString = responseContent.ToString();
            Preferences.Set("accessToken", tokenItself);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //public static async Task<bool> LoginWSA(string email, string password)
        //{
        //    //var domain = Preferences.Get("loginCompany", string.Empty);
        //    //var webserviceLink = Preferences.Get("webservicelink", string.Empty);
        //    //Session session = new Session(email, password, false, 1, "1", domain, null);
        //    //await session.CreateByRestServiceAddressAsync(webserviceLink);

        //    //if (!)
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    return true;
        //    //}
        //}

        public static async Task<Dictionary<string, Roles[]>> GetAllUserRoles()
        {
            SimpleWSA.Command command = new SimpleWSA.Command("rolemanager_getcheckroleobjects");
            command.Parameters.Add("_roleid", PgsqlDbType.Integer).Value = 1;
            command.WriteSchema = WriteSchema.TRUE;
            string xmlResult = SimpleWSA.Command.Execute(command,
                                               RoutineType.DataSet,
                                               httpMethod: SimpleWSA.HttpMethod.GET,
                                               responseFormat: ResponseFormat.JSON);

            var dataFinalize = JsonConvert.DeserializeObject<Dictionary<string, Roles[]>>(xmlResult);

            return dataFinalize;
        }
    }
}
