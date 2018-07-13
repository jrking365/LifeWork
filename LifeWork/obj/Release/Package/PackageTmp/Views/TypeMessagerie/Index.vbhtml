@ModelType IEnumerable(Of TypeMessagerie)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_TypeMessagerie
End Code

<h2>@Resource.Index_TypeMessagerie</h2>

<p>
    @Html.ActionLink(Resource.Create_TypeMessagerie, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
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
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_TypeMessagerie, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_TypeMessagerie, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_TypeMessagerie, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
