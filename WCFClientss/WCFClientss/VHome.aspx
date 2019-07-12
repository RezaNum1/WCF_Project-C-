<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VHome.aspx.cs" Inherits="WCFClientss.VHome" %>

<!doctype html>
<!-- Website Template by freewebsitetemplates.com -->
<html>
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Mustache Enthusiast</title>
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

        #body div ul li div a.more {
	background: #000;
	color: #fff;
	display: inline-block;
	font-family: "Arial Black", Gadget, sans-serif;
	font-size: 18px;
	font-weight: normal;
	margin: 0;
	padding: 8px 28px;
	text-decoration: none;
	text-transform: uppercase;
}

       

        #body > ul li a img {
	border: 2px solid #1a1a1a;
	display: block;
	margin: 0;
	padding: 10;
	opacity: .8;
	transition: 0.5s ease-in-out;
    height: 350px;
    width: 299px;
}

        #body > div .article {
	margin: 0 auto;
	padding: 30px 30px 0;
	width: 560px;
}
        #body > div img {
	border: 2px solid #292929;
	margin: 15px 0 0;
	padding: 0;
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
			<li class="selected">
				<a href="VHome.aspx">Home</a>
			</li>
			<li>
				<a href="VLogin.aspx">Login</a>
			</li>
			<li>
				<a href="VAbout.aspx">About</a>
			</li>
			
		</ul>
	</div>
	<div id="body">
		<div id="featured">
			<img src="images/aa.jpg" alt="">
			<div>
				<h2>Book Is the Window Of The World</h2>
				<span>Time will not get back</span>
				<span>Rapot Online Application</span>
				<span>make it easier for students to see the value.</span>
				<a href="blog-single-post.html" class="more">read more</a>
			</div>
		</div>
		<ul>
			<li>
				<a href="gallery.html">
					<img src="images/bb.png" alt="">
					<span>It's Time</span>
				</a>
			</li>
			<li>
				<a href="gallery.html">
					<img src="images/cc.jpg" alt="">
					<span>The Target</span>
				</a>
			</li>
			<li>
				<a href="gallery.html">
					<img src="images/dd.jpg" alt="">
					<span>Study</span>
				</a>
			</li>
		</ul>
	</div>
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
</body>
</html>

