@ModelType Messagerie
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_Messagerie
End Code

<h2>@Resource.Details_Messagerie</h2>
<hr />

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
</div>
<p>
    @Html.ActionLink(Resource.Edit_Messagerie, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
