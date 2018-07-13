@ModelType MessagerieViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_Messagerie
End Code

<h2>Resource.Edit_Messagerie</h2>
<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)

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
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateEnvoi, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateEnvoi)
            @Html.ValidationMessageFor(Function(model) model.DateEnvoi)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateReception, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateReception)
            @Html.ValidationMessageFor(Function(model) model.DateReception)
        </div>
    </div>

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
        </div>*@

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="@Resource.Btn_Enregistrer" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
    @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
