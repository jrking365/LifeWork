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

Partial Public Class Notification
    Public Property Id As Long

    Public Property Titre As String
    Public Property Contenu As String
    Public Property DateEnvoi As DateTime? = Now

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    'Listes des utilisateurs ayant �t� notifi�
End Class
