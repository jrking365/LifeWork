@ModelType ConsulterCvViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_ConsulterCv
End Code

<h2>@Resource.Create_ConsulterCv</h2>
<hr />

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    <div class="form-group">
        @Html.LabelFor(Function(model) model.CvId, "CvId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("CvId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.CvId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.UserId, "UserId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("UserId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.UserId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateConsulter, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateConsulter)
            @Html.ValidationMessageFor(Function(model) model.DateConsulter)
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="@Resource.Btn_Ajouter" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
    @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
</div>
