<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PartialSearchGridView.aspx.cs" Inherits="WebApp.ExercisePages.PartialSearchGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Partial Search to DropDown Selection to GridView</h1>
    <div class="row">
        <div class="col-md-6">
            <div class="offset-1">
                <asp:Label runat="server" Text="Enter a partial product name:"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox id="PartialProductNameArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
                <asp:Button id="SearchProductsPartial" runat="server" Text="Fetch" OnClick="SearchProductsPartial_Click" />
                <br /><br />
                <asp:Label id="MessageLabel" runat="server"></asp:Label>
            </div>
        </div>
        <div class="col-md-6">
            <asp:Label runat="server" Text="Region ID:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="RegionID" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Description:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="RegionDescription" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
