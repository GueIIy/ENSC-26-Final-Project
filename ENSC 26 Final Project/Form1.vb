Public Class Form1
    Dim lowerHour As Integer
    Dim lowerMin As Integer
    Dim upperHour As Integer
    Dim upperMin As Integer
    Dim reqTimes As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        reqTimes = obsCountTxt.Text
        lowerHour = startHourTxt.Text
        lowerMin = startMinTxt.Text
        upperHour = endHourTxt.Text
        upperMin = endMinTxt.Text
        'records inputted values

        obsTxt.Clear()

        Dim arrTime(reqTimes) As String
        ' places the times in an array later on
        Dim randomMinute As Integer
        Dim randomHour As Integer

        For i = 0 To reqTimes - 1

            randomHour = Int((upperHour - lowerHour + 1) * Rnd() + lowerHour)
            If randomHour <= 9 Then
                'obsTxt.Text &= 0 & randomHour
                arrTime(i) &= "0"
            Else
                'obsTxt.Text &= randomHour
            End If
            ' adds a 0 before it if the random number is a single digit integer


            If randomHour = upperHour Then
                randomMinute = Int((upperMin + 1) * Rnd())
                If randomMinute <= 9 Then
                    'obsTxt.Text &= ":0" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":0" & randomMinute
                Else
                    'obsTxt.Text &= ":" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":" & randomMinute
                End If
                ' adds a 0 before it if the random number is a single digit integer


                ' if the random hour chosen is same as upper hour, the max minutes is based on the inputted max

            ElseIf randomHour = lowerHour Then
                randomMinute = Int((59 - lowerMin + 1) * Rnd() + lowerMin)
                If randomMinute <= 9 Then
                    'obsTxt.Text &= ":0" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":0" & randomMinute
                Else
                    'obsTxt.Text &= ":" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":" & randomMinute
                End If
                ' adds a 0 before it if the random number is a single digit integer


                ' if the random hour chosen is same as lower hour, the min minutes is based on the inputted min
            Else
                randomMinute = Int(60 * Rnd())
                If randomMinute <= 9 Then
                    'obsTxt.Text &= ":0" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":0" & randomMinute
                Else
                    'obsTxt.Text &= ":" & randomMinute & vbNewLine
                    arrTime(i) &= randomHour & ":" & randomMinute
                End If
                ' adds a 0 before it if the random number is a single digit integer


                ' if the random hour chosen is not same as upper hour or lower hour, the calc works normally

            End If

        Next

        'obsTxt.Text &= " " & vbNewLine
        ' formula exists for testing purposes

        arrTime(reqTimes) = "xx:xx"
        ' dummy variable for future use
        Dim varHold As String
        ' variable that would hold strings temporarily
        Dim reorderCheck As Boolean = False

        For j = 1 To reqTimes + 1
            For i = 1 To reqTimes - 1
                Do Until reorderCheck = True
                    If arrTime(i) < arrTime(i - 1) Then
                        varHold = arrTime(i - 1)
                        arrTime(i - 1) = arrTime(i)
                        arrTime(i) = varHold
                    ElseIf arrTime(i) >= arrTime(i - 1) Then
                        reorderCheck = True
                    End If
                Loop
                reorderCheck = False
            Next
        Next
        ' arranges times according to chronological order
        ' checks whether the time before it occurs first and if it does, it rearranges then moves on
        ' it will only get rechecked once the calc goes through all array members

        Dim doublesTracker As Double
        Dim doublesCheck As Boolean = False
        ' checks for similar entries

        For i = 0 To reqTimes - 1
            If arrTime(i) = arrTime(i + 1) Then
                doublesCheck = True
                ' if a single instance of similar values is observed, boolean is triggered
            End If
        Next

        If doublesCheck = True Then
            For i = 0 To reqTimes - 1
                arrTime(i) = ""
            Next
            ' resets the values when doubles are observed
        End If


        If doublesCheck = True Then
            Do Until doublesCheck = False
                ' from this point on, same as above
                For i = 0 To reqTimes - 1

                    randomHour = Int((upperHour - lowerHour + 1) * Rnd() + lowerHour)
                    If randomHour <= 9 Then
                        arrTime(i) &= "0"
                    End If


                    If randomHour = upperHour Then
                        randomMinute = Int((upperMin + 1) * Rnd())
                        If randomMinute <= 9 Then
                            arrTime(i) &= randomHour & ":0" & randomMinute
                        Else
                            arrTime(i) &= randomHour & ":" & randomMinute
                        End If
                    ElseIf randomHour = lowerHour Then
                        randomMinute = Int((59 - lowerMin + 1) * Rnd() + lowerMin)
                        If randomMinute <= 9 Then
                            arrTime(i) &= randomHour & ":0" & randomMinute
                        Else
                            arrTime(i) &= randomHour & ":" & randomMinute
                        End If
                    Else
                        randomMinute = Int(60 * Rnd())
                        If randomMinute <= 9 Then
                            arrTime(i) &= randomHour & ":0" & randomMinute
                        Else
                            arrTime(i) &= randomHour & ":" & randomMinute
                        End If
                    End If

                Next

                For j = 1 To reqTimes + 1
                    For i = 1 To reqTimes - 1
                        Do Until reorderCheck = True
                            If arrTime(i) < arrTime(i - 1) Then
                                varHold = arrTime(i - 1)
                                arrTime(i - 1) = arrTime(i)
                                arrTime(i) = varHold
                            ElseIf arrTime(i) >= arrTime(i - 1) Then
                                reorderCheck = True
                            End If
                        Loop
                        reorderCheck = False
                    Next
                Next
                ' end of stuff that repeated from earlier

                For i = 0 To reqTimes - 1
                    If arrTime(i) <> arrTime(i + 1) Then
                        doublesTracker += 1
                    End If
                Next
                ' tracks the amount of non doubles
                If doublesTracker = reqTimes Then
                    doublesCheck = False
                End If
                ' if the amount of non doubles is equal to the required, everything is good now
            Loop
        End If
        ' if the calc finds it to be true, a new set is generated by doing everything all over again

        For i = 0 To reqTimes - 1
            obsTxt.Text &= arrTime(i) & vbNewLine
        Next
        ' plugs everything in the text box

    End Sub
End Class
