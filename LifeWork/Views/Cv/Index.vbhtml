@ModelType IEnumerable(Of Cv)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Cv
End Code

<h2>@Resource.Index_Cv</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </th>
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
            @Html.DisplayFor(Function(modelItem) item.User.UserName)
        </td>
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
             @Html.ActionLink(Resource.Edit_Cv, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Cv, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Cv, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
