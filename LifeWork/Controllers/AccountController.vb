Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Data.Entity
Imports System.Data.Entity.Validation

<Authorize>
Public Class AccountController
    Inherits System.Web.Mvc.Controller

    Private db As New ApplicationDbContext

    ''' <summary>
    ''' DEBUT FONCTION QUI RETOURNE L'UTILISATEUR CONNECTE ACTUELLEMENT
    ''' </summary>
    ''' <returns>userConnected</returns>
    ''' <remarks></remarks>
    Public Function GetUserConnected() As ApplicationUser
        Dim id = User.Identity.GetUserId
        Dim userConnected = db.Users.Find(id)
        Return userConnected
    End Function
    '' FIN FONCTION QUI RETOURNE L'UTILISATEUR CONNECTE ACTUELLEMENT

    <HttpPost()>
    Public Function SousSecteurBySecteur(id_pere As String) As ActionResult
        Dim results = (From ss In db.SousSecteurActivite
                       Where ss.SecteurActiviteId = id_pere
                       Select New SelectListItem With {.Value = ss.Id, .Text = ss.Libelle})

        'Dim count = results.Count

        Return Json(results, JsonRequestBehavior.AllowGet)
    End Function


    ''' <summary>
    ''' DEBUT FONCTION QUI RETOURNE LE TYPE DE L'UTILISATEUR CONNECTE ACTUELLEMENT
    ''' </summary>
    ''' <returns>TypeuserConnected</returns>
    Public Function GetTypeUserConnected() As String
        Dim id = User.Identity.GetUserId
        Dim TypeuserConnected = db.Users.Find(id)
        Return TypeuserConnected.TypeCompte.Libelle
    End Function
    ''FIN FONCTION QUI RETOURNE LE TYPE DE L'UTILISATEUR CONNECTE ACTUELLEMENT


    ''' <summary>
    ''' DEBUT FONCTION TRAITEMENT IMAGE
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowImage(Id As String) As ActionResult
        If IsNothing(Id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If
        Dim user As ApplicationUser = db.Users.Find(Id)
        If IsNothing(user) Then
            Return HttpNotFound()
        End If
        Return File(user.Photo, "image/png")
    End Function
    '' FIN FONCTION TRAITEMENT IMAGE

    Public Sub New()
        Me.New(New UserManager(Of ApplicationUser)(New UserStore(Of ApplicationUser)(New ApplicationDbContext())))
    End Sub

    Public Sub New(manager As UserManager(Of ApplicationUser))
        UserManager = manager
    End Sub

    Public Property UserManager As UserManager(Of ApplicationUser)

    '
    ' GET: /Account/Login
    <AllowAnonymous>
    Public Function Login(returnUrl As String) As ActionResult
        ViewBag.ReturnUrl = returnUrl
        Return View()
    End Function


    Public Function active(ByVal activationCode As String) As Boolean
        Dim user = db.Users.Find(activationCode)
        If Not IsNothing(user) Then
            user.StatutExistant = True
            db.Entry(user).State = Entity.EntityState.Modified
            db.SaveChanges()
            Redirect("/Account/Login")
        End If
        Return False
    End Function
    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Login(model As LoginViewModel, returnUrl As String) As Task(Of ActionResult)

        If ModelState.IsValid Then
            Dim user = (From u In db.Users Where u.UserName = model.UserName And u.StatutExistant = True Select u).ToList
            If Not user.Count = 0 Then
                Dim appUser = Await UserManager.FindAsync(model.UserName, model.Password)
                If appUser IsNot Nothing Then
                    Await SignInAsync(appUser, model.RememberMe)
                    'SendSmsZag("237", "695224277", "nouvelle connexion a votre espace LifeWork")
                    'SendSmsLMTG("237", model., "nouvelle connexion a votre espace LifeWork")
                    returnUrl = "/Dashboard/Index"

                    Return RedirectToLocal(returnUrl)
                    ViewBag.idcon = GetUserConnected.Id
                Else
                    ModelState.AddModelError("", "Nom d'utilisateur ou mot de passe invalide.")
                End If
            Else
                ModelState.AddModelError("", " Login incorrect et/ou votre compte n'est pas activé veuillez cliquer sur le lien dans votre adresse email.")
            End If
            ' Valider le mot de passe

        End If

        ' Si nous sommes arrivés là, un échec s’est produit. Réafficher le formulaire
        Return View(model)
    End Function

    '
    ' GET: /Account/Register
    <AllowAnonymous>
    Public Function Register() As ActionResult
        'Return View()
        Dim Db = New ApplicationDbContext()
        Dim model = New RegisterViewModel()
        ' Remplir les combos						
        model.LesPays = Db.Pays.OfType(Of Pays)().ToList
        model.LesTypeCompte = Db.TypeCompte.OfType(Of TypeCompte)().ToList
        Return View(model)
    End Function

    ''' <summary>
    ''' FONCTION DE MAIL POUR CONFIRMATION
    ''' </summary>
    ''' <param name="pseudo">Pseudo</param>
    ''' <param name="recepient">Recepteur</param>
    ''' <param name="subject">Objet</param>
    ''' <returns>Booleen</returns>
    ''' <remarks></remarks>
    Public Function SendConfirmEmail(ByVal pseudo As String, ByVal recepient As String, ByVal subject As String) As Boolean
        Try
            Dim confirmEmail As String = Guid.NewGuid().ToString
            Dim body As String = """<p>Salutation <strong style='" + "color:green;font-style:italic;" + "'>" + pseudo + ",</p>"
            body += "<br /><br />Cliquer sur le lien suivant pour activer votre compte"
            body += "<br /><div style='" + "background-color:green;font-style:italic;color:white;" + "'><a href = '" + Request.Url.AbsoluteUri.Replace("VB.aspx", Convert.ToString("VB_Activation.aspx?ActivationCode=") & confirmEmail) + "'>Cliquer ici pour activer votre compte.</a></div>"
            body += "<br /><br />Merci"
            SendEmail(recepient, subject, body)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return False
    End Function

    '
    ' POST: /Account/Register
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Register(model As RegisterViewModel, Photo As HttpPostedFileBase) As Task(Of ActionResult)
        If ModelState.IsValid Then
            '' DEBUT GESTION DE LAFIRE PHOTO
            'If Photo IsNot Nothing AndAlso Photo.ContentLength > 0 Then
            '    user.Photo = New Byte(Photo.ContentLength - 1) {}
            '    user.InputStream.Read(user.Photo, 0, Photo.ContentLength)
            'End If
            '' FIN GESTION DE LA PHOTO

            Dim user = model.GetUserMinimal
            user.StatutExistant = False

            Dim result = Await UserManager.CreateAsync(user, model.Password)
            If result.Succeeded Then
                'Await SignInAsync(user, isPersistent:=False)

                If user.TypeCompteId = 1 Then
                    Dim connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
                    Dim Con As New SqlConnection(connectionString)
                    Dim id As Integer = 2
                    Dim strSql As String = "Insert into dbo.AspNetUserRoles(UserId,RoleId) values('" & user.Id & "','" & id & "')"
                    Con.Open()
                    Dim cmd As New SqlCommand
                    Dim reader As SqlDataReader
                    cmd.Connection = Con
                    cmd.CommandText = strSql
                    cmd.CommandType = CommandType.Text
                    reader = cmd.ExecuteReader()
                    Con.Close()
                ElseIf user.TypeCompteId = 2 Then
                    Dim connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
                    Dim Con As New SqlConnection(connectionString)
                    Dim id As Integer = 3
                    Dim strSql As String = "Insert into dbo.AspNetUserRoles(UserId,RoleId) values('" & user.Id & "','" & id & "')"
                    Con.Open()
                    Dim cmd As New SqlCommand
                    Dim reader As SqlDataReader
                    cmd.Connection = Con
                    cmd.CommandText = strSql
                    cmd.CommandType = CommandType.Text
                    reader = cmd.ExecuteReader()
                    Con.Close()
                End If

                'DEBUT DE L'ENVOI DU MAIL
                SendConfirmEmail(user.UserName, user.Email, "ACTIVER VOTRE COMPTE SUR LIFEWORK ")
                'FIN ENVOI DE MAIL

                '' DEBUT ON ENREGISTRE LES INFORMATIONS DE SON CV
                Dim cv As New Cv
                cv.UserId = user.Id
                'cv.Titre = "CV de " + GetUserCivility(user.Sexe) + user.Nom + " " + user.Prenom
                'cv.StatutExistant = True
                cv.Titre = "CV de [" + user.UserName + "]"
                cv.DateCreation = Now
                db.Cv.Add(cv)
                db.SaveChanges()
                '' FIN ON ENREGISTRE LES INFORMATIONS DE SON CV

                Return RedirectToAction("Index", "Home")
            Else
                AddErrors(result)
            End If
        End If
        ' Si nous sommes arrivés là, un échec s’est produit. Réafficher le formulaire
        model.LesPays = db.Pays.OfType(Of Pays)().ToList
        model.LesTypeCompte = db.TypeCompte.OfType(Of TypeCompte)().ToList

        Return View(model)
    End Function

    '
    ' POST: /Account/Disassociate
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Async Function Disassociate(loginProvider As String, providerKey As String) As Task(Of ActionResult)
        Dim message As ManageMessageId? = Nothing
        Dim result As IdentityResult = Await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), New UserLoginInfo(loginProvider, providerKey))
        If result.Succeeded Then
            message = ManageMessageId.RemoveLoginSuccess
        Else
            message = ManageMessageId.UnknownError
        End If

        Return RedirectToAction("Manage", New With {
            .Message = message
        })
    End Function

    '
    ' GET: /Account/Manage
    Public Function Manage(ByVal message As ManageMessageId?) As ActionResult
        ViewData("StatusMessage") =
            If(message = ManageMessageId.ChangePasswordSuccess, "Votre mot de passe a été modifié.",
                If(message = ManageMessageId.SetPasswordSuccess, "Votre mot de passe a été défini.",
                    If(message = ManageMessageId.RemoveLoginSuccess, "La connexion externe a été supprimée.",
                        If(message = ManageMessageId.UnknownError, "Une erreur s'est produite.",
                        ""))))
        ViewBag.HasLocalPassword = HasPassword()
        ViewBag.ReturnUrl = Url.Action("Manage")
        Return View()
    End Function

    '
    ' POST: /Account/Manage
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Async Function Manage(model As ManageUserViewModel) As Task(Of ActionResult)
        Dim hasLocalLogin As Boolean = HasPassword()
        ViewBag.HasLocalPassword = hasLocalLogin
        ViewBag.ReturnUrl = Url.Action("Manage")
        If hasLocalLogin Then
            If ModelState.IsValid Then
                Dim result As IdentityResult = Await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword)
                If result.Succeeded Then
                    Return RedirectToAction("Manage", New With {
                        .Message = ManageMessageId.ChangePasswordSuccess
                    })
                Else
                    AddErrors(result)
                End If
            End If
        Else
            ' L’utilisateur ne possède pas de mot de passe local. Supprimez donc toutes les erreurs de validation causées par un champ OldPassword manquant
            Dim state As ModelState = ModelState("OldPassword")
            If state IsNot Nothing Then
                state.Errors.Clear()
            End If

            If ModelState.IsValid Then
                Dim result As IdentityResult = Await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword)
                If result.Succeeded Then
                    Return RedirectToAction("Manage", New With {
                        .Message = ManageMessageId.SetPasswordSuccess
                    })
                Else
                    AddErrors(result)
                End If
            End If
        End If

        ' Si nous sommes arrivés là, un échec s’est produit. Réafficher le formulaire
        Return View(model)
    End Function

    '
    ' POST: /Account/ExternalLogin
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Function ExternalLogin(provider As String, returnUrl As String) As ActionResult
        ' Demandez une redirection vers le fournisseur de connexions externe
        Return New ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", New With {.ReturnUrl = returnUrl}))
    End Function

    '
    ' GET: /Account/ExternalLoginCallback
    <AllowAnonymous>
    Public Async Function ExternalLoginCallback(returnUrl As String) As Task(Of ActionResult)
        Dim loginInfo = Await AuthenticationManager.GetExternalLoginInfoAsync()
        If loginInfo Is Nothing Then
            Return RedirectToAction("Login")
        End If

        ' Sign in the user with this external login provider if the user already has a login
        Dim user = Await UserManager.FindAsync(loginInfo.Login)
        If user IsNot Nothing Then
            Await SignInAsync(user, isPersistent:=False)
            Return RedirectToLocal(returnUrl)
        Else
            ' If the user does not have an account, then prompt the user to create an account
            ViewBag.ReturnUrl = returnUrl
            ViewBag.LoginProvider = loginInfo.Login.LoginProvider
            Return View("ExternalLoginConfirmation", New ExternalLoginConfirmationViewModel() With {.UserName = loginInfo.DefaultUserName})
        End If
        Return View("ExternalLoginFailure")
    End Function

    '
    ' POST: /Account/LinkLogin
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Function LinkLogin(provider As String) As ActionResult
        ' Request a redirect to the external login provider to link a login for the current user
        Return New ChallengeResult(provider, Url.Action("LinkLoginCallback", "Account"), User.Identity.GetUserId())
    End Function

    '
    ' GET: /Account/LinkLoginCallback
    Public Async Function LinkLoginCallback() As Task(Of ActionResult)
        Dim loginInfo = Await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId())
        If loginInfo Is Nothing Then
            Return RedirectToAction("Manage", New With {
                .Message = ManageMessageId.UnknownError
            })
        End If
        Dim result = Await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login)
        If result.Succeeded Then
            Return RedirectToAction("Manage")
        End If
        Return RedirectToAction("Manage", New With {
            .Message = ManageMessageId.UnknownError
        })
    End Function

    ''' <summary>
    ''' Completer Infos Get
    ''' </summary>
    ''' <returns></returns>
    <HttpGet>
    Public Function CompleterInfos(ByVal id As String) As ActionResult

        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If

        Dim User As ApplicationUser = db.Users.Find(id)
        If IsNothing(User) Then
            Return HttpNotFound()
        End If

        Dim entityVM As New CompleterInfosViewModel(User)
        entityVM.LesTypesComptes = db.TypeCompte.OfType(Of TypeCompte)().ToList
        entityVM.SecteurActivite = db.SecteurActivite.OfType(Of SecteurActivite)().ToList
        entityVM.SoussecteurActivite = db.SousSecteurActivite.OfType(Of SousSecteurActivite)().ToList

        Return View("CompleterInfos", "_Layout", entityVM)
    End Function

    ''' <summary>
    ''' FONCTION COMPLETER INFOS POST
    ''' </summary>
    ''' <returns> something</returns>
    <HttpPost()>
    Public Function CompleterInfos(<Bind(Include:="Id,UserName,Password,ConfirmPassword,StatutExistant,DateCreation,TypeCompteId,Nom,Prenom,DateNaissance,Sexe,Email,Photo,Telephone,Cni")> ByVal user As CompleterInfosViewModel) As ActionResult
        '<ValidateAntiForgeryToken()>
        user.LesTypesComptes = db.TypeCompte.OfType(Of TypeCompte)().ToList
        user.SecteurActivite = db.SecteurActivite.OfType(Of SecteurActivite)().ToList
        user.SoussecteurActivite = db.SousSecteurActivite.OfType(Of SousSecteurActivite)().ToList
        'user.Email = GetUserConnected.Email
        'user.TypeCompteId = GetUserConnected.TypeCompteId
        'user.id = GetUserConnected.Id

        Dim errors = ModelState.Values.SelectMany(Function(v) v.Errors)

        If ModelState.IsValid Then
            user.StatutExistant = True
            'DEBUT GESTION DE LAFIRE PHOTO
            'If photo IsNot Nothing AndAlso photo.ContentLength > 0 Then
            '    user.Photo = New Byte(photo.ContentLength - 1) {}
            '    photo.InputStream.Read(user.Photo, 0, photo.ContentLength)
            'End If
            ' FIN GESTION DE LA PHOTO
            Dim entity = user.getEntity()
            db.Entry(entity).State = EntityState.Modified
            db.SaveChanges()
            If Not String.IsNullOrEmpty(user.Password) Then
                UserManager.RemovePassword(user.id)

                Dim result = UserManager.AddPassword(user.id, user.Password)
            End If

            Return RedirectToAction("/Dashboard/Index")
            Return RedirectToAction("Index", "Dashboard")
        End If

        Return View("CompleterInfos", "_Layout", user)
    End Function


    '
    ' POST: /Account/ExternalLoginConfirmation
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function ExternalLoginConfirmation(model As ExternalLoginConfirmationViewModel, returnUrl As String) As Task(Of ActionResult)
        If User.Identity.IsAuthenticated Then
            Return RedirectToAction("Manage")
        End If

        If ModelState.IsValid Then
            ' Obtenez des informations sur l’utilisateur auprès du fournisseur de connexions externe
            Dim info = Await AuthenticationManager.GetExternalLoginInfoAsync()
            If info Is Nothing Then
                Return View("ExternalLoginFailure")
            End If
            Dim user = New ApplicationUser() With {.UserName = model.UserName}
            Dim result = Await UserManager.CreateAsync(user)
            If result.Succeeded Then
                result = Await UserManager.AddLoginAsync(user.Id, info.Login)
                If result.Succeeded Then
                    Await SignInAsync(user, isPersistent:=False)
                    Return RedirectToLocal(returnUrl)
                End If
            End If
            AddErrors(result)
        End If

        ViewBag.ReturnUrl = returnUrl
        Return View(model)
    End Function

    '
    ' POST: /Account/LogOff

    Public Function LogOff() As ActionResult
        AuthenticationManager.SignOut()
        Return RedirectToAction("Index", "Home")
    End Function

    '
    ' GET: /Account/ExternalLoginFailure
    <AllowAnonymous>
    Public Function ExternalLoginFailure() As ActionResult
        Return View()
    End Function

    <ChildActionOnly>
    Public Function RemoveAccountList() As ActionResult
        Dim linkedAccounts = UserManager.GetLogins(User.Identity.GetUserId())
        ViewBag.ShowRemoveButton = linkedAccounts.Count > 1 Or HasPassword()
        Return DirectCast(PartialView("_RemoveAccountPartial", linkedAccounts), ActionResult)
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso UserManager IsNot Nothing Then
            UserManager.Dispose()
            UserManager = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Assistants"
    ' Used for XSRF protection when adding external logins
    Private Const XsrfKey As String = "XsrfId"

    Private Function AuthenticationManager() As IAuthenticationManager
        Return HttpContext.GetOwinContext().Authentication
    End Function

    Private Async Function SignInAsync(user As ApplicationUser, isPersistent As Boolean) As Task
        AuthenticationManager.SignOut(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ExternalCookie)
        Dim identity = Await UserManager.CreateIdentityAsync(user, Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie)
        AuthenticationManager.SignIn(New AuthenticationProperties() With {.IsPersistent = isPersistent}, identity)
    End Function

    Private Sub AddErrors(result As IdentityResult)
        For Each [error] As String In result.Errors
            ModelState.AddModelError("", [error])
        Next
    End Sub

    Private Function HasPassword() As Boolean
        Dim appUser = UserManager.FindById(User.Identity.GetUserId())
        If (appUser IsNot Nothing) Then
            Return appUser.PasswordHash IsNot Nothing
        End If
        Return False
    End Function

    Private Function RedirectToLocal(returnUrl As String) As ActionResult
        If Url.IsLocalUrl(returnUrl) Then
            Return Redirect(returnUrl)
        Else
            Return RedirectToAction("Index", "Home")
        End If
    End Function

    Public Enum ManageMessageId
        ChangePasswordSuccess
        SetPasswordSuccess
        RemoveLoginSuccess
        UnknownError
    End Enum

    Private Class ChallengeResult
        Inherits HttpUnauthorizedResult
        Public Sub New(provider As String, redirectUri As String)
            Me.New(provider, redirectUri, Nothing)
        End Sub
        Public Sub New(provider As String, redirectUri As String, userId As String)
            Me.LoginProvider = provider
            Me.RedirectUri = redirectUri
            Me.UserId = userId
        End Sub

        Public Property LoginProvider As String
        Public Property RedirectUri As String

        Public Property UserId As String

        Public Overrides Sub ExecuteResult(context As ControllerContext)
            Dim properties = New AuthenticationProperties() With {.RedirectUri = RedirectUri}
            If UserId IsNot Nothing Then
                properties.Dictionary(XsrfKey) = UserId
            End If
            context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider)
        End Sub
    End Class
#End Region

End Class

