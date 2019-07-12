<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GantiPass.aspx.cs" Inherits="WCFClientss.GantiPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>About - Mustache Enthusiast</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<link rel="stylesheet" type="text/css" href="css/mobile.css" media="screen and (max-width : 568px)">
	<script type="text/javascript" src="js/mobile.js"></script>
    <style type ="text/css">
        #body a {
	margin: 0 auto;
	padding: 24px 0 0;
	width: 620px;
}
#body a input, #body form textarea {
	border: 2px solid #252525;
	color: #252525;
	font-family: Arial, Helvetica, sans-serif;
	font-size: 15px;
	font-weight: normal;
	margin: 0 0 37px;
	padding: 20px 10px;
	text-align: center;
	text-transform: uppercase;
	width: 596px;
}
#body a textarea {
	height: 175px;
	overflow: auto;
	resize: none;
}
#body a #send {
	background: #252525;
	color: #fff;
	font-family: "Arial Black", Gadget, sans-serif;
	font-size: 15px;
	font-weight: normal;
	display: inline-block;
	padding: 20px 28px;
	width: auto;
}
#body a #send:hover {
	background: #fff;
	color: #252525;
	cursor: pointer;
}
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
            <form id="form1" runat="server">

			<h1><span>Rapot Application</span></h1>
        <br />
        <br />
            <h2>---Always Provide Convenience----</h2>
		
		<ul id="navigation">
			<li>
				<a href="WCFClintss.aspx">Profile
				</a>
			</li>
			<li class="selected">
				<a href="GantiPass.aspx">Ganti Username & Password </a>
			</li>
			<li>
				<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LOGOUT</asp:LinkButton></li>
		</ul>

	</div>
    <div>
        <div id="body">
            <a>
                <div style="height: 118px">
      
    
        <asp:Label ID="Label1" runat="server" Text="NIS"></asp:Label>
                    <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="USERNAME"></asp:Label>
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    <br />
                    <br />
                    <br />
    <asp:Label ID="Label3" runat="server" Text="PASSWORD"></asp:Label>
                    <br />
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ganti Password" />
    
    </div>
            </a>
            
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
