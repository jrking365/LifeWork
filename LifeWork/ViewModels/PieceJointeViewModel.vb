Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class PieceJointeViewModel

    Public Property Id As Long

    <Display(Name:="Piece_PieceJointe", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    Public Property Piece As Byte()

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Messagerie_PieceJointe", ResourceType:=GetType(Resource))>
    Public Property MessagerieId As Long
    Public Overridable Property LesMessagerie As List(Of Messagerie)

    Public Sub New()
    End Sub

    Public Sub New(entity As PieceJointe)
        With Me
            .Id = entity.Id
            .MessagerieId = entity.MessagerieId
            .Piece = entity.Piece
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As PieceJointe
        Dim entity As New PieceJointe
        With entity
            .Id = Me.Id
            .MessagerieId = Me.MessagerieId
            .Piece = Me.Piece
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
