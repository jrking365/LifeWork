@ModelType IEnumerable(Of Jobs)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Job_Cloture
End Code

<p>
    <strong>
        @Html.ActionLink(Resource.job_Dispo, "jobsDispo", "Jobs", New With {.class = "btn btn-primary btn-rounded btn-block bold"})
    </strong>
</p>
<div class="wrapper wrapper-content animated fadeInRight ecommerce">
    <div class="row">
        <div class="col-lg-12">
            <div class="ibox">
                <div class="ibox-content">
                    <table class="footable table table-stripped toggle-arrow-tiny" data-page-size="15">
                        <thead>
                            <tr>
                                <th data-toggle="true">
                                    @Html.DisplayNameFor(Function(model) model.Titre)
                                </th>
                                <th data-hide="all">@Resource.Description_Jobs</th>
                                <th>
                                    @*@Html.DisplayNameFor(Function(model) model.LieuExecution)*@
                                    Lieu
                                </th>
                                <th>
                                    @*@Html.DisplayNameFor(Function(model) model.DatePublication)*@
                                    publié le
                                </th>
                                <th>
                                    @*@Html.DisplayNameFor(Function(model) model.BudgetMinimal)*@
                                    budget attribution
                                </th>

                                <th>Postulation</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            @For Each item In Model
                                @<tr>
                                    <td>@Html.DisplayFor(Function(modelItem) item.Titre)</td>
                                    <td>@Html.DisplayFor(Function(modelItem) item.Description)</td>
                                    <td>@Html.DisplayFor(Function(modelItem) item.LieuExecution)</td>
                                    <td>@Html.DisplayFor(Function(modelItem) item.DatePublication)</td>
                                     <td>@Html.DisplayFor(Function(modelItem) item.BudgetAttribution)</td>
                                     @*<td>@Html.DisplayFor(Function(modelItem) item.BudgetMaximal)</td>*@
                                    <td></td>
                                     <td>

                                         @Html.ActionLink(Resource.NoteEmployeur_NoterJob, "NoterEmployeur", "NoterJob", New With {.id = item.Id}, New With {.class = "modal-link btn-warning btn btn-xs"})
                                         @Html.ActionLink(Resource.Details_Jobs, "Details", New With {.id = item.Id}, New With {.class = "btn-info btn btn-xs"})

                                     </td>
                                </tr>
                            Next
                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan="6">
                                    <ul class="pagination pull-right"></ul>
                                </td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<script src="~/Content/js/plugins/footable/footable.all.min.js"></script>
<script>
    $(document).ready(function () {

        $('.footable').footable();

    });

</script>
