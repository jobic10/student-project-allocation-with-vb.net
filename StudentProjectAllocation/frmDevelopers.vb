
Public Class frmDevelopers
    Private Sub frmDevelopers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Segun As Member = New Member("Olaniyi Segun Samuel", "15/52HA004")
        Dim Presh As Member = New Member("Olaniyi Segun Samuel", "15/52HA026")
        Dim Dara As Member = New Member("Olaniyi Segun Samuel", "15/52HA074")
        Dim Ola As Member = New Member("Olaoye Kolwawole Olaoye", "16/30GD089")
        Dim Tes As Member = New Member("Ijaiya Tesleemat", "16/30GB070")

        Dim Sofiat As Member = New Member("Musa", "17/52HA123")
        Dim Kayode As Member = New Member("Olaniyi Segun Samuel", "17/52HA124")
        Dim Wale As Member = New Member("Olawale Hammed Wale", "17/52HA125")
        Dim Oseni As Member = New Member("Oseni Kehinde Adeniyi", "17/52HA126")
        Dim Job As Member = New Member("Olaniyi Segun Samuel", "17/52HA127")
        Dim Members() As Member = {Segun, Presh, Dara, Ola, Tes, Sofiat, Kayode, Wale, Oseni, Job}
        '{"Please wait ", "Please wait  . ", "Please wait  .. ", "Please wait  ... ", "System is being initialized", "Program files are being loaded", "Almost done"}

    End Sub
End Class