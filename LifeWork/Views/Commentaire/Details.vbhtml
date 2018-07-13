@ModelType Commentaire
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_Commentaire
End Code

<h2>@Resource.Delete_Commentaire</h2>

<div>
    <h4>Commentaire</h4>
    <hr />
    <dl class="dl-horizontal">
        @*<dt>
                @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Jobs.UserPublierId)
            </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserEmployeur.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserEmployeur.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserPrestataire.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserPrestataire.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contenu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contenu)
        </dd>

        @*<dt>
                @Html.DisplayNameFor(Function(model) model.StatutExistant)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.StatutExistant)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.DateCreation)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DateCreation)
            </dd>*@

    </dl>    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
