Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class ServiceViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Service", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    '<Display(Name:="Description_Service", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DatePostulation_Service", ResourceType:=GetType(Resource))>
    Public Property DatePostulation As DateTime = Now

    '<Display(Name:="DureeRealisation_Service", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property DureeRealisation As String

    <Display(Name:="MontantMinimal_Service", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property MontantMinimal As String = "0"

    <Display(Name:="MontantMaximal_Service", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property MontantMaximal As String = "0"

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="SousSecteurActivite", ResourceType:=GetType(Resource))>
    Public Property SousSecteurActiviteId As Long
    Public Overridable Property LesSousSecteurActivite As List(Of SousSecteurActivite)

    Public Sub New()
    End Sub

    Public Sub New(entity As Service)
        With Me
            .Id = entity.Id
            .UserId = entity.UserId
            .SousSecteurActiviteId = entity.SousSecteurActiviteId

            .Titre = entity.Titre
            .Description = entity.Description
            .DatePostulation = entity.DatePostulation
            .DureeRealisation = entity.DureeRealisation
            .MontantMinimal = entity.MontantMinimal
            .MontantMaximal = entity.MontantMaximal
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Service
        Dim entity As New Service
        With entity
            .Id = Me.Id
            .UserId = Me.UserId
            .SousSecteurActiviteId = Me.SousSecteurActiviteId

            .Titre = Me.Titre
            .Description = Me.Description
            .DatePostulation = Me.DatePostulation
            .DureeRealisation = Me.DureeRealisation
            .MontantMinimal = Me.MontantMinimal
            .MontantMaximal = Me.MontantMaximal
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
