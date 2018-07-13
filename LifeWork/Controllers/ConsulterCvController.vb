Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class ConsulterCvController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /ConsulterCv/
        Function Index() As ActionResult
            Dim consulter = db.Consulter.Include(Function(c) c.cv).Include(Function(c) c.User)
            Return View(consulter.ToList())
        End Function

        ' GET: /ConsulterCv/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim consultercv As ConsulterCv = db.Consulter.Find(id)
            If IsNothing(consultercv) Then
                Return HttpNotFound()
            End If
            Return View(consultercv)
        End Function

        ' GET: /ConsulterCv/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName")
            Return View()
        End Function

        ' POST: /ConsulterCv/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "CvId,UserId,DateConsulter")> ByVal consultercv As ConsulterCv) As ActionResult
            If ModelState.IsValid Then
                db.Consulter.Add(consultercv)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", consultercv.CvId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", consultercv.UserId)
            Return View(consultercv)
        End Function

        ' GET: /ConsulterCv/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim consultercv As ConsulterCv = db.Consulter.Find(id)
            If IsNothing(consultercv) Then
                Return HttpNotFound()
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", consultercv.CvId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", consultercv.UserId)
            Return View(consultercv)
        End Function

        ' POST: /ConsulterCv/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "CvId,UserId,DateConsulter")> ByVal consultercv As ConsulterCv) As ActionResult
            If ModelState.IsValid Then
                db.Entry(consultercv).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", consultercv.CvId)
            'ViewBag.UserId = New SelectList(db.IdentityUsers, "Id", "UserName", consultercv.UserId)
            Return View(consultercv)
        End Function

        ' GET: /ConsulterCv/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim consultercv As ConsulterCv = db.Consulter.Find(id)
            If IsNothing(consultercv) Then
                Return HttpNotFound()
            End If
            Return View(consultercv)
        End Function

        ' POST: /ConsulterCv/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim consultercv As ConsulterCv = db.Consulter.Find(id)
            db.Consulter.Remove(consultercv)
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
