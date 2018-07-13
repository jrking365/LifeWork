@ModelType ConsulterCv
@Imports LifeWork.My.Resources
@Code
    ViewData("Title") = Resource.Delete_CompteBancaire
End Code

<h2>@Resource.Delete_CompteBancaire</h2>
<hr />

<h3>@Resource.ConfirmDelete</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

         @<div class="form-actions no-color">
            <input type="submit" value="@Resource.Btn_Supprimer" class="btn btn-default" /> |
            @Html.ActionLink(Resource.Btn_Annuler, "Index", Nothing, New With {.class = "btn btn-danger"})
        </div>
    End Using
</div>
