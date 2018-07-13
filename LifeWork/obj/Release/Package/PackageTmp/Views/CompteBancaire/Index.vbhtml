@ModelType IEnumerable(Of CompteBancaire)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_CompteBancaire
End Code

<h2>@Resource.Index_CompteBancaire</h2>
<hr />

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Code)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DatePeremption)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Solde)
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
            @Html.DisplayFor(Function(modelItem) item.Code)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DatePeremption)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Solde)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_CompteBancaire, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_CompteBancaire, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_CompteBancaire, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
