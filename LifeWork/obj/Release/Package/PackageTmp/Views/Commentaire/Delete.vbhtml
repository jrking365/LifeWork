﻿@ModelType Commentaire
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Commentaire</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Jobs.UserPublierId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserEmployeur.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserEmployeur.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserPrestataire.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserPrestataire.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contenu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contenu)
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
