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

Partial Public Class Commentaire
    Public Property Id As Long
    Public Property JobsId As Long
    Public Property UserEmployeurId As String
    Public Property UserPrestataireId As String

    Public Property Contenu As String

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime

    Public Overridable Property UserEmployeur As ApplicationUser
    Public Overridable Property UserPrestataire As ApplicationUser
    Public Overridable Property Jobs As Jobs
End Class
