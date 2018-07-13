Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient

Module ModuleUser

    ''' <summary>
    ''' FONCTION QUI RETOURNE {M. ou Mme} SELON LE SEXE DE L'UTILISATEUR
    ''' </summary>
    ''' <returns>userConnected</returns>
    ''' <remarks></remarks>
    Public Function GetUserCivility(ByVal sexe As String) As String
        If (sexe.Equals("Masculin")) Then
            Return "M. "
        ElseIf (sexe.Equals("Féminin")) Then
            Return "Mme "
        Else
            Return "? "
        End If
    End Function


    ''' <summary>
    ''' FONCTION QUI ENVOI UN MAIL A L'UTILISATEUR
    ''' </summary>
    ''' <param name="Recepient">Adresse email du recepteur</param>
    ''' <param name="subject">Object du mail</param>
    ''' <param name="body">Contenu du mail</param>
    ''' <returns>Booleen</returns>
    ''' <remarks></remarks>
    Public Function SendEmail(ByVal recepient As String, ByVal subject As String, ByVal body As String) As Boolean
        Dim message = New MailMessage()
        message.[To].Add(New MailAddress(recepient))
        Dim FromEmail As String = "stphane_kamga@outlook.fr"
        message.From = New MailAddress(FromEmail)
        message.Subject = subject
        message.Body = body
        message.IsBodyHtml = True

        Using smtp = New SmtpClient()
            smtp.UseDefaultCredentials = True
            smtp.Credentials = New Net.NetworkCredential("stphane_kamga@outlook.fr", "Cloud2015")
            smtp.Port = 587
            smtp.Host = "smtp-mail.outlook.com"
            smtp.EnableSsl = True
            Try
                smtp.Send(message)
                Return True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Return False
    End Function

    Public Function SendSmsZag(ByVal indicatif As String, ByVal numero As String, ByVal msg As String) As Boolean
        'Dim request As HttpWebRequest
        'Dim response As HttpWebResponse = Nothing
        'Dim url As String
        'Dim username As String
        'Dim password As String
        'Dim host As String
        'Dim originator As String

        Dim result As Boolean = False

        Try

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim url As String
            Dim username As String = ConfigurationManager.AppSettings("username")
            Dim password As String = ConfigurationManager.AppSettings("password")
            Dim host As String = ConfigurationManager.AppSettings("host")
            Dim originator As String = ConfigurationManager.AppSettings("originator")
            Dim sender As String = ConfigurationManager.AppSettings("sender")

            url = host + "/lang_fr/apicmr.php?action=envoismsun&" _
            & "id=" & HttpUtility.UrlEncode(username) _
            & "&pwd=" + HttpUtility.UrlEncode(password) _
            & "&to=" + HttpUtility.UrlEncode(numero) _
            & "&codest=" + HttpUtility.UrlEncode(indicatif) _
            & "&sender=" + HttpUtility.UrlEncode(sender) _
            & "&msg=" + HttpUtility.UrlEncode(msg) _
            & "&originator=" + HttpUtility.UrlEncode(originator) _
            & "&serviceprovider=" _
            & "&responseformat=html"

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)

            'MessageBox.Show("Response: " & response.StatusDescription)
            result = True
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function


    Public Function SendSmsLMTG(ByVal indicatif As String, ByVal numero As String, ByVal msg As String) As Boolean

        Dim result As Boolean = False

        Try
            Dim num As String = indicatif & numero
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            'Dim url As String
            Dim username As String = ConfigurationManager.AppSettings("usernameLmt")
            Dim password As String = ConfigurationManager.AppSettings("passwordLmt")
            'Dim host As String = ConfigurationManager.AppSettings("hostLmt")
            'Dim originator As String = ConfigurationManager.AppSettings("originatorLmt")
            Dim sender As String = ConfigurationManager.AppSettings("senderLmt")

            Dim url = "http://lmtgroup.dyndns.org/sendsms/sendsms.php?" & "UserName=" & HttpUtility.UrlEncode(username) & "&Password=" & HttpUtility.UrlEncode(password) & "&SOA=" & HttpUtility.UrlEncode(sender) & "&MN=" & HttpUtility.UrlEncode(num) & "&SM=" & HttpUtility.UrlEncode(msg)

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)

            'MessageBox.Show("Response: " & response.StatusDescription)
            result = True
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function

End Module
