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
<div class="wrapper wrapper-content animated fadeInRight">
    <div class="row">
        @For Each item In Model
            @<div Class="col-lg-4">
                <div Class="contact-box">
                    
                        <div class="col-sm-4">
                            <div class="text-center">
                                <img alt="image" class="img-circle m-t-xs img-responsive" src="~/Content/img/default_profile.png">
                                <div class="m-t-xs font-bold">@Html.DisplayFor(Function(modelItem) item.UserPublier.UserName)</div>
                            </div>
                        </div>
                        <div Class="col-sm-8">
                            <h3> <strong>@Html.DisplayFor(Function(modelItem) item.TypeJob.Libelle)</strong></h3>
                            <p> <i Class="fa fa-map-marker"></i> @Html.DisplayFor(Function(modelItem) item.LieuExecution)</p>
                            <address>
                                <label class="alert-danger"><strong> @Html.DisplayFor(Function(modelItem) item.DatePrevueLivraison)</strong></label><br>
                                @Html.DisplayFor(Function(modelItem) item.BudgetAttribution)<br>
                                @*@Html.ActionLink(Resource.Mark_exec, "MarquerExecute", New With {.id = item.Id})*@
                                @*<input type="button" value=@Resource.Mark_exec onclick="location.href='@Url.Action("MarquerExecute", "Jobs", New With {.id = item.Id})'" />*@
                                <a class="btn btn-danger btn-xs" data-toggle="tooltip" data-placement="left" title="@Resource.Mark_exec" href="@Url.Action("MarquerExecute", "Jobs", New With {.idJob = item.Id})">
                                    <i class="fa fa-remove"></i>
                                    <span class="sr-only">@Resource.Mark_exec</span>
                                </a>
                                
</address>
                        </div>
                        <div Class="clearfix"></div>
                   
                </div>
            </div>
        Next
    </div>
</div>

