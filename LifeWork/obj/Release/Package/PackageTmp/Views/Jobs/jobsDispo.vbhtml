@ModelType IEnumerable(Of Jobs)
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Index_Jobs
End Code



<p>
    <strong>
        @Html.ActionLink(Resource.Create_Jobs, "Create", "Jobs", New With {.class = "btn btn-primary btn-rounded btn-block bold"})
    </strong>
</p>

<div class="wrapper wrapper-content animated fadeInRight">
    <div class="row">
        @For Each item In Model
            @<div class="col-md-3">
                <div class="ibox">
                    <div class="ibox-content product-box">

                        <div class="product-imitation">
                            @*@if(IsNothing(item.UserPublier.Photo)) Then*@
                            <img src="~/Content/img/default_profile.png" class="img-circle m-t-xs img-responsive" />
                            @*Else
                                    @Html.DisplayFor(Function(modelItem) item.UserPublier.Photo)
                                End If*@
                            @code
                                                        if item.UserPublier.Photo IsNot Nothing Then
                                    @<img  class="img-circle m-t-xs img-responsive" width="90" height="50" src='@Url.Action("ShowImage", "Jobs", New With {.id = item.UserPublierId)' />
                                End If
                            End Code
                            <label class="label-info">@Html.DisplayFor(Function(modelItem) item.UserPublier.Nom)</label>
                        </div>
                        <div class="product-desc">
                            <div>
                                <span class="product-price">
                                    @Html.DisplayFor(Function(modelItem) item.BudgetMinimal) FCFA
                                </span>
                            </div>
                            <div>
                                <span class="product-price">
                                    @Html.DisplayFor(Function(modelItem) item.BudgetMaximal) FCFA
                                </span>
                            </div>
                            <small class="text-muted">@Html.DisplayFor(Function(modelItem) item.SousSecteurActivite.Libelle)</small>
                            @Html.DisplayFor(Function(modelItem) item.Titre, New With {.class = "product-name "})
                            <div class="small m-t-xs">
                                @Html.DisplayFor(Function(modelItem) item.Description)
                            </div>
                            <div class="m-t text-righ">

                                @Html.ActionLink(Resource.Details_Jobs, "Details", New With {.id = item.Id}, New With {.class = "btn btn-xs btn-outline btn-primary"}) <i class="fa fa-long-arrow-right"></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        Next
    </div>
</div>

