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

Partial Public Class PieceJointe
    Public Property Id As Long
    Public Property MessagerieId As Long?

    Public Property Piece As Byte()

    Public Property StatutExistant As Boolean?
    Public Property DateCreation As DateTime?

    Public Overridable Property Messagerie As Messagerie
End Class
