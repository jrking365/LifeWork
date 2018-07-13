Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class ServiceController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Service/
        Function Index() As ActionResult
            Dim service = db.Service.Include(Function(s) s.SousSecteurActivite).Include(Function(s) s.User)
            Return View(service.ToList())
        End Function

        ' GET: /Service/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As Service = db.Service.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            Return View(service)
        End Function

        ' GET: /Service/Create
        Function Create() As ActionResult
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle")
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /Service/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,UserId,SousSecteurActiviteId,Titre,Description,DatePostulation,DureeRealisation,MontantMinimal,MontantMaximal,StatutExistant,DateCreation")> ByVal service As Service) As ActionResult
            If ModelState.IsValid Then
                db.Service.Add(service)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", service.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", service.UserId)
            Return View(service)
        End Function

        ' GET: /Service/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As Service = db.Service.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", service.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", service.UserId)
            Return View(service)
        End Function

        ' POST: /Service/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,UserId,SousSecteurActiviteId,Titre,Description,DatePostulation,DureeRealisation,MontantMinimal,MontantMaximal,StatutExistant,DateCreation")> ByVal service As Service) As ActionResult
            If ModelState.IsValid Then
                db.Entry(service).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.SousSecteurActiviteId = New SelectList(db.SousSecteurActivite, "Id", "Libelle", service.SousSecteurActiviteId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", service.UserId)
            Return View(service)
        End Function

        ' GET: /Service/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim service As Service = db.Service.Find(id)
            If IsNothing(service) Then
                Return HttpNotFound()
            End If
            Return View(service)
        End Function

        ' POST: /Service/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim service As Service = db.Service.Find(id)
            db.Service.Remove(service)
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
