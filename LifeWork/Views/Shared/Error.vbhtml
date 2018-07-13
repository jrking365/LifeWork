@ModelType System.Web.Mvc.HandleErrorInfo

@Code
    ViewBag.Title = "Erreur 404"
End Code

@*ERREUR 404*@
<div class="middle-box text-center animated fadeInDown">
    <h1>404</h1>
    <h3 class="font-bold">Page non trouvee</h3>

    <div class="error-desc">
        Une erreur s’est produite lors du traitement de la requête.
        <form class="form-inline m-t" role="form">
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Rechercher une page">
            </div>
            <button type="submit" class="btn btn-primary">Rechercher</button>
        </form>
    </div>
</div>


@*ERREUR 500*@

@*<div class="middle-box text-center animated fadeInDown">
    <h1>500</h1>
    <h3 class="font-bold">Erreur interne du serveur</h3>

    <div class="error-desc">
        Notre serveur a eu un probleme nous sommes desole.<br />
        Vous pouvez retourner sur la page principale: <br /><a href="" class="btn btn-primary m-t">Retour</a>
    </div>
</div>*@
