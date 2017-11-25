<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebSistemaGonzalez.Index" %>


<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Sistema Ventas Gonzalez</title>

    <!-- Bootstrap -->
    <link href="/Estilos/css/bootstrap.min.css" rel="stylesheet">
	<link rel="stylesheet" href="/Estilos/css/font-awesome.min.css">
	<link rel="stylesheet" href="/Estilos/css/jquery.bxslider.css">
	<link rel="stylesheet" type="/Estilos/text/css" href="css/isotope.css" media="screen" />	
	<link rel="stylesheet" href="/Estilos/css/animate.css">
	<link rel="stylesheet" href="/Estilos/js/fancybox/jquery.fancybox.css" type="text/css" media="screen" />
	<link href="/Estilos/css/style.css" rel="stylesheet">	
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body>
	<header>
		<nav div class="navbar navbar-default navbar-static-top" role="navigation">
			<div class="container">
				<ul class="info">
					<li><p><i class="fa fa-phone"></i>+1 769 525 422 5663</p></li>
					<li><a href="#"><i class="fa fa-envelope"></i>hello@Dewi.com</a></li>
				</ul>
			</div>
		</nav>
		
		<nav class="navbar navbar-default navbar-static-top" role="navigation">
			<div class="navigation">
				<div class="container">					
					<div class="navbar-header">
						<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target=".navbar-collapse.collapse">
							<span class="sr-only">Toggle navigation</span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
						</button>
						<div class="navbar-brand">
							<a href="/index.html"><h1>Sistema Ventas Gonzalez</h1></a>
						</div>
					</div>
					
					<div class="navbar-collapse collapse">							
						<div class="menu">
							<ul class="nav nav-tabs" role="tablist">
								<li role="presentation"><a href="/index.html" class="active">INICIO</a></li>
								<li role="presentation"><a href="/ContactarWebForm.aspx">Contacto</a></li>
								<li role="presentation"><a href="Login.aspx">Login</a></li>						
							</ul>
						</div>
					</div>						
				</div>
			</div>	
		</nav>		
	</header>
   
    <div class="slider">
		<div class="img-responsive">
			<ul class="bxslider">				
				<li><img src="Content/IMG/camera-buying_dotshot_123RF.jpg" alt=""/></li>		
                <li><img src="Content/IMG/54ecfbf939883_1420_!.jpg" alt=""/></li>		
				<li><img src="Content/IMG/area-de-ventas.png" alt=""/></li>	
				<li><img src="Content/IMG/recursos.png" alt=""/></li>			
			</ul>
		</div>	
    </div>
	
    
	<%--<div class="container">
		<div class="row">				
			<div class="col-md-4">
				<div class="wow bounceIn" data-wow-offset="0" data-wow-delay="0.4s">
					<div class="align-center">
						<h4>Quick Support</h4>					
						<div class="icon">
							<i class="fa fa-heart-o fa-3x"></i>
						</div>
						<p>
						 Voluptatem accusantium doloremque laudantium sprea totam rem aperiam.
						</p>
						<div class="ficon">
							<a href="#" class="btn btn-default" role="button">Read more</a>
						</div>
					</div>
				</div>
			</div>--%>
			<%--<div class="col-md-4">
				<div class="wow bounceIn" data-wow-offset="0" data-wow-delay="1.0s">
					<div class="align-center">
						<h4>Web Design</h4>				
						<div class="icon">
							<i class="fa fa-desktop fa-3x"></i>
						</div>
						<p>
						 Voluptatem accusantium doloremque laudantium sprea totam rem aperiam.
						</p>
						<div class="ficon">
							<a href="#" class="btn btn-default" role="button">Read more</a>
						</div>
					</div>
				</div>
			</div>--%>
			<%--<div class="col-md-4">
				<div class="wow bounceIn" data-wow-offset="0" data-wow-delay="1.6s">
					<div class="align-center">
						<h4>Easy Customize</h4>					
						<div class="icon">
							<i class="fa fa-location-arrow fa-3x"></i>
						</div>
						<p>
						 Voluptatem accusantium doloremque laudantium sprea totam rem aperiam.
						</p>
						<div class="ficon">
							<a href="#" class="btn btn-default" role="button">Read more</a>
						</div>
					</div>
				</div>
			</div>				
		</div>
	</div>--%>
    

    <div class="box">
		<div class="container">
			<div class="row">			
				
				<div class="col-md-4">
					<div class="thumbnail">
						<div class="img-thumbnail">
							<img src="/Estilos/img/team/tufoto.jpg" alt="" height:"150px" width:"150px">			
							<div class="caption">
								<h3>Jose Ariel Paredes Gonzalez</h3>
								<p>Es un estudiante de la Universidad Catolica Nordestana . </p>
								<a href="/ContactarWebForm.aspx" class="btn btn-default" role="button">Perfil</a>
							</div>
						</div>
					</div>
				</div>
							
			</div>	
		</div>
    </div>
    
	<div class="jumbotron">
		<h1>Problemas con el <span>sistema comunicarse con el soporte</span> </h1>
		<p>&nbsp;Ten claro que a la cima no llegarás superando a los demás, sino superándote a ti mismo.</p>
		<p><a class="btn btn-primary btn-lg" href="#" role="button">Get it now</a></p>
	</div>
	
	<footer>
		<div class="inner-footer">
			<div class="container">
				<div class="row">
					<div class="col-md-4 f-about">
						<a href="index.html"><h1>Sistema Ventas Gonzalez</h1></a>
						<p>Este sisitema va dirigido a pequeñas empresas con el fin de automatizar el area de ventas y contribuir a el desarrollo de la empresa.</p>
						
					</div>
					<div class="col-md-4 l-posts">
						<h3 class="widgetheading">Ultimas Publicaciones</h3>
						<ul>
							<li><a href="#">Este es un título increíble</a></li>
							<li><a href="#">Las características increíbles son impresionantes</a></li>
							<li><a href="#">Superacion para pequeñas empresas</a></li>
							<li><a href="#">Wow, increible nunca visto</a></li>
						</ul>
					</div>
					<div class="col-md-4 f-contact">
						<h3 class="widgetheading">Contacto</h3>
						<a href="mailto:joseari0022@gmail.com?&subject=&body="><p><i class="fa fa-envelope"></i> example@gmail.com</p></a>
						<p><i class="fa fa-phone"></i>  +809 589 9480</p>
						<p><i class="fa fa-home"></i> JG Sofware  |  PO Box 23456 
							El Factor, Nagua <br>
							RD</p>
					</div>
				</div>
			</div>
		</div>
			
		<div class="last-div">
			<div class="container">
				<div class="row">
                    <!-- 
                        All links in the footer should remain intact. 
                        Licenseing information is available at: http://bootstraptaste.com/license/
                        You can buy this theme without footer links online at: http://bootstraptaste.com/buy/?theme=Dewi
                    -->
					<nav class="foot-nav">
						<ul>
							<li><a href="#">INICIO</a></li>
							<li><a href="#">Services</a></li>
							<li><a href="#">Blog</a></li>                            
							<li><a href="/ContactarWebForm.aspx">Contacto</a></li>
							<li><a href="/Login.aspx">Login</a></li>
						</ul>
					</nav>
					<div class="clear"></div>
				</div>
			</div>
			<a href="" class="scrollup"><i class="fa fa-chevron-up"></i></a>	
		</div>		
	</footer>
   
	
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->	
    <script src="/Estilos/js/jquery-2.1.1.min.js"></script>	
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="/Estilos/js/bootstrap.min.js"></script>
	<script src="/Estilos/js/wow.min.js"></script>
	<script src="/Estilos/js/fancybox/jquery.fancybox.pack.js"></script>
	<script src="/Estilos/js/jquery.easing.1.3.js"></script>
	<script src="/Estilos/js/jquery.bxslider.min.js"></script>
	<script src="/Estilos/js/functions.js"></script>
	<script>
	wow = new WOW(
	 {
	
		}	) 
		.init();
	</script>
	
  </body>
</html>