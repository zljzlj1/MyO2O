using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string strSQL = "SELECT * FROM [User]  Where Username='" + TextBox1.Text.ToString() + "'";
        DataSet ds = DBA.GetDataSet(strSQL);
        if (ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Rows.Count == null)
        {

            string strsql = "insert into User (Username,mm,qrmm,lxdh,yb,sfid,sid,xid,zid,cid,Jtdz,truename) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" +
            TextBox5.Text + "','" + bind_Province.SelectedItem.Value + "','" + bind_City.SelectedItem.Value + "','" + bind_Borough.SelectedItem.Value + "','" + bind_zh.SelectedItem.Value + "','" + bind_cun.SelectedItem.Value + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
            DBA.ExeSql(strsql);
            Session["Username"] = TextBox1.Text;
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "alert", "<script>alert('注册成功!');location.href= 'index.aspx ' ; </script>");

        }
        else
        {
            ClientScript.RegisterStartupScript(ClientScript.GetType(), "alert", "<script>alert('用户名已存在，注册失败,请重新注册!');</script>");
        }






    }













    DBAccess1 DBA = new DBAccess1();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DataList1_content();
        }


    }
    private void DataList1_content()
    {
        string SQLStr = "select * from jsjxs";
        DataSet ds = DBA.GetDataSet(SQLStr);

        int rowSum = ds.Tables[0].Rows.Count;
        PagedDataSource objPds = new PagedDataSource();
        objPds.DataSource = ds.Tables[0].DefaultView;
        objPds.AllowPaging = true;
        objPds.PageSize = 12;
        int maxPage;//总共有多少页
        if (rowSum == 0) return;//如果没有数据，退出过程
        if (rowSum % objPds.PageSize > 0)//计算出浏览数据的总页数
        {
            maxPage = rowSum / objPds.PageSize + 1;//有余数要加1
        }
        else
        {
            maxPage = rowSum / objPds.PageSize;//正好除尽
        }
        int CurPage;//计算当前页
        CurPage = 1;
        objPds.CurrentPageIndex = CurPage - 1;
        Session["CurPage"] = CurPage;//*****************************************************
        lblCurrentPage.Text = "第 " + CurPage.ToString() + " 页 (共" + maxPage.ToString() + "页)";
        DataList1.DataSource = objPds;
        DataList1.DataBind();
    }

    public void PagerButtonClick(object sender, EventArgs e)
    {
        string SQLStr = "select * from jsjxs";
        DataSet ds = DBA.GetDataSet(SQLStr);

        int rowSum = ds.Tables[0].Rows.Count;

        PagedDataSource objPds = new PagedDataSource();
        objPds.DataSource = ds.Tables[0].DefaultView;
        objPds.AllowPaging = true;
        objPds.PageSize = 12;

        int maxPage;//总共有多少页
        if (rowSum == 0)
        {
            return;//如果没有数据，退出过程
        }

        if (rowSum % objPds.PageSize > 0)//计算出浏览数据的总页数
        {
            maxPage = rowSum / objPds.PageSize + 1;//有余数要加1
        }
        else
        {
            maxPage = rowSum / objPds.PageSize;//正好除尽
        }
        objPds.CurrentPageIndex = Convert.ToInt32(Session["CurPage"]) - 1;//*********************
        string arg = ((LinkButton)sender).CommandArgument.ToString();
        switch (arg)
        {
            case "next":
                if (objPds.CurrentPageIndex < (maxPage - 1))//未到末页
                {
                    objPds.CurrentPageIndex += 1;
                }
                break;
            case "prev":
                if (objPds.CurrentPageIndex > 0)
                {
                    objPds.CurrentPageIndex -= 1;
                }
                break;
            case "last":
                objPds.CurrentPageIndex = (maxPage - 1);
                break;
            default:
                objPds.CurrentPageIndex = 0;// System.Convert.ToInt32(arg)
                break;
        }
        int CurPage = objPds.CurrentPageIndex + 1;//*********************

        lblCurrentPage.Text = "第 " + CurPage.ToString() + " 页 (共" + maxPage.ToString() + "页)";
        Session["CurPage"] = CurPage;//*********************
        DataList1.DataSource = objPds;
        DataList1.DataBind();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        int vgoto = 1;
        if (TextBox1.Text != "")
        {
            string SQLStr = "select * from jsjxs";
            vgoto = Convert.ToInt32(TextBox1.Text.ToString().Trim());
            Session["vgoto"] = vgoto;
            TextBox1.Text = Session["vgoto"].ToString().Trim();
            DataSet ds = DBA.GetDataSet(SQLStr);
            int rowSum = ds.Tables[0].Rows.Count;
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = ds.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 12;
            int maxPage;//总共有多少页
            if (rowSum == 0)
            {
                return;//如?果?没?有瓺数簓据Y，?退?出?过y程ì
            }
            if (rowSum % objPds.PageSize > 0)//计算出浏览数据的总页数
            {
                maxPage = rowSum / objPds.PageSize + 1;//有余数要加1
            }
            else
            {
                maxPage = rowSum / objPds.PageSize;//正好除尽
            }
            int CurPage;//计算当前页
            CurPage = vgoto;
            Session["CurPage"] = CurPage;//*****************************************************
            objPds.CurrentPageIndex = CurPage - 1;
            lblCurrentPage.Text = "第 " + CurPage.ToString() + " 页 (共" + maxPage.ToString() + "页)";
            DataList1.DataSource = objPds;
            DataList1.DataBind();
        }

    }

}