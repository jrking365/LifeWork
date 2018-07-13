@ModelType IEnumerable(Of Jobs)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Jobs_Encours
End Code

<p>
    <strong>
        @Html.ActionLink(Resource.Create_Jobs, "Create", "Jobs", New With {.class = "btn btn-primary btn-rounded btn-block bold"})
    </strong>
</p>

@*<table class="table">
    <tr>
        <th>
                @Html.DisplayNameFor(Function(model) model.SousSecteurActivite.Libelle)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.statut.Libelle)
            </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TypeJob.Libelle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserAttribuer.UserName)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.UserPublier.UserName)
            </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Titre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Duree)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.Code)
            </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.LieuExecution)
            </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DatePrevueLivraison)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.DatePublication)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.DateAttribution)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.DateCloture)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.BudgetMinimal)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.BudgetMaximal)
            </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BudgetAttribution)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.CahierDeCharge)
            </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.StatutExistant)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DateCreation)
            </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.SousSecteurActivite.Libelle)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.statut.Libelle)
                </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TypeJob.Libelle)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.UserAttribuer.UserName)
            </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.UserPublier.UserName)
                </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Titre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Duree)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Code)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Description)
            </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.LieuExecution)
                </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatePrevueLivraison)
            </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.DatePublication)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.DateAttribution)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.DateCloture)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.BudgetMinimal)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.BudgetMaximal)
                </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BudgetAttribution)
            </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.CahierDeCharge)
                </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.StatutExistant)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DateCreation)
                </td>
            <td>
                @Html.ActionLink(Resource.Edit_Jobs, "Edit", New With {.id = item.Id}) |
                @Html.ActionLink(Resource.Details_Jobs, "Details", New With {.id = item.Id}) |
                @Html.ActionLink(Resource.Delete_Jobs, "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>*@
<div class="wrapper wrapper-content animated fadeInRight">
    <div class="row">
        @For Each item In Model
        @<div Class="col-lg-4">
            <div Class="contact-box">
                
                    <div class="col-sm-4">
                        <div class="text-center">
                            <img alt="image" class="img-circle m-t-xs img-responsive" src="~/Content/img/default_profile.png">
                                <div class="m-t-xs font-bold">@Html.DisplayFor(Function(modelItem) item.UserAttribuer.UserName)</div>
                        </div>
                    </div>
                <div Class="col-sm-8">
                        <h3> <strong>@Html.DisplayFor(Function(modelItem) item.TypeJob.Libelle)</strong></h3>
                        <p> <i Class="fa fa-map-marker"></i> @Html.DisplayFor(Function(modelItem) item.LieuExecution)</p>
                        <address>
                        <strong> @Html.DisplayFor(Function(modelItem) item.DatePrevueLivraison)</strong><br>
                            @Html.DisplayFor(Function(modelItem) item.BudgetAttribution)<br>
                            @Html.ActionLink(Resource.Details_Jobs, "Details", New With {.id = item.Id})
                            @code
                                    If item.StatutId = 4 Then
                                    @<a Class="btn btn-danger btn-xs" data-toggle="tooltip" data-placement="left" title="@Resource.Mark_exec" href="@Url.Action("MarquerExecuteEmployeur", "Jobs", New With {.idJob = item.Id})">
                                <i Class="fa fa-save"></i>
                                <span Class="sr-only">@Resource.Mark_exec</span>
                            </a>

                                End If
                            End Code                  
                        </address>
                    </div>
                    <div Class="clearfix"></div>
                
            </div>
        </div>
                                            Next
    </div>
</div>
