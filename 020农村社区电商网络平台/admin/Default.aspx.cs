using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class admin_Default : System.Web.UI.Page
{
    DBAccess1 DBA = new DBAccess1();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.BackColor = System.Drawing.Color.Transparent;
        TextBox2.BackColor = System.Drawing.Color.Transparent;
        TextBox3.BackColor = System.Drawing.Color.Transparent;
       TextBox4.BackColor = System.Drawing.Color.Transparent;
       TextBox5.BackColor = System.Drawing.Color.Transparent;
        if (!IsPostBack)
        {
            GridView1_content();
            GridView2_content();
            GridView3_content();
            GridView4_content();
            GridView5_content();

        }
        GridView1_content();
        GridView2_content();
        GridView3_content();
        GridView4_content();
        GridView5_content();
    }

    

  protected void GridView1_content()
    {

        string strSQL = "select * from Adsf";
        DataSet ds = DBA.GetDataSet(strSQL);
        GridView1.DataSource = ds.Tables["datatable"].DefaultView;
        GridView1.DataBind();
      Show();
}

  protected void GridView2_content()
  {       string strSQ = "select  sm,sid,Sf from Adsf,Ads where Ads.sfid=Adsf.sfid";
        DataSet ds = DBA.GetDataSet(strSQ);
        GridView2.DataSource = ds.Tables["datatable"].DefaultView;
        GridView2.DataBind();
        Show1();
  }
  protected void GridView3_content()
  {        string strS = "select sm,xid,xm from Ads,Adx where Ads.sid=Adx.sid";
        DataSet ds = DBA.GetDataSet(strS);
        GridView3.DataSource = ds.Tables["datatable"].DefaultView;
        GridView3.DataBind(); Show2();
  }
  protected void GridView4_content()
  {      string strSa = "select xm,zid,zm from Adz,Adx where Adz.xid=Adx.xid";
        DataSet ds = DBA.GetDataSet(strSa);
        GridView4.DataSource = ds.Tables["datatable"].DefaultView;
        GridView4.DataBind(); Show3();
  }
  protected void GridView5_content()
  {         string strSj = "select zm,cid,cm from Adc,Adz where Adz.zid=Adc.zid";
        DataSet ds = DBA.GetDataSet(strSj);
        GridView5.DataSource = ds.Tables["datatable"].DefaultView;
        GridView5.DataBind(); Show4();
  }
    private void Show()
    {//显示当前页数和总页数

        Label1.Text = "第 " + (GridView1.PageIndex + 1).ToString() + " 页";
        if (GridView1.PageCount == 0)
            Label2.Text = "总共 " + 1 + " 页";
        else
            Label2.Text = "总共 " + GridView1.PageCount.ToString() + " 页";
    }
    private void Show1()
    {//显示当前页数和总页数
        Label3.Text = "第 " + (GridView2.PageIndex + 1).ToString() + " 页";
        if (GridView2.PageCount == 0)
            Label4.Text = "总共 " + 1 + " 页";
        else
            Label4.Text = "总共 " + GridView2.PageCount.ToString() + " 页";
    }
    private void Show2()
    {//显示当前页数和总页数
        Label5.Text = "第 " + (GridView3.PageIndex + 1).ToString() + " 页";
        if (GridView3.PageCount == 0)
            Label6.Text = "总共 " + 1 + " 页";
        else
            Label6.Text = "总共 " + GridView3.PageCount.ToString() + " 页";

    }
    private void Show3()
    {//显示当前页数和总页数
        Label7.Text = "第 " + (GridView4.PageIndex + 1).ToString() + " 页";
        if (GridView4.PageCount == 0)
            Label8.Text = "总共 " + 1 + " 页";
        else
            Label8.Text = "总共 " + GridView4.PageCount.ToString() + " 页";
    }
    private void Show4()
    {//显示当前页数和总页数
        Label9.Text = "第 " + (GridView5.PageIndex + 1).ToString() + " 页";
        if (GridView5.PageCount == 0)
            Label10.Text = "总共 " + 1 + " 页";
        else
            Label10.Text = "总共 " + GridView5.PageCount.ToString() + " 页";
   
    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    { 
        string sf = TextBox1.Text;
      
      

        if (sf!= "" || sf != null)
        {
            GridView1.PageIndex = e.NewPageIndex;
            ss();
        }
        else
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1_content();
        }  
      
       
}  protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string x = TextBox3.Text;
    
    if (x != "" || x != null)
        {
            GridView3.PageIndex = e.NewPageIndex;
            ss();
        }
        else
        {
            GridView3.PageIndex = e.NewPageIndex;
            GridView3_content();
        }
       
  
  }
    protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string z = TextBox4.Text;
       
 if (z != "" || z != null)
        {
            GridView4.PageIndex = e.NewPageIndex;
            ss();
        }
        else
        {
            GridView4.PageIndex = e.NewPageIndex;
            GridView4_content();
        }

    }
    protected void GridView5_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string c = TextBox5.Text;
        if (c != "" || c != null)
        {
            GridView5.PageIndex = e.NewPageIndex;
            ss();
        }
        else
        {
            GridView5.PageIndex = e.NewPageIndex;
            GridView5_content();
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vsfid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string strSQL = "delete from Adsf where sfid='" + vsfid + "'";//删除记录
        DBA.ExeSql(strSQL);
        if ((GridView1.Rows.Count) % (GridView1.PageSize) == 1)//判断最后一页是否只有一条记录
        {
            GridView1.PageIndex = GridView1.PageIndex - 1;
        }
      if (TextBox1.Text == "" || TextBox1.Text == null)
            GridView1_content();
        else
            ss();
        
     
      
       

    }
    protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vxid = GridView3.DataKeys[e.RowIndex].Value.ToString();
        string strS = "delete from Adx where xid='" + vxid + "'";//删除记录
        DBA.ExeSql(strS);
        if ((GridView3.Rows.Count) % (GridView3.PageSize) == 1)//判断最后一页是否只有一条记录
        {
            GridView3.PageIndex = GridView3.PageIndex - 1;
        }
        if (TextBox3.Text == "" || TextBox3.Text == null)
            GridView3_content();
        else
            ss2();
    }
    protected void GridView4_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vzid = GridView4.DataKeys[e.RowIndex].Value.ToString();
        string str = "delete from Adz where zid='" + vzid + "'";//删除记录
        DBA.ExeSql(str);
        if ((GridView4.Rows.Count) % (GridView4.PageSize) == 1)//判断最后一页是否只有一条记录
        {
            GridView4.PageIndex = GridView4.PageIndex - 1;
        }
        if (TextBox4.Text == "" || TextBox4.Text == null)
            GridView4_content();
        else
            ss3();
        

    }
    protected void GridView5_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vcid = GridView5.DataKeys[e.RowIndex].Value.ToString();
        string st = "delete from Adc where cid='" + vcid + "'";//删除记录
        DBA.ExeSql(st);
        if ((GridView5.Rows.Count) % (GridView5.PageSize) == 1)//判断最后一页是否只有一条记录
        {
            GridView5.PageIndex = GridView5.PageIndex - 1;
        }
        if ( TextBox5.Text == "" || TextBox5.Text == null)
            GridView5_content();
        else
            ss4();
    }
   
    protected void link(object sender, EventArgs e)
    {
        string args = ((LinkButton)sender).CommandArgument.ToString();
        switch (args)
        {//根据不同的arguement值,进行相应的操作：
            case "n":
                if (GridView1.PageIndex < GridView1.PageCount - 1)//判断是否为最后一条记录
                {
                    GridView1.PageIndex = GridView1.PageIndex + 1;//读取到下一页
                }
                break;//返回
            case "p":
                if (GridView1.PageIndex > 0)//判断是否为第一页
                {
                    GridView1.PageIndex = GridView1.PageIndex - 1;//读取到前一页的内容
                }
                break;
            case "l":
                if ((GridView1.PageCount - 1) > 0)
                    GridView1.PageIndex = (GridView1.PageCount - 1);//读取最后一页
                break;
            default://不满足上述情况，则读取首页的内容
                GridView1.PageIndex = 0;
                break;
        }

        if (TextBox1.Text == "" || TextBox1.Text == null)
            GridView1_content();
        else
            ss();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            

            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
            //当鼠标移开时还原背景色
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[3].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：这条\"" + e.Row.Cells[1].Text + "\"信息吗?')");
            }
          
        }
     
        
     
        }
    
    
    
  
 
    
    protected void ss()
    {

        string t = TextBox1.Text;

        if (t != "" && t != null)
        {
            string sql = "select Adsf.* from Adsf where  sf  like '%" + t + "%'";
    
           DataSet ds = DBA.GetDataSet(sql);
            GridView1.DataSource = ds.Tables["datatable"].DefaultView;
            GridView1.DataBind();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('无此省份信息！');", true);
                GridView1_content();

            }
            else
                Show();
        }
        else if (t == "" || t == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('请输入搜索关键字！');", true);
            GridView1_content();
        }
       

    }
    protected void ss1()
    {

        string t = TextBox2.Text;

        if (t != "" && t != null)
        {
            string sql = "select sm,sid,Sf from Ads,Adsf  where Adsf.sfid=Ads.sfid and Ads.sm  like '%" + t + "%'";
           
            
            //string sql = "select Ads.* from Ads  where  Adsf.sfid=Ads.sfid and Ads.sid=Adx.sid and Adx.xid=Adz.xid and Adz.zid=Adc.zid and Adsf.sf  like '%" + t + "%'";

            DataSet ds = DBA.GetDataSet(sql);
            GridView2.DataSource = ds.Tables["datatable"].DefaultView;
            GridView2.DataBind();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('无此市信息！');", true);
                GridView2_content();

            }
            else
                Show1();
        }
        else if (t == "" || t == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('请输入搜索关键字！');", true);
            GridView2_content();
        }


    }
    protected void ss2()
    {

        string t = TextBox3.Text;

        if (t != "" && t != null)
        {
            string sql = "select xm,xid,sm from Ads,Adx  where Adx.sid=Ads.sid and Adx.xm  like '%" + t + "%'";
            DataSet ds = DBA.GetDataSet(sql);
            GridView3.DataSource = ds.Tables["datatable"].DefaultView;
            GridView3.DataBind();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('无此县信息！');", true);
                GridView3_content();

            }
            else
                Show2();
        }
        else if (t == "" || t == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('请输入搜索关键字！');", true);
            GridView3_content();
        }


    }
    protected void ss3()
    {

        string t = TextBox4.Text;

        if (t != "" && t != null)
        {
            string sql = "select zm,zid,xm from Adz,Adx  where Adx.xid=Adz.zid and Adz.zm  like '%" + t + "%'";
            DataSet ds = DBA.GetDataSet(sql);
            GridView4.DataSource = ds.Tables["datatable"].DefaultView;
            GridView4.DataBind();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('无此镇信息！');", true);
                GridView4_content();

            }
            else
                Show3();
        }
        else if (t == "" || t == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('请输入搜索关键字！');", true);
            GridView4_content();
        }


    }
    protected void ss4()
    {

        string t = TextBox5.Text;

        if (t != "" && t != null)
        {
            string sql = "select cm,cid,zm from Adz,Adc  where Adz.zid=Adc.zid and Adc.cm  like '%" + t + "%'";
            DataSet ds = DBA.GetDataSet(sql);
            GridView5.DataSource = ds.Tables["datatable"].DefaultView;
            GridView5.DataBind();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('无此村信息！');", true);
                GridView5_content();

            }
            else
                Show4();
        }
        else if (t == "" || t == null)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "test", "alert('请输入搜索关键字！');", true);
            GridView5_content();
        }


    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = (int)e.NewEditIndex;
        GridView1_content();
    }
    protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView3.EditIndex = (int)e.NewEditIndex;
        GridView3_content();
    }
    protected void GridView4_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView4.EditIndex = (int)e.NewEditIndex;
        GridView4_content();
    }
    protected void GridView5_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView5.EditIndex = (int)e.NewEditIndex;
        GridView5_content();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1_content();
    }

    protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView3.EditIndex = -1;
        GridView3_content();
    }
    protected void GridView4_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView4.EditIndex = -1;
        GridView4_content();

    }
    protected void GridView5_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView5.EditIndex = -1;
        GridView5_content();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string k = GridView1.DataKeys[e.RowIndex].Value.ToString();
      string vSf = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.Trim();
       string sql = " update Adsf set Sf='" + vSf+ "' where sfid='" + k + "' ";
     DataSet ds = DBA.GetDataSet(sql);
        GridView1.EditIndex = -1;
        GridView1_content();

}
    protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string k = GridView3.DataKeys[e.RowIndex].Value.ToString();
        string vxm = ((TextBox)(GridView3.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();
        string sql = " update Adx set xm='" + vxm + "' where xid='" + k + "' ";
        DataSet ds = DBA.GetDataSet(sql);
        GridView3.EditIndex = -1;
        GridView3_content();

    }
    protected void GridView4_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string k = GridView4.DataKeys[e.RowIndex].Value.ToString();
        string vzm = ((TextBox)(GridView4.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();
        string sql = " update Adz set zm='" + vzm + "' where zid='" + k + "' ";
        DataSet ds = DBA.GetDataSet(sql);
        GridView4.EditIndex = -1;
        GridView4_content();

    }
    protected void GridView5_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string k = GridView5.DataKeys[e.RowIndex].Value.ToString();
        string vcm = ((TextBox)(GridView5.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();
        string sql = " update Adc set cm='" + vcm + "' where cid='" + k + "' ";
        DataSet ds = DBA.GetDataSet(sql);
        GridView5.EditIndex = -1;
        GridView5_content();

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ss();
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string s = TextBox2.Text;
        if (s != "" || s != null)
        {
            GridView2.PageIndex = e.NewPageIndex;
            ss();
        }
        else
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2_content();
        }

    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
            //当鼠标移开时还原背景色
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：这条\"" + e.Row.Cells[1].Text + "\"信息吗?')");
            }

        }
     
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
            //当鼠标移开时还原背景色
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：这条\"" + e.Row.Cells[1].Text + "\"信息吗?')");
            }

        }

    }
    protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
            //当鼠标移开时还原背景色
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：这条\"" + e.Row.Cells[1].Text + "\"信息吗?')");
            }

        }

    }
    protected void GridView5_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
            //当鼠标移开时还原背景色
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：这条\"" + e.Row.Cells[1].Text + "\"信息吗?')");
            }

        }

    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vsid = GridView2.DataKeys[e.RowIndex].Value.ToString();
        string strSQ = "delete from Ads where sid='" + vsid + "'";//删除记录
        DBA.ExeSql(strSQ);
        if ((GridView2.Rows.Count) % (GridView2.PageSize) == 1)//判断最后一页是否只有一条记录
        {
            GridView2.PageIndex = GridView2.PageIndex - 1;
            if (TextBox2.Text == "" || TextBox2.Text == null)
                GridView2_content();
            else
                ss2();
        }
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
 
        GridView2.EditIndex = (int)e.NewEditIndex;
        GridView2_content();
    
  
    }
    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string k = GridView2.DataKeys[e.RowIndex].Value.ToString();
        string vsm = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[2].Controls[0])).Text.Trim();

        string sql = " update Ads set sm='" + vsm + "' where sid='" + k + "' ";
        DataSet ds = DBA.GetDataSet(sql);

        GridView2.EditIndex = -1;
        GridView2_content();
    }
    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView2.EditIndex = -1;
        GridView2_content();
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        ss1();
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        ss2();
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        ss3();
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        ss4();
    }
    protected void link1(object sender, EventArgs e)
    {
        string arg = ((LinkButton)sender).CommandArgument.ToString();
        switch (arg)
        {//根据不同的arguement值,进行相应的操作：
            case "n1":
                if (GridView2.PageIndex < GridView2.PageCount - 1)//判断是否为最后一条记录
                {
                    GridView2.PageIndex = GridView2.PageIndex + 1;//读取到下一页
                }
                break;//返回
            case "p1":
                if (GridView2.PageIndex > 0)//判断是否为第一页
                {
                    GridView2.PageIndex = GridView2.PageIndex - 1;//读取到前一页的内容
                }
                break;
            case "l1":
                if ((GridView2.PageCount - 1) > 0)
                    GridView2.PageIndex = (GridView2.PageCount - 1);//读取最后一页
                break;
            default://不满足上述情况，则读取首页的内容
                GridView2.PageIndex = 0;
                break;
        }

        if (TextBox2.Text == "" || TextBox2.Text == null)
            GridView2_content();
        else
            ss1();
    }
    protected void link2(object sender, EventArgs e)
    {
        string argq = ((LinkButton)sender).CommandArgument.ToString();
        switch (argq)
        {//根据不同的arguement值,进行相应的操作：
            case "n2":
                if (GridView3.PageIndex < GridView3.PageCount - 1)//判断是否为最后一条记录
                {
                    GridView3.PageIndex = GridView3.PageIndex + 1;//读取到下一页
                }
                break;//返回
            case "p2":
                if (GridView3.PageIndex > 0)//判断是否为第一页
                {
                    GridView3.PageIndex = GridView3.PageIndex - 1;//读取到前一页的内容
                }
                break;
            case "l2":
                if ((GridView3.PageCount - 1) > 0)
                    GridView3.PageIndex = (GridView3.PageCount - 1);//读取最后一页
                break;
            default://不满足上述情况，则读取首页的内容
                GridView3.PageIndex = 0;
                break;
        }

        if (TextBox3.Text == "" || TextBox3.Text == null)
            GridView3_content();
        else
            ss2();
    }
    protected void link3(object sender, EventArgs e)
    {
        string a = ((LinkButton)sender).CommandArgument.ToString();
        switch (a)
        {//根据不同的arguement值,进行相应的操作：
            case "n3":
                if (GridView4.PageIndex < GridView4.PageCount - 1)//判断是否为最后一条记录
                {
                    GridView4.PageIndex = GridView4.PageIndex + 1;//读取到下一页
                }
                break;//返回
            case "p3":
                if (GridView4.PageIndex > 0)//判断是否为第一页
                {
                    GridView4.PageIndex = GridView4.PageIndex - 1;//读取到前一页的内容
                }
                break;
            case "l3":
                if ((GridView4.PageCount - 1) > 0)
                    GridView4.PageIndex = (GridView4.PageCount - 1);//读取最后一页
                break;
            default://不满足上述情况，则读取首页的内容
                GridView4.PageIndex = 0;
                break;
        }

        if (TextBox4.Text == "" || TextBox4.Text == null)
            GridView4_content();
        else
            ss3();
    }
    protected void link4(object sender, EventArgs e)
    {
        string ar = ((LinkButton)sender).CommandArgument.ToString();
        switch (ar)
        {//根据不同的arguement值,进行相应的操作：
            case "n4":
                if (GridView5.PageIndex < GridView5.PageCount - 1)//判断是否为最后一条记录
                {
                    GridView5.PageIndex = GridView5.PageIndex + 1;//读取到下一页
                }
                break;//返回
            case "p4":
                if (GridView5.PageIndex > 0)//判断是否为第一页
                {
                    GridView5.PageIndex = GridView5.PageIndex - 1;//读取到前一页的内容
                }
                break;
            case "l4":
                if ((GridView5.PageCount - 1) > 0)
                    GridView5.PageIndex = (GridView5.PageCount - 1);//读取最后一页
                break;
            default://不满足上述情况，则读取首页的内容
                GridView5.PageIndex = 0;
                break;
        }

        if (TextBox5.Text == "" || TextBox5.Text == null)
            GridView5_content();
        else
            ss4();
    }





    
}