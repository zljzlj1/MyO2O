<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    
       
      .styled {
        border-radius:5px;
        width:158px;
        height:25px;
        padding:0 24px 0 8px;
        color:#fff;
        background-color:#3d69f7;
        font:14px "微软雅黑";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ProvinceContect" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="bind_Province" CssClass="styled" 
                    runat="server" AutoPostBack="True" onselectedindexchanged="bind_Province_SelectedIndexChanged">
         
                    <asp:ListItem Value="0">请选择</asp:ListItem>
         
                </asp:DropDownList>
                <asp:DropDownList ID="bind_City" CssClass="styled" 
                    runat="server" AutoPostBack="True" onselectedindexchanged="bind_City_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:DropDownList ID="bind_Borough" CssClass="styled" 
                runat="server"  AutoPostBack="True" onselectedindexchanged="bind_Borough_SelectedIndexChanged">
                </asp:DropDownList>
                    <asp:DropDownList ID="bind_zh" CssClass="styled" 
                    runat="server" AutoPostBack="True" onselectedindexchanged="bind_zh_SelectedIndexChanged">
                </asp:DropDownList>
                    <asp:DropDownList ID="bind_cun" CssClass="styled" runat="server">
                </asp:DropDownList>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
