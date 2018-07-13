@ModelType IEnumerable(Of Commentaire)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Commentaire
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.UserEmployeur.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserPrestataire.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contenu)
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
            @Html.DisplayFor(Function(modelItem) item.Jobs.UserPublierId)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserEmployeur.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserPrestataire.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contenu)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Commentaire, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Commentaire, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Commentaire, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
