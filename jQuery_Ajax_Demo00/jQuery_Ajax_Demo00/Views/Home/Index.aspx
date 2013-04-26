<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script src="Scripts/jquery-1.9.1.js" type="text/javascript" ></script>
    <script src="Scripts/dropDownList.js" type="text/javascript" ></script>
	<script src="Scripts/Index.js" type="text/javascript" ></script>
	<link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<div>
		<%= Html.Encode(ViewData["Message"]) %>
	</div>
	Customer: 
	<div id="dropDown" class="drop-Down">
		<input id="customer" type="text" /><input id="CustomerBrowser" class="dropDownBrowser" type="button" value="..."/>
		<div id="list">
		</div>
	</div>
   <div id="dropDown2" class="drop-Down">
      <input id="game" type="text" /><input id="gameBrowser" class="dropDownBrowser" type="button" value="..." />
      <div id="gameList"></div>
   </div>
   <div id="dropDown3" class="drop-Down">
      <input id="remoteGame" type="text" /><input id="remoteGameBrowser" class="dropDownBrowser" type="button" value="..." />
      <div id="remoteGameList"></div>
   </div>
   <input id="another" value="Another" type="button" />
</body>
</html>
