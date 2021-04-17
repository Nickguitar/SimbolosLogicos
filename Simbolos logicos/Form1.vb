Imports System.Runtime.InteropServices
Imports IWshRuntimeLibrary
Imports System.Diagnostics

Public Class Form1

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function


    Public Shared Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Integer
    End Function
    ' Public path As String = "C:\Users\Nick\Documents\dict.txt"
    Const KeyDownBit As Integer = &H8000

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(Keys.F9)) Then
            If Me.Visible Then
                Me.Hide()
            Else
                Me.Show()
            End If
        End If


        '  If (GetAsyncKeyState(Keys.NumPad3)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad3)) Then
            SendKeys.Send("Ǝ")
        End If
        ' End If
        ' If (GetAsyncKeyState(Keys.NumPad4)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad4)) Then
            SendKeys.Send("∀")
        End If
        ' End If

        ' If (GetAsyncKeyState(Keys.NumPad7)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad7)) Then
            SendKeys.Send("∨")
        End If
        'End If
        'If (GetAsyncKeyState(Keys.NumPad8)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad8)) Then
            SendKeys.Send("∧")
        End If
        ' End If
        ' If (GetAsyncKeyState(Keys.NumPad9)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad9)) Then
            SendKeys.Send("ϕ")
        End If
        'End If
        'If (GetAsyncKeyState(Keys.NumPad5)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad5)) Then
            SendKeys.Send("↔")
        End If
        'End If
        'If (GetAsyncKeyState(Keys.NumPad6)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad6)) Then
            SendKeys.Send("⊃")
        End If
        'End If
        'If (GetAsyncKeyState(Keys.NumPad1)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad1)) Then
            SendKeys.Send("□")
        End If
        ' End If
        'If (GetAsyncKeyState(Keys.NumPad2)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad2)) Then
            SendKeys.Send("◊")
        End If
        ' End If
        'If (GetAsyncKeyState(Keys.NumPad0)) Then
        If (GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(Keys.LMenu) And GetAsyncKeyState(Keys.NumPad0)) Then
            SendKeys.Send("∴")
        End If
        '  End If

        ' Dim dict As Array = Split(My.Computer.FileSystem.ReadAllText(path), "#|#" & vbNewLine)
        ' Button42.Text = "Adicionar entrada (" + dict.Length.ToString + ")"
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\forall")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∀")
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\exists")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∃")
        End If
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\alpha")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("α")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\leftrightarrow")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("↔")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\rightarrow")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("→")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\supset")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊃")
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\wedge")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∧")
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\or")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∨")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\vDash")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊨")
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\oplus")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊕")
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\veebar")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊻")
        End If
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\square")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("□")
        End If
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\Diamond")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("◇")
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\nvdash")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊬")
        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\vdash")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊢")
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\varnothing")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∅")
        End If
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\beta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("β")
        End If
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\gamma")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("γ")
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\delta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("δ")
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\varepsilon")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ε")
        End If
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\neq")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("≠")
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\notin")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∉")
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\in")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∈")
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\bot")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊥")
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\therefore")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∴")
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        'Dim dict As Array = Split(My.Computer.FileSystem.ReadAllText(path), "#|#" & vbNewLine)
        'For Each item In dict
        'Dim termo As Array = Split(item, "|#|")
        ' If termo(0).ToString.Count > 5 Then
        ' ListBox1.Items.Add(UppercaseFirstLetter(termo(0)))
        ' End If
        '  Next
        'Button42.Text = "Adicionar entrada (" + dict.Length.ToString + ")"

        'Dim array As Array = Split(My.Settings.Palavras, "#|#")
        'For Each item As String In array
        '    Dim add = True
        '    Dim termo = Split(item, "|#|")
        '    If termo(0) <> "" Then
        '        Dim del As Array = Split(My.Settings.Deletados, "###")
        '        For Each deletado As String In del
        '            If Form1.UppercaseFirstLetter(deletado) = Form1.UppercaseFirstLetter(termo(0)) Then
        '                add = False
        '            End If
        '        Next
        '        If add Then
        '            ListBox1.Items.Add(Form1.UppercaseFirstLetter(termo(0)))
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\zeta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ζ")
        End If
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\eta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("η")
        End If
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\theta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("θ")
        End If
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\mu")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("μ")
        End If
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\pi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("π")
        End If
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\omega")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ω")
        End If
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\psi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ψ")
        End If
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\varphi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("φ")
        End If
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\sigma")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("σ")
        End If
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\rho")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ρ")
        End If
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\xi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ξ")
        End If
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\lambda")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("λ")
        End If
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\kappa")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("κ")
        End If
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\Delta")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("Δ")
        End If
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\Gamma")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("Γ")
        End If
    End Sub
    Dim i = False

    Public variavel As String = ""




    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        '

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\phi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ϕ")
        End If
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\varpsi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ψ")
        End If
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\Omega")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("Ω")
        End If
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\Sigma")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("Σ")
        End If
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        '

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\iota")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("ι")
        End If
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        'ƒ
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("ƒ")

    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("∗")
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\equiv")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("≡")
        End If
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\chi")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("χ")
        End If
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click

        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("·")
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("x̂")
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("ŷ")
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("ẑ")
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("ɸ̂")
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("ᗡ")
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("Ř")
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("β̂")
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\subset")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊂")
        End If
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("⥽")
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\subsetdot")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⪽")
        End If
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        SendKeys.Send("%{TAB}")
        System.Threading.Thread.Sleep(200)
        If CheckBox1.Checked Then
            SendKeys.Send("\supset")
        Else
            SendKeys.Send("⊃")
        End If
    End Sub


    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\nvDash")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊭")
        End If
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\cap")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∩")
        End If

    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\cup")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("∪")
        End If
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click

        If CheckBox1.Checked Then
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("\subseteq")
        Else
            SendKeys.Send("%{TAB}")
            System.Threading.Thread.Sleep(200)
            SendKeys.Send("⊆")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://youtube.com/ÉLógicoPô")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.Click
        Process.Start("http://youtube.com/ÉLógicoPô")
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub



#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.DarkGray
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.DarkGray
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    Private Sub Label4_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    Private Sub Panel1_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.ForeColor = Color.Green
        Else
            CheckBox1.ForeColor = Color.DarkGray
        End If
    End Sub


#End Region




End Class
