' Programmer: Eric Patrick

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstLanguage.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Do you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub TranslateFrench()
        Select Case True
            Case radMother.Checked
                lblTranslation.Text = "Frenchmom"
            Case radFather.Checked
                lblTranslation.Text = "Frenchdad"
            Case radSister.Checked
                lblTranslation.Text = "Frenchsis"
            Case radBrother.Checked
                lblTranslation.Text = "Frenchbro"
        End Select
    End Sub

    Private Sub TranslateItalian()
        Select Case True
            Case radMother.Checked
                lblTranslation.Text = "Italianmom"
            Case radFather.Checked
                lblTranslation.Text = "Italiandad"
            Case radSister.Checked
                lblTranslation.Text = "Italiansis"
            Case radBrother.Checked
                lblTranslation.Text = "Italianbro"
        End Select
    End Sub

    Private Sub TranslateSpanish()
        Select Case True
            Case radMother.Checked
                lblTranslation.Text = "Spanishmom"
            Case radFather.Checked
                lblTranslation.Text = "Spanishdad"
            Case radSister.Checked
                lblTranslation.Text = "Spanishsis"
            Case radBrother.Checked
                lblTranslation.Text = "Spanishbro"
        End Select
    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Select Case True
            Case lstLanguage.SelectedIndex = 0
                TranslateFrench()
            Case lstLanguage.SelectedIndex = 1
                TranslateItalian()
            Case lstLanguage.SelectedIndex = 2
                TranslateSpanish()
        End Select
    End Sub

    Private Sub ThingsChanged(sender As Object, e As EventArgs) Handles radMother.CheckedChanged, radBrother.CheckedChanged, radFather.CheckedChanged, radSister.CheckedChanged, lstLanguage.SelectedIndexChanged
        lblTranslation.Text = String.Empty
    End Sub

End Class
