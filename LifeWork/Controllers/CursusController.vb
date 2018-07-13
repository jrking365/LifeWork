Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class CursusController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Cursus/
        Function Index() As ActionResult
            Dim cursus = db.Cursus.Include(Function(c) c.Cv).Include(Function(c) c.TypeCursus)
            Return View(cursus.ToList())
        End Function

        ' GET: /Cursus/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cursus As Cursus = db.Cursus.Find(id)
            If IsNothing(cursus) Then
                Return HttpNotFound()
            End If
            Return View(cursus)
        End Function

        ' GET: /Cursus/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            ViewBag.TypeCursusId = New SelectList(db.TypeCursus, "Id", "Type")
            Return View()
        End Function

        ' POST: /Cursus/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,TypeCursusId,CvId,Titre,Poste,Structures,Diplome,Periode,StatutExistant,DateCreation")> ByVal cursus As Cursus) As ActionResult
            If ModelState.IsValid Then
                db.Cursus.Add(cursus)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", cursus.CvId)
            ViewBag.TypeCursusId = New SelectList(db.TypeCursus, "Id", "Type", cursus.TypeCursusId)
            Return View(cursus)
        End Function

        ' GET: /Cursus/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cursus As Cursus = db.Cursus.Find(id)
            If IsNothing(cursus) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", cursus.CvId)
            ViewBag.TypeCursusId = New SelectList(db.TypeCursus, "Id", "Type", cursus.TypeCursusId)
            Return View(cursus)
        End Function

        ' POST: /Cursus/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,TypeCursusId,CvId,Titre,Poste,Structures,Diplome,Periode,StatutExistant,DateCreation")> ByVal cursus As Cursus) As ActionResult
            If ModelState.IsValid Then
                db.Entry(cursus).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", cursus.CvId)
            ViewBag.TypeCursusId = New SelectList(db.TypeCursus, "Id", "Type", cursus.TypeCursusId)
            Return View(cursus)
        End Function

        ' GET: /Cursus/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cursus As Cursus = db.Cursus.Find(id)
            If IsNothing(cursus) Then
                Return HttpNotFound()
            End If
            Return View(cursus)
        End Function

        ' POST: /Cursus/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim cursus As Cursus = db.Cursus.Find(id)
            cursus.StatutExistant = False
            db.Cursus.Add(cursus)
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
