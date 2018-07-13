@ModelType ConsulterCvViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_ConsulterCv
End Code

<h2>@Resource.Edit_ConsulterCv</h2>
<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.CvId)

    @Html.HiddenFor(Function(model) model.UserId)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateConsulter, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateConsulter)
            @Html.ValidationMessageFor(Function(model) model.DateConsulter)
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="@Resource.Btn_Enregistrer" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
    @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
