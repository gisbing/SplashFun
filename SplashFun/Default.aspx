<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SplashFun._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><%: Title %></h1>
        <p class="lead">Small app to find your swimmer and his/her best time</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Find a Swimmer</h2>
            <p>
                Search a swimmer by first name or last name.
            </p>
            <p>
                <a class="btn btn-primary" href="/SwimmerList">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Find best time</h2>
            <p>
                Find the fastest time in an stroke
            </p>
            <p>
                <a class="btn btn-primary" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Find an Event</h2>
            <p>
                Comming soon
            </p>
            <p>
                <a class="btn btn-primary" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
