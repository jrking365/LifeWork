@ModelType MessagerieViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_Messagerie
End Code
@Styles.Render("~/Content/css")


@*@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    <div class="form-group">
        @Html.LabelFor(Function(model) model.TypeMessagerieId, "TypeMessagerieId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("TypeMessagerieId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.TypeMessagerieId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.UserExpediteurId, "UserExpediteurId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("UserExpediteurId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.UserExpediteurId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.UserDestinataireId, "UserDestinataireId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("UserDestinataireId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.UserDestinataireId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.JobsId, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.JobsId)
            @Html.ValidationMessageFor(Function(model) model.JobsId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Contenu, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Contenu)
            @Html.ValidationMessageFor(Function(model) model.Contenu)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Objet, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Objet)
            @Html.ValidationMessageFor(Function(model) model.Objet)
        </div>
    </div>*@

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.DateEnvoi, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DateEnvoi)
                @Html.ValidationMessageFor(Function(model) model.DateEnvoi)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DateReception, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DateReception)
                @Html.ValidationMessageFor(Function(model) model.DateReception)
            </div>
        </div>*@

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.StatutExistant, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.StatutExistant)
                @Html.ValidationMessageFor(Function(model) model.StatutExistant)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DateCreation, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DateCreation)
                @Html.ValidationMessageFor(Function(model) model.DateCreation)
            </div>
        </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="@Resource.Btn_Ajouter" class="btn btn-default" />
        </div>
    </div>
</div>
End Using*@

@*<div>
    @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
</div>*@


    <div Class="wrapper wrapper-content">
    <div Class="row">
        <!-- Start Mail menu -->
        <div Class="col-md-3">
            <div Class="ibox float-e-margins">
                <div Class="ibox-content mailbox-content">
                    <div Class="file-manager">
                        @Html.ActionLink(Resource.Create_Messagerie, "Create", "Messagerie", New With {.class = "btn btn-block btn-primary compose-mail"})
                        <div Class="space-25"></div>
                        <h5> Dossier</h5>
                        <ul Class="folder-list m-b-md" style="padding: 0">
                            <li> <a href = "" > <i Class="fa fa-inbox "></i> Reception <span Class="label label-warning pull-right">1</span> </a></li>
                            <li> <a href = "" > <i Class="fa fa-envelope-o"></i> Envoyé</a></li>
                            <li> <a href = "mailbox.html"> <i Class="fa fa-certificate"></i> Important</a></li>
                            <li> <a href = "mailbox.html"> <i Class="fa fa-file-text-o"></i> Brouillon <span Class="label label-danger pull-right">1</span></a></li>
                            <li> <a href = "mailbox.html"> <i Class="fa fa-trash-o"></i> Corbeille</a></li>
                        </ul>
                        <h5> Catégories</h5>
                        <ul Class="category-list" style="padding: 0">
                            <li> <a href = "#" > <i Class="fa fa-circle text-navy"></i> Annonces</a></li>
                            <li> <a href = "#"> <i Class="fa fa-circle text-danger"></i> Réalisations</a></li>
                            <li> <a href = "#"> <i Class="fa fa-circle text-primary"></i> Jobs</a></li>
                            <li> <a href = "#"> <i Class="fa fa-circle text-info"></i> Publicités</a></li>
                            <li> <a href = "#"> <i Class="fa fa-circle text-warning"></i> Clients/Prestaires</a></li>
                        </ul>
                        <div Class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Mail menu -->
        <!-- Start Mail content -->
        <div Class="col-md-9 animated fadeInRight">
            <div Class="mail-box-header">
                <div Class="pull-right tooltip-demo">

                    <a href = "" Class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="top" title="Deplacer vers le brouillon"><i Class="fa fa-pencil"></i> Brouillon</a>
                    <a href = "" Class="btn btn-danger btn-sm" data-toggle="tooltip" data-placement="top" title="Supprimer"><i Class="fa fa-times"></i> Supprimer</a>
                </div>
                <h2>
                                                        Message/Mail
                </h2>
            </div>
            <div Class="mail-box">


                <div Class="mail-body">
                    <form Class="form-horizontal" method="get">
                        <div Class="form-group">
                            <Label Class="col-sm-2 control-label">A:</label>
                            
                            <div Class="col-sm-10"><input type="text" class="form-control" value=""></div>
                        </div>

                        <div Class="form-group">
                            <Label Class="col-sm-2 control-label">Objet:</label>
                            <div Class="col-sm-10"><input type="text" class="form-control" value=""></div>
                        </div>
                    </form>

                </div>

                <div Class="mail-text h-200">
                    <div Class="summernote">

                    </div>
                    <div Class="clearfix"></div>
                </div>
                
                <div Class="mail-body text-right tooltip-demo">
                    <a href = "" Class="btn btn-sm btn-primary" data-toggle="tooltip" data-placement="top" title="Envoyer"><i Class="fa fa-reply"></i> Envoyer</a>
                    <a href = "" Class="btn btn-danger btn-sm" data-toggle="tooltip" data-placement="top" title="Supprimer"><i Class="fa fa-times"></i> Supprimer</a>
                    <a href = "" Class="btn btn-white btn-sm" data-toggle="tooltip" data-placement="top" title="Deplacer vers le brouillon"><i Class="fa fa-pencil"></i> Brouillon</a>
                </div>
                <div Class="clearfix"></div>
            </div>
        </div>
        <!-- End Mail content -->
    </div>
</div>

<script src="~/Content/js/plugins/summernote/summernote.min.js"></script>
<script type="text/javascript">
        $(document).ready(function(){

            $('.summernote').summernote();
            //<a href="~/Views/Messagerie/Create.vbhtml">~/Views/Messagerie/Create.vbhtml</a>
        });

</script>

