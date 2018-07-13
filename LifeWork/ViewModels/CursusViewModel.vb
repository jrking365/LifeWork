Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class CursusViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Cursus", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="Poste_Cursus", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Poste As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Structures_Cursus", ResourceType:=GetType(Resource))>
    Public Property Structures As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Diplome_Cursus", ResourceType:=GetType(Resource))>
    Public Property Diplome As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    <Display(Name:="Periode_Cursus", ResourceType:=GetType(Resource))>
    Public Property Periode As String

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Cv", ResourceType:=GetType(Resource))>
    Public Property CvId As Long
    Public Overridable Property LesCv As List(Of Cv)

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="TypeCursus", ResourceType:=GetType(Resource))>
    Public Property TypeCursusId As Long
    Public Overridable Property LesTypeCursus As List(Of TypeCursus)

    Public Sub New()
    End Sub

    Public Sub New(entity As Cursus)
        With Me
            .Id = entity.Id
            .TypeCursusId = entity.TypeCursusId
            .CvId = entity.CvId
            .Titre = entity.Titre
            .Poste = entity.Poste
            .Structures = entity.Structures
            .Diplome = entity.Diplome
            .Periode = entity.Periode
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Cursus
        Dim entity As New Cursus
        With entity
            .Id = Me.Id
            .CvId = Me.CvId
            .TypeCursusId = Me.TypeCursusId
            .Titre = Me.Titre
            .Poste = Me.Poste
            .Structures = Me.Structures
            .Diplome = Me.Diplome
            .Periode = Me.Periode
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
