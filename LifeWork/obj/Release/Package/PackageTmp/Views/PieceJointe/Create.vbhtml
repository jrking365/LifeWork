@ModelType PieceJointeViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_PieceJointe
End Code

<h2>@Resource.Create_PieceJointe</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    @Html.ValidationSummary(True)
    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.MessagerieId, "MessagerieId", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("MessagerieId", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.MessagerieId)
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Piece, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Piece)
            @Html.ValidationMessageFor(Function(model) model.Piece)
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
