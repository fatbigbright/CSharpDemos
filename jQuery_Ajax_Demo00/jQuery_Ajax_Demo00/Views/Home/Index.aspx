<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script src="Scripts/jquery-1.9.1.js" type="text/javascript" ></script>
	<script type="text/javascript">
	$(document).ready(function(){
		//alert("jQuery works!");
		$("#ScrollList")[0].innerText = "Test Text";
		$('#CustomerBrowser').click(function(){
			alert("Browse for customer");
		});
	});
	</script>
</head>
<body>
	<div>
		<%= Html.Encode(ViewData["Message"]) %>
	</div>
	Customer: 
	<input id="customer" type="text" /><input id="CustomerBrowser" type="button" value="Browse..."/>
	<div id="ScrollList">
	</div>
</body>

