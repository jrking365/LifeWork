@ModelType NotificationViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_Notification
End Code

<h2>@Resource.Create_Notification</h2>
<hr />

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    <div class="form-group">
        @Html.LabelFor(Function(model) model.Titre, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Titre)
            @Html.ValidationMessageFor(Function(model) model.Titre)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Contenu, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Contenu)
            @Html.ValidationMessageFor(Function(model) model.Contenu)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateEnvoi, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateEnvoi)
            @Html.ValidationMessageFor(Function(model) model.DateEnvoi)
        </div>
    </div>

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.StatutExistant, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.StatutExistant)
                @Html.ValidationMessageFor(Function(model) model.StatutExistant)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DateCreation, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.DateCreation)
                @Html.ValidationMessageFor(Function(model) model.DateCreation)
            </div>
        </div>*@

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

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
