@ModelType IEnumerable(Of Competence)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Competence
End Code

<h2>@Resource.Index_Competence</h2>
<hr/>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.cv.UserId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Libelle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
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
            @Html.DisplayFor(Function(modelItem) item.cv.UserId)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.Libelle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Competence, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Competence, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Competence, "Delete", New With {.id = item.Id})
         </td>

    </tr>
Next

</table>
