Public Class Form1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rad_distrito_nao.CheckedChanged
        CalcularAvenca()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_distrito_sim.CheckedChanged
        CalcularAvenca()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agravamento.CheckedChanged
        CalcularAvenca()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_desc_socio.CheckedChanged
        CalcularAvenca()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_escalao.CheckedChanged
        CalcularAvenca()
    End Sub

    Private Sub txt_ano_TextChanged(sender As Object, e As EventArgs) Handles txt_ano.TextChanged
        CalcularAvenca()
    End Sub


    Private Sub CalcularAvenca()
        Dim ano As Integer
        Dim desc_idade As Integer
        Dim valor_base As Double
        Dim desc_escalao As Double
        Dim desc_socio As Double
        Dim valor_agrav As Double
        Dim desc_concelho As Double
        Dim desc_distrito As Double

        Integer.TryParse(txt_ano.Text, ano)
        Double.TryParse(txt_valor_base.Text, valor_base)


        If chk_escalao.Checked Then
            desc_escalao = 0.1
        Else
            desc_escalao = 0.0
        End If

        If chk_desc_socio.Checked Then
            desc_socio = 0.05
        Else
            desc_socio = 0.0
        End If

        If chk_agravamento.Checked Then
            valor_agrav = 12.0
        Else
            valor_agrav = 0.0
        End If

        If cmb_concelho.Text = "Amares" Then
            desc_concelho = 0.2
        Else
            desc_concelho = 0.0
        End If

        If rad_distrito_sim.Checked Then
            desc_distrito = 0.01
        Else
            desc_distrito = 0.0
        End If

        If ano >= 2000 Then
            desc_idade = 0.1
        Else
            desc_idade = 0.0
        End If


        Dim result As Double
        result = valor_base * (1 - desc_escalao) * (1 - desc_socio) * (1 - desc_concelho)
        result = result * (1 - desc_distrito) * (1 - desc_idade)

        result += valor_agrav

        lbl_resultado.Text = result.ToString()
    End Sub

    Private Sub txt_valor_base_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_base.TextChanged
        CalcularAvenca()
    End Sub

    Private Sub cmb_concelho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_concelho.SelectedIndexChanged
        CalcularAvenca()
    End Sub
End Class
