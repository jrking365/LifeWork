Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Description."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Nos contacts."

        Return View()
    End Function
End Class
