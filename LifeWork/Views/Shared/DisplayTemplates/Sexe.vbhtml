@ModelType String
@Imports ICDPD.My.Resources

@Code
    Dim data As String = ""
    Select Case Model
        Case "MASCULIN"
            data = "MASCULIN"
        Case "FEMININ"
            data = "FEMININ"
        Case Else
            data = "AUTRE"
    End Select
    @data
End Code