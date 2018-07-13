@ModelType IEnumerable(Of Notification)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Notification
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink(Resource.Create_Notification, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Contenu)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DateEnvoi)
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
            @Html.DisplayFor(Function(modelItem) item.Titre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Contenu)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateEnvoi)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Notification, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Notification, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Notification, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
