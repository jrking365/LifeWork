@ModelType Messagerie
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_Messagerie
End Code

<h2>@Resource.Delete_Messagerie</h2>

<h3>@Resource.ConfirmDelete</h3>
<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TypeMessagerie.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TypeMessagerie.Titre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserDestinataire.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserDestinataire.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserExpediteur.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserExpediteur.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.JobsId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.JobsId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Contenu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Contenu)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Objet)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Objet)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateEnvoi)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateEnvoi)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateReception)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateReception)
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

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
