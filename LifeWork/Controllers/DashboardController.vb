Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity

Namespace LifeWork
    Public Class DashboardController

        Inherits System.Web.Mvc.Controller
        Private db As New ApplicationDbContext

        Function Index() As ActionResult
            Dim id_user = GetUserConnected().Id
            Dim Exec As Long = (From J In db.Jobs.OfType(Of Jobs)() Where (J.UserPublierId = id_user Or J.UserAttribuerId = id_user) AndAlso (J.StatutId = 3) Select J).Count()
            ViewBag.exec = Exec
            Dim JobCours As Long = (From J In db.Jobs.OfType(Of Jobs)() Where (J.UserPublierId = id_user Or J.UserAttribuerId = id_user) AndAlso (J.StatutId = 1) Select J).Count()
            ViewBag.JobCours = JobCours
            Dim Postul As Long = (From P In db.Postuler.OfType(Of PostulerJob)() Where P.UserId = id_user Select P).Count()
            ViewBag.Postul = Postul
            Dim Publie As Long = (From J In db.Jobs.OfType(Of Jobs)() Where (J.UserPublierId = id_user) Select J).Count()
            ViewBag.Publie = Publie
            Dim JobValid As Long = (From J In db.Jobs.OfType(Of Jobs)() Where (J.UserPublierId = id_user Or J.UserAttribuerId = id_user) AndAlso (J.StatutId = 4) Select J).Count()
            ViewBag.JobValid = JobValid
            If IsNothing(Publie) Then
                ViewBag.PexecE = 0
                ViewBag.PvalidE = 0
                ViewBag.PCours = 0
            ElseIf Publie <> 0 Then
                ViewBag.PexecE = Convert.ToInt32(Exec * 100 / Publie)
                ViewBag.PvalidE = Convert.ToInt32(JobValid * 100 / Publie)
                ViewBag.PCours = Convert.ToInt32(JobCours * 100 / Publie)
            End If

            If IsNothing(Postul) Then
                ViewBag.Pexec = 0
                ViewBag.Pvalid = 0
            ElseIf Postul <> 0 Then
                ViewBag.Pexec = Convert.ToInt32(Exec * 100 / Postul)

                ViewBag.Pvalid = Convert.ToInt32(JobValid * 100 / Postul)
            End If


            Return View()
        End Function





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

    End Class

End Namespace