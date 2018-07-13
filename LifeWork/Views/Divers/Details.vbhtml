@ModelType Divers
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Divers
End Code

<h2>@Resource.Details_Divers</h2>
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
            @Html.DisplayNameFor(Function(model) model.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Titre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Commentaire)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Commentaire)
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
    @Html.ActionLink(Resource.Edit_Divers, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
