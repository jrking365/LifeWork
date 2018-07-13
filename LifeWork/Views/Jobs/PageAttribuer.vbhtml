@ModelType Jobs
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.attribuer_Job
End Code

@Styles.Render("~/Content/css")

@*<div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-6">
        </div>
        <div class="col-lg-6">
            <div class="title-action">
                <a href="#" class="btn btn-white"><i class="fa fa-pencil"></i> Modifier </a>
                <a href="#" class="btn btn-white"><i class="fa fa-check "></i> Enregistrer </a>
                <a href="invoice_print.html" target="_blank" class="btn btn-primary"><i class="fa fa-print"></i> Imprimer la commande </a>
            </div>
        </div>
    </div>*@

<div class="row">
    <div class="col-lg-12">
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="ibox-content p-xl">
                <div class="row">
                    <div class="col-sm-6">
                        <h5>De:</h5>
                        <address>
                            <strong>LifeWork, SARL</strong><br />
                            CAMGAZ, BP 260 Yde<br />
                            Yaoundé Cameroun<br />
                            <abbr title="Telephone">Tel: </abbr>(237) 690 90 34 35
                        </address>
                    </div>

                    <div class="col-sm-6 text-right">
                        <h4>Commande No.</h4>
                        <h4 class="text-navy">LFW-000567F7-00</h4>
                        <span>A:</span>
                        <address>
                            <strong>@ViewBag.user.Nom</strong><br>
                            @ViewBag.user.Pays<br>
                            @ViewBag.user.Email<br>
                            <abbr title="Phone">Tel: </abbr> (00237) @ViewBag.user.Telephone
                        </address>
                        <p>
                            <span><strong>Date d'envoi: </strong> @Date.Now.ToString("dd MMMM yyyy")</span><br />
                            <span><strong>Date limite:  </strong>@Model.DatePrevueLivraison.ToString("dd MMMM yyyy") @*@ViewBag.Job.DatePrevueLivraison.ToString("dd MMMM yyyy")*@</span>
                        </p>
                    </div>
                </div>
                <div class="table-responsive m-t">
                    <table class="table invoice-table">
                        <thead>
                            <tr>
                                <th>Article(s)</th>
                                <th>Prix</th>
                                <th>Taxe</th>
                                <th>Prix total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <div><strong>@Model.Titre</strong></div>
                                    <small>@Model.Description</small>
                                </td>
                                <td>@ViewBag.BudgetExige</td>
                                <td>10%</td>
                                @code
                                    Dim B As Decimal = Convert.ToDecimal(ViewBag.BudgetExige)
                                    Dim total As Decimal = B + (B * 0.1)
                                End Code
                                <td>@total @Resource.FCFA</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <table class="table invoice-total">
                    <tbody>
                        <tr>
                            <td><strong>Total Hors taxes:</strong></td>
                            <td>@B @Resource.FCFA</td>
                        </tr>
                        <tr>
                            <td><strong>Taxe : </strong></td>
                            <td>@(B * 0.1) @Resource.FCFA</td>
                        </tr>
                        <tr>
                            <td><strong>Net a payer :</strong></td>
                            <td>@total @Resource.FCFA</td>
                        </tr>
                    </tbody>
                </table>
                @Using (Html.BeginForm())
                    @Html.AntiForgeryToken()

                    @<div Class="form-actions text-right">
                        <Button Class="btn btn-primary demo3"><i class="fa fa-dollar"></i> PAYER</Button>
                        
                    </div>
                End Using
                <div class="well m-t">
                    <strong class="alert-danger">A Noter</strong>
                    l'argent ne sera transmis au prestataire qu'une fois le job exécuté, il sera donc stocké en attendant dans notre compte et u cas ou le prestataire n'exécuterai pas le job, il vous sera restitué
                </div>

            </div>
        </div>
    </div>
</div>

<script src="~/Content/js/plugins/sweetalert/sweetalert.min.js"></script>
<script>

    $(document).ready(function () {

        $('.demo1').click(function(){
            swal({
                title: "Welcome in Alerts",
                text: "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            });
        });

        $('.demo2').click(function(){
            swal({
                title: "Good job!",
                text: "You clicked the button!",
                type: "success"
            });
        });

        $('.demo3').click(function () {
            swal({
                title: "Etes vous sure?",
                text: "Vous ne serez pas capable d'annuler cela apres avoir validé",
                type: "warning",
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Oui, attribuer!",
                closeOnConfirm: false
            }, function () {
                swal("Attribuer!", "Votre Job a été attribué.", "success");
            });
        });

        $('.demo4').click(function () {
            swal({
                        title: "Are you sure?",
                        text: "Your will not be able to recover this imaginary file!",
                        type: "warning",
                        showCancelButton: true,
                        confirmButtonColor: "#DD6B55",
                        confirmButtonText: "Yes, delete it!",
                        cancelButtonText: "No, cancel plx!",
                        closeOnConfirm: false,
                        closeOnCancel: false },
                    function (isConfirm) {
                        if (isConfirm) {
                            swal("Deleted!", "Your imaginary file has been deleted.", "success");
                        } else {
                            swal("Cancelled", "Your imaginary file is safe :)", "error");
                        }
                    });
        });


    });

</script>