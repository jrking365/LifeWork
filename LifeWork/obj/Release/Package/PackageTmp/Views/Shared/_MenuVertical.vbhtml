@Imports LifeWork.My.Resources
@Imports Microsoft.AspNet.Identity
@Code
    Dim activeMenu As String = ViewBag.activeMenu
    If String.IsNullOrEmpty(activeMenu) Then
        activeMenu = "param"
    End If

    Dim idcon As String = User.Identity.GetUserId
End Code

@Helper selectedMenu(menu As String, activeMenu As String)
    If activeMenu.StartsWith(menu) Then
        @:in
    End If
End Helper

@Helper selectedItem(menu As String, activeMenu As String)
    If menu = activeMenu Then
        @:active
    End If
End Helper
@Styles.Render("~/Content/css")
@Scripts.Render("~/bundles/bootstrap")
<!-- Start Menu de gauche -->
<nav class="navbar-default navbar-static-side" role="navigation">
    <div class="sidebar-collapse">
        <ul class="nav metismenu" id="side-menu">
            <li class="nav-header">
                <div class="dropdown profile-element">
                    <span>
                     
                        <img alt="image" class="img-circle" src="~/Content/img/default_profile.png" width="90" height="90" />
                    </span>
                    <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                        <span class="clear">
                            <span class="block m-t-xs">
                                <strong class="font-bold"></strong>
                            </span> <span class="text-muted text-xs block">@User.Identity.Name </span>
                        </span>
                    </a>
                </div>
                <div class="logo-element">
                    LFW
                </div>
            </li>

            <li>


                <a><i class="fa fa-desktop"></i><span class="nav-label">@Resource.User_MesProjets</span><span class="fa arrow"></span></a>
                <ul class="nav nav-second-level collapse ">
                    <li>
                       
                                <a> <i Class="fa fa-th-large"></i><span class="nav-label">En tant que Employeur</span><span class="fa arrow"></span></a>
                                <ul Class="nav nav-second-level  ">
                                    <li> @Html.ActionLink("Job en cours d'execution", "JobEnCours", "Jobs")</li>
                                    <li>@Html.ActionLink("Poster Job", "Create", "Jobs")</li>
                                    <li>@Html.ActionLink("Jobs non attribué", "JobOuvertPostulation", "Jobs")</li>
                                    <li>@Html.ActionLink(Resource.Job_Cloture, "JobsClotureEmployeur", "Jobs")</li>
                                </ul>
                           

                        @code
                           @If User.IsInRole("SA") Or User.IsInRole("PRESTATAIRE") Then
                                 @<a> <i Class="fa fa-th-large"></i><span class="nav-label">En tant que Prestataire</span><span class="fa arrow"></span></a>
                                @<ul Class="nav nav-second-level ">
                                     <li>@Html.ActionLink("Jobs Disponible", "JobsDispo", "Jobs")</li>
                                     <li>@Html.ActionLink(Resource.Job_Cloture, "JobsCloturePrestataire", "Jobs")</li>
                                     <li> @Html.ActionLink(Resource.Jobs_Encours, "JobEnCoursPrestataire", "Jobs")</li>

                                    
                                </ul>
                           End If
                        End Code
                        
                    </li>
                </ul>
                <a><i class="fa fa-envelope"></i> <span class="nav-label">@Resource.Messagerie</span><span class="label label-warning pull-right">16/24</span></a>
                <ul class="nav nav-second-level collapse">
                    <li>@Html.ActionLink(Resource.Create_Messagerie, "Create", "Messagerie")</li>
                    <li>@Html.ActionLink(Resource.Index_Messagerie, "Index", "Messagerie")</li>
                </ul>

                <a><i class="fa fa-cogs"></i><span class="nav-label">Gerer compte</span></a>
                <ul class="nav nav-second-level">
                    <li> @Html.ActionLink("completer informations", "CompleterInfos", "Account", New With {.id = idcon}, Nothing) </li>
                </ul>

                <a><i class="fa fa-archive"></i><span class="nav-label">Gerer le CV</span></a>
                <ul class="nav nav-second-level">
                    <li> @Html.ActionLink("Ajouter informations", "LeCV", "Cv") </li>
                </ul>
            </li>




        </ul>
    </div>
</nav>
@Scripts.Render("~/bundles/jquery")

@Scripts.Render("~/bundles/modernizr")
@Scripts.Render("~/bundles/jsTemplate")



<!-- End Menu de gauche -->