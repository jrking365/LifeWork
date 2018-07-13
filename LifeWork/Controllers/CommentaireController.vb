Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class CommentaireController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Commentaire/
        Function Index() As ActionResult
            Dim commentaire = db.Commentaire.Include(Function(c) c.Jobs).Include(Function(c) c.UserEmployeur).Include(Function(c) c.UserPrestataire)
            Return View(commentaire.ToList())
        End Function

        ' GET: /Commentaire/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim commentaire As Commentaire = db.Commentaire.Find(id)
            If IsNothing(commentaire) Then
                Return HttpNotFound()
            End If
            Return View(commentaire)
        End Function

        ' GET: /Commentaire/Create
        Function Create() As ActionResult
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId")
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName")
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /Commentaire/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,JobsId,UserEmployeurId,UserPrestataireId,Contenu,StatutExistant,DateCreation")> ByVal commentaire As Commentaire) As ActionResult
            If ModelState.IsValid Then
                db.Commentaire.Add(commentaire)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", commentaire.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserPrestataireId)
            Return View(commentaire)
        End Function

        ' GET: /Commentaire/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim commentaire As Commentaire = db.Commentaire.Find(id)
            If IsNothing(commentaire) Then
                Return HttpNotFound()
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", commentaire.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserPrestataireId)
            Return View(commentaire)
        End Function

        ' POST: /Commentaire/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,JobsId,UserEmployeurId,UserPrestataireId,Contenu,StatutExistant,DateCreation")> ByVal commentaire As Commentaire) As ActionResult
            If ModelState.IsValid Then
                db.Entry(commentaire).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", commentaire.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", commentaire.UserPrestataireId)
            Return View(commentaire)
        End Function

        ' GET: /Commentaire/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim commentaire As Commentaire = db.Commentaire.Find(id)
            If IsNothing(commentaire) Then
                Return HttpNotFound()
            End If
            Return View(commentaire)
        End Function

        ' POST: /Commentaire/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim commentaire As Commentaire = db.Commentaire.Find(id)
            db.Commentaire.Remove(commentaire)
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
