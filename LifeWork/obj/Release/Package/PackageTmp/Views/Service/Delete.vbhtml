@ModelType Service
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_Service
End Code

<h2>@Resource.Delete_Service</h2>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
