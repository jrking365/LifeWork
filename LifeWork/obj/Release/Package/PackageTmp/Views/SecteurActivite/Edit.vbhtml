﻿@ModelType SecteurActiviteViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_SecteurActivite
End Code

<h2>@Resource.Edit_SecteurActivite</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Libelle, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Libelle)
            @Html.ValidationMessageFor(Function(model) model.Libelle)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
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
