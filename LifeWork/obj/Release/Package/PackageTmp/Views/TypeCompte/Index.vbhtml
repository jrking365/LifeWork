@ModelType IEnumerable(Of TypeCompte)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_TypeCompte
End Code

<h2>@Resource.Index_TypeCompte</h2>

<p>
    @Html.ActionLink(Resource.Create_TypeCompte, "Create")
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
             @Html.ActionLink(Resource.Edit_TypeCompte, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_TypeCompte, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_TypeCompte, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
