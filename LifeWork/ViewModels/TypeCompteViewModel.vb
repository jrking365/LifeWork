﻿Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class TypeCompteViewModel

    Public Property Id As Long

    <Display(Name:="Libelle_TypeCompte", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Libelle As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    Public Sub New()
    End Sub

    Public Sub New(entity As TypeCompte)
        With Me
            .Id = entity.Id
            .Libelle = entity.Libelle
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As TypeCompte
        Dim entity As New TypeCompte
        With entity
            .Id = Me.Id
            .Libelle = Me.Libelle
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
