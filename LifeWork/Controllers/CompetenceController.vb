Imports System
Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports System.Data.Entity
Imports System.Data.Entity.Validation
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.SessionState

Namespace LifeWork
    Public Class CompetenceController
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

        ' GET: /Competence/
        Function Index() As ActionResult
            Dim competence = db.Competence.Include(Function(c) c.cv)
            Return View(competence.ToList())
        End Function

        ' GET: /Competence/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim competence As Competence = db.Competence.Find(id)
            If IsNothing(competence) Then
                Return HttpNotFound()
            End If
            Return View(competence)
        End Function

        ' GET: /Competence/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            Return View()
        End Function

        ' POST: /Competence/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,CvId,Libelle,Description,StatutExistant,DateCreation")> ByVal competence As Competence) As ActionResult
            If ModelState.IsValid Then
                db.Competence.Add(competence)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", competence.CvId)
            Return View(competence)
        End Function

        ' GET: /Competence/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim competence As Competence = db.Competence.Find(id)
            If IsNothing(competence) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", competence.CvId)
            Return View(competence)
        End Function

        ' POST: /Competence/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,CvId,Libelle,Description,StatutExistant,DateCreation")> ByVal competence As Competence) As ActionResult
            If ModelState.IsValid Then
                db.Entry(competence).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", competence.CvId)
            Return View(competence)
        End Function

        ' GET: /Competence/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim competence As Competence = db.Competence.Find(id)
            If IsNothing(competence) Then
                Return HttpNotFound()
            End If
            Return View(competence)
        End Function

        ' POST: /Competence/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim competence As Competence = db.Competence.Find(id)
            competence.StatutExistant = False
            db.Competence.Add(competence)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
