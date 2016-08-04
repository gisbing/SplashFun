<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SwimmerList.aspx.cs" Inherits="SplashFun.SwimmerList" %>
<asp:Content ID="SwimmerListContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Swimmers</h1>

    <div id="SwimmerListPanel" style="text-align: center">
        <asp:ListView ID="Swimmers" ItemType="SplashFun.Models.Swimmer" runat="server" DataKeyNames="SwimmerID" GroupItemCount="4" SelectMethod="GetSwimmers">
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
                                  <a href="SwimmerDetails.aspx?swimmerID=<%#: Item.SwimmerID %>"> 
                                    <image src='/Images/avatars/<%#:Item.Avatar%>' 
                                      width="100" height="75" border="1" /> 
                                  </a> 
                                </td> 
                            </tr> 
                            <tr> 
                                <td> 
                                    <a href="SwimmerDetails.aspx?swimmerID=<%#: Item.SwimmerID %>"> 
                                      <%#: Item.FirstName %> <%#: Item.LastName %> 
                                    </a> 
                                    <br /> 
                                    <span> 
                                        <b>Age: </b><%#:Item.Age%> 
                                    </span> 
                                    <br />                                    
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
    <br />
    <div>
        <asp:Button CssClass="btn btn-primary" style="margin-right:100px" ID="AddSwimmerButton" runat="server" Text="Add New Swimmer" 
            PostBackUrl="~/Admin/AddSwimmer.aspx" />

    </div>
</asp:Content>
