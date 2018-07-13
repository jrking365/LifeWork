Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace LifeWork
    Public Class PieceJointeController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDbContext

        ' GET: /PieceJointe/
        Function Index() As ActionResult
            Dim piecejointe = db.PieceJointe.Include(Function(p) p.Messagerie)
            Return View(piecejointe.ToList())
        End Function

        ' GET: /PieceJointe/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim piecejointe As PieceJointe = db.PieceJointe.Find(id)
            If IsNothing(piecejointe) Then
                Return HttpNotFound()
            End If
            Return View(piecejointe)
        End Function

        ' GET: /PieceJointe/Create
        Function Create() As ActionResult
            ViewBag.MessagerieId = New SelectList(db.Messagerie, "Id", "UserExpediteurId")
            Return View()
        End Function

        ' POST: /PieceJointe/Create
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,MessagerieId,Piece,StatutExistant,DateCreation")> ByVal piecejointe As PieceJointe) As ActionResult
            If ModelState.IsValid Then
                db.PieceJointe.Add(piecejointe)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.MessagerieId = New SelectList(db.Messagerie, "Id", "UserExpediteurId", piecejointe.MessagerieId)
            Return View(piecejointe)
        End Function

        ' GET: /PieceJointe/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim piecejointe As PieceJointe = db.PieceJointe.Find(id)
            If IsNothing(piecejointe) Then
                Return HttpNotFound()
            End If
            ViewBag.MessagerieId = New SelectList(db.Messagerie, "Id", "UserExpediteurId", piecejointe.MessagerieId)
            Return View(piecejointe)
        End Function

        ' POST: /PieceJointe/Edit/5
        'Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        'plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,MessagerieId,Piece,StatutExistant,DateCreation")> ByVal piecejointe As PieceJointe) As ActionResult
            If ModelState.IsValid Then
                db.Entry(piecejointe).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.MessagerieId = New SelectList(db.Messagerie, "Id", "UserExpediteurId", piecejointe.MessagerieId)
            Return View(piecejointe)
        End Function

        ' GET: /PieceJointe/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim piecejointe As PieceJointe = db.PieceJointe.Find(id)
            If IsNothing(piecejointe) Then
                Return HttpNotFound()
            End If
            Return View(piecejointe)
        End Function

        ' POST: /PieceJointe/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim piecejointe As PieceJointe = db.PieceJointe.Find(id)
            db.PieceJointe.Remove(piecejointe)
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
