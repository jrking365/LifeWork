@ModelType IEnumerable(Of PostulerJob)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_PostulerJob
End Code



@*<p>
    @Html.ActionLink(Resource.Create_PostulerJob, "Create")
</p>*@
<table class="table">
    <tr>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.Job.UserPublierId)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DureeExecution)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BudgetExige)
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
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.Job.UserPublierId)
        </td>*@
        <td>
            @Html.DisplayFor(Function(modelItem) item.User.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DureeExecution)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BudgetExige)
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
         @*<td>
             @Html.ActionLink(Resource.Edit_PostulerJob, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_PostulerJob, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_PostulerJob, "Delete", New With {.id = item.Id})
         </td>*@
    </tr>
Next

</table>
