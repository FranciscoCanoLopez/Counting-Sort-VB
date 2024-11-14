Imports System.Reflection.Emit

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
        components = New ComponentModel.Container()
        txtInput = New System.Windows.Forms.TextBox()
        lblValues = New System.Windows.Forms.Label()
        btnSort = New System.Windows.Forms.Button()
        Timer = New System.Windows.Forms.Timer(components)
        dgvOutput = New System.Windows.Forms.DataGridView()
        dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        lblTimeElapsed = New System.Windows.Forms.Label()
        cBOrden = New System.Windows.Forms.ComboBox()
        label1 = New System.Windows.Forms.Label()
        CType(dgvOutput, ComponentModel.ISupportInitialize).BeginInit()
        MyBase.SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Drawing.Font("Segoe UI", 15.0F)
        txtInput.Location = New Drawing.Point(12, 38)
        txtInput.Name = "txtInput"
        txtInput.Size = New Drawing.Size(521, 41)
        txtInput.TabIndex = 0
        ' 
        ' lblValues
        ' 
        lblValues.AutoSize = True
        lblValues.Location = New Drawing.Point(12, 9)
        lblValues.Name = "lblValues"
        lblValues.Size = New Drawing.Size(51, 20)
        lblValues.TabIndex = 1
        lblValues.Text = "Values"
        ' 
        ' btnSort
        ' 
        btnSort.Location = New Drawing.Point(199, 85)
        btnSort.Name = "btnSort"
        btnSort.Size = New Drawing.Size(94, 29)
        btnSort.TabIndex = 2
        btnSort.Text = "Sort"
        btnSort.UseVisualStyleBackColor = True
        AddHandler btnSort.Click, AddressOf Me.btnSort_Click
        ' 
        ' timer
        ' 
        Timer.Interval = 500
        AddHandler Timer.Tick, AddressOf Me.timer_Tick
        ' 
        ' dgvOutput
        ' 
        dgvOutput.AllowUserToAddRows = False
        dgvOutput.AllowUserToDeleteRows = False
        dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOutput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {dataGridViewTextBoxColumn1})
        dgvOutput.EnableHeadersVisualStyles = False
        dgvOutput.Location = New Drawing.Point(12, 120)
        dgvOutput.Name = "dgvOutput"
        dgvOutput.RowHeadersWidth = 51
        dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvOutput.Size = New Drawing.Size(809, 396)
        dgvOutput.TabIndex = 300
        ' 
        ' dataGridViewTextBoxColumn1
        ' 
        dataGridViewTextBoxColumn1.MinimumWidth = 6
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        dataGridViewTextBoxColumn1.Width = 125
        ' 
        ' lblTimeElapsed
        ' 
        lblTimeElapsed.AutoSize = True
        lblTimeElapsed.Location = New Drawing.Point(536, 89)
        lblTimeElapsed.Name = "lblTimeElapsed"
        lblTimeElapsed.Size = New Drawing.Size(179, 20)
        lblTimeElapsed.TabIndex = 301
        lblTimeElapsed.Text = "Tiempo de ordenamiento"
        ' 
        ' cBOrden
        ' 
        cBOrden.FormattingEnabled = True
        cBOrden.Location = New Drawing.Point(564, 43)
        cBOrden.Name = "cBOrden"
        cBOrden.Size = New Drawing.Size(151, 28)
        cBOrden.TabIndex = 302
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Drawing.Point(564, 9)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(50, 20)
        label1.TabIndex = 303
        label1.Text = "Orden"
        ' 
        ' Form1
        ' 
        MyBase.AutoScaleDimensions = New Drawing.SizeF(8.0F, 20.0F)
        MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        MyBase.ClientSize = New Drawing.Size(833, 528)
        MyBase.Controls.Add(label1)
        MyBase.Controls.Add(cBOrden)
        MyBase.Controls.Add(lblTimeElapsed)
        MyBase.Controls.Add(dgvOutput)
        MyBase.Controls.Add(btnSort)
        MyBase.Controls.Add(lblValues)
        MyBase.Controls.Add(txtInput)
        MyBase.Name = "Form1"
        MyBase.Text = "Counting Sort"
        CType(dgvOutput, ComponentModel.ISupportInitialize).EndInit()
        MyBase.ResumeLayout(False)
        MyBase.PerformLayout()
    End Sub
    Private txtInput As System.Windows.Forms.TextBox
    Private lblValues As System.Windows.Forms.Label
    Private btnSort As System.Windows.Forms.Button
    Private timer As System.Windows.Forms.Timer
    Private dgvOutput As System.Windows.Forms.DataGridView
    Private dataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private lblTimeElapsed As System.Windows.Forms.Label
    Private cBOrden As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label

End Class
