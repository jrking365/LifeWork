@ModelType IEnumerable(Of TypeJob)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_TypeJob
End Code

<h2>@Resource.Index_TypeJob</h2>

<p>
    @Html.ActionLink(Resource.Create_TypeJob, "Create")
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
             @Html.ActionLink(Resource.Edit_TypeJob, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_TypeJob, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_TypeJob, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
