@ModelType CompleterInfosViewModel
@Styles.Render("~/Content/css")

<link href="~/Content/css/plugins/steps/jquery.steps.css" rel="stylesheet" />

<div class="wrapper wrapper-content">
    <div class="row">
        <div class="col-lg-12">
            <div class="ibox">
                <div class="ibox-title">
                    <h5>Enregistrement des informations</h5>
                </div>
                <div class="ibox-content">
                    <h2>
                        Enregistrement des informations
                    </h2>
                    <p>
                        Completer vos informations
                    </p>

                    

                    <form id="form" method="post" action='@Url.Action("CompleterInfos", "Account")' enctype="multipart/form-data" Class="wizard-big">
                       @Html.AntiForgeryToken()
                         @Html.ValidationSummary(True)
                        @Html.HiddenFor(Function(model) model.id)
                        @Html.HiddenFor(Function(model) model.TypeCompteId)
                        @Html.HiddenFor(Function(model) model.StatutExistant)
                        @Html.HiddenFor(Function(model) model.DateCreation)
                        @*@Html.HiddenFor(Function(model) model.Password)
                        @Html.HiddenFor(Function(model) model.ConfirmPassword)*@

                        <h1>Compte</h1>
                        <fieldset>
                            <h2>Parametres de connexion</h2>
                            <div Class="row">
                                <div Class="col-lg-8">
                                    <div Class="col-lg-6">
                                        <div Class="form-group">
                                            <Label> Pseudo</Label>
                                            @Html.TextBoxFor(Function(model) model.UserName, New With {.class = "form-control"})
                                        </div>

                                        <div Class="form-group">
                                            <Label> Email</Label>

                                            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control"})
                                        </div>



                                        <div class="form-group">
                                            <label> Type de compte</label>
                                            <input id="typeCompte" name="typeCompte" type="text" class="form-control" value="Employeur" disabled />

                                        </div>

                                        </div>



                                    <div Class="col-lg-6">

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

                                        
                                    </div>
                                </div>

                                <div Class="col-lg-4">
                                    <div Class="text-center">
                                        <div style="margin-top: 20px">
                                            <i class="fa fa-sign-in" style="font-size: 180px;color: #e5e5e5 "></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </fieldset>

                        <h1> Profile</h1>
                        <fieldset>
                            
                            <div Class="row">
                                <div Class="col-lg-6">
                                    <div Class="form-group">
                                        <Label> Nom </Label>
                                        @Html.TextBoxFor(Function(model) model.Nom, New With {.class = "form-control", .required = "required"})
                                    </div>

                                    <div Class="form-group">
                                        <Label> Prénom</Label>
                                        @Html.TextBoxFor(Function(model) model.Prenom, New With {.class = "form-control", .required = "required"})
                                    </div>
                                </div>

                                <div Class="col-lg-6">
                                    <div Class="form-group">
                                        <Label> Civilité</Label>

                                        @Html.DropDownListFor(Function(model) model.Sexe, New SelectList({"Masculin", "Féminin"}), New With {.class = "form-control input-sm"})
                                    </div>

                                    <div Class="form-group" id="data_1">
                                        <Label>Date de naissance</Label>
                                        <div Class="input-group date">
                                            <i class="fa fa-calendar"></i>@Html.TextBoxFor(Function(model) model.DateNaissance, New With {.class = "datepicker form-control"})

                                        </div>
                                    </div>
                                </div>

                                <div Class="col-lg-6">
                                    <div Class="form-group">
                                        <Label> Téléphone</Label>
                                        @Html.TextBoxFor(Function(model) model.Telephone, New With {.class = "form-control", .required = "required"})
                                    </div>

                                    <div Class="form-group">
                                        <Label> Photo de profile</Label>
                                        <input id="photo" name="photo" type="file" class="form-control">
                                    </div>
                                </div>


                                <div Class="col-lg-6">
                                    <div Class="form-group">
                                        <Label> CNI</Label>
                                        @Html.TextBoxFor(Function(model) model.CNI, New With {.class = "form-control", .required = "required"})
                                    </div>
                                </div>

                                    @*<div class="form-group required-field">
                                                                                @Html.LabelFor(Function(model) model.CommuneId, Resource.Collectivite_Libelle, New With {.class = "control-label col-md-2"})
                                                                                <div class="col-md-10">
                                                                                    @Html.DropDownListFor(Function(model) model.CommuneId,
                                        New SelectList(Model.IDscomm, "Id", "Libelle"), Resource.Collectivite_Libelle, New With {.class = "select2_single form-control"})
                                                                                    @Html.ValidationMessageFor(Function(model) model.CommuneId)
                                                                                </div>
                                                                            </div>

                                                                            <div class="form-group required-field">
                                                                                @Html.LabelFor(Function(model) model.ProjetId, Resource.PjtPc_Projet, New With {.class = "control-label col-md-2"})
                                                                                <div class="col-md-10">
                                                                                    @Html.DropDownListFor(Function(model) model.ProjetId,
                                        New SelectList(Model.Projet, "Id", "Libelle"), Resource.PjtPc_Projet, New With {.class = "select2_single form-control"})
                                                                                    @Html.DropDownListFor(Function(model) model.DetailSessionId,
                                                                                        New SelectList(Model.DetailSessions, "Value", "Text"), Resource.dco_deta_select, New With {.class = "form-control"})

                                                                                    @Html.ValidationMessageFor(Function(model) model.ProjetId)
                                                                                </div>
                                                                            </div>*@



                               
                            </div>
                        </fieldset>

                        <h1>Domaines</h1>
                        <fieldset>
                            <div Class="form-group required">
                                <Label> Secteur d'activitie</Label>
                                <select name="secteuractivite" id="secteuractivite">
                                    <option value=""> --Selectionnez - -</option>
                                    <option value="Informatique"> TIC</option>
                                    <option value="Physique"> Mecanique</option>
                                </select>

                            </div>

                            <div Class="form-group">
                                <Label> Sous secteurs d'activite</Label>
                                <select name="secteuractivite" id="secteuractivite" data-placeholder="Choose a Country..." class="chosen-select" multiple style="width:350px;" tabindex="4">
                                    <option value=""> --Selectionnez - -</option>
                                    <option value="Informatique"> TIC</option>
                                    <option value="Physique"> Mecanique</option>
                                </select>
                            </div>

                        </fieldset>


                        <h1> Fin</h1>
                        <fieldset>
                            <h2> Terms And Conditions</h2>
                            <input id="acceptTerms" name="acceptTerms" type="checkbox" Class="required"> <label For="acceptTerms">I agree With the Terms And Conditions.</label>
                        </fieldset>
                        @*<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <input type="submit"id="add" value="ajouter" class="btn btn-default" />
                            </div>

                        </div>*@
                        
                    </form>


                </div>
            </div>
        </div>

    </div>
