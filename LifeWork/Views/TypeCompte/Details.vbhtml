@ModelType TypeCompte
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_TypeCompte
End Code

<h2>@Resource.Details_TypeCompte</h2>

<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Libelle)
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
    @Html.ActionLink(Resource.Edit_TypeCompte, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
