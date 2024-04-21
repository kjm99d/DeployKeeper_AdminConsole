using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        private UIProductProfile m_productProfile;

        public UserProfileManager(TreeView view)
        {
            if (null == m_view) m_view = view;

            if (null == m_products) m_products = new TypeProduct();

            if (null == m_userProducts) m_userProducts = new TypeUserProduct();

            SetNodeClickEvent();
        }

        private void CreateUserObject(ref JObject obj, string strIdProduct, TreeNode SelectedNode)
        {
            // ID 로 찾는다.
            string strId = SelectedNode.Name.Split("USERPRODUCT_")[1];
            int nId = Convert.ToInt32(strId);

            JObject? sel = null;
            foreach (var item in m_userProducts)
            {
                if (Convert.ToInt32(item["id"]) == nId && strIdProduct.Equals(item["product_id"].ToString()))
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

        public void SetUserProfile(UIUserProfile userControl)
        {
            m_userProfile = userControl;
        }

        public void SetProductProfile(UIProductProfile userControl)
        {
            m_productProfile = userControl;
        }

        private void SetGroup()
        {
            m_productProfile.Visible = true;
            m_userProfile.Visible = false;
        }
        private void SetUser()
        {
            m_productProfile.Visible = false;
            m_userProfile.Visible = true;
        }

        // 노드를 선택 했을 때 발생하는 이벤트
        public void SetNodeClickEvent()
        {
            if (null == m_view) return;

            m_view.AfterSelect += (sender, e) =>
            {
                TreeNode node = e?.Node;
                string strNodeName = node.Name;
                if (0 == strNodeName.IndexOf("USERPRODUCT_"))
                {
                    // :: 사용자 노드를 클릭한 경우 부모노트(제품 노드) 에서 제품 ID를 취득한다.
                    string strIdProduct = node.Parent.Name.Split("PRODUCT_")[1];
                    SetUser();

                    m_userProfile?.Clear();

                    // 노드가 사용자노드이다.
                    Debug.WriteLine("Selected User Node .. ");

                    // Notify UserProfile : 유저프로파일 컨트롤에 현재 클릭된 노드의 정보를 전달한다.
                    JObject obj = new JObject();
                    CreateUserObject(ref obj, strIdProduct, node);
                    m_userProfile?.SetUser(obj);
                }
                else if (0 == strNodeName.IndexOf("PRODUCT_"))
                {
                    SetGroup();

                    string strIdProduct = strNodeName.Split("_")[1];
                    int nIdProduct = Convert.ToInt32(strIdProduct);
                    string strNameProduct = m_products[nIdProduct];
                    m_productProfile.SetProductInfo(strNameProduct, strIdProduct);

                }

            };
        }

        public bool Update()
        {
            m_view?.Nodes.Clear();

            if (false == GetData()) return false;

            // ======================================================== //
            
            // 리스트뷰에 제품 목록을 추가한다.
            foreach(var product in m_products)
            {
                string NodeName = "PRODUCT_" + product.Key.ToString();
                string NodeText = product.Value;

                TreeNode temp = new TreeNode();
                temp.Name = NodeName;
                temp.Text = NodeText;

                // 해당 제품에 가입된 사용자를 추가한다.
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
