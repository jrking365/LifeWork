Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class PersonneDeReferenceController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /PersonneDeReference/
        Function Index() As ActionResult
            Dim personnedereference = db.PersonneDeReference.Include(Function(p) p.Cv)
            Return View(personnedereference.ToList())
        End Function

        ' GET: /PersonneDeReference/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personnedereference As PersonneDeReference = db.PersonneDeReference.Find(id)
            If IsNothing(personnedereference) Then
                Return HttpNotFound()
            End If
            Return View(personnedereference)
        End Function

        ' GET: /PersonneDeReference/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            Return View()
        End Function

        ' POST: /PersonneDeReference/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,CvId,Nom,Prenom,Sexe,Telephone,Profession,Email,StatutExistant,DateCreation")> ByVal personnedereference As PersonneDeReference) As ActionResult
            If ModelState.IsValid Then
                db.PersonneDeReference.Add(personnedereference)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", personnedereference.CvId)
            Return View(personnedereference)
        End Function

        ' GET: /PersonneDeReference/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personnedereference As PersonneDeReference = db.PersonneDeReference.Find(id)
            If IsNothing(personnedereference) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", personnedereference.CvId)
            Return View(personnedereference)
        End Function

        ' POST: /PersonneDeReference/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,CvId,Nom,Prenom,Sexe,Telephone,Profession,Email,StatutExistant,DateCreation")> ByVal personnedereference As PersonneDeReference) As ActionResult
            If ModelState.IsValid Then
                db.Entry(personnedereference).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", personnedereference.CvId)
            Return View(personnedereference)
        End Function

        ' GET: /PersonneDeReference/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim personnedereference As PersonneDeReference = db.PersonneDeReference.Find(id)
            If IsNothing(personnedereference) Then
                Return HttpNotFound()
            End If
            Return View(personnedereference)
        End Function

        ' POST: /PersonneDeReference/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim personnedereference As PersonneDeReference = db.PersonneDeReference.Find(id)
            personnedereference.StatutExistant = False
            db.PersonneDeReference.Add(personnedereference)
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
