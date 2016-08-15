<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="admin_Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>后台管理系统</title>
        <link href="css/skint.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body{font-family: 楷体; font-size: 14px; font-weight: bolder;}
        .style1
        {
            height: 22px;
            line-height: 28px;
            background: #FFFFCC;
            width: 50px;
        }
        .style2
        {
            height: 22px;
        }
        .dd{ margin-left:10px;}
          .style{ border-radius:5px; width:100px; height:25px; padding:0 0px 0 0px;color:#fff; font:14px "微软雅黑"; } 
.sa{ BORDER-RIGHT: #000000 0px solid; BORDER-TOP: #000000 0px solid; BORDER-LEFT: #000000 0px solid; BORDER-BOTTOM: #000000 1px solid; width:80px;}
 #menu #nav {display:table;width:100%;padding:0;margin:0;list-style:none; }
#menu #nav li {float:left;width:85px; background-image: url('Images/bg%20(5).gif');}
#menu #nav li a{display: block;line-height: 27px;text-decoration: none;padding: 0 0 0 5px;text-align: center;}
#menu_con{ width:100%; height:135px; border-top:none}
.tag{ padding:10px; overflow:hidden; }
.selected{ background-image: url('Images/bg (6).gif');background-repeat: no-repeat;color: #FFFFFF;}
.ss li span{ float:right;}
.ss li{  line-height:30px }
.ss li a{ font-family:宋体; font-size:12px;color: #999999; font-weight:bolder; margin-left:20px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="100%" border="0" cellpadding="0" cellspacing="0" 
           >
  <tr>
    <td width="17" valign="top"   style="background-image: url('images/mail_leftbg.gif')"><img src="images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top"  style="background-image: url('images/content-bg.gif')"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">修改地址</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top"  style="background-image: url('images/mail_rightbg.gif')"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" style="background-image: url('images/mail_leftbg.gif')">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
    <div class="divtext">
          
          <font style="color: #000000; font-family: 楷体; font-weight: bold">省份：</font><asp:TextBox ID="TextBox3" runat="server" Class="s"></asp:TextBox>&nbsp&nbsp
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/admin/images/1.jpg" onclick="ImageButton1_Click" />

          
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" PageSize="5" Width="100%"  DataKeyNames="cid" 
            onpageindexchanging="GridView1_PageIndexChanging" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            CellSpacing="2" Height="250px" onrowdatabound="GridView1_RowDataBound" 
                  onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                  onrowcancelingedit="GridView1_RowCancelingEdit" 
                  onrowupdating="GridView1_RowUpdating" GridLines="None" >
            <Columns>
                <asp:TemplateField HeaderText="序号"><ItemTemplate> 
<asp:Label ID="Label2" runat="server" Text='<%# this.GridView1.PageIndex * this.GridView1.PageSize + this.GridView1.Rows.Count + 1%>' /> 
</ItemTemplate> 
</asp:TemplateField>
      
            
                <asp:TemplateField HeaderText="省份">
           <ItemTemplate><asp:Label ID="Label5" runat="server" Text='<%#Eval("Sf") %>'></asp:Label></ItemTemplate>
       <EditItemTemplate><asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval("sfid") %>' /><asp:DropDownList ID="DropDownList2" runat="server"  Width="80px"></asp:DropDownList></EditItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="市名">
           <ItemTemplate><asp:Label ID="Label6" runat="server" Text='<%#Eval("sm") %>'></asp:Label></ItemTemplate>
       <EditItemTemplate><asp:HiddenField ID="HiddenField3" runat="server" Value='<%#Eval("sid") %>' /><asp:DropDownList ID="DropDownList2" runat="server"  Width="80px"></asp:DropDownList></EditItemTemplate>
                </asp:TemplateField>   
                       <asp:TemplateField HeaderText="县名">
           <ItemTemplate><asp:Label ID="Label7" runat="server" Text='<%#Eval("xm") %>'></asp:Label></ItemTemplate>
       <EditItemTemplate><asp:HiddenField ID="HiddenField4" runat="server" Value='<%#Eval("xid") %>' /><asp:DropDownList ID="DropDownList2" runat="server"  Width="80px"></asp:DropDownList></EditItemTemplate>
                </asp:TemplateField>   
                       <asp:TemplateField HeaderText="镇名">
           <ItemTemplate><asp:Label ID="Label8" runat="server" Text='<%#Eval("zm") %>'></asp:Label></ItemTemplate>
       <EditItemTemplate><asp:HiddenField ID="HiddenField5" runat="server" Value='<%#Eval("zid") %>' /><asp:DropDownList ID="DropDownList2" runat="server"  Width="80px"></asp:DropDownList></EditItemTemplate>
                </asp:TemplateField>   
                       <asp:TemplateField HeaderText="村名">
           <ItemTemplate><asp:Label ID="Label9" runat="server" Text='<%#Eval("cm") %>'></asp:Label></ItemTemplate>
       <EditItemTemplate><asp:HiddenField ID="HiddenField6" runat="server" Value='<%#Eval("cid") %>' /><asp:DropDownList ID="DropDownList2" runat="server"  Width="80px"></asp:DropDownList></EditItemTemplate>
                </asp:TemplateField>   
          
                <asp:CommandField HeaderText="操作" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="SingerID" 
                    DataNavigateUrlFormatString="Admin_xggsgl.aspx?SingerID={0}" 
                    HeaderText="修改" Target="a" Text="修改" >
                <ControlStyle ForeColor="Black" />
                </asp:HyperLinkField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerSettings Visible="False" />
            <PagerStyle BorderStyle="Groove" ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BorderStyle="Ridge" BackColor="#738A9C" Font-Bold="True" 
                ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Names="楷体" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True" Font-Names="楷体" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 
       <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument="f" 
            onclick="link" Font-Bold="True" Font-Names="楷体" ForeColor="Black">首页</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument="p" 
            onclick="link" Font-Bold="True" Font-Names="楷体" ForeColor="Black">上一页</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument="n" 
            onclick="link" Font-Bold="True" Font-Names="楷体" ForeColor="Black">下一页</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument="l" 
            onclick="link" Font-Bold="True" Font-Names="楷体" ForeColor="Black">末页</asp:LinkButton>


  
    </div>

     </td>
    <td style="background-image: url('images/mail_rightbg.gif')">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" style="background-image: url('images/mail_leftbg.gif')"><img src="images/buttom_left2.gif" width="17" height="17" /></td>
    <td style="background-image: url('images/buttom_bgs.gif')"><img src="images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" style="background-image: url('images/mail_rightbg.gif')"><img src="images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
