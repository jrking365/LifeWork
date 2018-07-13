@ModelType PostulerJobViewModel
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Create_PostulerJob
End Code



@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
         <div class="ibox float-e-margins">
             @Html.ValidationSummary(True)
             @*<div class="form-group">
                @Html.LabelFor(Function(model) model.UserId, "UserId", New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.DropDownList("UserId", String.Empty)
                    @Html.ValidationMessageFor(Function(model) model.UserId)
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.JobsId, "JobsId", New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.DropDownList("JobsId", String.Empty)
                    @Html.ValidationMessageFor(Function(model) model.JobsId)
                </div>
            </div>*@
             <div class="form-group">
                 @Html.LabelFor(Function(model) model.DureeExecution, New With {.class = "control-label col-md-2"})
                 <div class="col-md-5">
                     @Html.TextBoxFor(Function(model) model.DureeExecution, New With {.class = "col-md-2 touchspin3"})
                     @Html.ValidationMessageFor(Function(model) model.DureeExecution)
                 </div>
             </div>

             <div class="form-group">
                 @Html.LabelFor(Function(model) model.BudgetExige, New With {.class = "control-label col-md-2"})
                 <div class="col-md-5">
                     @*@Html.TextBoxFor(Function(model) model.BudgetExige, New)*@
                     @Html.EditorFor(Function(model) model.BudgetExige)
                     @Html.ValidationMessageFor(Function(model) model.BudgetExige)
                 </div>
             </div>

             <div class="form-group">
                 @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
                 <div class="col-md-5">
                     @Html.EditorFor(Function(model) model.Description, New With {.class = "summernote"})
                     @Html.ValidationMessageFor(Function(model) model.Description)
                 </div>
             </div>

            

             

             @*<div class="form-group">
                @Html.LabelFor(Function(model) model.DateEnvoi, New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.DateEnvoi)
                    @Html.ValidationMessageFor(Function(model) model.DateEnvoi)
                </div>
            </div>*@

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

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
   @Scripts.Render("~/bundles/jsFormCrea")
End Section
<script>    
 $(".touchspin3").TouchSpin({
                verticalbuttons: true,
                buttondown_class: 'btn btn-white',
                buttonup_class: 'btn btn-white'
 });
</script>
<script type="text/javascript">
    $(function () {
        $('#approve-btn').click(function () {
            $('#modal-container').modal('hide');
        });
    });
</script>