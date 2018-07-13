Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class MessagerieViewModel

    Public Property Id As Long

    '<Display(Name:="Contenu_Messagerie", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Contenu As String

    <Display(Name:="Objet_Messagerie", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Objet As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateEnvoi_Messagerie", ResourceType:=GetType(Resource))>
    Public Property DateEnvoi As DateTime = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateReception_Messagerie", ResourceType:=GetType(Resource))>
    Public Property DateReception As DateTime = Now

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="TypeMessagerie", ResourceType:=GetType(Resource))>
    Public Property TypeMessagerieId As Long
    Public Overridable Property LesTypeMessagerie As List(Of TypeMessagerie)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Expediteur", ResourceType:=GetType(Resource))>
    Public Property UserExpediteurId As String
    Public Overridable Property LesUserExpediteur As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Destinataire", ResourceType:=GetType(Resource))>
    Public Property UserDestinataireId As String
    Public Overridable Property LesUserDestinataire As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="Jobs", ResourceType:=GetType(Resource))>
    Public Property JobsId As Long
    Public Overridable Property LesJobs As List(Of Jobs)

    Public Sub New()
    End Sub

    Public Sub New(entity As Messagerie)
        With Me
            .Id = entity.Id
            .UserExpediteurId = entity.UserExpediteurId
            .UserDestinataireId = entity.UserDestinataireId
            .TypeMessagerieId = entity.TypeMessagerieId
            .JobsId = entity.JobsId

            .Contenu = entity.Contenu
            .Objet = entity.Objet
            .DateEnvoi = entity.DateEnvoi
            .DateReception = entity.DateReception
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Messagerie
        Dim entity As New Messagerie
        With entity
            .Id = Me.Id
            .UserExpediteurId = Me.UserExpediteurId
            .UserDestinataireId = Me.UserDestinataireId
            .TypeMessagerieId = Me.TypeMessagerieId
            .JobsId = Me.JobsId

            .Contenu = Me.Contenu
            .Objet = Me.Objet
            .DateEnvoi = Me.DateEnvoi
            .DateReception = Me.DateReception
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
