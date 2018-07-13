@ModelType Pays
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Pays
End Code

<h2>@Resource.Details_Pays</h2>

<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nom)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Abreviation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Abreviation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IdentifiantTelephonique)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IdentifiantTelephonique)
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
    @Html.ActionLink(Resource.Edit_Pays, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
