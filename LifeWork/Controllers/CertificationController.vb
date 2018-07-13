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
    Public Class CertificationController
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


        ' GET: /Certification/
        Function Index() As ActionResult
            Dim iduser = GetUserConnected.Id
            Dim cv = From c In db.Cv Where c.UserId = iduser And c.StatutExistant = True Select c

            Dim certif As New Certification
            certif.CvId = cv.ToList.First.Id
            Dim certification = db.Certification.Include(Function(c) c.cv)
            certification.Where(Function(e) e.StatutExistant = True) '' GESTION DES STATUTEXISTANT OU NON
            Return View(certification.ToList())
        End Function

        ' GET: /Certification/Details/5
        Function Details() As ActionResult
            Dim id = GetUserConnected().Id
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim certification As Certification = db.Certification.Find(id)
            If IsNothing(certification) Then
                Return HttpNotFound()
            End If
            Return View(certification)
        End Function

        ' GET: /Certification/Create
        Function Create() As ActionResult
            ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId")
            Return View()
        End Function

        ' POST: /Certification/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,CvId,Libelle,Description,DateObtention,StatutExistant,DateCreation")> ByVal certification As Certification) As ActionResult
            If User.Identity.IsAuthenticated Then
                If ModelState.IsValid Then
                    Dim iduser = GetUserConnected.Id
                    Dim cv = From c In db.Cv Where c.UserId = iduser And c.StatutExistant = True Select c

                    Dim certif As New Certification
                    certif.CvId = cv.ToList.First.Id
                    certif.Libelle = certification.Libelle
                    certif.Description = certification.Description
                    certif.DateObtention = certification.DateObtention
                    certif.StatutExistant = True
                    certif.DateCreation = Now
                    db.Certification.Add(certif)
                    db.SaveChanges()
                    Return RedirectToAction("Index")
                End If
                'ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", certification.CvId)
            End If
            Return View(certification)
        End Function

        ' GET: /Certification/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim certification As Certification = db.Certification.Find(id)
            If IsNothing(certification) Then
                Return HttpNotFound()
            End If
            'ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", certification.CvId)
            Return View(certification)
        End Function

        ' POST: /Certification/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,CvId,Libelle,Description,DateObtention,StatutExistant,DateCreation")> ByVal certification As Certification) As ActionResult
            If User.Identity.IsAuthenticated Then
                If ModelState.IsValid Then
                    db.Entry(certification).State = EntityState.Modified
                    db.SaveChanges()
                    Return RedirectToAction("Index")
                End If
                'ViewBag.CvId = New SelectList(db.Cv, "Id", "UserId", certification.CvId)
            End If
            Return View(certification)
        End Function

        ' GET: /Certification/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim certification As Certification = db.Certification.Find(id)
            If IsNothing(certification) Then
                Return HttpNotFound()
            End If
            Return View(certification)
        End Function

        ' POST: /Certification/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            If User.Identity.IsAuthenticated Then
                Dim certification As Certification = db.Certification.Find(id)
                certification.StatutExistant = False
                db.Entry(certification).State = EntityState.Modified
                db.SaveChanges()
            End If
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
