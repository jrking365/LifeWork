@ModelType IEnumerable(Of Service)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Service
End Code

<h2>@Resource.Index_Service</h2>

<p>
    @Html.ActionLink(Resource.Create_Service, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DatePostulation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DureeRealisation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MontantMinimal)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.MontantMaximal)
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
        <td>
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DatePostulation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DureeRealisation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MontantMinimal)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MontantMaximal)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Service, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Service, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Service, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
