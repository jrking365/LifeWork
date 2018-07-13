@ModelType IEnumerable(Of PieceJointe)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_PieceJointe
End Code

<h2>@Resource.Index_PieceJointe</h2>

<p>
    @Html.ActionLink(Resource.Create_PieceJointe, "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Messagerie.UserExpediteurId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Piece)
        </th>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.StatutExistant)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateCreation)
        </th>*@
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.Messagerie.UserExpediteurId)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.Piece)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_PieceJointe, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_PieceJointe, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_PieceJointe, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
