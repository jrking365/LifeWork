<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="Cloud Informations System with Guiala Jean roger">
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/modernizr")
    @*@Scripts.Render("~/bundles/jsTemplate")*@
    @Scripts.Render("~/bundles/jsFormCrea")
    <style>
        .modal-content {
            width: 600px !important;
            margin: 30px auto !important;
        }
    </style>
    <title>@ViewBag.Title - LifeWork</title>
    
    

</head>
<body>
    <div id="wrapper">
        @If User.Identity.IsAuthenticated Then
            @Html.Partial("_MenuVertical")
End If
        @Html.Partial("_LoginPartial")

        <div id="page-wrapper" class="gray-bg">
            <!-- Start Entete pour utilisateur -->
            <div class="row border-bottom">
                <nav class="navbar navbar-static-top  " role="navigation" style="margin-bottom: 0">
                    <div class="navbar-header">
                        <a class="navbar-minimalize minimalize-styl-2 btn btn-primary" href="#"><i class="fa fa-bars"></i> </a>
                        <form role="search" class="navbar-form-custom" action="">
                            <div class="form-group">
                                <input type="text" placeholder="Rechercher..." class="form-control" name="top-search" id="top-search">
                            </div>
                        </form>
                    </div>

                    <ul class="nav navbar-top-links navbar-right">
                        <li>
                            <span class="m-r-sm text-muted welcome-message">Bienvenue dans LifeWork.</span>
                        </li>

                        <li class="dropdown">
                            <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                <i class="fa fa-envelope"></i>  <span class="label label-danger">SMS</span>
                            </a>

                            <ul class="dropdown-menu dropdown-messages">
                                <li>
                                    <div class="dropdown-messages-box">
                                        <a href="" class="pull-left">
                                            <img alt="image" class="img-circle" src="img/a7.jpg">
                                        </a>
                                        <div class="media-body">
                                            <small class="pull-right">Il y 46h</small>
                                            <strong>MOMO</strong> a ecrit a <strong>KAMGA</strong>. <br>
                                            <small class="text-muted">Il ya 3jours a 10h34 - 13/09/2016</small>
                                        </div>
                                    </div>
                                </li>
                                <li class="divider"></li>
                                <li>
                                    <div class="text-center link-block">
                                        <a href="">
                                            <i class="fa fa-envelope"></i> <strong>Lire tous les messages.</strong>
                                        </a>
                                    </div>
                                </li>
                            </ul>
                        </li>

                        <li class="dropdown">
                            <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                <i class="fa fa-bell"></i>  <span class="label label-warning">Job</span>
                            </a>
                            <ul class="dropdown-menu dropdown-alerts">
                                <li>
                                    <a href="">
                                        <div>
                                            <i class="fa fa-envelope fa-fw"></i> Fabrication d'une chaise
                                            <span class="pull-right text-muted small">Il ya 9h</span>
                                        </div>
                                    </a>
                                </li>
                                <li class="divider"></li>
                                <li>
                                    <div class="text-center link-block">
                                        <a href="">
                                            <strong>Regarder toutes les annonces</strong>
                                            <i class="fa fa-angle-right"></i>
                                        </a>
                                    </div>
                                </li>
                            </ul>
                        </li>

                        <li>
                                
                                @Html.ActionLink("Deconnexion", "LogOff", "Account")

                            
                        </li>
                    </ul>
                </nav>
            </div>
            <!-- End Entete pour utilisateur -->
            <!-- Start Titre du contenu actuel -->
            <div class="row wrapper border-bottom white-bg page-heading">
                <div class="col-sm-4">
                    <h2>@ViewBag.Title</h2>
                </div>
            </div>
            <!-- End Titre du contenu actuel -->
            <!-- Start Contenu de la page -->
            <div class="wrapper wrapper-content">
                @RenderBody()
            </div>
            <!-- End Contenu de la page -->
            <!-- Start Pied de page -->
            <div class="footer">
                <div class="pull-right">
                    <strong>Tous droits reserves</strong>
                </div>
                <div>
                    <strong>Copyright</strong> Cloud Information System &copy; 2016
                </div>

            </div>
            <!-- End pied de page -->
        </div>
    </div>

    <div id="modal-container" class="modal fade"
         tabindex="-1" role="dialog" style="display:none">
        <div class="modal-content">
        </div>
    </div>

    
    @RenderSection("scripts", required:=False)
    <script type="text/javascript">
        $(function () {
            // Initialize numeric spinner input boxes
            //$(".numeric-spinner").spinedit();
            // Initialize modal dialog
            // attach modal-container bootstrap attributes to links with .modal-link class.
            // when a link is clicked with these attributes, bootstrap will display the href content in a modal dialog.
            $('body').on('click', '.modal-link', function (e) {
                e.preventDefault();
                $(this).attr('data-target', '#modal-container');
                $(this).attr('data-toggle', 'modal');
            });
            // Attach listener to .modal-close-btn's so that when the button is pressed the modal dialog disappears
            $('body').on('click', '.modal-close-btn', function () {
                $('#modal-container').modal('hide');
            });
            //clear modal cache, so that new content can be loaded
            $('#modal-container').on('hidden.bs.modal', function () {
                $(this).removeData('bs.modal');
            });
            $('#CancelModal').on('click', function () {
                return false;
            });
        });
    </script>

</body>
</html>
