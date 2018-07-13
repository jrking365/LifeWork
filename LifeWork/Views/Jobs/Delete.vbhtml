@ModelType Jobs
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Jobs
End Code

<h2>@Resource.Details_Jobs</h2>
<hr />

<h3>@Resource.ConfirmDelete</h3>
<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SousSecteurActivite.Libelle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.statut.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.statut.Libelle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TypeJob.Libelle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TypeJob.Libelle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserAttribuer.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserAttribuer.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserPublier.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserPublier.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Titre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Duree)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Duree)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Code)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LieuExecution)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LieuExecution)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatePrevueLivraison)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatePrevueLivraison)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatePublication)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatePublication)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateAttribution)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateAttribution)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateCloture)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateCloture)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BudgetMinimal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BudgetMinimal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BudgetMaximal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BudgetMaximal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BudgetAttribution)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BudgetAttribution)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CahierDeCharge)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CahierDeCharge)
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

         @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
