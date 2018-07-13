@ModelType JobsNotification
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_JobsNotification
End Code

<h2>@Resource.Details_JobsNotification</h2>
<hr />

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
</div>
<p>
    @*@Html.ActionLink(Resource.Edit_JobsNotification, "Edit", New With {.id = Model.Id}) |*@
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
