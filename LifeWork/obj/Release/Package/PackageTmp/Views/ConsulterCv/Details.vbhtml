@ModelType ConsulterCv
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Details_ConsulterCv
End Code

<h2>Resource.Details_ConsulterCv</h2>
<hr />

<div>
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.cv.UserId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cv.UserId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.User.UserName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.User.UserName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateConsulter)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateConsulter)
        </dd>

    </dl>
</div>
<p>
    @*@Html.ActionLink("Resource.Edit_ConsulterCv", "Edit", New With {.id = Model.Id}) |*@
    @Html.ActionLink(Resource.Btn_Annuler, "Index")
</p>
