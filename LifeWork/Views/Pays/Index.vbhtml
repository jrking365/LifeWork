@ModelType IEnumerable(Of Pays)
@Imports LifeWork.My.Resources
@Code
ViewData("Title") = Resource.Index_Pays
End Code

<h2>@Resource.Index_Pays</h2>

<p>
    @Html.ActionLink(Resource.Create_Pays, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Abreviation)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IdentifiantTelephonique)
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
            @Html.DisplayFor(Function(modelItem) item.Nom)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Abreviation)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.IdentifiantTelephonique)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.StatutExistant)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DateCreation)
        </td>*@
         <td>
             @Html.ActionLink(Resource.Edit_Pays, "Edit", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Details_Pays, "Details", New With {.id = item.Id}) |
             @Html.ActionLink(Resource.Delete_Pays, "Delete", New With {.id = item.Id})
         </td>
    </tr>
Next

</table>
