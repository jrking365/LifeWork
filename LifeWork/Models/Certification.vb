'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré à partir d'un modèle.
'
'     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Certification
    Public Property Id As Long
    Public Property CvId As Long?

    Public Property Libelle As String
    Public Property Description As String
    Public Property DateObtention As DateTime? = Now

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    Public Overridable Property cv As Cv
End Class
