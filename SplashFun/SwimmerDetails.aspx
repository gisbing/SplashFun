<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SwimmerDetails.aspx.cs" Inherits="SplashFun.SwimmerDetails" %>

<asp:Content ID="SwimmerDetailsContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:FormView ID="SwimmerDetailsView" runat="server" ItemType="SplashFun.Models.Swimmer" SelectMethod="SwimmerDetailsView_GetItem" RenderOuterTable="false">
        <ItemTemplate>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title"><%#: Item.FirstName %> <%#: Item.LastName %></h3>
                    <img src="/Images/teams/<%#:Item.Team.Logo %>" style="height: 26px; float: right; margin-top: -20px" />
                </div>
                <div class="panel-body">
                    <table class="col-md-4">
                        <tr>
                            <td>
                                <img src="/Images/avatars/<%#:Item.Avatar %>" style="border: solid; height: 200px" alt="<%#:Item.FirstName %>" />
                            </td>
                            <td>&nbsp;</td>
                            <td style="vertical-align: top; text-align: left; margin-left: 20px">
                                <span><b>Age:</b>&nbsp;<%#:Item.Age %></span>
                                <br />
                                <span><b>Gender:</b>&nbsp;<%#: Item.Gender %></span>
                                <br />
                                <span><b>Swimmer ID:</b>&nbsp;<%#:Item.SwimmerID %></span>
                                <br />
                            </td>

                        </tr>
                    </table>
                    <div class="col-md-1"></div>
                    <div class="col-md-6">
                        <asp:Chart ID="Chart1" runat="server" DataSourceID="" Height="200px">
                            <Series>
                                <asp:Series ChartType="Line" Name="Series1" XValueMember="Stroke" YValueMembers="TimeRecord"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
            <!--list of records-->
            <div class="panel panel-warning">
                <div class="panel-heading">
                    Records
                </div>
                <div class="panel-body">
                    <table class="col-md-6 table table-striped table-hover">
                        <tbody>
                            <asp:Repeater ID="repTimeRecords" runat="server" SelectMethod="repTimeRecords_GetData">
                                <HeaderTemplate>
                                    <th>Distance</th>
                                    <th>Stroke</th>
                                    <th>Time</th>
                                </HeaderTemplate>
                                <ItemTemplate>

                                    <tr <%# FormatRow(Eval("TimeRecordID").ToString()) %>>
                                        <td>
                                            <asp:Label ID="lblDistance" runat="server" Text='<%# Eval("Distance.Measure") %>' /></td>
                                        <td>
                                            <asp:Label ID="lblStroke" runat="server" Text='<%# Eval("Stroke.StrokeName") %>' /></td>
                                        <td>
                                            <asp:Label ID="lblTime" runat="server" Text='<%# Eval("Record") %>' /></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>

                </div>
            </div>
            <asp:Button ID="btnShowAddTime" runat="server" OnClick="btnShowAddTime_Click" Text="Add New Time" CssClass="btn btn-warning"/>
            <%--<asp:GridView ID="grdTimeRecords" runat="server" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical" CellPadding="4"
        ItemType="SplashFun.Models.TimeRecord" SelectMethod="GetTimeRecord" AlternatingRowStyle-BackColor="WhiteSmoke">
        <Columns>
            <asp:BoundField DataField="TimeRecordID" HeaderText="#" />
            <asp:BoundField DataField="Distance.Distance" HeaderText="Distance" />
            <asp:BoundField DataField="Stroke.Stroke" HeaderText="Stroke" />
            <asp:BoundField DataField="Record" HeaderText="Time" />
        </Columns>
    </asp:GridView>--%>
            <asp:Panel ID="pnlNewTime" runat="server" Visible="false">
                <h3>Enter New Time</h3>
                <div class="form-horizontal">

                    <div class="form-group">
                        <asp:Label ID="lblDistance" CssClass="col-md-1 control-label" runat="server">Distance:</asp:Label>
                        <asp:DropDownList ID="drpDistance" runat="server" CssClass="col-md-2" ItemType="SplashFun.Models.Distance" SelectMethod="GetDistanceValues" DataTextField="Measure" DataValueField="DistanceID">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblStroke" CssClass="col-md-1 control-label" runat="server">Stroke:</asp:Label>
                        <asp:DropDownList ID="drpStroke" runat="server" CssClass="col-md-2" ItemType="SplashFun.Models.Stroke" SelectMethod="GetStrokes" DataTextField="StrokeName" DataValueField="StrokeID">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblTime" CssClass="col-md-1 control-label" runat="server">Time:</asp:Label>
                        <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="Must be in format '00:00:00'." ControlToValidate="txtTime" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^([0-5]?\d:)?([0-5]?\d):([0-5]?\d)$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <asp:Button ID="btnAddNewTime" runat="server" Text="Add" OnClick="btnAddNewTime_Click" CausesValidation="true" />
            </asp:Panel>


        </ItemTemplate>
    </asp:FormView>


</asp:Content>
