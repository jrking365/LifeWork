@ModelType RegisterViewModel
@Imports LifeWork.My.Resources
@Code
    ViewBag.Title = "S’inscrire"
End Code

<h2>@ViewBag.Title.</h2>

@Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

    @Html.AntiForgeryToken()

    @<text>
    <h4>Créer un nouveau compte sur LifeWork.</h4>
    <hr />
    @Html.ValidationSummary()

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Nom, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            <div class="row">
                @Html.TextBoxFor(Function(model) model.Nom, New With {.class = "form-control"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.Nom)
            </div>
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Prenom, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            <div class="row">
                @Html.TextBoxFor(Function(model) model.Prenom, New With {.class = "form-control"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.Prenom)
            </div>
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Email, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            <div class="row">
                @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.Email)
            </div>
        </div>
    </div>
    
    <div class="form-group">
        @Html.LabelFor(Function(m) m.UserName, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
        </div>
    </div>

    <div class="form-group required-field">
        @Html.LabelFor(Function(model) model.PaysId, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            <div class="row">
                @Html.DropDownListFor(Function(model) model.PaysId, New SelectList(Model.LesPays, "Id", "Nom"), Resource.Liste_Pays, New With {.class = "form-control"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.PaysId)
            </div>
        </div>
    </div>

    <div class="form-group required-field">
        @Html.LabelFor(Function(model) model.TypeCompteId, New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            <div class="row">
                @Html.DropDownListFor(Function(model) model.TypeCompteId, New SelectList(Model.LesTypeCompte, "Id", "Libelle"), Resource.Liste_TypeCompte, New With {.class = "form-control"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.TypeCompteId)
            </div>
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Sexe, New With {.class = "col-md-2 control-label"})
        <div class="col-md-10">
            <div class="row">
                @Html.DropDownListFor(Function(model) model.Sexe, New SelectList({"Masculin", "Féminin"}), Resource.Liste_Sexe, New With {.class = "form-control input-sm"})
            </div>
            <div class="row">
                @Html.ValidationMessageFor(Function(model) model.Sexe)
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" class="btn btn-primary" value="@Resource.Btn_Enregistrer" /> 
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-primary"})
        </div>
    </div>
    </text>
End Using

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
