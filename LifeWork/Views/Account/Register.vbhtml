@ModelType RegisterViewModel
@Imports LifeWork.My.Resources
@Code
    ViewBag.Title = Resource.User_Inscrire
End Code

<div class="loginColumns text-center animated fadeInDown">
    <div class="row">
        <div>
            <h1 class="logo-name">L W</h1>
        </div>
        <h3>Bienvenue sur LifeWork</h3>
        <p>
            Nouveau look avec CIS
        </p>
        <p>Inscrivez vous pour le voir en action.</p>

        @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "m-t", .role = "form"})

            @Html.AntiForgeryToken()

            @<text>
                @Html.ValidationSummary()

                <div class="col-md-6">
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.UserName, New With {.class = "control-label"})
                        <div>
                            @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.Email, New With {.class = "control-label"})
                        <div>
                            <div class="row">
                                @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control"})
                            </div>
                            <div class="row">
                                @Html.ValidationMessageFor(Function(model) model.Email)
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Password, New With {.class = "control-label"})
                        <div>
                            @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "control-label"})
                        <div>
                            @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                        </div>
                    </div>

                    <div class="form-group required-field">
                        @Html.LabelFor(Function(model) model.TypeCompteId, New With {.class = "control-label"})
                        <div>
                            <div class="row">
                                @Html.DropDownListFor(Function(model) model.TypeCompteId, New SelectList(Model.LesTypeCompte, "Id", "Libelle"), Resource.Liste_TypeCompte, New With {.class = "form-control"})
                            </div>
                            <div class="row">
                                @Html.ValidationMessageFor(Function(model) model.TypeCompteId)
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div>
                        <input type="submit" class="btn btn-info btn-sm" value="@Resource.Btn_Enregistrer" />
                        @Html.ActionLink(Resource.Btn_Retour, "Index", Nothing, New With {.class = "btn btn-danger btn-sm"})
                    </div>
                </div>
            </text>

        End Using

    </div>
</div>

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
