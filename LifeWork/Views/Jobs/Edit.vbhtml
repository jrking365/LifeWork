@ModelType JobsViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Edit_Jobs
End Code

<h2>@Resource.Edit_Jobs</h2>
<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @Html.HiddenFor(Function(model) model.Id)

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.UserPublierId, "UserPublierId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("UserPublierId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserPublierId)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.UserAttribuerId, "UserAttribuerId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("UserAttribuerId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.UserAttribuerId)
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.TypeJobId, "TypeJobId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("TypeJobId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.TypeJobId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.SousSecteurActiviteId, "SousSecteurActiviteId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("SousSecteurActiviteId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.SousSecteurActiviteId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.StatutId, "StatutId", New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.DropDownList("StatutId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.StatutId)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Titre, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Titre)
            @Html.ValidationMessageFor(Function(model) model.Titre)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Duree, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Duree)
            @Html.ValidationMessageFor(Function(model) model.Duree)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Code, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Code)
            @Html.ValidationMessageFor(Function(model) model.Code)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Description)
            @Html.ValidationMessageFor(Function(model) model.Description)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.LieuExecution, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.LieuExecution)
            @Html.ValidationMessageFor(Function(model) model.LieuExecution)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DatePrevueLivraison, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DatePrevueLivraison)
            @Html.ValidationMessageFor(Function(model) model.DatePrevueLivraison)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DatePublication, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DatePublication)
            @Html.ValidationMessageFor(Function(model) model.DatePublication)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateAttribution, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateAttribution)
            @Html.ValidationMessageFor(Function(model) model.DateAttribution)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.DateCloture, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.DateCloture)
            @Html.ValidationMessageFor(Function(model) model.DateCloture)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.BudgetMinimal, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.BudgetMinimal)
            @Html.ValidationMessageFor(Function(model) model.BudgetMinimal)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.BudgetMaximal, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.BudgetMaximal)
            @Html.ValidationMessageFor(Function(model) model.BudgetMaximal)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.BudgetAttribution, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.BudgetAttribution)
            @Html.ValidationMessageFor(Function(model) model.BudgetAttribution)
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.CahierDeCharge, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.CahierDeCharge)
            @Html.ValidationMessageFor(Function(model) model.CahierDeCharge)
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