</div>

<Script src="~/Content/js/plugins/staps/jquery.steps.min.js"></Script>
<Script src="~/Content/js/plugins/validate/jquery.validate.min.js"></Script>
<script src="~/Content/js/plugins/datapicker/bootstrap-datepicker.js"></script>


<script>
  


    $(document).ready(function () {
        $("#wizard").steps();
        $("#form").steps({
            bodyTag: "fieldset",
            onStepChanging: function (event, currentIndex, newIndex) {
                // Always allow going backward even if the current step contains invalid fields!
                if (currentIndex > newIndex) {
                    return true;
                }

                // Forbid suppressing "Warning" step if the user is to young
                if (newIndex === 3 && Number($("#age").val()) < 18) {
                    return false;
                }

                var form = $(this);

                // Clean up if user went backward before
                if (currentIndex < newIndex) {
                    // To remove error styles
                    $(".body:eq(" + newIndex + ") label.error", form).remove();
                    $(".body:eq(" + newIndex + ") .error", form).removeClass("error");
                }

                // Disable validation on fields that are disabled or hidden.
                form.validate().settings.ignore = ":disabled,:hidden";

                // Start validation; Prevent going forward if false
                return form.valid();
            },
            onStepChanged: function (event, currentIndex, priorIndex) {
                // Suppress (skip) "Warning" step if the user is old enough.
                if (currentIndex === 2 && Number($("#age").val()) >= 18) {
                    $(this).steps("next");
                }

                // Suppress (skip) "Warning" step if the user is old enough and wants to the previous step.
                if (currentIndex === 2 && priorIndex === 3) {
                    $(this).steps("previous");
                }
            },
            onFinishing: function (event, currentIndex) {
                var form = $(this);

                // Disable validation on fields that are disabled.
                // At this point it's recommended to do an overall check (mean ignoring only disabled fields)
                form.validate().settings.ignore = ":disabled";

                // Start validation; Prevent form submission if false
                return form.valid();
            },
            onFinished: function (event, currentIndex) {
                var form = $(this);
               
                // Submit form input
                form.submit();
            }
        }).validate({
            errorPlacement: function (error, element) {
                element.before(error);
            },
            rules: {
                confirm: {
                    equalTo: "#password"
                }
            }
        });
    });

    $(document).ready(function () {
        var cboPereId = '#CommuneId';
        var cboFilsId = '#ProjetId';
        var url = '@Url.Action("SousSecteurBySecteur", "Account")';
        //Dropdownlist Selectedchange event
        $(cboPereId).change(function () {
            $(cboFilsId).empty();
            if ($(cboPereId).val()) {

                $.ajax({
                    type: 'POST',
                    url: url, // we are calling json method

                    dataType: 'json',

                    data: { id_pere: $(cboPereId).val() },
                    // here we are get value of selected country and passing same value as inputto json method GetStates.

                    success: function (states) {
                        // states contains the JSON formatted list
                        // of states passed from the controller

                        $.each(states, function (i, state) {
                            $(cboFilsId).append('<option value="">' + "selectionnez un élemennt" + '</option>'); // ici on met d'abord unn premier elt vide
                            $(cboFilsId).append('<option value="' + state.Value + '">' +
                             state.Text + '</option>');
                            // here we are adding option for States

                        });
                    },
                    error: function (ex) {
                        alert('Failed to retrieve states.' + ex);
                    }
                });
            } else {
                $(cboFilsId).append('<option value="">" a modifier"</option>');
            };

            return false;
        })
    });



</script>