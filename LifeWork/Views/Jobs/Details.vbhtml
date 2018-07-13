@ModelType Jobs
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Jobs
End Code
@Styles.Render("~/Content/css")
<hr />
@*<div>
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.SousSecteurActivite.Libelle)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.statut.Libelle)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.statut.Libelle)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.TypeJob.Libelle)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.TypeJob.Libelle)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.UserAttribuer.UserName)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.UserAttribuer.UserName)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.UserPublier.UserName)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.UserPublier.UserName)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.Titre)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Titre)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.Duree)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Duree)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.Code)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Code)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.Description)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Description)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.LieuExecution)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.LieuExecution)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DatePrevueLivraison)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DatePrevueLivraison)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DatePublication)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DatePublication)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DateAttribution)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DateAttribution)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DateCloture)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DateCloture)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.BudgetMinimal)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.BudgetMinimal)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.BudgetMaximal)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.BudgetMaximal)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.BudgetAttribution)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.BudgetAttribution)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.CahierDeCharge)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CahierDeCharge)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.StatutExistant)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.StatutExistant)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DateCreation)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DateCreation)
            </dd>

        </dl>
    </div>*@

@*<p>
        @Html.ActionLink(Resource.Edit_Jobs, "Edit", New With {.id = Model.Id}) |
        @Html.ActionLink(Resource.Btn_Annuler, "Index")
    </p>*@
<div class="wrapper wrapper-content animated fadeInRight">

    <div class="row">
        <div class="col-lg-12">

            <div class="ibox product-detail">
                <div class="ibox-content">

                    <div class="row">
                        <div class="col-md-5">
                            <div class="product-images">
                                <div>
                                    <div class="image-imitation">
                                        
                                        <img src="~/Content/img/job.jpg" />
                                    </div>
                                </div>
                                @*<div>
                                        <div class="image-imitation">
                                            [IMAGE 2]
                                        </div>
                                    </div>
                                    <div>
                                        <div class="image-imitation">
                                            [IMAGE 3]
                                        </div>
                                    </div>*@
                            </div>

                        </div>
                        <div class="col-md-7">

                            <h2 class="font-bold m-b-xs">
                                @Html.DisplayFor(Function(model) model.Titre)
                            </h2>
                            <small>@Resource.Il_S_Agit @Resource.D_Un @Resource.Jobs <strong>@Html.DisplayFor(Function(model) model.TypeJob.Libelle)</strong>@Resource.A_Accent <strong> @Html.DisplayFor(Function(model) model.LieuExecution)</strong> </small>
                            <div class="m-t-md">
                                <h2 class="product-main-price"><label class="text-success">@Html.DisplayFor(Function(model) model.BudgetMinimal) @Resource.FCFA</label> <small class="text-muted">@Resource.BudgetMinimal_Jobs</small>  <label class="text-danger">@Html.DisplayFor(Function(model) model.BudgetMaximal) @Resource.FCFA</label> <small class="text-muted"> @Resource.BudgetMaximal_Jobs</small> </h2>
                            </div>
                            <hr>

                            <h4>@Html.DisplayNameFor(Function(model) model.Description)</h4>

                            <div class=" text-muted">
                                @Html.DisplayFor(Function(model) model.Description)
                            </div>
                            <dl class="small m-t-md">
                                <dt>@Resource.PublierPar</dt>
                                <dd> @Html.DisplayFor(Function(model) model.UserPublier.UserName)</dd>
                                <dt>@Resource.DatePrevueLivraison_Jobs</dt>
                                <dd>@Html.DisplayFor(Function(model) model.DatePrevueLivraison)</dd>
                                <dt>@Resource.Statut</dt>
                                <dd>@Html.DisplayFor(Function(model) model.statut.Libelle)</dd>
                            </dl>
                            <hr>

                            <div>
                                <div class="btn-group">
                                    <button class="btn btn-primary btn-sm">@Html.DisplayFor(Function(model) model.CahierDeCharge)<i class="fa fa-cart-plus"></i>@Resource.CahierDeCharge_Jobs</button>

                                    @*<button class="btn btn-white btn-sm"><i class="fa fa-envelope"></i>@Resource.Contact_Employeur</button>*@
                                    @Html.ActionLink(Resource.Contact_Employeur, "Create", "Messagerie")
                                </div>
                                @code
                                    'ici nous définissons que le bouton postuler ne sera visible que par l'utilisateur qui n'est pas l'utilisateur connecté
                                    If (ViewBag.TypeCompteUser = "Prestataire" AndAlso Model.StatutId = 2) Then
                                        If (ViewBag.idUse <> Model.UserPublierId) Then
                                            @Html.ActionLink(" Postuler", "vuePostulerA1Job", "PostulerJob", New With {.id = Model.Id}, New With {.class = "modal-link btn btn-success fa fa-shopping-cart"})

                                        End If
                                    End If
                                End Code

                            </div>




                        </div>
                    </div>

                </div>
                <div class="ibox-footer">
                    <span class="pull-right">
                        <i class="fa fa-clock-o"></i>@Date.Now
                    </span>
                    LifeWork Your Work
                </div>
            </div>

        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="ibox">
                <div class="ibox-title bg-primary">
                    <span class="pull-right">(<strong>mettre un count ici</strong>) Personnes</span>
                    <h5>Nombre de personnes ayant postulé</h5>
                </div>



                @for Each postuleur In ViewBag.Postuleurs
                    @<div Class="ibox-content">
                        <div Class="table-responsive">
                            <Table Class="table shoping-cart-table">
                                <tbody>
                                    <tr>
                                        <td width="90">
                                            <div class="cart-product-imitation">
                                                @*@postuleur.User.Photo*@
                                                @code
                                                        if postuleur.User.Photo IsNot Nothing Then
                                                        @<img Class="img-rounded center-block" width="90" height="50" src='@Url.Action("ShowImage", "Jobs", New With {.id = postuleur.UserId})' />
                                                    End If
                                                End Code

                                            </div>
                                        </td>
                                        <td class="desc">
                                            <h3>
                                                <a href="#" class="text-navy">
                                                    @postuleur.User.UserName

                                                </a>

                                            </h3>
                                            <p class="small">
                                                @postuleur.Description
                                            </p>

                                            @If (ViewBag.idUse = Model.UserPublierId AndAlso Model.StatutId = 2) Then
                                            @<div Class="m-t-sm">
                                                @Html.ActionLink("Attribuer le job", "PageAttribuer", "Jobs", New With {.id = postuleur.UserId, .jobsid = postuleur.JobsId}, New With {.class = "btn btn-primary fa fa-gift"})
                                            </div>
                                            End If



                                        </td>
                                        <td width="100">
                                            @postuleur.DureeExecution Jours
                                        </td>
                                        <td width="300">
                                            publié le @postuleur.DateEnvoi
                                        </td>
                                        <td width="400">
                                            <h4>
                                                @postuleur.BudgetExige FCFA
                                            </h4>
                                        </td>
                                    </tr>
                                </tbody>
                            </Table>
                        </div>
                    </div>
                                                    Next
            </div>
        </div>
    </div>
</div>
<Script>
    //$(document).ready(Function () {
    //  $('.product-images').slick({
    //dots: true
    //});

    //});
</Script>
@Section Scripts
    @Scripts.Render("~/bundles/jsTemplate")

End Section