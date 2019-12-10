<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="Website_TinTuc.ChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:FormView ID="bookDetail" runat="server"
        ItemType="Website_TinTuc.Models.TinTuc" SelectMethod ="GetDetails"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1><%#:Item.Tin_ID %></h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.HinhAnh %>"
         style="border:solid; height:225px" alt="<%#:Item.TacGia %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Description:</b><br /><%#:Item.NoiDung %>
         <br />
         <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}",Item.NgayGui)
        %></span>
         <br />
         <span><b>Book Number:</b>&nbsp;<%#:Item.Tin_ID %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
