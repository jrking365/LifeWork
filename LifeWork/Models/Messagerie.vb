'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Messagerie
    Public Property Id As Long
    Public Property TypeMessagerieId As Long?
    Public Property UserExpediteurId As String
    Public Property UserDestinataireId As String
    Public Property JobsId As Long?

    Public Property Contenu As String
    Public Property Objet As String
    Public Property DateEnvoi As DateTime = Now
    Public Property DateReception As DateTime = Now

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    Public Overridable Property UserExpediteur As ApplicationUser
    Public Overridable Property UserDestinataire As ApplicationUser
    Public Overridable Property TypeMessagerie As TypeMessagerie
    Public Overridable Property PieceJointe As ICollection(Of PieceJointe) = New HashSet(Of PieceJointe)

End Class