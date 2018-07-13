@ModelType IEnumerable(Of NoterJob)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_NoterJob
End Code

<h2>@Resource.Index_NoterJob</h2>

<p>
    @Html.ActionLink(Resource.Create_NoterJob, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </th>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.UserEmployeur.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserPrestataire.UserName)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.NoteEmployeur)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NotePrestataire)
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
            @Html.DisplayFor(Function(modelItem) item.Jobs.UserPublierId)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.UserEmployeur.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserPrestataire.UserName)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.NoteEmployeur)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NotePrestataire)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_NoterJob, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_NoterJob, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_NoterJob, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
