Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="PageAttribuer",
            url:="{Jobs}/{PageAttribuer}/{id}/{jobsid}",
            defaults:=New With {.controller = "Jobs", .action = "PageAttribuer", .id = "", .jobsid = ""},
            constraints:=New With {.jobsid = "[0-9]"}
        )
    End Sub
End Module