 <!-- Start Formulaire de connexion -->
<div id="connexion-form" class="modal fade" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-body">
                <div class="row">
                    <div class="col-sm-6 b-r">
                        <h3 class="m-t-none m-b">Se connecter</h3>

                        <p>Ameloirer votre experience sur LifeWork</p>

                        <form role="form">
                            <div class="form-group"><label>Email</label> <input type="email" placeholder="Entrez votre adresse email" class="form-control"></div>
                            <div class="form-group"><label>Mot de passe</label> <input type="password" placeholder="Entrez votre mot de passe" class="form-control"></div>
                            <div>
                                <button class="btn btn-sm btn-primary pull-right m-t-n-xs" type="submit"><strong>Connexion</strong></button>
                                <label> <input type="checkbox" class="i-checks">Se souvenir de moi </label>
                            </div>
                        </form>
                    </div>
                    <div class="col-sm-6">
                        <h4>Pas encore inscrire ?</h4>
                        <p>Creer votre compte maintenant :</p>
                        <p class="text-center">
                            <a data-toggle="modal" data-dismiss="modal" href="#inscription-form" id="inscription"><i class="fa fa-sign-in big-icon"></i></a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Formulaire de connexion -->
<!-- Start Formulaire d'inscription -->
<div id="inscription-form" class="modal fade" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-body">
                <div class="row">
                    <div class="col-sm-6 b-r">
                        <h3 class="m-t-none m-b">Inscription gratuite sur LifeWork</h3>
                        <p>Et ça restera toujours gratuit.</p>
                        <div class="divider"></div>

                        <form role="form">
                            <div class="form-group"><label>Email</label> <input type="email" placeholder="Adresse email" class="form-control"></div>
                            <div class="form-group"><label>Pseudo</label> <input type="text" placeholder="Pseudo" class="form-control"></div>
                            <select class="form-control m-b" name="account">
                                <option>option 1</option>
                                <option>option 2</option>
                                <option>option 3</option>
                                <option>option 4</option>
                            </select>


                            <div class="form-group"><label>Mot de passe</label> <input type="password" placeholder="Mot de passe" class="form-control"></div>
                            <div class="form-group"><label>Confirmer le mot de passe</label> <input type="password" placeholder="Confirmer le mot de passe" class="form-control"></div>
                            <div>
                                <button class="btn btn-sm btn-primary pull-right m-t-n-xs" type="submit"><strong>S'inscrire</strong></button>
                            </div>
                        </form>
                    </div>
                    <div class="col-sm-6">
                        <h4>Deja inscrire ?</h4>
                        <p>Connecter vous maintenant :</p>
                        <p class="text-center">
                            <a data-toggle="modal" data-dismiss="modal" href="#connexion-form" id="connexion"><i class="fa fa-sign-in big-icon"></i></a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Formulaire d'inscription -->
