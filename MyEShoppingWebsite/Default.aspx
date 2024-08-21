
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My E-Shopping Website</title>
    <meta  charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta http-equiv="X-UA-Compatibble" content="Microsoft Edge"/>
    <link href="css/Custom.css" rel="stylesheet" />
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle Navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="Default.aspx" ><span><img src="icon/2aff5063c0173b9a15e9598a87db7e78.gif" alt="MyEShopping" height="30" /></span>MyEShopping</a>

                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li class="active"><a href="Default.aspx">Home</a></li>
                             <li><a href="#">About</a></li>
                            <li><a href="#">Contact</a></li>
                            <li><a href="#">Blog</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Products<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li class="dropdown-header">Mens Wear</li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="#">Shirts</a></li>
                                    <li><a href="#">Pants</a></li>
                                    <li><a href="#">Shorts</a></li>
                                    <li role="separator" class="divider"></li>
                                    <li class="dropdown-header">Womens Wear</li>
                                    <li role="separator" class="divider"></li>
                                    <li><a href="#">Tops</a></li>
                                    <li><a href="#">Leggings</a></li>
                                    <li><a href="#">Chudidhars</a></li>
                                </ul>
                            </li>
                            <li> <a href="SignUp.aspx">SignUp</a></li>
                            <li><a href="SignIn.aspx">SignIn</a></li>
                           
                           
                        </ul>

                    </div>

                </div>


            </div>

            <!---image slider--->
            <div class="container">
  <h2>Carousel Example</h2>  
  <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner">
      <div class="item active">
       <!---- <img src="ImgSlider/la.jpg" alt="Los Angeles" style="width:100%;">-->
          <img src="ImgSlider/sliderimg3.jpg" alt="OnlineShopping" style="width:100%" />
          <div class="carousel-caption">
              <h3 style="color:green">SHOPPING</h3>
              <p style="color:blue">Now Shop Online and stay away from Covid-19</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Buy Now</a></p>
          </div>
      </div>

      <div class="item">
       <!--- <img src="ImgSlider/chicago.jpg" alt="Chicago" style="width:100%;">--->
           <img src="ImgSlider/sliderimg2.jpg" alt="MensWear"  style="width:100%"/>
          <div class="carousel-caption">
              <h3 style="color:green">MEN SHOPPING</h3>
              <p style="color:blue">Now Shop Online and stay away from Covid-19</p>
          </div>
      </div>
    
      <div class="item">
      <!--- <img src="ImgSlider/ny.jpg" alt="New york" style="width:100%;">--->
          <img src="ImgSlider/sliderimg1.jpg" alt="WomenWear" style="width:100%" />
          <div class="carousel-caption">
              <h3 style="color:green">WOMEN SHOPPING</h3>
              <p style="color:blue">Now Shop Online and stay away from Covid-19</p>
          </div>
      </div>
    </div>
     

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
</div>


            <!---image  slider End--->

        </div>
        <br />
        <!---middle contents start-->
        <hr />
        <div class="container center">
            <div class="row">
                <div class="col-lg-4">
                    <img class="img-square" src="Clothes/cb0f8498656d0798c9eb63a22e280b46.gif" alt="thumb" width="140" height="140" />
                    <h2>Clothings</h2>
                    <p><B> Quality Clothes at Affordable Prices...!Mens Wear,Womens Wear at Cheap and Best but it doesnt mean Worst quality.Not Branded but we promise you that your money worth these clothes.</B></p>
                    <p><a class="btn btn-default" href="#" role="button">View More &raquo;</a></p>
                </div>

                <div class="col-lg-4">
                    <img class="img-square" src="Shoes/Shoes1.jpg" alt="thumb" width="140" height="140" />
                    <h2>Footwear</h2>
                    <p><B> For both men and women we provide Accessories like Shoes,Chappal,Sandles with multiple,suitable styles,designs and colors,Style and cooling Glasses and Many more.</B></p>
                    <p><a class="btn btn-default" href="#" role="button">View More &raquo;</a></p>
                </div>
                 <div class="col-lg-4">
                    <img class="img-square" src="Cosmotics/Cosmotics.jpg" alt="thumb" width="140" height="140" />
                    <h2>Accessories</h2>
                    <p><B> For both men and women we provide Accessories like Style and Cooling glasses,Cosmotics,Makeup kits of Best Quality at affordable prices only and many more...</B></p>
                    <p><a class="btn btn-default" href="#" role="button">View More &raquo;</a></p>
                </div>

            </div>
        </div>


        <!---middle contents End-->

        <!---Footer content starts-->
        <footer>
            <div class="container">
                <p class="pull-right"><a href="#">Back to Top</a></p>
                <p>&copy;2020Coderbaba.in &middot; <a href="Default.aspx">Home</a>&middot;<a href="#">About</a>&middot;<a href="#">Contact</a>&middot;<a href="#">Products</a></p>
            </div>
        </footer>


        <!---Footer Content endws-->
    </form>

    
</body>
</html>
