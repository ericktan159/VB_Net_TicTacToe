Public Class Form1


    Dim turn As Boolean = True

    Dim symbol As String = ""
    Dim turn_count As Integer = 0
    Dim N As Integer = 9
    Dim N_Side As Integer = 3

    Dim Player_1 As String = "Player 1"
    Dim Player_2 As String = "Player 2"
    Dim Player_1_Score As Integer = 0
    Dim Player_2_Score As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiator()
    End Sub

    Private Sub eventBtnClick_TicTacToeBtns(sender As Object, e As EventArgs) Handles C3.Click, C2.Click, C1.Click, B3.Click, B2.Click, B1.Click, A3.Click, A2.Click, A1.Click
        Dim btn As Button = CType(sender, Button)

        If (turn) Then
            btn.Text = "X"
            symbol = "O"
        Else
            btn.Text = "O"
            symbol = "X"
        End If

        turn = Not turn
        playersTurnDisplay()
        btn.Enabled = False
        turn_count += 1
        gameResult()



    End Sub


    Private Sub initiator()
        player_1_Score_lbl.Text = Player_1 + " Score: " + Player_1_Score.ToString()
        player_2_Score_lbl.Text = Player_2 + " Score: " + Player_2_Score.ToString()


        symbol = "X"
        playersTurnLabel.Text = Player_1 + " : " + symbol

    End Sub

    Private Sub playersTurnDisplay()

        If (symbol = "X") Then
            playersTurnLabel.Text = Player_1 + " : " + symbol
        Else
            playersTurnLabel.Text = Player_2 + " : " + symbol
        End If

    End Sub

    Private Function isHorzontalMatch() As Boolean


        Dim isMatchTrue As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        i = 0
        While ((i < N_Side) And (Not isMatchTrue))
            j = 0
            While (j < N_Side)
                If ((myTicTacToeButtnsArray(i, 0).Text = myTicTacToeButtnsArray(i, 1).Text) And (myTicTacToeButtnsArray(i, 1).Text = myTicTacToeButtnsArray(i, 2).Text) And (Not myTicTacToeButtnsArray(i, 0).Enabled) And (Not myTicTacToeButtnsArray(i, 1).Enabled) And (Not myTicTacToeButtnsArray(i, 2).Enabled)) Then
                    myTicTacToeButtnsArray(i, j).BackColor = Color.Green
                    isMatchTrue = True
                Else
                    isMatchTrue = False
                End If
                j += 1
            End While
            i += 1
        End While

        Return isMatchTrue

    End Function


    Private Function isVerticalMatch() As Boolean
        Dim isMatchTrue As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        i = 0
        While ((i < N_Side) And (Not isMatchTrue))
            j = 0
            While (j < N_Side)
                If ((myTicTacToeButtnsArray(0, i).Text = myTicTacToeButtnsArray(1, i).Text) And (myTicTacToeButtnsArray(1, i).Text = myTicTacToeButtnsArray(2, i).Text) And (Not myTicTacToeButtnsArray(0, i).Enabled) And (Not myTicTacToeButtnsArray(1, i).Enabled) And (Not myTicTacToeButtnsArray(2, i).Enabled)) Then
                    myTicTacToeButtnsArray(j, i).BackColor = Color.Green
                    isMatchTrue = True
                Else
                    isMatchTrue = False
                End If
                j += 1
            End While
            i += 1
        End While

        Return isMatchTrue
    End Function


    Private Function isDiagonalMatch() As Boolean
        If ((myTicTacToeButtnsArray(0, 0).Text = myTicTacToeButtnsArray(1, 1).Text) And (myTicTacToeButtnsArray(1, 1).Text = myTicTacToeButtnsArray(2, 2).Text) And (Not myTicTacToeButtnsArray(0, 0).Enabled) And (Not myTicTacToeButtnsArray(1, 1).Enabled) And (Not myTicTacToeButtnsArray(2, 2).Enabled)) Then
            myTicTacToeButtnsArray(0, 0).BackColor = Color.Green
            myTicTacToeButtnsArray(1, 1).BackColor = Color.Green
            myTicTacToeButtnsArray(2, 2).BackColor = Color.Green
            Return True
        ElseIf ((myTicTacToeButtnsArray(0, 2).Text = myTicTacToeButtnsArray(1, 1).Text) And (myTicTacToeButtnsArray(1, 1).Text = myTicTacToeButtnsArray(2, 0).Text) And (Not myTicTacToeButtnsArray(0, 2).Enabled) And (Not myTicTacToeButtnsArray(1, 1).Enabled) And (Not myTicTacToeButtnsArray(2, 0).Enabled)) Then
            myTicTacToeButtnsArray(0, 2).BackColor = Color.Green
            myTicTacToeButtnsArray(1, 1).BackColor = Color.Green
            myTicTacToeButtnsArray(2, 0).BackColor = Color.Green
            Return True
        Else
            Return False
        End If

    End Function



    Private Sub gameResult()
        Dim isThereAWinner As Boolean = False


        If ((isHorzontalMatch()) Or isVerticalMatch() Or isDiagonalMatch()) Then
            isThereAWinner = True
        Else
            isThereAWinner = False
        End If




        If (isThereAWinner) Then
            disableAllBtns()

            Dim winner As String = ""
            If (turn) Then
                winner = "O"
                playersTurnLabel.Text = Player_2 + "Wins!"
                Player_2_Score += 1
            Else
                winner = "X"
                playersTurnLabel.Text = Player_1 + "Wins!"
                Player_1_Score += 1
            End If
            MessageBox.Show(winner + " Wins!", "Result")

        Else

            If (turn_count = N) Then
                playersTurnLabel.Text = "Draw!"
                MessageBox.Show("Draw!", "Result")
            End If

        End If

        player_1_Score_lbl.Text = Player_1 + " Score: " + Player_1_Score.ToString()
        player_2_Score_lbl.Text = Player_2 + " Score: " + Player_2_Score.ToString()

    End Sub

    Private Sub disableAllBtns()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To (N_Side - 1)
            For j = 0 To (N_Side - 1)
                myTicTacToeButtnsArray(i, j).Enabled = False

            Next
        Next

    End Sub



    Private Function myTicTacToeButtnsArray(i As Integer, j As Integer) As Button

        If ((i = 0) And (j = 0)) Then
            Return A1
        ElseIf ((i = 0) And (j = 1)) Then
            Return A2
        ElseIf ((i = 0) And (j = 2)) Then
            Return A3
        ElseIf ((i = 1) And (j = 0)) Then
            Return B1
        ElseIf ((i = 1) And (j = 1)) Then
            Return B2
        ElseIf ((i = 1) And (j = 2)) Then
            Return B3
        ElseIf ((i = 2) And (j = 0)) Then
            Return C1
        ElseIf ((i = 2) And (j = 1)) Then
            Return C2
        Else 'If ((i = 0) And (j = 2))
            Return C3
        End If



    End Function

    Private Sub event_MenuStrpClick_NewGame(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        turn = True
        turn_count = 0

        Dim i As Integer
        Dim j As Integer

        For i = 0 To (N_Side - 1)
            For j = 0 To (N_Side - 1)
                myTicTacToeButtnsArray(i, j).Enabled = True
                myTicTacToeButtnsArray(i, j).BackColor = Color.White
                myTicTacToeButtnsArray(i, j).Text = ""
            Next
        Next
        initiator()

    End Sub

    Private Sub event_MenuStrpClick_Exit(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub event_MenuStrpClick_About(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("By Tan, Frederick B. ", "Tic Tac Toe About")
    End Sub
End Class
