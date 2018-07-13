@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Dashboard
End Code
@Styles.Render("~/Content/css")

<div class="wrapper wrapper-content">
    <div class="row">
        <div class="col-lg-3">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <span class="label label-success pull-right">Exécuté</span>
                    <h5>Job déja exécuté</h5>
                </div>
                <div class="ibox-content">
                    <h1 class="no-margins">@ViewBag.exec</h1>
                    <div class="stat-percent font-bold text-success">10% <i class="fa fa-bolt"></i></div>
                    <small>Total </small>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <span class="label label-info pull-right">En cours</span>
                    <h5>Job en cours d'exécution</h5>
                </div>
                <div class="ibox-content">
                    <h1 class="no-margins">@ViewBag.JobCours</h1>
                    <div class="stat-percent font-bold text-info">20% <i class="fa fa-level-up"></i></div>
                    <small>Total</small>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <span class="label label-primary pull-right">Postuler</span>
                    <h5>Job auxquels j'ai postulé</h5>
                </div>
                <div class="ibox-content">
                    <h1 class="no-margins"> @ViewBag.Postul</h1>
                    <div class="stat-percent font-bold text-navy">40% <i class="fa fa-level-up"></i></div>
                    <small>Total</small>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <span class="label label-danger pull-right">Publier</span>
                    <h5>Job publié</h5>
                </div>
                <div class="ibox-content">
                    <h1 class="no-margins">@ViewBag.Publie</h1>
                    <div class="stat-percent font-bold text-danger">30% <i class="fa fa-level-down"></i></div>
                    <small>Total</small>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <h5>Orders</h5>
                    <div class="pull-right">
                        <div class="btn-group">
                            <button type="button" class="btn btn-xs btn-white active">Today</button>
                            <button type="button" class="btn btn-xs btn-white">Monthly</button>
                            <button type="button" class="btn btn-xs btn-white">Annual</button>
                        </div>
                    </div>
                </div>
                <div class="ibox-content">
                    <div class="row">
                        <div class="col-lg-9">
                            <div class="flot-chart">
                                <div class="flot-chart-content" id="flot-dashboard-chart"></div>
                            </div>
                        </div>
                        <div class="col-lg-3">
                            <ul class="stat-list">
                                <li>
                                    <h2 class="no-margins">@ViewBag.exec</h2>
                                    <small>JOB éxécuté en tant que employeur</small>
                                    <div class="stat-percent">@ViewBag.PexecE%<i class="fa fa-level-up text-navy"></i></div>
                                    <div Class="progress progress-mini">
                                        <div style="width: @ViewBag.PexecE%;" Class="progress-bar"></div>
                                    </div>
                                </li>

                                @code
                                    @If User.IsInRole("SA") Or User.IsInRole("PRESTATAIRE") Then
                                        @<li>
                                            <h2 Class="no-margins">@ViewBag.exec</h2>
                                            <small> JOB éxécuté en tant que  Prestataire</small>
                                            <div Class="stat-percent">@ViewBag.Pexec%<i class="fa fa-level-up text-navy"></i></div>
                                            <div Class="progress progress-mini">
                                                <div style="width: @ViewBag.Pexec%;" Class="progress-bar"></div>
                                            </div>
                                        </li>
                                    End If
                                End Code

                                <li>
                                    <h2 Class="no-margins ">@ViewBag.JobValid</h2>
                                    <small> en attente de validation pour mes jobs</small>
                                    <div Class="stat-percent">@ViewBag.PvalidE% <i class="fa fa-level-down text-navy"></i></div>
                                    <div Class="progress progress-mini">
                                        <div style="width: @ViewBag.PvalidE%;" Class="progress-bar"></div>
                                    </div>
                                </li>

                                @code
                                    @If User.IsInRole("SA") Or User.IsInRole("PRESTATAIRE") Then
                                        @<li>
                                            <h2 Class="no-margins">@ViewBag.JobValid</h2>
                                            <small> en attente de validation pour mes prestations</small>
                                            <div Class="stat-percent">@ViewBag.Pvalid%<i class="fa fa-level-up text-navy"></i></div>
                                            <div Class="progress progress-mini">
                                                <div style="width: @ViewBag.Pvalid%;" Class="progress-bar"></div>
                                            </div>
                                        </li>
                                    End If
                                End Code
                                <li>
                                    <h2 Class="no-margins ">@ViewBag.JobCours</h2>
                                    <small> Job en cours</small>
                                    <div Class="stat-percent">@ViewBag.PCours% <i class="fa fa-bolt text-navy"></i></div>
                                    <div Class="progress progress-mini">
                                        <div style="width: @ViewBag.PCours%;" Class="progress-bar"></div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>




@*ce que je dois modifier*@


<Script src="~/Content/js/plugins/chartJs/Chart.min.js"></Script>
<Script src="~/Content/js/plugins/flot/jquery.flot.js"></Script>
<Script src="~/Content/js/plugins/flot/jquery.flot.tooltip.min.js"></Script>
<Script src="~/Content/js/plugins/flot/jquery.flot.resize.js"></Script>
<Script src="~/Content/js/plugins/flot/jquery.flot.pie.js"></Script>
<Script src="~/Content/js/plugins/flot/jquery.flot.time.js"></Script>
<Script src="~/Content/js/demo/flot-demo.js"></Script>
