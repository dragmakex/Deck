Public Class Form1
    Dim arrcards(52) As String
    Dim card As String
    Dim temp1 As String
    Dim path As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdFill_Click(sender As Object, e As EventArgs) Handles cmdFill.Click

        Dim i As Integer
        Dim j As Integer


        For i = 1 To 4

            For j = 1 To 13
                card = ""

                If j = 1 Then
                    card = card + "A"
                ElseIf j = 10 Then
                    card = card + "T"
                ElseIf j = 11 Then
                    card = card + "J"
                ElseIf j = 12 Then
                    card = card + "Q"
                ElseIf j = 13 Then
                    card = card + "K"
                Else
                    card = card + Str(j)
                End If

                If i = 1 Then
                    card = card + "C"
                    arrcards(j) = Trim(card)
                ElseIf i = 2 Then
                    card = card + "D"
                    arrcards(j + 13) = Trim(card)
                ElseIf i = 3 Then
                    card = card + "H"
                    arrcards(j + 26) = Trim(card)
                ElseIf i = 4 Then
                    card = card + "S"
                    arrcards(j + 39) = Trim(card)
                End If
            Next j
        Next i

        For i = 1 To 52
            lstDeck.Items.Add(arrcards(i))
        Next

        path = lstDeck.SelectedItem

        piccard.ImageLocation = "D:\Locker\Files\Projects\Computer Programming 2\cardimages\" + path + ".gif"

    End Sub

    Private Sub cmdShuffle_Click(sender As Object, e As EventArgs) Handles cmdShuffle.Click
        Dim rnum As Integer


        For I = 1 To 52
            rnum = Int(Rnd() * 52) + 1
            Temp1 = arrCards(I)
            arrCards(I) = arrCards(rnum)
            arrCards(rnum) = Temp1
        Next I
        lstDeck.Items.Clear()
        For i = 1 To 52

            lstDeck.Items.Add(UCase(arrcards(i)))
        Next
    End Sub

    Private Sub lstDeck_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDeck.SelectedIndexChanged
        path = lstDeck.SelectedItem
        piccard.ImageLocation = "D:\Locker\Files\Projects\Computer Programming 2\Card Images\cardimages\" + path + ".gif"
    End Sub
End Class
