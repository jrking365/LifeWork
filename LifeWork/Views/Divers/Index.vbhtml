@ModelType IEnumerable(Of Divers)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Divers
End Code

<h2>@Resource.Index_Divers</h2>
<hr />

<p>
    @Html.ActionLink(Resource.Create_Divers, "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.cv.UserId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Commentaire)
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
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Commentaire)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Divers, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Divers, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Divers, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
