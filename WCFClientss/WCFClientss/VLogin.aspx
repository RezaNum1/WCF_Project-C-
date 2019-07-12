<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VLogin.aspx.cs" Inherits="WCFClientss.VLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<!doctype html>
<!-- Website Template by freewebsitetemplates.com -->
<head runat="server">
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>About - Mustache Enthusiast</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel="stylesheet" type="text/css" href="css/mobile.css" media="screen and (max-width : 568px)">
	<script type="text/javascript" src="js/mobile.js"></script>
    <style type ="text/css">

      h1 {
	color: white;
	display: inline;
	font-family: poller_oneregular;
	font-size: 25px;
	font-weight: normal;
	margin: 0;
	padding: 0;
	text-transform: uppercase;
}
 h1 span {
	margin-top: 26px;
	background: black;
	display: inline-block;
	padding: 15px 28px 12px;
}
h2 {
    color: black;
    display: inline;
    font-family: poller_oneregular;
    font-size: 25px;
    font-weight: normal;
    margin: 0;
    padding: 0;
    text-transform: uppercase;
}

#header ul {

	margin: 15px;
	padding: 20px 0 0;
    background-color: black;
    height: 24px;
}

#header ul li a {
	color: white;
	display: inline-block;
	font-family: "Arial Black", Gadget, sans-serif;
	font-size: 14px;
	font-weight: normal;
	margin: 0;
	padding: 0 0 10px;
	text-decoration: none;
	text-transform: uppercase;
    margin-bottom: 15px;
}


    </style>
</head>
<body>
    
	<div id="header">

			<h1><span>Rapot Application</span></h1>
        <br />
        <br />
            <h2>---Always Provide Convenience----</h2>
		
		<ul id="navigation">
			<li>
				<a href="VHome.aspx">Home</a>
			</li>
			<li class="selected">
				<a href="VLogin.aspx">Login</a>
			</li>
			<li>
				<a href="contact.html">About</a></li>
		</ul>
	</div>
	<div id="body">
		<form id="form1" runat="server">
    <div style="height: 118px">
       
        <br />
    <br />
    <br />
    
    <asp:Label ID="Label1" runat="server" Text="USERNAME"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="125px" />
        </div>
        </form>
	</div>
	
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
	
</body>

    <div id="footer">
		<div>
			<p>&copy; 2023 by Mustacchio. All rights reserved.</p>
			<ul>
				<li>
					<a href="http://freewebsitetemplates.com/go/twitter/" id="twitter">twitter</a>
				</li>
				<li>
					<a href="http://freewebsitetemplates.com/go/facebook/" id="facebook">facebook</a>
				</li>
				<li>
					<a href="http://freewebsitetemplates.com/go/googleplus/" id="googleplus">googleplus</a>
				</li>
				<li>
					<a href="http://pinterest.com/fwtemplates/" id="pinterest">pinterest</a>
				</li>
			</ul>
		</div>
	</div>
</html>
