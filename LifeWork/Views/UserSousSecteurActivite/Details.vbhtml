@ModelType UserSousSecteurActivite
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_UserSousSecteurActivite
End Code

<h2>@Resource.Details_UserSousSecteurActivite</h2>

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
   @*@Html.ActionLink(Resource.Edit_UserSousSecteurActivite, "Edit", New With {.id = Model.Id}) |*@
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
