Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CertificationViewModel

    Public Property Id As Long

    <Display(Name:="Libelle_Certification", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Libelle As String

    <Display(Name:="Description_Certification", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateObtention_Certification", ResourceType:=GetType(Resource))>
    Public Property DateObtention As DateTime

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Cv", ResourceType:=GetType(Resource))>
    Public Property CvId As Long
    Public Overridable Property LesCv As List(Of Cv)

    Public Sub New()
    End Sub

    Public Sub New(entity As Certification)
        With Me
            .Id = entity.Id
            .CvId = entity.CvId
            .Libelle = entity.Libelle
            .Description = entity.Description
            .DateObtention = entity.DateObtention
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Certification
        Dim entity As New Certification
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .Libelle = Me.Libelle
            .Description = Me.Description
            .DateObtention = Me.DateObtention
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
