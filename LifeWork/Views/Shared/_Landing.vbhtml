<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - LifeWork</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jsTemplate")

</head>
<body id="page-top" class="landing-page">

    <!-- Start menu navigation -->
    <div class="navbar-wrapper">
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header page-scroll">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-controls="navbar">
                        <span class="sr-only">Menu</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="">LifeWork</a>
                </div>

                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a class="" href="">Prestataires</a></li>
                        <li><a class="" href="">Clients</a></li>
                        <li>@Html.ActionLink("S’inscrire", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
                        @*<li>@Html.ActionLink("Se connecter", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "modal-link"})</li>*@
                        <li><a class="modal-link" id="loginLink" data-toggle="modal" href="@Url.Action("Login", "Account")">Se connecter</a></li>
                        <li><a class="" href="">Aide <i class="fa fa-question"></i></a></li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    
    <!-- End menu navigation -->
    <!-- Start Slider -->
    <div id="inSlider" class="carousel carousel-fade" data-ride="carousel">

        <!-- Start nombre de slider -->
        <ol class="carousel-indicators">
            <li data-target="#inSlider" data-slide-to="0" class="active"></li>
            <li data-target="#inSlider" data-slide-to="1"></li>
            <li data-target="#inSlider" data-slide-to="2"></li>
            <li data-target="#inSlider" data-slide-to="3"></li>
            <li data-target="#inSlider" data-slide-to="4"></li>
            <li data-target="#inSlider" data-slide-to="5"></li>
        </ol>
        <!-- End nombre de slider -->

        <div class="carousel-inner" role="listbox">

            <!-- Start 1er slider -->
            <div class="item active">
                <div class="container">
                    <div class="carousel-caption">
                        <h1>
                            De quoi avez-vous besoin ?<br />
                            Trouver le sur LifeWork.
                        </h1>
                        <p>Nouvelle plateforme de freelance au Cameroun.</p>
                        <p>
                            <a class="btn btn-lg btn-primary" href="~/Views/Home/About.vbhtml" role="button">En savoir plus</a>
                            <a class="caption-link" href="" role="button">LifeWork</a>
                        </p>
                    </div>
                    <div class="carousel-image wow zoomIn">
                        <img src="~/Content/img/landing/laptop.png" alt="laptop" />
                    </div>
                </div>
                <!-- Set background for slide in css -->
                <div class="header-back one"></div>
            </div>
            <!-- End 1er slider -->
            <!-- Start 2e slider -->
            <div class="item">
                <div class="container">
                    <div class="carousel-caption blank">
                        <h1>Travaillons avec liberté</h1>
                        <p>Les meilleurs freelancees. Disponibles maintenant. le tout en alliant une sécurité optimale.</p>
                        <p><a class="btn btn-lg btn-primary" href="" role="button">En savoir plus</a></p>
                    </div>
                </div>
                <!-- Set background for slide in css -->
                <div class="header-back two"></div>
            </div>
            <!-- End 2e slider -->

        </div>

        <!-- Start Bouton de navigation du slider -->
        <a class="left carousel-control" href="#inSlider" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Précédent</span>
        </a>
        <a class="right carousel-control" href="#inSlider" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Suivant</span>
        </a>
        <!-- End Bouton de navigation du slider -->

    </div>
    <!-- End Slider -->

    <div>
        @RenderBody()
    </div>

    <section id="contact" class="gray-section contact">
        <div class="container">
            <div class="row m-b-lg">
                <div class="col-lg-12 text-center">
                    <div class="navy-line"></div>
                    <h1>Nous rencontrer</h1>
                </div>
            </div>
            <div class="row m-b-lg">
                <div class="col-lg-3 col-lg-offset-3">
                    <address>
                        <strong><span class="navy">Cloud Informations System</span></strong><br />
                        SCDP Cameroun<br />
                        CAMGAZ, BP 260 Yde<br />
                        <abbr title="Telephone">Tel:</abbr> +237 690 90 34 35<br />
                        <abbr title="Adresse email">Email:</abbr> cloudinformation@gmail.com<br />
                        <abbr title="Site web">Site:</abbr> www.cis.cm<br />
                    </address>
                </div>
                <div class="col-lg-4">
                    <p class="text-color">

                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <a href="" class="btn btn-primary">Envoyer un mail</a>
                    <p class="m-t-sm">
                        Suivez nous sur
                    </p>
                    <ul class="list-inline social-icon">
                        <li>
                            <a href="https://twitter.com/?lang=fr" target="_blank"><i class="fa fa-twitter"></i></a>
                        </li>
                        <li>
                            <a href="https://www.facebook.com/" target="_blank"><i class="fa fa-facebook"></i></a>
                        </li>
                        <li>
                            <a href="https://fr.linkedin.com/" target="_blank"><i class="fa fa-linkedin"></i></a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 text-center m-t-lg m-b-lg">
                    <p><strong>&copy; 2016 Cloud Informations System</strong><br /></p>
                </div>
            </div>
        </div>
    </section>

   @*pour les classes modales*@
<div id="connexion" class="modal fade" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
        </div>
    </div>
</div>
    <script>
        $(document).ready(function () {

            $('body').scrollspy({
                target: '.navbar-fixed-top',
                offset: 80
            });

            // Page scrolling feature
            $('a.page-scroll').bind('click', function (event) {
                var link = $(this);
                $('html, body').stop().animate({
                    scrollTop: $(link.attr('href')).offset().top - 50
                }, 500);
                event.preventDefault();
                $("#navbar").collapse('hide');
            });
        });

        var cbpAnimatedHeader = (function () {
            var docElem = document.documentElement,
                    header = document.querySelector('.navbar-default'),
                    didScroll = false,
                    changeHeaderOn = 200;
            function init() {
                window.addEventListener('scroll', function (event) {
                    if (!didScroll) {
                        didScroll = true;
                        setTimeout(scrollPage, 250);
                    }
                }, false);
            }
            function scrollPage() {
                var sy = scrollY();
                if (sy >= changeHeaderOn) {
                    $(header).addClass('navbar-scroll')
                }
                else {
                    $(header).removeClass('navbar-scroll')
                }
                didScroll = false;
            }
            function scrollY() {
                return window.pageYOffset || docElem.scrollTop;
            }
            init();

        })();

        // Activate WOW.js plugin for animation on scrol
        new WOW().init();

    </script>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    
</body>
</html>
