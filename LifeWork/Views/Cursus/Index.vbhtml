@ModelType IEnumerable(Of Cursus)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Cursus
End Code

<h2>@Resource.Index_Cursus</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Cv.UserId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.TypeCursus.Type)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Poste)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Structures)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Diplome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Periode)
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
            @Html.DisplayFor(Function(modelItem) item.Cv.UserId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TypeCursus.Type)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Poste)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Structures)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Diplome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Periode)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>
         <td>
             @Html.ActionLink(Resource.Edit_Cursus, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Cursus, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Cursus, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
