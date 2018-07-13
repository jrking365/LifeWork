@ModelType IEnumerable(Of JobsNotification)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_JobsNotification
End Code

<h2>@Resource.Index_JobsNotification</h2>
<hr />

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.Notification.Titre)
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
            @Html.DisplayFor(Function(modelItem) item.Notification.Titre)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
