﻿@ModelType Competence
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Competence
End Code

<h2>@Resource.Details_Competence</h2>
<hr />

<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.cv.UserId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cv.UserId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Libelle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        @*<dt>
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
        </dd>*@

    </dl>
</div>
<p>
    @Html.ActionLink(Resource.Edit_Competence, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
