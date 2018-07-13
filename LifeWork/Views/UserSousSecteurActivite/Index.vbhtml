@ModelType IEnumerable(Of UserSousSecteurActivite)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_UserSousSecteurActivite
End Code

<h2>@Resource.Index_UserSousSecteurActivite</h2>

<p>
    @Html.ActionLink(Resource.Create_UserSousSecteurActivite, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
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
            @Html.DisplayFor(Function(modelItem) item.SousSecteurActivite.Libelle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.User.UserName)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         @*<td>
             @Html.ActionLink(Resource.Edit_UserSousSecteurActivite, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_UserSousSecteurActivite, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_UserSousSecteurActivite, "Delete", New With {.id = item.Id})
         </td>*@
    </tr>
Next

</table>
