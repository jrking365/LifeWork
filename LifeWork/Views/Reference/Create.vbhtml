@ModelType ReferenceViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_Reference
End Code

<h2>@Resource.Create_Reference</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    <div class="form-group">
        @Html.LabelFor(Function(model) model.Titre, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Titre)
            @Html.ValidationMessageFor(Function(model) model.Titre)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Adresse, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Adresse)
            @Html.ValidationMessageFor(Function(model) model.Adresse)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Annee, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Annee)
            @Html.ValidationMessageFor(Function(model) model.Annee)
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="@Resource.Btn_Ajouter" class="btn btn-default" />
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
