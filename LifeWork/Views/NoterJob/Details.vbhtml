@ModelType NoterJob
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_NoterJob
End Code

<h2>@Resource.Details_NoterJob</h2>
<hr />

<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Jobs.UserPublierId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserEmployeur.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserEmployeur.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserPrestataire.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserPrestataire.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NoteEmployeur)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NoteEmployeur)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NotePrestataire)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NotePrestataire)
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
    @Html.ActionLink(Resource.Edit_NoterJob, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>

