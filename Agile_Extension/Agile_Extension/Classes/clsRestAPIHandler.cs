using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using RestSharp.Authenticators;
using System.Diagnostics;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Agile_Extension.Classes
{
    class clsRestAPIHandler
    {

        private const string BASE_URL = "https://mysterious-reef-01698.herokuapp.com/";
        public clsRestAPIHandler()
        {

        }
        #region USER_ROUTES
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
                Debug.WriteLine("login_user" + response.Content);
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
                Debug.WriteLine("login_user" + response.Content);
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
     
        public JObject get_user_info(string username)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/user/" + username, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);
                
                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("get_user_info" + response.Content);
                if ((int)statusCode == 200)
                {            
                    return toJsonObject(response.Content);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            return null;
        }

        public JObject get_all_users()
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/user/", Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                var response = client.Execute(request);

                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("get_all_users: " + response.Content);
                if ((int)statusCode == 200)
                {               
                    return toJsonObject(response.Content);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            return null;
        }

        public JObject update_user(string username ,string content)
        {
            try
            {
             
                Debug.WriteLine("data to be sent: update user: " + content);
                
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/user/" + username, Method.PATCH);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");  
                request.AddJsonBody(content);

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("update_user: " + response.Content);

                if ((int)statusCode == 200)
                {                    
                    return toJsonObject(response.Content);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            return null;
        }

        #endregion
 
        #region PROJECT_ROUTES
        public JObject create_project(string project_name, List<string> members, List<string> sprints)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/project/project_create", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(new
                {
                    projName = project_name,
                    projUsers = members,
                    sprints = sprints
                });
                var response = client.Execute(request);

                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("create_project: " + response.Content);
                if ((int)statusCode == 201)
                {                  
                    return toJsonObject(response.Content);
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            return null;
        }

        public JObject delete_project(string project_name)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/project/" + project_name, Method.DELETE);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("Delete project: " + response.Content);

                if ((int)statusCode == 200)
                {
                    return toJsonObject(response.Content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return null;
        }

        #endregion

        #region SPRINT_ROUTES
        public JObject create_sprint(string sprint_name, string project)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/sprint/sprint_create", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(new
                {
                    sprName = sprint_name,
                    project = project
                });
                var response = client.Execute(request);

                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("create_project: " + response.Content);
                if ((int)statusCode == 201)
                {
                    return toJsonObject(response.Content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            return null;
        }

        public JObject update_sprint(string sprint_name, string content)
        {
            try
            {

                Debug.WriteLine("data to be sent: update user: " + content);

                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/sprint/" + sprint_name, Method.PATCH);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(content);

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("Update Sprint: " + response.Content);

                if ((int)statusCode == 200)
                {
                    return toJsonObject(response.Content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return null;
        }

        public JObject delete_sprint(string sprint_name)
        {
            try
            {
                var client = new RestClient(BASE_URL);
                var request = new RestRequest("/sprint/" + sprint_name, Method.DELETE);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-type", "application/json");

                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                Debug.WriteLine("Delete sprint: " + response.Content);

                if ((int)statusCode == 200)
                {
                    return toJsonObject(response.Content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return null;
        }


        #endregion

        #region GENERIC_METHODS
        public JObject toJsonObject(string response)
        {
            JObject obj = JObject.Parse(response);
            return obj;
        }
        #endregion
    }

    
}
