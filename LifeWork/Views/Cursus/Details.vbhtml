@ModelType Cursus
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Cursus
End Code

<h2>@Resource.Details_Cursus</h2>
<hr />

<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cv.UserId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.TypeCursus.Type)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TypeCursus.Type)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Titre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Poste)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Poste)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Structures)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Structures)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Diplome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Diplome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Periode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Periode)
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
    @Html.ActionLink(Resource.Edit_Cursus, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
