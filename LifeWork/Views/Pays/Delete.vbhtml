@ModelType Pays
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_Pays
End Code

<h2>@Resource.Delete_Pays</h2>

<h3>@Resource.ConfirmDelete</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
