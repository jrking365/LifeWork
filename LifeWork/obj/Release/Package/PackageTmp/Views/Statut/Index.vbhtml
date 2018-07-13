@ModelType IEnumerable(Of Statut)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Statut
End Code

<h2>@Resource.Index_Statut</h2>

<p>
    @Html.ActionLink(Resource.Create_Statut, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Libelle)
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
        <td>
            @Html.DisplayFor(Function(modelItem) item.Libelle)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Statut, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Statut, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Statut, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
