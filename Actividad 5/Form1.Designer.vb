<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Num1 = New TextBox()
        Num3 = New TextBox()
        Num2 = New TextBox()
        NumC = New TextBox()
        NumB = New TextBox()
        NumA = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Ordenar = New Button()
        borrar = New Button()
        salir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(52, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 21)
        Label1.TabIndex = 0
        Label1.Text = "Ordena 3 numeros de mayor a menor"
        ' 
        ' Num1
        ' 
        Num1.Location = New Point(57, 58)
        Num1.Name = "Num1"
        Num1.Size = New Size(66, 23)
        Num1.TabIndex = 1
        ' 
        ' Num3
        ' 
        Num3.Location = New Point(259, 58)
        Num3.Name = "Num3"
        Num3.Size = New Size(66, 23)
        Num3.TabIndex = 2
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(160, 58)
        Num2.Name = "Num2"
        Num2.Size = New Size(66, 23)
        Num2.TabIndex = 3
        ' 
        ' NumC
        ' 
        NumC.Location = New Point(259, 192)
        NumC.Name = "NumC"
        NumC.Size = New Size(66, 23)
        NumC.TabIndex = 4
        ' 
        ' NumB
        ' 
        NumB.Location = New Point(160, 192)
        NumB.Name = "NumB"
        NumB.Size = New Size(66, 23)
        NumB.TabIndex = 5
        ' 
        ' NumA
        ' 
        NumA.Location = New Point(57, 192)
        NumA.Name = "NumA"
        NumA.Size = New Size(66, 23)
        NumA.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(77, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 21)
        Label2.TabIndex = 7
        Label2.Text = "A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(181, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 21)
        Label3.TabIndex = 8
        Label3.Text = "B"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(282, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 21)
        Label4.TabIndex = 9
        Label4.Text = "C"
        ' 
        ' Ordenar
        ' 
        Ordenar.Location = New Point(57, 134)
        Ordenar.Name = "Ordenar"
        Ordenar.Size = New Size(75, 23)
        Ordenar.TabIndex = 10
        Ordenar.Text = "Ordenar"
        Ordenar.UseVisualStyleBackColor = True
        ' 
        ' borrar
        ' 
        borrar.Location = New Point(151, 134)
        borrar.Name = "borrar"
        borrar.Size = New Size(75, 23)
        borrar.TabIndex = 11
        borrar.Text = "Borrar"
        borrar.UseVisualStyleBackColor = True
        ' 
        ' salir
        ' 
        salir.Location = New Point(259, 134)
        salir.Name = "salir"
        salir.Size = New Size(75, 23)
        salir.TabIndex = 12
        salir.Text = "Salir"
        salir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 246)
        Controls.Add(salir)
        Controls.Add(borrar)
        Controls.Add(Ordenar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NumA)
        Controls.Add(NumB)
        Controls.Add(NumC)
        Controls.Add(Num2)
        Controls.Add(Num3)
        Controls.Add(Num1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num3 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents NumC As TextBox
    Friend WithEvents NumB As TextBox
    Friend WithEvents NumA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Ordenar As Button
    Friend WithEvents borrar As Button
    Friend WithEvents salir As Button
End Class
