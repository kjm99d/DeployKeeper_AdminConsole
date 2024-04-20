using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===================================================== //
// ======================= Types ======================= //
using TypeProduct = System.Collections.Generic.Dictionary<int, string>;
using TypeUserProduct = System.Collections.Generic.List<Newtonsoft.Json.Linq.JObject>;
// ===================================================== //

namespace DeployKeeper_AdminConsole
{
    internal class UserProfileManager
    {
        private TreeView m_view;

        private TypeProduct m_products;
        private TypeUserProduct m_userProducts;
        private UIUserProfile m_userProfile;

        public UserProfileManager(TreeView view)
        {
            if (null == m_view) m_view = view;

            if (null == m_products) m_products = new TypeProduct();

            if (null == m_userProducts) m_userProducts = new TypeUserProduct();

            SetClickEvent();
        }

        private void CreateUserObject(ref JObject obj, TreeNode SelectedNode)
        {
            // ID 로 찾는다.
            string strId = SelectedNode.Name.Split("USERPRODUCT_")[1];
            int nId = Convert.ToInt32(strId);

            JObject? sel = null;
            foreach (var item in m_userProducts)
            {
                if (Convert.ToInt32(item["id"]) == nId)
                {
                    sel = item;
                    break;
                }
            }


            if (null != sel)
            {
                obj = sel;
                obj["product_name"] = "123";
            }


        }

        public void SetUserProfile(UIUserProfile userProfile)
        {
            m_userProfile = userProfile;
        }

        // 노드를 선택 했을 때 발생하는 이벤트
        public void SetClickEvent()
        {
            if (null == m_view) return;

            m_view.AfterSelect += (sender, e) =>
            {
                m_userProfile?.Clear();

                TreeNode node = e?.Node;
                if (node.Nodes.Count > 0 || false == node.Name.Contains("USERPRODUCT_")) return;
                

                // 노드가 사용자노드이다.
                Debug.WriteLine("Selected User Node .. ");

                // Notify UserProfile : 유저프로파일 컨트롤에 현재 클릭된 노드의 정보를 전달한다.
                JObject obj = new JObject();
                CreateUserObject(ref obj, node);
                m_userProfile?.SetUser(obj);
                
                
            };
        }

        public bool Update()
        {
            m_view?.Nodes.Clear();

            if (false == GetData()) return false;

            // ======================================================== //
            
            // Users 에 제품 목록을 추가한다.
            foreach(var product in m_products)
            {
                string NodeName = "PRODUCT_" + product.Key.ToString();
                string NodeText = product.Value;

                TreeNode temp = new TreeNode();
                temp.Name = NodeName;
                temp.Text = NodeText;

                AddUserNode(product.Key, temp);

                m_view?.Nodes.Add(temp);
            }

            

            // ======================================================== //

            return true;
        }

        private void AddUserNode(int nProductId, TreeNode node)
        {
            foreach (var userProduct in m_userProducts)
            {
                if (nProductId == Convert.ToInt32(userProduct["product_id"]))
                {

                    string NodeName = "USERPRODUCT_" + userProduct["id"].ToString();
                    string NodeText = userProduct["username"].ToString();

                    TreeNode temp = new TreeNode();
                    temp.Name = NodeName;
                    temp.Text = NodeText;

                    node.Nodes.Add(temp);
                }
            }
        }

        private bool GetUserProductList()
        {
            bool bResult = false;

            try
            {
                APIConnect handler = APIConnect.Instance;

                JObject userProductInfo = handler.GetUserProductList();
                if (null != userProductInfo && 0 == Convert.ToInt32(userProductInfo["code"]))
                {
                    JArray items = (JArray)userProductInfo["data"];

                    foreach (var item in items)
                    {
                        m_userProducts.Add((JObject)item);
                    }

                    bResult = true;
                }

            }
            catch (Exception ex)
            {

            }


            return bResult;
        }

        private bool GetProductList()
        {
            bool bResult = false;

            try
            {
                APIConnect handler = APIConnect.Instance;

                JObject productInfo = handler.GetProductList();
                if (null != productInfo && 0 == Convert.ToInt32(productInfo["code"]))
                {
                    JArray items = (JArray)productInfo["data"];

                    foreach (var item in items)
                    {
                        int nId = Convert.ToInt32(item["id"]);
                        string strName = (string)item["product_name"];

                        m_products.Add(nId, strName);
                    }

                    bResult = true;
                }

            }
            catch (Exception ex)
            {

            }


            return bResult;
        }

        private bool GetData()
        {
            m_products.Clear();
            if (false == GetProductList()) return false;
            m_userProducts.Clear();
            if (false == GetUserProductList()) return false;


            return true;
        }
    }
}
