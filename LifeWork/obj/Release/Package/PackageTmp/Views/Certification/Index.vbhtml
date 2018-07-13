@ModelType IEnumerable(Of Certification)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Certification
End Code

<h2>@Resource.Index_Certification</h2>

<p>
    @Html.ActionLink(Resource.Create_Certification, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Libelle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateObtention)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.cv.Id)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.Libelle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateObtention)
        </td>
        <td>
            @Html.ActionLink(Resource.Edit_Certification, "Edit", New With {.id = item.Id}) |
            @Html.ActionLink(Resource.Details_Certification, "Details", New With {.id = item.Id}) |
            @Html.ActionLink(Resource.Delete_Certification, "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
