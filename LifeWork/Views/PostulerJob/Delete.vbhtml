@ModelType PostulerJob
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_PostulerJob
End Code

<h2>@Resource.Delete_PostulerJob</h2>

<h3>@Resource.ConfirmDelete</h3>
<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Job.UserPublierId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Job.UserPublierId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DureeExecution)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DureeExecution)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BudgetExige)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BudgetExige)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateEnvoi)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateEnvoi)
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
