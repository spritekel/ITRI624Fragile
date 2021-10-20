using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using RestSharp.Authenticators;
using System.Diagnostics;

namespace Agile_Extension.Classes
{
    class clsRestAPIHandler
    {

        private const string BASE_URL = "https://mysterious-reef-01698.herokuapp.com/";
        public clsRestAPIHandler()
        {

        }


        public bool create_user(string username, string password, string role)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/user/signup", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(new
                {
                    username = username,
                    password = password,
                    role = role
                });

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                int num_status_code = (int)statusCode;
                if (num_status_code == 201)
                {
                    return true;
                }

              
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            return false;
        }

        public bool login_user(string username, string password)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/user/login", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(new
                {
                    username = username,
                    password = password

                });

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                
                if ((int)statusCode == 200)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            return false; 
        }

    }
}
