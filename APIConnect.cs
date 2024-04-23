using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DeployKeeper_AdminConsole
{
    internal class APIConnect
    {
        private static APIConnect? instance;
        private static readonly object lockObject = new object();

        private const string host = "http://localhost:8080";
        private string m_accessToken = "";

        private APIConnect() { }

        public static APIConnect Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new APIConnect();
                    }
                    return instance;
                }
            }
        }

        public JObject GetProductList()
        {
            const string url = host + "/api/admin/product/all";
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", m_accessToken);
            string strResp = HTTPConnect.Get(url, header);

            return JObject.Parse(strResp);

        }

        public JObject AddProduct(string strNameProduct)
        {
            const string url = host + "/api/admin/product";
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            JObject obj = new JObject();
            obj["productName"] = strNameProduct;

            string strResp = HTTPConnect.Put(url, obj.ToString(), header);

            return JObject.Parse(strResp);
        }

        public JObject DeleteProduct(int nProductId)
        {
            string url = host + "/api/admin/product/" + nProductId.ToString();
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            string strResp = HTTPConnect.Delete(url, header);

            return JObject.Parse(strResp);
        }

        public JObject AddProductPolicy(int nIdProduct, string strPolicyName)
        {
            const string url = host + "/api/admin/product/policy";
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            JObject obj         = new JObject();
            obj["productId"]    = nIdProduct;
            obj["policyName"]   = strPolicyName;

            string strResp = HTTPConnect.Put(url, obj.ToString(), header);

            return JObject.Parse(strResp);
        }


        public JObject GetUserProductList()
        {
            const string url = host + "/api/admin/users";
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);
            string strResp = HTTPConnect.Get(url, header);

            return JObject.Parse(strResp);

        }

        public JObject GetProductPolicy(int nProductId)
        {
            string url = host + "/api/admin/product/policy/" + nProductId.ToString();
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);
            string strResp = HTTPConnect.Get(url, header);

            return JObject.Parse(strResp);
        }

        public JObject DeleteProductPolicy(int nIdProduct, int nIdPolicy)
        {
            string url = host + "/api/admin/product/policy/" + nIdProduct.ToString() + "/" + nIdPolicy.ToString();
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);
            string strResp = HTTPConnect.Delete(url, header);

            return JObject.Parse(strResp);
        }

        public JObject GetUserPolicy(int nUserId, int nProductId)
        {
            const string url = host + "/api/admin/user/policy";
            
            // Request Header 
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            // Payloads
            JObject obj = new JObject();
            obj["userId"] = nUserId;
            obj["productId"] = nProductId;


            string strResp = HTTPConnect.Post(url, obj.ToString() ,header);

            return JObject.Parse(strResp);
        }


        public bool SetUserPolicy(int nUserId, int nProductId, List<JObject> data)
        {
            const string url = host + "/api/admin/user/policy";
            JObject contents = new JObject();

            contents["userId"] = nUserId;
            contents["productId"] = nProductId;
            contents["data"] = new JArray(data);

            string jsonString = contents.ToString();

            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            var response = JObject.Parse(HTTPConnect.Patch(url, jsonString, header));
            if (0 == Convert.ToInt32(response["code"]))
            {
                return true;
            }

            return false;
        }

        public bool SetUserExpirationDate(int nUserId, int nProductId, List<string> data)
        {
            const string url = host + "/api/admin/user/product/date";
            JObject contents = new JObject();

            contents["userId"] = nUserId;
            contents["productId"] = nProductId;
            contents["data"] = new JArray(data);

            string jsonString = contents.ToString();

            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            var response = JObject.Parse(HTTPConnect.Patch(url, jsonString, header));
            if (0 == Convert.ToInt32(response["code"]))
            {
                return true;
            }

            return false;
        }

        public JObject GetUserExpirationDate(int nUserId, int nProductId)
        {
            string url = host + $"/api/admin/user/product/date?userId={nProductId}&productId={nUserId}";

            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("authorization", "Bearer " + m_accessToken);

            var response = JObject.Parse(HTTPConnect.Get(url,  header));

            return response;
        }


        // Deprecated
        public bool LoginAdmin(string username, string passwd)
        {
            const string url = host + "/api/user/login_admin";
            JObject contents = new JObject();
            contents["username"] = username;
            contents["passwd"] = passwd;
            var response = JObject.Parse(HTTPConnect.Post(url, contents.ToString()));
            if (0 == Convert.ToInt32(response["code"]))
            {
                JArray datas = (JArray)response["data"];
                m_accessToken = datas[0].ToString();

                return true;
            }

            return false;
        }

        public JObject GetAllProduct()
        {
            const string url = host + "/api/product/all";
            return JObject.Parse(HTTPConnect.Get(url));
        }

        public bool Login(string username, string password)
        {
            const string url = host + "/api/user/login";
            JObject contents = new JObject();
            contents["username"] = username;
            contents["passwd"] = password;
            var response = JObject.Parse(HTTPConnect.Post(url, contents.ToString()));
            if (0 == Convert.ToInt32(response["code"]))
            {
                JArray datas = (JArray)response["data"];
                m_accessToken = datas[0].ToString();

                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(m_accessToken);

                if (1 == Convert.ToInt32(jwtToken.Payload["isAdmin"]))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
