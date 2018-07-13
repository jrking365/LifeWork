@Code
    'Layout = "~/Views/Shared/_Layout.vbhtml"


    Dim controller = HttpContext.Current.Request.RequestContext.RouteData.Values("Controller").ToString()
    Dim cLayout As String = ""


    If controller.Equals("Home") Or controller.Equals("Account") Then
        cLayout = "~/Views/Shared/_Landing.vbhtml"
    Else
        cLayout = "~/Views/Shared/_Layout.vbhtml"
    End If

    Layout = cLayout
End Code