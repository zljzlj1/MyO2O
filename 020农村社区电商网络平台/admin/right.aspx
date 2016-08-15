<%@ Page Language="C#" AutoEventWireup="true" CodeFile="right.aspx.cs" Inherits="admin_right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理系统</title>
        <link href="css/skint.css" rel="stylesheet" type="text/css" />
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
        <td height="31"><div class="titlebt">后台首页</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top"  style="background-image: url('images/mail_rightbg.gif')"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" style="background-image: url('images/mail_leftbg.gif')">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
    <div class="divtext">
          <table cellspacing="0" cellpadding="0" width="100%"  class="tablexian" border="0">
     


        <tr >
            <td align="right" colspan="2" style="height:5px; background-color: #FFFF99;">
                </td>
        </tr>
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                会员统计：</td>
         <td align="left">
                共：<asp:Label ID="usercount" runat="server"></asp:Label>
                个，今天共：<asp:Label ID="todayuser" runat="server"></asp:Label>
                个</td>
     </tr>
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                网站产品：</td>
         <td align="left">
                共：<asp:Label ID="productcount" runat="server"></asp:Label>
                个，今天共：<asp:Label ID="todayproduct" runat="server"></asp:Label>
                个</td>
     </tr>
</table>
  <table cellspacing="0" cellpadding="0" width="100%"  class="tablexian" border="0">
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                官网：</td>
         <td align="left">
                <a href="http://www.shazhiqiu.cn/" target="_blank">http://www.shazhiqiu.cn</a></td>
     </tr>
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                程序名：</td>
         <td align="left">
                =Powered.powered >&nbsp;</td>
     </tr>
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                版本：</td>
         <td align="left">
                 Powered.banben </td>
     </tr>
     <tr>
         <td align="right" style="width: 100px" class="tablebg">
                技术论坛：</td>
         <td align="left">
                <a href="http://www.shazhiqiu.cn/bbs/" target="_blank">http://www.shazhiqiu.cn/bbs/</a></td>
     </tr>
</table>
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
