<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
 <!--
   <table style="width: 537px">
            
            <tr>
                <td style="width: 103px; height: 12px;">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/最新.gif" /></td>
            </tr>
            <tr>
                <td style="width: 103px; height: 97px">
                    <asp:DataList ID="DLnew" runat="server" RepeatColumns="4" Width="144px" DataKeyField="GoodsID" RepeatDirection="Horizontal" OnItemCommand="DLnew_ItemCommand">
                        <ItemTemplate>
                            <div style="text-align: center">
                                <table style="width: 157px; height: 286px">
                                    <tr>
                                        <td style="width: 100px; height: 100px">
                                            <asp:ImageButton ID="ImageNEW" runat="server" Height="154px" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"GoodsUrl") %>'
                                                Width="156px" CommandName="detailSee" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 23px">
                                            <table style="width: 150px; height: 10px">
                                                <tr>
                                                    <td style="width: 100px; height: 21px">
                                                        <span style="font-size: 10pt">产品名:</span></td>
                                                    <td style="width: 100px; height: 21px">
                                                        <asp:Label ID="Label1" runat="server" Font-Size="Smaller" Text='<%# DataBinder.Eval(Container.DataItem, "GoodsName") %>'></asp:Label></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 16px">
                                            <table style="width: 156px; height: 21px">
                                                <tr>
                                                    <td style="width: 100px">
                                                        <span style="font-size: 10pt">单价:</span></td>
                                                    <td style="width: 106px">
                                                        <asp:Label ID="Label2" runat="server" Font-Size="Smaller" Text='<%# GetUserPrice(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString()) %>'></asp:Label><span
                                                            style="font-size: 10pt">￥</span></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/放入购物车.gif" CommandName="buyGoods" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"MemberPrice") %>' /></td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="width: 103px">
                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Image/推荐.gif" /></td>
            </tr>
            <tr>
                <td style="width: 103px; height: 7px;">
                    <asp:DataList ID="DLbest" runat="server" RepeatColumns="4" DataKeyField="GoodsID" OnItemCommand="DLbest_ItemCommand" RepeatDirection="Horizontal">
                     <ItemTemplate>
                            <div style="text-align: center">
                                <table style="width: 157px; height: 286px">
                                    <tr>
                                        <td style="width: 100px; height: 100px">
                                            <asp:ImageButton ID="ImageBest" runat="server" ImageUrl='<%#DataBinder.Eval(Container.DataItem,"GoodsUrl") %>' CommandName="detailSee" Height="162px" Width="156px" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 23px">
                                            <table style="width: 150px; height: 10px">
                                                <tr>
                                                    <td style="width: 100px; height: 21px">
                                                        <span style="font-size: 10pt">产品名:</span></td>
                                                    <td style="width: 100px; height: 21px">
                                                        <asp:Label ID="Label1" runat="server" Font-Size="Smaller" Text='<%# DataBinder.Eval(Container.DataItem, "GoodsName") %>'></asp:Label></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px; height: 16px">
                                            <table style="width: 156px; height: 21px">
                                                <tr>
                                                    <td style="width: 100px">
                                                        <span style="font-size: 10pt">单价:</span></td>
                                                    <td style="width: 106px">
                                                        <asp:Label ID="Label2" runat="server" Font-Size="Smaller" Text='<%# GetUserPrice(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString()) %>'></asp:Label><span
                                                            style="font-size: 10pt">￥</span></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Image/放入购物车.gif" CommandName="buyGoods" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"MemberPrice") %>' /></td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:DataList></td>
            </tr>
           
           
        </table>
-->
  
    </div>
    </form>
</body>
</html>
