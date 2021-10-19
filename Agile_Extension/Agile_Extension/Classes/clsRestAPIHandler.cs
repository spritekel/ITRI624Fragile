using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace Agile_Extension.Classes
{
    class clsRestAPIHandler
    {

        private const string BASE_URL = "";
        public clsRestAPIHandler()
        {

        }


        public bool create_user(string username, string password, string role)
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(new
            {
                username = username,
                password = password,
                role = role
            });
            
            var response = client.Execute(request);

            if(response.StatusCode.GetHashCode() == 200)
            {
                return true;
            }

            return false;
        }

        public bool login_user(string username, string password)
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(new
            {
                username = username,
                password = password

            });

            var respone = client.Execute(request);

            if(respone.StatusCode.GetHashCode() == 200)
            {
                return true;
            }

            return false; 
        }



    }
}
