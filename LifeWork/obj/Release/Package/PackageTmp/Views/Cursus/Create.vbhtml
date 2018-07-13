@ModelType CursusViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_Cursus
End Code

<h2>@Resource.Create_Cursus</h2>
<hr />

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    <div class="form-group">
        @Html.LabelFor(Function(model) model.TypeCursusId, "TypeCursusId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("TypeCursusId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.TypeCursusId)
        </div>
    </div>

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.CvId, "CvId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("CvId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.CvId)
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Titre, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Titre)
            @Html.ValidationMessageFor(Function(model) model.Titre)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Poste, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Poste)
            @Html.ValidationMessageFor(Function(model) model.Poste)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Structures, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Structures)
            @Html.ValidationMessageFor(Function(model) model.Structures)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Diplome, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Diplome)
            @Html.ValidationMessageFor(Function(model) model.Diplome)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Periode, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Periode)
            @Html.ValidationMessageFor(Function(model) model.Periode)
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
