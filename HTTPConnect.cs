using System;
using System.Net.Http;
using System.Text;

namespace DeployKeeper_AdminConsole
{
    internal class HTTPConnect
    {
        

        public static string Get(string url)
        {
            return Get(url, new Dictionary<string, string>());
        }

        public static string Get(string url, Dictionary<string, string> additionalHeader)
        {
            try
            {
                HttpClient client = new HttpClient();

                foreach (var header in additionalHeader)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                HttpResponseMessage response = client.GetAsync(url).Result;

                
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Error: {e.Message}";
            }
        }

        public static string Post(string url, string jsonContent)
        {
            return Post(url, jsonContent, new Dictionary<string, string>());
        }

        public static string Post(string url, string jsonContent, Dictionary<string, string> additionalHeader)
        {
            try
            {
                HttpClient client = new HttpClient();

                foreach (var header in additionalHeader)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(url, content).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Error: {e.Message}";
            }
        }

        public static string Patch(string url, string jsonContent)
        {
            return Patch(url, jsonContent, new Dictionary<string, string>());
        }

        public static string Patch(string url, string jsonContent, Dictionary<string, string> additionalHeader)
        {
            try
            {
                HttpClient client = new HttpClient();

                foreach (var header in additionalHeader)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PatchAsync(url, content).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Error: {e.Message}";
            }
        }

        public static string Put(string url, string jsonContent)
        {
            return Put(url, jsonContent, new Dictionary<string, string>());
        }

        public static string Put(string url, string jsonContent, Dictionary<string, string> additionalHeader)
        {
            try
            {
                HttpClient client = new HttpClient();
                
                foreach (var header in additionalHeader)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync(url, content).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Error: {e.Message}";
            }
        }

        public static string Delete(string url)
        {
            return Delete(url, new Dictionary<string, string>());
        }

        public static string Delete(string url, Dictionary<string, string> additionalHeader)
        {
            try
            {
                HttpClient client = new HttpClient();

                foreach (var header in additionalHeader)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                HttpResponseMessage response = client.DeleteAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"Error: {e.Message}";
            }
        }
    }
}
