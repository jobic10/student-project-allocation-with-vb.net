
Public Class frmDevelopers
    Private Sub frmDevelopers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Kayode As Member = New Member("Adegoke Kayode", "15/52HA004")
        Dim Presh As Member = New Member("Olaniyi Segun Samuel", "15/52HA026")
        Dim Dara As Member = New Member("Olaniyi Segun Samuel", "15/52HA074")
        Dim Ola As Member = New Member("Olaoye Kolwawole Olaoye", "16/30GD089")
        Dim Tes As Member = New Member("Ijaiya Tesleemat", "16/30GB070")

        Dim Sofiat As Member = New Member("Musa Sofiat Titilayo", "17/52HA123")
        Dim Segun As Member = New Member("Olaniyi Segun Samuel", "17/52HA124")
        Dim Wale As Member = New Member("Olawale Hammed Wale", "17/52HA125")
        Dim Oseni As Member = New Member("Oseni Kehinde Adeniyi", "17/52HA126")
        Dim Job As Member = New Member("Owonubi Job Sunday", "17/52HA127")
        Dim Members() As Member = {Segun, Presh, Dara, Ola, Tes, Sofiat, Kayode, Wale, Oseni, Job}

        GroupBox1.Text = Members(0).FullName
        GroupBox2.Text = Members(1).FullName
        GroupBox3.Text = Members(2).FullName
        GroupBox4.Text = Members(3).FullName
        GroupBox5.Text = Members(4).FullName
        GroupBox6.Text = Members(5).FullName
        GroupBox7.Text = Members(6).FullName
        GroupBox8.Text = Members(7).FullName
        GroupBox9.Text = Members(8).FullName
        GroupBox10.Text = Members(9).FullName

        PictureBox1.Image = My.Resources.ResourceManager.GetObject(Members(0).Photo)
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(Members(1).Photo)
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(Members(2).Photo)
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(Members(3).Photo)
        PictureBox5.Image = My.Resources.ResourceManager.GetObject(Members(4).Photo)
        PictureBox6.Image = My.Resources.ResourceManager.GetObject(Members(5).Photo)
        PictureBox7.Image = My.Resources.ResourceManager.GetObject(Members(6).Photo)
        PictureBox8.Image = My.Resources.ResourceManager.GetObject(Members(7).Photo)
        PictureBox9.Image = My.Resources.ResourceManager.GetObject(Members(8).Photo)
        PictureBox10.Image = My.Resources.ResourceManager.GetObject(Members(9).Photo)

    End Sub
End Class