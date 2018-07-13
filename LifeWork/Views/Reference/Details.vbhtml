@ModelType Reference
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Reference
End Code

<h2>@Resource.Details_Reference</h2>

<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cv.UserId)
        </dd>*@

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
            @Html.DisplayNameFor(Function(model) model.Adresse)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Adresse)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Annee)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Annee)
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
    @Html.ActionLink(Resource.Edit_Reference, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
