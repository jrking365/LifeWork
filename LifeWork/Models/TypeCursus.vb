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

Partial Public Class TypeCursus
    Public Property Id As Long

    Public Property Type As String

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    Public Overridable Property Cursus As ICollection(Of Cursus) = New HashSet(Of Cursus)
End Class
