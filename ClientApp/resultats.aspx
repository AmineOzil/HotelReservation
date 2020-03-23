<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultats.aspx.cs" Inherits="ClientApp.resultats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<link href="css/main2.css" rel="stylesheet" />

<!------ Include the above in your HEAD tag ---------->

<div class="container">

<br>  <p class="text-center">More bootstrap 4 components on <a href="http://bootstrap-ecommerce.com/"> Bootstrap-ecommerce.com</a></p>
<hr>




<div class="row">
<div class="col-md-4">
	<figure class="card card-product">
		<div class="img-wrap"><img src="https://www.hotel-diana-dauphine.com/media/cache/jadro_resize/rc/rhCiPkJe1582096951/jadroRoot/medias/5658345e8f976/chambre-1.jpg"></div>
		<figcaption class="info-wrap">
				<h4 class="title">Another name of item</h4>
				<p class="desc">Some small description goes here</p>
				<div class="rating-wrap">
					<div class="label-rating">132 reviews</div>
					<div class="label-rating">154 orders </div>
				</div> <!-- rating-wrap.// -->
		</figcaption>
		<div class="bottom-wrap">
			<a href="" class="btn btn-sm btn-primary float-right">Order Now</a>	
			<div class="price-wrap h5">
				<span class="price-new">$1280</span> <del class="price-old">$1980</del>
			</div> <!-- price-wrap.// -->
		</div> <!-- bottom-wrap.// -->
	</figure>
</div> <!-- col // -->
<div class="col-md-4">
	<figure class="card card-product">
		<div class="img-wrap"><img src="https://www.hotel-diana-dauphine.com/media/cache/jadro_resize/rc/rhCiPkJe1582096951/jadroRoot/medias/5658345e8f976/chambre-1.jpg"> </div>
		<figcaption class="info-wrap">
				<h4 class="title">Good product</h4>
				<p class="desc">Some small description goes here</p>
				<div class="rating-wrap">
					<div class="label-rating">132 reviews</div>
					<div class="label-rating">154 orders </div>
				</div> <!-- rating-wrap.// -->
		</figcaption>
		<div class="bottom-wrap">
				<a href="" class="btn btn-sm btn-primary float-right">Order Now</a>	
				<div class="price-wrap h5">
					<span class="price-new"  id="test" runat="server">$1280</span> <del class="price-old"></del>
				</div> <!-- price-wrap.// -->
		</div> <!-- bottom-wrap.// -->
	</figure>
</div> <!-- col // -->
<div class="col-md-4">
	<figure class="card card-product">
		<div class="img-wrap"><img src="https://www.hotel-diana-dauphine.com/media/cache/jadro_resize/rc/rhCiPkJe1582096951/jadroRoot/medias/5658345e8f976/chambre-1.jpg"></div>
		<figcaption class="info-wrap">
				<h4 class="title">Product name goes here</h4>
				<p class="desc">Some small description goes here</p>
				<div class="rating-wrap">
					<div class="label-rating">132 reviews</div>
					<div class="label-rating">154 orders </div>
				</div> <!-- rating-wrap.// -->
		</figcaption>
		<div class="bottom-wrap">
				<a href="" class="btn btn-sm btn-primary float-right">Order Now</a>	
				<div class="price-wrap h5">
					<span class="price-new">$1280</span> <del class="price-old">$1980</del>
				</div> <!-- price-wrap.// -->
		</div> <!-- bottom-wrap.// -->
	</figure>
</div> <!-- col // -->
</div> <!-- row.// -->



</div> 
<!--container.//-->

<br><br><br>

    </form>
</body>
</html>
