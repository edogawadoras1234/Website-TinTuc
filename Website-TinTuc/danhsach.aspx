<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="danhsach.aspx.cs" Inherits="Website_TinTuc.danhsach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <body style="background-image:url(../Images/backg.png)"> 
      <section style="margin-top:100px">
         <div>
         <hgroup>
         <h2><%: Page.Title %></h2>
         </hgroup>
         <asp:ListView ID="tintuc" runat="server" DataKeyNames="Tin_ID" GroupItemCount="4" ItemType="Website_TinTuc.Models.TinTuc" SelectMethod="GetTinTuc">
         <EmptyDataTemplate>
             <table >
                 <tr>
                     <td>Không tìm thấy dữ liệu</td>
                 </tr>
             </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
             <tr id="itemPlaceholderContainer" runat="server">
             <td id="itemPlaceholder" runat="server"></td>
          </tr>
         </GroupTemplate>
         <ItemTemplate>
              <td runat="server">
                  <table>
                     <tr>
                     <td>
                         <a href="ChiTiet.aspx?bookID=<%#:Item.Tin_ID%>">
                         <img src ="/Images/<%#:Item.HinhAnh%>" width="150" height="225" style="border:solid" /></a>
                    </td>
                     </tr>
             <tr>
          <td>
         <a href="ChiTiet.aspx?bookID=<%#:Item.Tin_ID%>">
         <span>
         <%#:Item.TacGia%>
             </span>
             </a>
             <br />
             <span>
         <b>Giá: </b><%#:String.Format("{0:c}",Item.TacGia)%>
          </span>
             <br />
             </a>        
             </td>
             </tr>
            <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
                  <table style="width:100%;">
                  <tbody>
                      <tr>
                      <td>
                          <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                            <tr id="groupPlaceholder"></tr>
                     </table>
              </td>
                 </tr>
                 <tr>
             <td></td>
             </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
        </body>
</asp:Content>
