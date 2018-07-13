@ModelType PersonneDeReference
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_PersonneDeReference
End Code

<h2>@Resource.Details_PersonneDeReference</h2>

<h3>@Resource.ConfirmDelete</h3>
<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cv.UserId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nom)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Prenom)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Prenom)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sexe)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sexe)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telephone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telephone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Profession)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Profession)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
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
