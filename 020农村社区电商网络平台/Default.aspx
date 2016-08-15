<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:CustomValidator 
                    ID="d" Display="Dynamic" runat="server" ControlToValidate="TextBox1" 
                    ForeColor="Red" ErrorMessage="用户名已存在,注册失败,请重新注册" 
                    onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
  <asp:DataList ID="DataList1" runat="server" CellPadding="4" RepeatColumns="4">
        <ItemTemplate>
           <asp:Image ID="Image1" runat="server" Height="95px" 
                                ImageUrl='<%# DataBinder.Eval(Container.DataItem,"pic") %>' Width="85px" />
                            <br />
                            <%# DataBinder.Eval(Container.DataItem,"xh") %>
                            <br />
                            <%# DataBinder.Eval(Container.DataItem,"xm") %>
                            <br />
                            <%# DataBinder.Eval(Container.DataItem,"xb") %>
                            <a href='VIEW.ASPX?vid=<%# DataBinder.Eval(Container.DataItem,"xh") %>' 
                                target="_self">详细信息</a>
                            <br />


        </ItemTemplate>
        

    </asp:DataList>
    <table style="WIDTH: 472px; HEIGHT: 28px" width="472" align="left" border="0">
<TR>
<TD vAlign="middle" align="center" width="135" colSpan="2"><asp:label id="lblCurrentPage" runat="server" Width="120px" Font-Size="9pt"></asp:label></TD>
<TD vAlign="middle" align="right" width="57"><asp:linkbutton id="btnFirst" runat="server" CommandArgument="first" Font-Size="9pt" onclick="PagerButtonClick">首页</asp:linkbutton>&nbsp;</TD>
<TD vAlign="middle" align="center" width="60"><asp:linkbutton id="btnPrev" runat="server" CommandArgument="prev" Font-Size="9pt" onclick="PagerButtonClick">前一页</asp:linkbutton></TD>
<TD vAlign="middle" align="left" width="51"><asp:linkbutton id="btnNext" runat="server" CommandArgument="next" Font-Size="9pt" onclick="PagerButtonClick">下一页</asp:linkbutton></TD>
<TD vAlign="middle" align="left" width="40"><asp:linkbutton id="btnLast" runat="server" CommandArgument="last" Font-Size="9pt" onclick="PagerButtonClick">末页</asp:linkbutton></TD>
<TD vAlign="middle" align="left" width="53" style="WIDTH: 53px">&nbsp;&nbsp;
<asp:label id="Label2" runat="server" Width="30px" Font-Size="9pt" Height="28px">转到</asp:label></TD>
<TD vAlign="middle" align="center" width="34"><asp:textbox id="TextBox1" runat="server" Width="33px" Height="20px" BorderStyle="Groove" Font-Size="9pt"></asp:textbox></TD>
<TD vAlign="middle" align="center" width="26"><asp:label id="Label3" runat="server" Font-Size="9pt">页</asp:label></TD>
<TD vAlign="middle" align="center" width="34">
<P><asp:button id="Button1" runat="server" Width="44px" Height="20px" 
        BorderStyle="Groove" Text="确定"
Font-Size="9pt" onclick="Button1_Click"></asp:button></P>
</TD>
</TR>
</table>

    </div>
    </form>
</body>
</html>
