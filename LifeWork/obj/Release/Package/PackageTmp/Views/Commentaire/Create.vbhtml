﻿@ModelType CommentaireViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_Commentaire
End Code

<h2>@Resource.Create_Commentaire</h2>
<hr />

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.JobsId)
    @Html.HiddenFor(Function(model) model.UserEmployeurId)
    @Html.HiddenFor(Function(model) model.UserPrestataireId)

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.JobsId, "JobsId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("JobsId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.JobsId)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UserEmployeurId, "UserEmployeurId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("UserEmployeurId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserEmployeurId)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UserPrestataireId, "UserPrestataireId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("UserPrestataireId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserPrestataireId)
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Contenu, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Contenu)
            @Html.ValidationMessageFor(Function(model) model.Contenu)
        </div>
    </div>

    @*<div class="form-group">
        @Html.LabelFor(Function(model) model.StatutExistant, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.StatutExistant)
            @Html.ValidationMessageFor(Function(model) model.StatutExistant)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateCreation, New With {.class = "control-label col-md-2"})
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
