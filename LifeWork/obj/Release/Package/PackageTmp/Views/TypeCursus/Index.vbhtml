@ModelType IEnumerable(Of TypeCursus)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_TypeCursus
End Code

<h2>@Resource.Index_TypeCursus</h2>

<p>
    @Html.ActionLink(Resource.Create_TypeCursus, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Type)
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
            @Html.DisplayFor(Function(modelItem) item.Type)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_TypeCursus, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_TypeCursus, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_TypeCursus, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
