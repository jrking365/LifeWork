Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CompteBancaireViewModel

    Public Property Id As Long

    <Display(Name:="Code_CompteBanquaire", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Code As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DatePeremption_CompteBancaire", ResourceType:=GetType(Resource))>
    Public Property DatePeremption As DateTime = Now

    <Display(Name:="Solde_CompteBanquaire", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property Solde As String = "0"

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    Public Sub New()
    End Sub

    Public Sub New(entity As CompteBancaire)
        With Me
            .Id = entity.Id
            .UserId = entity.UserId
            .Code = entity.Code
            .DatePeremption = entity.DatePeremption
            .Solde = entity.Solde
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As CompteBancaire
        Dim entity As New CompteBancaire
        With entity
            .Id = Me.Id
            .UserId = Me.UserId
            .Code = Me.Code
            .DatePeremption = Me.DatePeremption
            .Solde = Me.Solde
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
