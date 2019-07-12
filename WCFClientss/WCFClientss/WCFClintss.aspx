<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCFClintss.aspx.cs" Inherits="WCFClientss.WCFClintss" %>

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
    
	<form id="form1" runat="server">
    
	<div id="header">

			<h1><span>Rapot Application</span></h1>
        <br />
        <br />
            <h2>---Always Provide Convenience----</h2>
		<ul id="navigation">
            <li class="selected">
				<a href="WCFClintss.aspx">Profile</a>
			</li>
            <li>
				<a href="GantiPass.aspx">Ganti Password</a>
			</li>
			<li>
				&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
&nbsp;</li>
			
			
		</ul>
	</div>
	<div id="body">
		
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
        &nbsp;<br />
    <asp:Label ID="Label23" runat="server" Text="USERNAME    :" Font-Bold="True" Font-Italic="False" Font-Size="Large"></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Large"></asp:Label>
        <br />
        <br />
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="NIS" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label13" runat="server" Text="KODE PELAJARAN" Font-Bold="True" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="KODE KELAS" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="ID PIVOT" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="TAHUN AJARAN" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="NILAI HARIAN" Font-Bold="True" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label18" runat="server" Text="NILAI UTS" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="NILAI UAS" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:Label ID="Label20" runat="server" Text="RATA-RATA" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label10" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
        <asp:Label ID="Label21" runat="server" Text="KETERANGAN" Font-Bold="True" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label11" runat="server" Text="Label" Font-Size="Large"></asp:Label>
                    <br />
		
	</div>
	
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
    </form>

</html>
