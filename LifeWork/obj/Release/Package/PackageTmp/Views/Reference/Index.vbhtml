@ModelType IEnumerable(Of Reference)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Reference
End Code

<h2>@Resource.Index_Reference</h2>

<p>
    @Html.ActionLink(Resource.Create_Reference, "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Adresse)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Annee)
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
            @Html.DisplayFor(Function(modelItem) item.Cv.UserId)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Adresse)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Annee)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
        <td>
            @Html.ActionLink(Resource.Edit_Reference, "Edit", New With {.id = item.Id}) |
            @Html.ActionLink(Resource.Details_Reference, "Details", New With {.id = item.Id}) |
            @Html.ActionLink(Resource.Delete_Reference, "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
