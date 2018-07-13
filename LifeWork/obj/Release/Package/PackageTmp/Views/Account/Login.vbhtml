@ModelType LoginViewModel

@Code
    ViewBag.Title = "Se connecter"
End Code

<div class="middle-box text-center loginscreen animated fadeInDown">
    <div>
        <div>
            <h1 class="logo-name">LW</h1>
        </div>
        <h3>Bienvenue sur LifeWork</h3>
        <p>
            Nouveau look avec CIS
        </p>
        <p>Connectez vous pour le voir en action.</p>

        @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "m-t", .role = "form"})
            @Html.AntiForgeryToken()
            @<text>
                @Html.ValidationSummary(True)
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.UserName, New With {.class = "control-label"})
                    <div>
                        @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.UserName)
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "control-label"})
                    <div>
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password)
                    </div>
                </div>
                <div class="form-group">
                    <div>
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div>
                        <input type="submit" value="Connexion" class="btn btn-primary block full-width m-b" />
                    </div>
                </div>
                <p>
                    @Html.ActionLink("Enregistrez-vous", "Register", New With {.class = "btn btn-sm btn-white btn-block"}) si vous n'avez pas de compte.
                </p>

            </text>
        End Using
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section