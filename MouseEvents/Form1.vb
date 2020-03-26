Imports System.Threading

Public Class Form1
    Declare Auto Sub mouse_event Lib "user32" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As IntPtr)


    Const MOUSEEVENTF_MOVE As Int32 = &H1 '  mouse move
    Const MOUSEEVENTF_LEFTDOWN As Int32 = &H2 '  left button down
    Const MOUSEEVENTF_LEFTUP As Int32 = &H4 '  left button up
    Const MOUSEEVENTF_RIGHTDOWN As Int32 = &H8 '  right button down
    Const MOUSEEVENTF_RIGHTUP As Int32 = &H10 '  right button up
    Const MOUSEEVENTF_MIDDLEDOWN As Int32 = &H20 '  middle button down
    Const MOUSEEVENTF_MIDDLEUP As Int32 = &H40 '  middle button up
    Const MOUSEEVENTF_ABSOLUTE As Int32 = &H8000 '  absolute move
    Const MOUSEEVENTF_WHEEL As Int32 = &H800 ' wheel button rolled

    '在（10，10）模拟鼠标左键按下
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 100
            Dim dest_x As Single
            Dim dest_y As Single
            dest_x = 73 * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
            dest_y = 519 * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 1863, 23472, 0, 0)

            'mouse_event(MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 73, 519, 0, 0)
            Thread.Sleep(5)
            'mouse_event(MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 2368, 1080, 0, 0)
            dest_x = 2368 * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
            dest_y = 1080 * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
            mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP + MOUSEEVENTF_RIGHTDOWN + MOUSEEVENTF_RIGHTUP, 60497, 48866, 0, 0)
        Next


    End Sub

    '    在自动化测试的开发中，有一些控件的ID是很难找到的，所以有些时候，我们直接设置鼠标的位置，然后是用click事件，会收到很好的效果。在Windows API中有个mouse_event函数为我们准备好了这一切。 
    '这个函数在user32.dll这个库文件里面。我们可以在C:\WINDOWS\system32（XP系统）这个目录下找到这个文件，他是系统自带的。 我们以C#直接调用这个文件中的API为例子来说下怎么进行鼠标操作，首先在我们C#中声明引用，如果是一个基于From的程序，这个声明的位置写在你的From class就可以了 
    ' [System.Runtime.InteropServices.DllImport("user32")] 
    ' Private Static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    '参数 意义
    'dwFlags Long，下表中标志之一或它们的组合 
    'dx，dy Long，根据MOUSEEVENTF_ABSOLUTE标志，指定x，y方向的绝对位置或相对位置 
    'cButtons Long，没有使用 
    'dwExtraInfo Long，没有使用

    'dwFlags常数 意义

    '    Const int MOUSEEVENTF_MOVE = 0x0001;      移动鼠标 
    'Const int MOUSEEVENTF_LEFTDOWN = 0x0002; 模拟鼠标左键按下 
    'Const int MOUSEEVENTF_LEFTUP = 0x0004; 模拟鼠标左键抬起 
    'Const int MOUSEEVENTF_RIGHTDOWN = 0x0008; 模拟鼠标右键按下 
    'Const int MOUSEEVENTF_RIGHTUP = 0x0010; 模拟鼠标右键抬起 
    'Const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; 模拟鼠标中键按下 
    'Const int MOUSEEVENTF_MIDDLEUP = 0x0040; 模拟鼠标中键抬起 
    'Const int MOUSEEVENTF_ABSOLUTE = 0x8000; 标示是否采用绝对坐标

    '程序中我们直接调用mouse_event函数就可以了 
    'mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, 500, 500, 0, 0);

    '1、这里是鼠标左键按下和松开两个事件的组合即一次单击： 
    'mouse_event (MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 )

    'vb用法

    'mouse_event MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, 0, 0, 0, 0

    '2、模拟鼠标右键单击事件： 
    'mouse_event (MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0 )

    'VB用法

    'mouse_event MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0

    '3、两次连续的鼠标左键单击事件 构成一次鼠标双击事件： 
    'mouse_event (MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 )
    ' mouse_event (MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 )

    '4、使用绝对坐标 
    'MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, 500, 500, 0, 0

    '需要说明的是，如果没有使用MOUSEEVENTF_ABSOLUTE，函数默认的是相对于鼠标当前位置的点，如果dx，和dy，用0，0表示，这函数认为是当前鼠标所在的点。

    '５、直接设定绝对坐标并单击
    'mouse_event(MOUSEEVENTF_LEFTDOWN, X * 65536 / 1024, Y * 65536 / 768, 0, 0); 
    ' mouse_event(MOUSEEVENTF_LEFTUP, X * 65536 / 1024, Y * 65536 / 768, 0, 0); 
    '其中X，Y分别是你要点击的点的横坐标和纵坐标





    ' Simulate moving the mouse to the center of the
    ' PictureBox and clicking.
    Private Sub cmdClick_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClick.Click
        Dim cur_x As Single
        Dim cur_y As Single
        Dim dest_x As Single
        Dim dest_y As Single

        ' mouse_event moves in a coordinate system where
        ' (0, 0) is in the upper left corner and
        ' (65535,65535) is in the lower right corner.

        ' Get the current mouse coordinates and convert
        ' them into this new system.
        cur_x = System.Windows.Forms.Cursor.Position.X * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        cur_y = System.Windows.Forms.Cursor.Position.Y * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

        ' Convert the coordinates of the center of the
        ' picClicker PictureBox into this new system.
        Dim pt As Point = picClicker.PointToScreen(New Point(picClicker.ClientRectangle.Width / 2, picClicker.ClientRectangle.Height / 2))

        dest_x = pt.X * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        dest_y = pt.Y * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

        txtResults.Text = txtResults.Text & "From " & System.Windows.Forms.Cursor.Position.X & " " & System.Windows.Forms.Cursor.Position.Y & " to " & pt.X & " " & pt.Y & vbCrLf
        txtResults.Text = txtResults.Text & "From " & cur_x & " " & cur_y & " to " & dest_x & " " & dest_y & vbCrLf

        ' Move the mouse to its final destination and click it.
        mouse_event(MOUSEEVENTF_ABSOLUTE + MOUSEEVENTF_MOVE + MOUSEEVENTF_LEFTDOWN + MOUSEEVENTF_LEFTUP, dest_x, dest_y, 0, 0)
    End Sub

    Private Sub picClicker_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picClicker.Click
        txtResults.Text = txtResults.Text & "MouseClick" & vbCrLf
    End Sub

    Private Sub picClicker_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClicker.MouseDown
        txtResults.Text = txtResults.Text & "MouseDown (" & e.X & ", " & e.Y & ")" & vbCrLf
    End Sub

    Private Sub picClicker_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClicker.MouseUp
        txtResults.Text = txtResults.Text & "MouseUp (" & e.X & ", " & e.Y & ")" & vbCrLf
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim cur_x As Single
        Dim cur_y As Single



        ' mouse_event moves in a coordinate system where
        ' (0, 0) is in the upper left corner and
        ' (65535,65535) is in the lower right corner.

        ' Get the current mouse coordinates and convert
        ' them into this new system.
        cur_x = System.Windows.Forms.Cursor.Position.X * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        cur_y = System.Windows.Forms.Cursor.Position.Y * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        LabelX.Text = cur_x.ToString
        LabelY.Text = cur_y.ToString

    End Sub
















    '    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long


    '    Private Const WM_KEYDOWN = &H100 '按下

    '    Private Const WM_KEYUP = &H101 '释放

    '    Private Const Key_Alt = 18   'Alt按键的值


    '    Private Sub Alt(hwnd As Long)  'hwnd为指定窗口的句柄

    '        Call SendMessage(hwnd, WM_KEYDOWN, Key_Alt, 0&)

    '    End Sub


    '    Private Sub Form_Click()   '单击窗体就模拟ALT键按下

    '        Call Alt(Me.hwnd)

    '    End Sub


    '    Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)  '如果按下ALT键，则输出如下内容

    '        If KeyCode = Key_Alt Then Print "ALT键按下"

    'End Sub


    '    '接下来来研究下模拟鼠标

    '    '模拟鼠标的常数整理，如下

    '    'WM_MOUSEFIRST 0x0200 //移动鼠标时发生

    '    'WM_MOUSEMOVE 0x0200 //移动鼠标时发生，同WM_MOUSEFIRST

    '    'WM_LBUTTONDOWN 0x0201 //按下鼠标左键

    '    'WM_LBUTTONUP 0x0202 //释放鼠标左键

    '    'WM_LBUTTONDBLCLK 0x0203 //双击鼠标左键

    '    'WM_RBUTTONDOWN 0x0204 //按下鼠标右键

    '    'WM_RBUTTONUP 0x0205 //释放鼠标右键

    '    'WM_RBUTTONDBLCLK 0x0206 //双击鼠标右键

    '    'WM_MBUTTONDOWN 0x0207 //按下鼠标中键

    '    'WM_MBUTTONUP 0x0208 //释放鼠标中键

    '    'WM_MBUTTONDBLCLK 0x0209 //双击鼠标中键

    '    '再看下参数，模拟鼠标时wParam应设为0了，而lParam应该为实际参数


    '    '下面是在按下按钮时用sendmessage画点的实例：

    '    '首先当然是新建一个窗体，画一个按钮（最好画到右下角），并输入以下代码

    '    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As VariantType) As Long


    '    Private Const WM_LBUTTONDOWN = &H201  '按下鼠标左键

    '    Private Const WM_LBUTTONUP = &H202    '释放鼠标左键


    '    Private Structure POINTAPI

    '        Dim X As Long

    '        Dim Y As Long

    '    End Structure





    '    'Private Sub Form_Load()

    '    '    DrawWidth = 3     '设置输出的线宽

    '    '    Me.ScaleMode = vbPixels   '以像素为单位，因为windows坐标通常以像素为单位的

    '    'End Sub


    '    Private Function GetPoint_long(P As POINTAPI) As Long  '由于sendmessage的坐标参数不是以XY直接带入的，需要特殊的计算，以下就是算法

    '        GetPoint_long = P.X + P.Y * 65536

    '    End Function


    '    Private Sub Click(hwnd As Long, X As Long, Y As Long)    '模拟单击

    '        Dim p1 As POINTAPI

    '        Dim p2 As Long  '用于储存计算后的坐标

    '        p1.X = X

    '        p1.Y = Y

    '        p2 = GetPoint_long(p1)


    '        Call SendMessage(hwnd, WM_LBUTTONDOWN, 0, p2)

    '        Call SendMessage(hwnd, WM_LBUTTONUP, 0, p2)

    '    End Sub


    '    'Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single) '如果是左键单击的话，就在指定画个点

    '    '    If Button = 1 Then Me.PSet(X, Y)

    '    'End Sub

End Class
