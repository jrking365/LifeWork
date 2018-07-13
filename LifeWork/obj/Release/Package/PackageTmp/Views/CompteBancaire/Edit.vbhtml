@ModelType CompteBancaireViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_CompteBancaire
End Code

<h2>@Resource.Edit_CompteBancaire</h2>
<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)
    @Html.HiddenFor(Function(model) model.UserId)

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.UserId, "UserId", New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("UserId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserId)
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Code, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Code)
            @Html.ValidationMessageFor(Function(model) model.Code)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DatePeremption, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DatePeremption)
            @Html.ValidationMessageFor(Function(model) model.DatePeremption)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Solde, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Solde)
            @Html.ValidationMessageFor(Function(model) model.Solde)
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
