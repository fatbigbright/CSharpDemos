<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewBag.Message %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
    <input id="hideList" type="button" value="Hide the List" />
    <div id="dropdownContainer">
       <input id="customer" type="text" />
       <input id="showList" type="button" value="Show List" />
       <div id="list">
       </div>
    </div>
    AAAAAAABBBBBBBBBCCCCCCCCCC<br />EEEEEEEEEEEEEFFFFFFFFFFFFF
    <script src="<%: Url.Content("~/Scripts/Customized/Index.js") %>" type = "text/javascript"></script>
</asp:Content>
