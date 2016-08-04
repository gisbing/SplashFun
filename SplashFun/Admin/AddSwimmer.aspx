<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSwimmer.aspx.cs" Inherits="SplashFun.Admin.AddSwimmer" %>

<asp:Content ID="AddSwimmer" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Add a New Swimmer</h3>
    <div class="form-horizontal">
        
            <div class="form-group">               
                <asp:Label ID="lblTeam" CssClass="col-md-1 control-label" runat="server">Team:</asp:Label>
                <asp:DropDownList ID="drpTeam" runat="server" CssClass="col-md-2" ItemType="SplashFun.Models.Team" SelectMethod="GetTeams" DataTextField="Name" DataValueField="TeamID">
                </asp:DropDownList>
            </div>       
            <div class="form-group">
                <asp:Label ID="lblFirstName" CssClass="col-md-1 control-label" runat="server">First Name:</asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqFieldValidatorFirstName" runat="server" Text="* First name required" ControlToValidate="txtFirstName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>     
            <div class="form-group">
                <asp:Label ID="lblLastName" CssClass="col-md-1 control-label" runat="server">Last Name:</asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="reqFieldValidatorLastName" runat="server" Text="* Last name required" ControlToValidate="txtLastName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">               
                <asp:Label ID="Label1" CssClass="col-md-1 control-label" runat="server">Gender:</asp:Label>
                <asp:DropDownList ID="drpGender" runat="server" CssClass="col-md-2">
                    <asp:ListItem>------</asp:ListItem>
                    <asp:ListItem Text="Female" Value="F"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="M"></asp:ListItem>
                </asp:DropDownList>
            </div>      
            <div class="form-group">
                <asp:Label ID="lblAge" CssClass="col-md-1 control-label" runat="server">Age:</asp:Label>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="rangeValidator" runat="server" ControlToValidate="txtAge" Type="Integer"  Text="* Age has to be between 3 to 18"
                    MinimumValue="3" MaximumValue="18"></asp:RangeValidator>
            </div>

            <asp:Button ID="btnAddSwimmer" runat="server" Text="Add" OnClick="btnAddSwimmer_Click" CausesValidation="true" />
    </div>
</asp:Content>
