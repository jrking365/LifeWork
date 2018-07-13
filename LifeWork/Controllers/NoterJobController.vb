Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class NoterJobController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /NoterJob/
        Function Index() As ActionResult
            Dim noterjob = db.NoterJob.Include(Function(n) n.Jobs).Include(Function(n) n.UserEmployeur).Include(Function(n) n.UserPrestataire)
            Return View(noterjob.ToList())
        End Function

        ' GET: /NoterJob/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noterjob As NoterJob = db.NoterJob.Find(id)
            If IsNothing(noterjob) Then
                Return HttpNotFound()
            End If
            Return View(noterjob)
        End Function

        ''' <summary>
        ''' Function pour noter le prestataire
        ''' </summary>
        ''' <returns></returns>
        Function NoterPrestataire() As ActionResult

            Return View()
        End Function

        Function NoterEmployeur() As ActionResult

            Return View()
        End Function


        ' GET: /NoterJob/Create
        Function Create() As ActionResult
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId")
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName")
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /NoterJob/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,UserEmployeurId,UserPrestataireId,JobsId,NoteEmployeur,NotePrestataire,StatutExistant,DateCreation")> ByVal noterjob As NoterJob) As ActionResult
            If ModelState.IsValid Then
                db.NoterJob.Add(noterjob)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", noterjob.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserPrestataireId)
            Return View(noterjob)
        End Function

        ' GET: /NoterJob/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noterjob As NoterJob = db.NoterJob.Find(id)
            If IsNothing(noterjob) Then
                Return HttpNotFound()
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", noterjob.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserPrestataireId)
            Return View(noterjob)
        End Function

        ' POST: /NoterJob/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,UserEmployeurId,UserPrestataireId,JobsId,NoteEmployeur,NotePrestataire,StatutExistant,DateCreation")> ByVal noterjob As NoterJob) As ActionResult
            If ModelState.IsValid Then
                db.Entry(noterjob).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.JobsId = New SelectList(db.Jobs, "Id", "UserPublierId", noterjob.JobsId)
            'ViewBag.UserEmployeurId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserEmployeurId)
            'ViewBag.UserPrestataireId = New SelectList(db.IdentityUsers, "Id", "UserName", noterjob.UserPrestataireId)
            Return View(noterjob)
        End Function

        ' GET: /NoterJob/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noterjob As NoterJob = db.NoterJob.Find(id)
            If IsNothing(noterjob) Then
                Return HttpNotFound()
            End If
            Return View(noterjob)
        End Function

        ' POST: /NoterJob/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim noterjob As NoterJob = db.NoterJob.Find(id)
            db.NoterJob.Remove(noterjob)
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
