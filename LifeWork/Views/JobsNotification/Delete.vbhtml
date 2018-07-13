@ModelType JobsNotification
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_JobsNotification
End Code

<h2>@Resource.Details_JobsNotification</h2>

<h3>@Resource.ConfirmDelete</h3>
<div>
    <dl class="dl-horizontal">
        @*<dt>
            @Html.DisplayNameFor(Function(model) model.Jobs.UserPublierId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Jobs.UserPublierId)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.Notification.Titre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Notification.Titre)
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
