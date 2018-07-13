Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class MessagerieController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /Messagerie/
        Function Index() As ActionResult
            Dim messagerie = db.Messagerie.Include(Function(m) m.TypeMessagerie).Include(Function(m) m.UserDestinataire).Include(Function(m) m.UserExpediteur)
            Return View(messagerie.ToList())
        End Function

        ' GET: /Messagerie/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim messagerie As Messagerie = db.Messagerie.Find(id)
            If IsNothing(messagerie) Then
                Return HttpNotFound()
            End If
            Return View(messagerie)
        End Function

        ' GET: /Messagerie/Create
        Function Create() As ActionResult
            ViewBag.TypeMessagerieId = New SelectList(db.TypeMessagerie, "Id", "Titre")
            'ViewBag.UserDestinataireId = New SelectList(db.IdentityUsers, "Id", "UserName")
            'ViewBag.UserExpediteurId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /Messagerie/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,TypeMessagerieId,UserExpediteurId,UserDestinataireId,JobsId,Contenu,Objet,DateEnvoi,DateReception,StatutExistant,DateCreation")> ByVal messagerie As Messagerie) As ActionResult
            If ModelState.IsValid Then
                db.Messagerie.Add(messagerie)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.TypeMessagerieId = New SelectList(db.TypeMessagerie, "Id", "Titre", messagerie.TypeMessagerieId)
            'ViewBag.UserDestinataireId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserDestinataireId)
            'ViewBag.UserExpediteurId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserExpediteurId)
            Return View(messagerie)
        End Function

        ' GET: /Messagerie/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim messagerie As Messagerie = db.Messagerie.Find(id)
            If IsNothing(messagerie) Then
                Return HttpNotFound()
            End If
            ViewBag.TypeMessagerieId = New SelectList(db.TypeMessagerie, "Id", "Titre", messagerie.TypeMessagerieId)
            'ViewBag.UserDestinataireId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserDestinataireId)
            'ViewBag.UserExpediteurId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserExpediteurId)
            Return View(messagerie)
        End Function

        ' POST: /Messagerie/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,TypeMessagerieId,UserExpediteurId,UserDestinataireId,JobsId,Contenu,Objet,DateEnvoi,DateReception,StatutExistant,DateCreation")> ByVal messagerie As Messagerie) As ActionResult
            If ModelState.IsValid Then
                db.Entry(messagerie).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.TypeMessagerieId = New SelectList(db.TypeMessagerie, "Id", "Titre", messagerie.TypeMessagerieId)
            'ViewBag.UserDestinataireId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserDestinataireId)
            'ViewBag.UserExpediteurId = New SelectList(db.IdentityUsers, "Id", "UserName", messagerie.UserExpediteurId)
            Return View(messagerie)
        End Function

        ' GET: /Messagerie/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim messagerie As Messagerie = db.Messagerie.Find(id)
            If IsNothing(messagerie) Then
                Return HttpNotFound()
            End If
            Return View(messagerie)
        End Function

        ' POST: /Messagerie/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim messagerie As Messagerie = db.Messagerie.Find(id)
            db.Messagerie.Remove(messagerie)
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
