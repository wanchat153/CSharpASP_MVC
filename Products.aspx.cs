using CSharpASP_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpASP_MVC
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ProductRepository productsRepository = new ProductRepository();
            //productsRepository.getProducts();

            //!IsPostBack ตรวจสอบการแสดงผลของหน้าจอ
            if (!IsPostBack)
            {
                bindDataProducts();
            }
        }

        private void bindDataProducts()
        {
            ProductRepository productsRepository = new ProductRepository();
            gridViewProductList.DataSource = productsRepository.getProducts();
            gridViewProductList.DataBind();
        }
    }
}