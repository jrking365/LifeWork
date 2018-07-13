@ModelType CompteBancaire
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_CompteBancaire
End Code

<h2>@Resource.Details_CompteBancaire</h2>
<hr />

<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Code)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatePeremption)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatePeremption)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Solde)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Solde)
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
    @Html.ActionLink(Resource.Edit_CompteBancaire, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
