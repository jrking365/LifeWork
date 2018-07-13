@ModelType PieceJointe
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_PieceJointe
End Code

<h2>@Resource.Details_PieceJointe</h2>

<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Messagerie.UserExpediteurId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Messagerie.UserExpediteurId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.Piece)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Piece)
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
    @Html.ActionLink(Resource.Edit_PieceJointe, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
