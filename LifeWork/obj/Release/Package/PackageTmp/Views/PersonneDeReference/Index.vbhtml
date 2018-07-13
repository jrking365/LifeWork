@ModelType IEnumerable(Of PersonneDeReference)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_PersonneDeReference
End Code

<h2>@Resource.Index_PersonneDeReference</h2>

<p>
    @Html.ActionLink(Resource.Create_PersonneDeReference, "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Prenom)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sexe)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telephone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Profession)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
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
            @Html.DisplayFor(Function(modelItem) item.Nom)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Prenom)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sexe)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Telephone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Profession)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_PersonneDeReference, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_PersonneDeReference, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_PersonneDeReference, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
