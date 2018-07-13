Imports System.ComponentModel.DataAnnotations
Imports LifeWork.My.Resources

Public Class JobsViewModel

    Public Property Id As Long

    <Display(Name:="Titre_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Titre As String

    <Display(Name:="Duree_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Duree As String

    <Display(Name:="Code_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Code As String

    '<Display(Name:="Description_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property Description As String

    '<Display(Name:="LieuExecution_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <StringLength(500, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="StringLength")> _
    Public Property LieuExecution As String

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DatePrevueLivraison_Jobs", ResourceType:=GetType(Resource))>
    Public Property DatePrevueLivraison As DateTime = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DatePublication_Jobs", ResourceType:=GetType(Resource))>
    Public Property DatePublication As DateTime = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateAttribution_Jobs", ResourceType:=GetType(Resource))>
    Public Property DateAttribution As DateTime = Now

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <DataType(DataType.Date, ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="DataType_Date")>
    <Display(Name:="DateCloture_Jobs", ResourceType:=GetType(Resource))>
    Public Property DateCloture As DateTime = Now

    <Display(Name:="BudgetMinimal_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property BudgetMinimal As String = "0"

    <Display(Name:="BudgetMaximal_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property BudgetMaximal As String = "0"

    <Display(Name:="BudgetAttribution_Jobs", ResourceType:=GetType(Resource))> _
    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <RegularExpression("^(\d+(((\,))\d+)?)$", ErrorMessageResourceName:="DataType_Decimal", ErrorMessageResourceType:=GetType(Resource))> _
    Public Property BudgetAttribution As String = "0"

    '<Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>


    <Display(Name:="StatutExistant", ResourceType:=GetType(Resource))> _
    Public Property StatutExistant As Boolean? = True

    <Display(Name:="DateCreation", ResourceType:=GetType(Resource))> _
    Public Property DateCreation As DateTime? = Now

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Publier", ResourceType:=GetType(Resource))>
    Public Property UserPublierId As String
    Public Overridable Property LesUserPublier As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="User_Attribuer", ResourceType:=GetType(Resource))>
    Public Property UserAttribuerId As String
    Public Overridable Property LesUserAttribuer As List(Of ApplicationUser)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="TypeJob", ResourceType:=GetType(Resource))>
    Public Property TypeJobId As Long
    Public Overridable Property LesTypeJob As List(Of TypeJob)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")> _
    <Display(Name:="SousSecteurActivite", ResourceType:=GetType(Resource))>
    Public Property SousSecteurActiviteId As Long
    Public Overridable Property LesSousSecteurActivite As List(Of SousSecteurActivite)

    <Required(ErrorMessageResourceType:=GetType(Resource), ErrorMessageResourceName:="FieldRequired")>
    <Display(Name:="Statut", ResourceType:=GetType(Resource))>
    Public Property StatutId As Long




    <Display(Name:="CahierDeCharge_Jobs", ResourceType:=GetType(Resource))>
    Public Property CahierDeCharge As HttpPostedFileBase
    Public Overridable Property LesStatut As List(Of Statut)

    Public Sub New()
    End Sub

    Public Sub New(entity As Jobs)
        With Me
            .Id = entity.Id
            .UserPublierId = entity.UserPublierId
            .UserAttribuerId = entity.UserAttribuerId
            .TypeJobId = entity.TypeJobId
            .SousSecteurActiviteId = entity.SousSecteurActiviteId
            .StatutId = entity.StatutId
            
            .Titre = entity.Titre
            .Duree = entity.Duree
            .Code = entity.Code
            .Description = entity.Description
            .LieuExecution = entity.LieuExecution
            .DatePrevueLivraison = entity.DatePrevueLivraison
            .DatePublication = entity.DatePublication
            .DateAttribution = entity.DateAttribution
            .DateCloture = entity.DateCloture
            .BudgetMinimal = entity.BudgetMinimal
            .BudgetMaximal = entity.BudgetMaximal
            .BudgetAttribution = entity.BudgetAttribution
            '.CahierDeCharge = entity.CahierDeCharge
            .DateCreation = entity.DateCreation
            .StatutExistant = entity.StatutExistant
        End With
    End Sub

    Public Function getEntity() As Jobs
        Dim entity As New Jobs
        With entity
            .Id = Me.Id
            .UserPublierId = Me.UserPublierId
            .UserAttribuerId = Me.UserAttribuerId
            .TypeJobId = Me.TypeJobId
            .SousSecteurActiviteId = Me.SousSecteurActiviteId
            .StatutId = Me.StatutId

            .Titre = Me.Titre
            .Duree = Me.Duree
            .Code = Me.Code
            .Description = Me.Description
            .LieuExecution = Me.LieuExecution
            .DatePrevueLivraison = Me.DatePrevueLivraison
            .DatePublication = Me.DatePublication
            .DateAttribution = Me.DateAttribution
            .DateCloture = Me.DateCloture
            .BudgetMinimal = Me.BudgetMinimal
            .BudgetMaximal = Me.BudgetMaximal
            .BudgetAttribution = Me.BudgetAttribution
            '.CahierDeCharge = Me.CahierDeCharge
            .DateCreation = Me.DateCreation
            .StatutExistant = Me.StatutExistant

            If CahierDeCharge IsNot Nothing AndAlso CahierDeCharge.ContentLength > 0 Then
                entity.CahierDeCharge = New Byte(CahierDeCharge.ContentLength - 1) {}
                CahierDeCharge.InputStream.Read(entity.CahierDeCharge, 0, CahierDeCharge.ContentLength)
            End If

        End With
        Return entity
    End Function
End Class
