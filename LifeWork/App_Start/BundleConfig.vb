Imports System.Web.Optimization

Public Module BundleConfig
    ' Pour plus d’informations sur le regroupement, rendez-vous sur http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
        ' prêt pour la production, utilisez l’outil de génération sur http://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        '"~/Scripts/bootstrap.js", 'dans script bootstrap
        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/respond.js"))

        'bundles.Add(New StyleBundle("~/Content/css").Include(
        '          "~/Content/bootstrap.css",
        '          "~/Content/site.css"))

        'START DE MES INCLUSIONS CSS

        bundles.Add(New StyleBundle("~/Content/css").Include(
        "~/Content/css/bootstrap.min.css",
        "~/Content/css/animate.css",
        "~/Content/font-awesome/css/font-awesome.min.css",
        "~/Content/css/style.css",
        "~/Content/css/plugins/iCheck/custom.css",
        "~/Content/css/plugins/summernote/summernote.css",
        "~/Content/css/plugins/summernote/summernote-bs3.css",
        "~/Content/css/animate.css",
        "~/Content/css/style.css",
        "~/Content/css/font-awesome.css",
        "~/Content/css/plugins/datapicker/datepicker3.css"))

        'END DE MES INCLUSIONS CSS


        'START DE MES INCLUSIONS JS

        bundles.Add(New ScriptBundle("~/bundles/jsTemplate").Include(
        "~/Scripts/js/jquery-2.1.1.js",
        "~/Scripts/js/bootstrap.min.js",
        "~/Scripts/js/plugins/metisMenu/jquery.metisMenu.js",
        "~/Scripts/js/plugins/slimscroll/jquery.slimscroll.min.js",
        "~/Scripts/js/plugins/pace/pace.min.js",
        "~/Scripts/js/plugins/wow/wow.min.js",
        "~/Scripts/js/plugins//touchspin/jquery.bootstrap-touchspin.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/jsMail").Include(
        "~/Scripts/js/plugins/iCheck/icheck.min.js",
        "~/Scripts/js/plugins/summernote/summernote.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/jsFormCrea").Include(
                  "~/Scripts/js/bootstrap.min.js",
                  "~/Scripts/js/plugins/summernote/summernote.min.js",
                  "~/Scripts/js/inspinia.js",
                  "~/Scripts/js/plugins/datapicker/bootstrap-datepicker.js",
                  "~/Scripts/js/plugins/metisMenu/jquery.metisMenu.js",
                  "~/Scripts/js/plugins/slimscroll/jquery.slimscroll.min.js",
                  "~/Scripts/js/plugins/pace/pace.min.js"))


        'END DE MES INCLUSIONS JS

        'Ce js est insdispensable pour les menu

        '"~/Scripts/js/inspinia.js",


    End Sub
End Module

