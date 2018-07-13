@ModelType Service
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Service
End Code

<h2>@Resource.Details_Service</h2>

<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SousSecteurActivite.Libelle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Titre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatePostulation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatePostulation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DureeRealisation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DureeRealisation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MontantMinimal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MontantMinimal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MontantMaximal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MontantMaximal)
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
    @Html.ActionLink(Resource.Edit_Service, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
