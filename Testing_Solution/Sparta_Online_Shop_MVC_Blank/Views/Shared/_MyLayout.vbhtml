﻿<!DOCTYPE html>
<html>
<head>
    <title>@Page.Title</title>
    @RenderSection("head", required:  false)
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>Sparta Online Shop</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css">
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- Material Design Bootstrap -->
    <link href="css/mdb.min.css" rel="stylesheet">
    <!-- Your custom styles (optional) -->
    <link href="css/style.min.css" rel="stylesheet">
    <style type="text/css">
    html,
    body,
    header,
    .carousel {
      height: 90vh;
    }

    @media (max-width: 740px) {

      html,
      body,
      header,
      .carousel {
        height: 100vh;
      }
    }

    @media (min-width: 800px) and (max-width: 850px) {

      html,
      body,
      header,
      .carousel {
        height: 100vh;
      }
    }

    </style>
</head>







<body>
    @RenderBody()
    <body style="background-color: #36393F;" ">

        <!-- Navbar -->
        <nav class="navbar fixed-top navbar-expand-lg navbar-light spartaPurple scrolling-navbar">
            <div class="container">

                <!-- Brand -->
                <a class="navbar-brand waves-effect" href="home-page.html" target="_blank">
                    <img src="Logo.png" alt="" style="width:100px;height:45px;">
                    <!-- <strong class="spartaPink-text">Sparta Store</strong> -->
                </a>

                <!-- Collapse -->
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
                        aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <!-- Links -->
                <div class="collapse navbar-collapse" id="navbarSupportedContent">

                    <!-- Left -->
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                            <a class="nav-link waves-effect" href="#" style="color: white;">
                                Home
                                <span class="sr-only">(current)</span>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link waves-effect" href="https://www.spartaglobal.com/?gclid=CjwKCAjwusrtBRBmEiwAGBPgE_YW0DMlGuHtcL5auN4C3PX2yba8Q0yU8RbrRKl8c3lYIlt7oQN4JxoCab0QAvD_BwE" target="_blank" style="color: white;">Website</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link waves-effect" target="_blank" style="color: white;">Products</a>
                        </li>
                        <li class="nav-item">
                            <a href="contact-page.html" class="nav-link waves-effect" target="_blank" style="color: white;">Contact</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link waves-effect" target="_blank" style="color: white;">Credits</a>
                        </li>
                    </ul>

                    <!-- Right -->
                    <ul class="navbar-nav nav-flex-icons">
                        <li class="nav-item">
                            <a class="nav-link waves-effect">
                                <!-- <span class="badge red z-depth-1 mr-1"> 1 </span> -->
                                <i class="fas fa-shopping-cart" style="color: white;"></i>
                                <span class="clearfix d-none d-sm-inline-block" style="color: white;"> Cart </span>
                            </a>
                        </li>
                        <li class="nav-item">
                            <a href="https://www.facebook.com/spartaglobal" class="nav-link waves-effect" target="_blank">
                            </a>
                        </li>
                    </ul>

                </div>

            </div>
        </nav>
        <!-- Navbar -->
        <!--Carousel Wrapper-->
        <div id="carousel-example-1z" class="carousel slide carousel-fade pt-4" data-ride="carousel">



            <!--Indicators-->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-1z" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-1z" data-slide-to="1"></li>
                <li data-target="#carousel-example-1z" data-slide-to="2"></li>
            </ol>
            <!--/.Indicators-->
            <!--Slides-->
            <div class="carousel-inner" role="listbox">

                <!--First slide-->
                <div class="carousel-item active">
                    <div class="view" style="background-image: url('https://i.imgur.com/g3nHGxA.jpg'); background-repeat: no-repeat; background-size: cover; background-position: 0px 40%;">
                        <!-- Mask & flexbox options-->
                        <div class="mask rgba-black-strong d-flex justify-content-center align-items-center">
                            <!-- Content -->
                            <div class="text-center white-text mx-5 wow fadeIn">
                                <h1 class="mb-4">
                                    <strong>Men's Sparta Hoodie</strong>
                                </h1>
                                <!-- <p>
                                  <strong>Best & free guide of responsive web design</strong>
                                </p> -->
                                <!-- <p class="mb-4 d-none d-md-block">
                                  <strong>The most comprehensive tutorial for the Bootstrap 4. Loved by over 500 000 users. Video and
                                    written versions
                                    available. Create your own, stunning website.</strong>
                                </p> -->
                                <a target="_blank" href="https://mdbootstrap.com/education/bootstrap/" class="btn btn-outline-white btn-lg">
                                    More Info
                                    <i class="fas fa-graduation-cap ml-2"></i>
                                </a>
                            </div>
                            <!-- Content -->
                        </div>
                        <!-- Mask & flexbox options-->
                    </div>
                </div>
                <!--/First slide-->
                <!--Second slide-->
                <div class="carousel-item">
                    <div class="view" style="background-image: url('https://i.imgur.com/9xVYcuA.jpg'); background-repeat: no-repeat; background-size: cover; background-position: 0px 30%;">

                        <!-- Mask & flexbox options-->
                        <div class="mask rgba-black-strong d-flex justify-content-center align-items-center">

                            <!-- Content -->
                            <div class="text-center white-text mx-5 wow fadeIn">
                                <h1 class="mb-4">
                                    <strong>Men's Sparta Hoodie</strong>
                                </h1>



                                <!-- <p class="mb-4 d-none d-md-block">
                                  <strong>The most comprehensive tutorial for the Bootstrap 4. Loved by over 500 000 users. Video and
                                    written versions
                                    available. Create your own, stunning website.</strong>
                                </p> -->
                                <a target="_blank" href="https://mdbootstrap.com/education/bootstrap/" class="btn btn-outline-white btn-lg">
                                    More Info
                                    <i class="fas fa-graduation-cap ml-2"></i>
                                </a>
                            </div>
                            <!-- Content -->

                        </div>
                        <!-- Mask & flexbox options-->

                    </div>
                </div>
                <!--/Second slide-->
                <!--Third slide-->
                <div class="carousel-item">
                    <div class="view" style="background-image: url('https://i.imgur.com/Es1owH3.jpg'); background-repeat: no-repeat; background-size: cover;background-position: 0px 45%;">

                        <!-- Mask & flexbox options-->
                        <div class="mask rgba-black-strong d-flex justify-content-center align-items-center">

                            <!-- Content -->
                            <div class="text-center white-text mx-5 wow fadeIn">
                                <h1 class="mb-4">
                                    <strong>Women's Sparta Hoodie</strong>
                                </h1>

                                <p>
                                    <strong>A comfortable hoodie</strong>
                                </p>



                                <a target="_blank" href="https://mdbootstrap.com/education/bootstrap/" class="btn btn-outline-white btn-lg">
                                    More Info
                                    <i class="fas fa-graduation-cap ml-2"></i>
                                </a>
                            </div>
                            <!-- Content -->

                        </div>
                        <!-- Mask & flexbox options-->

                    </div>
                </div>
                <!--/Third slide-->

            </div>
            <!--/.Slides-->
            <!--Controls-->
            <a class="carousel-control-prev" href="#carousel-example-1z" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carousel-example-1z" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
            <!--/.Controls-->

        </div>
        <!--/.Carousel Wrapper-->
        <!--Main layout-->
        <main>
            <div class="container">

                <!--Navbar-->
                <nav class="navbar navbar-expand-lg navbar-dark spartaPurple mt-3 mb-5">

                    <!-- Navbar brand -->
                    <span class="navbar-brand">Categories:</span>

                    <!-- Collapse button -->
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#basicExampleNav"
                            aria-controls="basicExampleNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <!-- Collapsible content -->
                    <div class="collapse navbar-collapse" id="basicExampleNav">

                        <!-- Links -->
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item active">
                                <a class="nav-link" href="#">
                                    All
                                    <span class="sr-only">(current)</span>
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Hoodies</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Pens</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Food</a>
                            </li>

                        </ul>
                        <!-- Links -->
                    </div>
                    <!-- Collapsible content -->

                </nav>
                <!--/.Navbar-->
                <!--Section: Products v.3-->
                <section class="text-center mb-4">

                    <!--Grid row-->
                    <div class="row wow fadeIn">

                        <!--Grid column-->
                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="https://i.imgur.com/nGZoMOi.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Hoodie</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">
                                                Sparta Global Hoodie (Men's)
                                                <span class="badge badge-pill danger-color">NEW</span>
                                                <span class="badge badge-pill primary-color">bestseller</span>
                                            </a>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£35</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->
                        <!--Grid column-->
                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="https://i.imgur.com/etNnpuv.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Hoodie</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Hoodie (Women's)</a>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£35</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->
                        <!--Grid column-->
                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="https://i.imgur.com/g3nHGxA.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Hoodie</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">
                                                Sparta Global Hoodie (Men's)
                                                <span class="badge badge-pill primary-color">bestseller</span>
                                            </a>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£35</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->

                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="Fuat_1.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Hoodie</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Hoodie (Men's)</a>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£35</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->

                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="Umbrella_1.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Accessory</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Umbrella</a>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£30</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->


                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="Notepad_1.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Accessory</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Notepad</a>
                                            <span class="badge badge-pill danger-color">NEW</span>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£9</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->

                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="KeyChain_1.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Accessory</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Keychain</a>
                                            <span class="badge badge-pill danger-color">NEW</span>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£5</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->

                        <div class="col-lg-3 col-md-6 mb-4">

                            <!--Card-->
                            <div class="card">

                                <!--Card image-->
                                <div class="view overlay">
                                    <img src="Brownies_1.jpg" class="card-img-top"
                                         alt="">
                                    <a>
                                        <div class="mask rgba-white-slight"></div>
                                    </a>
                                </div>
                                <!--Card image-->
                                <!--Card content-->
                                <div class="card-body text-center">
                                    <!--Category & Title-->
                                    <a href="" class="grey-text">
                                        <h5>Confectionary</h5>
                                    </a>
                                    <h5>
                                        <strong>
                                            <a href="" class="dark-grey-text">Sparta Global Brownies</a>
                                            <span class="badge badge-pill danger-color">NEW</span>
                                        </strong>
                                    </h5>

                                    <h4 class="font-weight-bold purple-text">
                                        <strong>£25</strong>
                                    </h4>

                                </div>
                                <!--Card content-->

                            </div>
                            <!--Card-->

                        </div>
                        <!--Grid column-->

                </section>
                <!--Section: Products v.3-->
                <!--Pagination-->
                <nav class="d-flex justify-content-center wow fadeIn">
                    <ul class="pagination pg-blue">

                        <!--Arrow left-->
                        <li class="page-item disabled">
                            <a class="page-link" href="#" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                                <span class="sr-only">Previous</span>
                            </a>
                        </li>

                        <li class="page-item active">
                            <a class="page-link" href="#">
                                1
                                <span class="sr-only">(current)</span>
                            </a>
                        </li>


                        <li class="page-item">
                            <a class="page-link" href="#" aria-label="Next">
                                <span aria-hidden="true">&raquo;</span>
                                <span class="sr-only">Next</span>
                            </a>
                        </li>
                    </ul>
                </nav>
                <!--Pagination-->

            </div>
        </main>
        <!--Main layout-->
        <!--Footer-->
        <footer class="page-footer text-center font-small mt-4 wow fadeIn">

            <!--Call to action-->
            <!-- <div class="pt-4">
              <a class="btn btn-outline-white" href="https://mdbootstrap.com/docs/jquery/getting-started/download/" target="_blank"
                role="button">Download MDB
                <i class="fas fa-download ml-2"></i>
              </a>
              <a class="btn btn-outline-white" href="https://mdbootstrap.com/education/bootstrap/" target="_blank" role="button">Start
                free tutorial
                <i class="fas fa-graduation-cap ml-2"></i>
              </a>
            </div> -->
            <!--/.Call to action-->

            <hr class="my-4">

            <!-- Social icons -->
            <div class="pb-4">
                <a href="https://www.facebook.com/spartaglobal/" target="_blank">
                    <i class="fab fa-facebook-f mr-3"></i>
                </a>

                <!-- <a href="https://twitter.com/MDBootstrap" target="_blank">
                  <i class="fab fa-twitter mr-3"></i>
                </a> -->

                <a href="https://www.youtube.com/channel/UCLL-3SO5bUE1q6JRgFzjBrA/featured" target="_blank">
                    <i class="fab fa-youtube mr-3"></i>
                </a>

                <!-- <a href="https://plus.google.com/u/0/b/107863090883699620484" target="_blank">
                  <i class="fab fa-google-plus-g mr-3"></i>
                </a> -->
                <!-- <a href="https://dribbble.com/mdbootstrap" target="_blank">
                  <i class="fab fa-dribbble mr-3"></i>
                </a>

                <a href="https://pinterest.com/mdbootstrap" target="_blank">
                  <i class="fab fa-pinterest mr-3"></i>
                </a> -->

                <a href="https://github.com/MylesMuda/Sparta-Online-Shop" target="_blank">
                    <i class="fab fa-github mr-3"></i>
                </a>

                <!-- <a href="http://codepen.io/mdbootstrap/" target="_blank">
                  <i class="fab fa-codepen mr-3"></i>
                </a> -->
            </div>
            <!-- Social icons -->
            <!--Copyright-->
            <div class="footer-copyright py-3" id="#section2">
                © 2019 Copyright
                <a target="_blank"> Engineering 41 </a>
            </div>
            <!--/.Copyright-->

        </footer>
        <!--/.Footer-->
        <!-- SCRIPTS -->
        <!-- JQuery -->
        <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
        <!-- Bootstrap tooltips -->
        <script type="text/javascript" src="js/popper.min.js"></script>
        <!-- Bootstrap core JavaScript -->
        <script type="text/javascript" src="js/bootstrap.min.js"></script>
        <!-- MDB core JavaScript -->
        <script type="text/javascript" src="js/mdb.min.js"></script>
        <!-- Initializations -->
        <script type="text/javascript">
            // Animations initialization
            new WOW().init();

        </script>
    </body>

</body>
</html>
