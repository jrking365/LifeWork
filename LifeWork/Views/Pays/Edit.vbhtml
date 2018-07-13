@ModelType PaysViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_Pays
End Code

<h2>@Resource.Edit_Pays</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Nom, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Nom)
            @Html.ValidationMessageFor(Function(model) model.Nom)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Abreviation, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Abreviation)
            @Html.ValidationMessageFor(Function(model) model.Abreviation)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.IdentifiantTelephonique, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.IdentifiantTelephonique)
            @Html.ValidationMessageFor(Function(model) model.IdentifiantTelephonique)
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
