@ModelType ServiceViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_Service
End Code

<h2>@Resource.Edit_Service</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.UserId, "UserId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("UserId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserId)
            </div>
        </div>*@

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.SousSecteurActiviteId, "SousSecteurActiviteId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("SousSecteurActiviteId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.SousSecteurActiviteId)
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
        @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DatePostulation, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DatePostulation)
            @Html.ValidationMessageFor(Function(model) model.DatePostulation)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DureeRealisation, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DureeRealisation)
            @Html.ValidationMessageFor(Function(model) model.DureeRealisation)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.MontantMinimal, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.MontantMinimal)
            @Html.ValidationMessageFor(Function(model) model.MontantMinimal)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.MontantMaximal, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.MontantMaximal)
            @Html.ValidationMessageFor(Function(model) model.MontantMaximal)
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