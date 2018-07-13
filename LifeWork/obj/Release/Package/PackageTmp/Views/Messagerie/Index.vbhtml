@ModelType IEnumerable(Of Messagerie)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Messagerie
End Code



@*<p>
    @Html.ActionLink(Resource.Create_Messagerie, "Create")
</p>*@
@*<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.TypeMessagerie.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserDestinataire.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserExpediteur.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.JobsId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contenu)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Objet)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateEnvoi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateReception)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.StatutExistant)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateCreation)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TypeMessagerie.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserDestinataire.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserExpediteur.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.JobsId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contenu)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Objet)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateEnvoi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateReception)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>
         <td>
             @Html.ActionLink(Resource.Edit_Messagerie, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Messagerie, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Messagerie, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>*@

<!-- End Titre du contenu actuel -->

<div class="wrapper wrapper-content">
    <div class="row">
        <!-- Start Mail menu -->
        <div class="col-md-3">
            <div class="ibox float-e-margins">
                <div class="ibox-content mailbox-content">
                    <div class="file-manager">
                        @Html.ActionLink(Resource.Create_Messagerie, "Create", "Messagerie", New With {.class = "btn btn-block btn-primary compose-mail"})
                        <div class="space-25"></div>
                        <h5>Dossier</h5>
                        <ul class="folder-list m-b-md" style="padding: 0">
                            <li><a href=""> <i class="fa fa-inbox "></i> Reception <span class="label label-warning pull-right">1</span> </a></li>
                            <li><a href=""> <i class="fa fa-envelope-o"></i> Envoyé</a></li>
                            <li><a href="mailbox.html"> <i class="fa fa-certificate"></i> Important</a></li>
                            <li><a href="mailbox.html"> <i class="fa fa-file-text-o"></i> Brouillon <span class="label label-danger pull-right">1</span></a></li>
                            <li><a href="mailbox.html"> <i class="fa fa-trash-o"></i> Corbeille</a></li>
                        </ul>
                        <h5>Catégories</h5>
                        <ul class="category-list" style="padding: 0">
                            <li><a href="#"> <i class="fa fa-circle text-navy"></i> Annonces</a></li>
                            <li><a href="#"> <i class="fa fa-circle text-danger"></i> Réalisations</a></li>
                            <li><a href="#"> <i class="fa fa-circle text-primary"></i> Jobs</a></li>
                            <li><a href="#"> <i class="fa fa-circle text-info"></i> Publicités</a></li>
                            <li><a href="#"> <i class="fa fa-circle text-warning"></i> Clients/Prestaires</a></li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Mail menu -->
        <!-- Start Mail list -->
        <div class="col-md-9 animated fadeInRight">
            <div class="mail-box-header">

                <form method="get" action="" class="pull-right mail-search">
                    <div class="input-group">
                        <input type="text" class="form-control input-sm" name="search" placeholder="Rechercher un mail">
                        <div class="input-group-btn">
                            <button type="submit" class="btn btn-sm btn-primary">
                                Rechercher
                            </button>
                        </div>
                    </div>
                </form>
                <h2>
                    Reception (1)
                </h2>
                <div class="mail-tools tooltip-demo m-t-md">
                    <div class="btn-group pull-right">
                        <button class="btn btn-white btn-sm"><i class="fa fa-arrow-left"></i></button>
                        <button class="btn btn-white btn-sm"><i class="fa fa-arrow-right"></i></button>

                    </div>
                    <button class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="left" title="Rafraichir"><i class="fa fa-refresh"></i> Refresh</button>
                    <button class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="top" title="Marquer comme lu"><i class="fa fa-eye"></i> </button>
                    <button class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="top" title="Marquer comme important"><i class="fa fa-exclamation"></i> </button>
                    <button class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="top" title="Supprimer"><i class="fa fa-trash-o"></i> </button>

                </div>
            </div>

            <div class="mail-box">
                <table class="table table-hover table-mail">
                    <tbody>
                        <tr class="unread">
                            <td class="check-mail">
                                <input type="checkbox" class="i-checks">
                            </td>
                            <td class="mail-ontact"><a href="mail_detail.html">Stephane KAMGA</a></td>
                            <td class="mail-subject"><a href="mail_detail.html">CIS - LifeWork.</a></td>
                            <td class=""><i class="fa fa-paperclip"></i></td>
                            <td class="text-right mail-date">14 h</td>
                        </tr>
                        <tr class="read">
                            <td class="check-mail">
                                <input type="checkbox" class="i-checks">
                            </td>
                            <td class="mail-ontact"><a href="">LifeWork</a> <span class="label label-warning pull-right">Clients</span> </td>
                            <td class="mail-subject"><a href="">Nouvelle mise a jour du site.</a></td>
                            <td class=""></td>
                            <td class="text-right mail-date">12 Sept</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <!-- End Mail list -->
    </div>
</div>

<!-- Start Pied de page -->
<div class="footer">
    <div>
        <strong>Copyright</strong> Cloud Information System &copy; 2016
    </div>
    <div class="pull-right">
        <strong>Tous droits reserves</strong>
    </div>
</div>
<!-- End pied de page -->

<script>
            $(document).ready(function () {
                $('.i-checks').iCheck({
                    checkboxClass: 'icheckbox_square-green',
                    radioClass: 'iradio_square-green',
                });
            });
</script>
