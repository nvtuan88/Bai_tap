<%@ Page Title="StudentManagements" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="StudentManagement.StudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <h1><%: Page.Title %></h1>
            <asp:ListView ID="studentlist" runat="server" DataKeyNames="ID" GroupItemCount="3" ItemType="StudentManagement.Models.Student" SelectMethod="GetStudents">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>
                                No data was returned.
                            </td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyDataTemplate>
                    <td />
                </EmptyDataTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <div runat="server">
                        <p class="Title">
                            <a href="StudentDetails.aspx?studentID=<%#:Item.ID %>"><%#:Item.Name%></a>
                            
                        </p>
                        <p>
                            <image src="img/<%#:Item.ImagePath%>" width="100" height="100"/>
                        </p>
                        <p>
                            <%#:Item.Description%>
                        </p>
                        <p>
                            <%#:Item.Match%>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
