Imports System
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions 'jutumärgid
Imports System.ComponentModel 'taustal töötava taustprotsessi asi 
Imports System.Text

Public Class Spider
    Public websiteUml As String

    Public acceptButtonLink(0) As String    'Accept button html link code
    Public gameName(0) As String            'Task type
    Public startTime(0) As String           'Start time
    Public dateStartTime(0) As Date         'Start time as Date
    Public endTime(0) As String             'End time
    Public dateEndTime(0) As Date           'End time as Date
    Public duration(0) As String            'Task Duration


    Public loginCookie As CookieContainer   'LOGIN cookie
    Public cookieLost As Boolean = False    'Is cookie outdated?

    ''' <summary>
    ''' Scan site for jobs
    ''' </summary>
    ''' <returns>If login cookie lost = False</returns>
    Public Function ScanSite()
        ClearArrays()
        GetTableInfo()
        ConvertTableInformation()

        If cookieLost Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Get websites HTML code
    ''' </summary>
    ''' <returns></returns>
    Private Function GetWebHTML()
        Dim strHTML As String 'Original HTM code
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(websiteUml), HttpWebRequest)
            request.CookieContainer = loginCookie
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream())
            strHTML = reader.ReadToEnd
            Return strHTML
        Catch ex As Exception
            Return "0"
        End Try

    End Function


    ''' <summary>
    ''' Get data from HTML tabel
    ''' </summary>
    Private Sub GetTableInfo()
        Dim READ As Boolean = False
        Dim tableDataLines(0) As String
        Dim sentences() As String
        Dim i As String = 0
        Dim strHTML As String = GetWebHTML()

        Dim newLine As Boolean = False
        Dim newColumn As String = 0

        CheckCookie(strHTML)

        strHTML = strHTML.Replace(vbCr, "").Replace(vbLf, "")
        strHTML = Replace(strHTML, vbTab, "")
        strHTML = Replace(strHTML, " ", "")

        sentences = strHTML.Split("<")

        For Each line As String In sentences
            If InStr(line, "td>") Then
                READ = True             'Start saving 
            End If
            If InStr(line, "/td>") Then
                READ = False            'Stop saving
            End If

            If READ Then
                If line IsNot String.Empty Then
                    tableDataLines(i) = line.ToString
                    i += 1
                    ReDim Preserve tableDataLines(i)
                End If
            End If
        Next

        ''''''''''''''''''''''''''''''''''''Table Column info''''''''''''''''''''''''''''''''''''''''''''''''''
        i = 0
        For Each word As String In tableDataLines

            If InStr(word, "td>") Then

                If newLine Then
                    i += 1
                    newLine = False
                End If

                newColumn += 1

                ReDim Preserve acceptButtonLink(i)
                ReDim Preserve gameName(i)
                ReDim Preserve startTime(i)
                ReDim Preserve endTime(i)
                ReDim Preserve duration(i)
                ReDim Preserve dateStartTime(i)
                ReDim Preserve dateEndTime(i)
            End If

            Select Case newColumn
                Case 1
                    acceptButtonLink(i) = acceptButtonLink(i) & word
                Case 2
                    gameName(i) = gameName(i) & word
                Case 3
                    startTime(i) = startTime(i) & word
                Case 4
                    endTime(i) = endTime(i) & word
                Case 5
                    duration(i) = duration(i) & word

                    newColumn = 0
                    newLine = True
            End Select
        Next

    End Sub


    ''' <summary>
    ''' Convert table times to required forms and get correct accept link code
    ''' </summary>
    Private Sub ConvertTableInformation()
        Dim tableArrLenght As Integer = acceptButtonLink.Length - 1
        Dim timeConvert As String

        While tableArrLenght >= 0
            If acceptButtonLink(tableArrLenght) IsNot Nothing Then
                'Clean Accept button link
                acceptButtonLink(tableArrLenght) = Regex.Replace(acceptButtonLink(tableArrLenght), """", "")
                acceptButtonLink(tableArrLenght) = Replace(acceptButtonLink(tableArrLenght).ToString, "http://task.betgenius.com", "").ToString
                acceptButtonLink(tableArrLenght) = Replace(acceptButtonLink(tableArrLenght).ToString, "td>ahref=", "").ToString
                acceptButtonLink(tableArrLenght) = Replace(acceptButtonLink(tableArrLenght).ToString, "/WorkAvailable/Accept/", "").ToString
                acceptButtonLink(tableArrLenght) = Replace(acceptButtonLink(tableArrLenght).ToString, ">Accepttask/a>", "").ToString

                'Clean game name
                gameName(tableArrLenght) = Replace(gameName(tableArrLenght).ToString, "td>", "").ToString

                'Clean duration
                duration(tableArrLenght) = Replace(duration(tableArrLenght).ToString, "td>", "").ToString

                'Format and convert time
                timeConvert = Mid(startTime(tableArrLenght), 12, 2) & "/" & Mid(startTime(tableArrLenght), 9, 2) & "/" & Mid(startTime(tableArrLenght), 4, 4) & " " & Mid(startTime(tableArrLenght), 14, 5)
                dateStartTime(tableArrLenght) = DateTime.Parse(timeConvert)

                'Format and convert time
                timeConvert = Mid(endTime(tableArrLenght), 12, 2) & "/" & Mid(endTime(tableArrLenght), 9, 2) & "/" & Mid(endTime(tableArrLenght), 4, 4) & " " & Mid(endTime(tableArrLenght), 14, 5)
                dateEndTime(tableArrLenght) = DateTime.Parse(timeConvert)
            End If
            tableArrLenght -= 1
        End While
    End Sub

    ''' <summary>
    ''' Check if login cookie is still valid
    ''' </summary>
    ''' <param name="strHTML">Sites HTML code</param>
    Private Sub CheckCookie(ByVal strHTML)
        If strHTML.Contains("loginContainer") Then    'Tuvasta, kas küpsis kehtib!!
            cookieLost = True
        Else
            cookieLost = False
        End If
    End Sub


    ''' <summary>
    ''' Glear all arrays
    ''' </summary>
    Private Sub ClearArrays()
        Array.Clear(acceptButtonLink, 0, acceptButtonLink.Length)
        Array.Clear(gameName, 0, gameName.Length)
        Array.Clear(startTime, 0, startTime.Length)
        Array.Clear(endTime, 0, endTime.Length)
        Array.Clear(duration, 0, duration.Length)
        Array.Clear(dateStartTime, 0, dateStartTime.Length)
        Array.Clear(dateEndTime, 0, dateEndTime.Length)
        ReDim Preserve acceptButtonLink(0)
        ReDim Preserve gameName(0)
        ReDim Preserve startTime(0)
        ReDim Preserve endTime(0)
        ReDim Preserve duration(0)
        ReDim Preserve dateStartTime(0)
        ReDim Preserve dateEndTime(0)
    End Sub
End Class
