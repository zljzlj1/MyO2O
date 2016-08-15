using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class Default3 : System.Web.UI.Page
{
    DBAccess1 DBA = new DBAccess1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          
                BindProvince();
                BindCity(bind_Province.SelectedItem.Value);
                BindBorough(bind_City.SelectedItem.Value);
                Bindzh(bind_Borough.SelectedItem.Value);
                Bindcun(bind_zh.SelectedItem.Value);
           
        }
    }
     private void BindProvince()
        {
          
            string sql = "select sfid,sf from Adsf";

            DataSet ds = DBA.GetDataSet(sql);
         
            bind_Province.DataSource =  ds.Tables["datatable"].DefaultView;
            bind_Province.DataValueField = "sfid";
            bind_Province.DataTextField = "Sf";
            bind_Province.DataBind();
          

            
           
        }
        private void BindCity(string code)
        {
            string provinceCode = code;
            string sql = "select sid, sm,Ads.sfid from  Adsf  left join Ads on  Adsf.sfid=Ads.sfid where Ads.sfid='" + provinceCode + "'";
            //省份和城市进行关联

            DataSet ds = DBA.GetDataSet(sql);

            bind_City.DataSource = ds.Tables["datatable"].DefaultView;
            bind_City.DataValueField = "sid";
            bind_City.DataTextField = "sm";
            bind_City.DataBind();
          
        }
      
        private void BindBorough(string code)
        {
            string cityCode = code;
            //城市和地区进行关联
            string sql = "select xid,xm ,Adx.sid from Ads left join Adx on Ads.sid=Adx.sid where  Adx.sid='" + cityCode + "'";

            DataSet ds = DBA.GetDataSet(sql);

            bind_Borough.DataSource = ds.Tables["datatable"].DefaultView;
            bind_Borough.DataValueField = "xid";
            bind_Borough.DataTextField = "xm";
            bind_Borough.DataBind();
        }
        private void Bindzh(string code)
        {
            string zhCode = code;
            //城市和地区进行关联
            string sql = "select zid,zm,Adz.xid from Adx  left join Adz on Adz.xid=Adx.xid where Adz.xid='" + zhCode + "'";

            DataSet ds = DBA.GetDataSet(sql);

            bind_zh.DataSource = ds.Tables["datatable"].DefaultView;
            bind_zh.DataValueField = "zid";
            bind_zh.DataTextField = "zm";
            bind_zh.DataBind();
        }
        private void Bindcun(string code)
        {
            string cunCode = code;
            //城市和地区进行关联
            string sql = "select cid,cm ,Adc.zid from Adz  left join Adc on Adc.zid=Adz.zid where Adc.zid='" + cunCode + "'";

            DataSet ds = DBA.GetDataSet(sql);

            bind_cun.DataSource = ds.Tables["datatable"].DefaultView;
            bind_cun.DataValueField = "cid";
            bind_cun.DataTextField = "cm";
            bind_cun.DataBind();
        }
   
        protected void bind_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindBorough(bind_City.SelectedItem.Value);
             Bindzh(bind_zh.SelectedItem.Value);
            Bindcun(bind_Borough.SelectedItem.Value);
        }

        protected void bind_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCity(bind_Province.SelectedItem.Value);
            BindBorough(bind_City.SelectedItem.Value);
            Bindzh(bind_zh.SelectedItem.Value);
            Bindcun(bind_Borough.SelectedItem.Value);

        }
        protected void bind_Borough_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindzh(bind_zh.SelectedItem.Value);
            Bindcun(bind_Borough.SelectedItem.Value);
          
        }
        protected void bind_zh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindzh(bind_zh.SelectedItem.Value);
        }
}