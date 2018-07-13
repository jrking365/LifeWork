Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class PostulerJobViewModel

    Public Property Id As Long

    <Display(Name:="Description_PostulerJob", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    <Display(Name:="DureeExecution_PostulerJob", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property DureeExecution As String

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    <Display(Name:="BudgetExige_PostulerJob", ResourceType:=GetType(Resource))>
    Public Property BudgetExige As String = "0"

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateEnvoi_PostulerJob", ResourceType:=GetType(Resource))>
    Public Property DateEnvoi As DateTime = Now

    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="User", ResourceType:=GetType(Resource))>
    Public Property UserId As String
    Public Overridable Property LesUser As List(Of ApplicationUser)

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="RequiredField")>
    <Display(Name:="Jobs", ResourceType:=GetType(Resource))>
    Public Property JobsId As Long
    Public Overridable Property LesJobs As List(Of Jobs)

    Public Sub New()
    End Sub

    Public Sub New(entity As PostulerJob)
        With Me
            .JobsId = entity.JobsId
            .UserId = entity.UserId
            .Description = entity.Description
            .DureeExecution = entity.DureeExecution
            .BudgetExige = entity.BudgetExige
            .DateEnvoi = entity.DateEnvoi
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As PostulerJob
        Dim entity As New PostulerJob
        With entity
            .UserId = Me.UserId
            .JobsId = Me.JobsId
            .Description = Me.Description
            .DureeExecution = Me.DureeExecution
            .BudgetExige = Me.BudgetExige
            .DateEnvoi = Me.DateEnvoi
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant
        End With
        Return entity
    End Function
End Class
