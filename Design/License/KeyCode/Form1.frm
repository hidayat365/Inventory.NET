VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FFC0FF&
   Caption         =   "Keycode Demo - Create"
   ClientHeight    =   4515
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6195
   LinkTopic       =   "Form1"
   ScaleHeight     =   4515
   ScaleWidth      =   6195
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton BtnChk 
      Caption         =   "Check Key..."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   40
      Top             =   4080
      Width           =   5775
   End
   Begin VB.TextBox KeyCode 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   38
      Top             =   3600
      Width           =   4815
   End
   Begin VB.CheckBox Check16 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4440
      TabIndex        =   17
      Top             =   2880
      Width           =   255
   End
   Begin VB.CheckBox Check15 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4440
      TabIndex        =   16
      Top             =   2520
      Width           =   255
   End
   Begin VB.CheckBox Check14 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4440
      TabIndex        =   15
      Top             =   2160
      Width           =   255
   End
   Begin VB.CheckBox Check13 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4440
      TabIndex        =   14
      Top             =   1800
      Width           =   255
   End
   Begin VB.CheckBox Check12 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3120
      TabIndex        =   13
      Top             =   2880
      Width           =   255
   End
   Begin VB.CheckBox Check11 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3120
      TabIndex        =   12
      Top             =   2520
      Width           =   255
   End
   Begin VB.CheckBox Check10 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3120
      TabIndex        =   11
      Top             =   2160
      Width           =   255
   End
   Begin VB.CheckBox Check9 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3120
      TabIndex        =   10
      Top             =   1800
      Width           =   255
   End
   Begin VB.CheckBox Check8 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   1920
      TabIndex        =   9
      Top             =   2880
      Width           =   255
   End
   Begin VB.CheckBox Check7 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   1920
      TabIndex        =   8
      Top             =   2520
      Width           =   255
   End
   Begin VB.CheckBox Check6 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   1920
      TabIndex        =   7
      Top             =   2160
      Width           =   255
   End
   Begin VB.CheckBox Check5 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   1920
      TabIndex        =   6
      Top             =   1800
      Width           =   255
   End
   Begin VB.CheckBox Check4 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   600
      TabIndex        =   5
      Top             =   2880
      Width           =   255
   End
   Begin VB.CheckBox Check3 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   600
      TabIndex        =   4
      Top             =   2520
      Width           =   255
   End
   Begin VB.CheckBox Check2 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   600
      TabIndex        =   3
      Top             =   2160
      Width           =   255
   End
   Begin VB.CheckBox Check1 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Check1"
      Height          =   255
      Left            =   600
      TabIndex        =   2
      Top             =   1800
      Width           =   255
   End
   Begin VB.TextBox ProdName 
      Height          =   285
      Left            =   1080
      TabIndex        =   1
      Top             =   840
      Width           =   2775
   End
   Begin VB.TextBox UserName 
      Height          =   285
      Left            =   1080
      TabIndex        =   0
      Top             =   480
      Width           =   2775
   End
   Begin VB.Label Label21 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFC0FF&
      Caption         =   "Keycode"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   39
      Top             =   3600
      Width           =   975
   End
   Begin VB.Label Label20 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 16"
      Height          =   255
      Left            =   4800
      TabIndex        =   37
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label Label19 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 15"
      Height          =   255
      Left            =   4800
      TabIndex        =   36
      Top             =   2520
      Width           =   855
   End
   Begin VB.Label Label18 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 14"
      Height          =   255
      Left            =   4800
      TabIndex        =   35
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label17 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 13"
      Height          =   255
      Left            =   4800
      TabIndex        =   34
      Top             =   1800
      Width           =   855
   End
   Begin VB.Label Label16 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 12"
      Height          =   255
      Left            =   3480
      TabIndex        =   33
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label Label15 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 11"
      Height          =   255
      Left            =   3480
      TabIndex        =   32
      Top             =   2520
      Width           =   855
   End
   Begin VB.Label Label14 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 10"
      Height          =   255
      Left            =   3480
      TabIndex        =   31
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label13 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 9"
      Height          =   255
      Left            =   3480
      TabIndex        =   30
      Top             =   1800
      Width           =   855
   End
   Begin VB.Label Label12 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 8"
      Height          =   255
      Left            =   2280
      TabIndex        =   29
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label Label11 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 7"
      Height          =   255
      Left            =   2280
      TabIndex        =   28
      Top             =   2520
      Width           =   855
   End
   Begin VB.Label Label10 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 6"
      Height          =   255
      Left            =   2280
      TabIndex        =   27
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label9 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 5"
      Height          =   255
      Left            =   2280
      TabIndex        =   26
      Top             =   1800
      Width           =   855
   End
   Begin VB.Label Label8 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 4"
      Height          =   255
      Left            =   960
      TabIndex        =   25
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label Label7 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 3"
      Height          =   255
      Left            =   960
      TabIndex        =   24
      Top             =   2520
      Width           =   855
   End
   Begin VB.Label Label6 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 2"
      Height          =   255
      Left            =   960
      TabIndex        =   23
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label5 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Feature 1"
      Height          =   255
      Left            =   960
      TabIndex        =   22
      Top             =   1800
      Width           =   855
   End
   Begin VB.Label Label4 
      Caption         =   "Label4"
      Height          =   15
      Left            =   2040
      TabIndex        =   21
      Top             =   1560
      Width           =   135
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00FFC0FF&
      Caption         =   "Enabled Features"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1920
      TabIndex        =   20
      Top             =   1320
      Width           =   2655
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00FFC0FF&
      Caption         =   "Serial No."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   19
      Top             =   840
      Width           =   855
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFC0FF&
      Caption         =   "Licensee"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   18
      Top             =   480
      Width           =   855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' *
' * KeyCodeDemo
' * Copyright (C) 2007 John Mazza.
' *
' * Written by John Mazza <maz@mgcworks.com>
' *
' * This library is free software; you can redistribute it and/or
' * modify it under the terms of the GNU Lesser General Public
' * License Version 2.1 as published by the Free Software Foundation.
' *
' * This library is distributed in the hope that it will be useful,
' * but WITHOUT ANY WARRANTY; without even the implied warranty of
' * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' * Lesser General Public License for more details.
' *
' * You should have received a copy of the GNU Lesser General Public
' * License along with this library; if not, write to the Free Software
' * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
' ****************************************************************************
'
'
' PURPOSE
'    Demo application for KeyCode module.
'
' LANGUAGE
'    Visual Basic 6.0 (or VBA6) or newer
'
' DEPENDENCIES:
'    Requires KeyCode module and MD5_Crypt module
'

' ================================================
'   CUSTOMIZE THIS STRING BELOW
' ================================================
' "Secret" product name to append to Licensee/Serial
' Change to match your desired product name and/or version info
' Omit "version" if you want keys to work with any version of your
' application.

Private Const MyProductName = "KeyCodeDemoV1"



Private Sub UserName_gotfocus()
  Call GenNewKey
End Sub

Private Sub UserName_LostFocus()
  Call GenNewKey
End Sub

Private Sub ProdName_LostFocus()
  Call GenNewKey
End Sub

Private Sub Check1_Click()
  Call GenNewKey
End Sub

Private Sub Check2_Click()
  Call GenNewKey
End Sub

Private Sub Check3_Click()
  Call GenNewKey
End Sub

Private Sub Check4_Click()
  Call GenNewKey
End Sub

Private Sub Check5_Click()
  Call GenNewKey
End Sub

Private Sub Check6_Click()
  Call GenNewKey
End Sub

Private Sub Check7_Click()
  Call GenNewKey
End Sub

Private Sub Check8_Click()
  Call GenNewKey
End Sub

Private Sub Check9_Click()
  Call GenNewKey
End Sub

Private Sub Check10_Click()
  Call GenNewKey
End Sub

Private Sub Check11_Click()
  Call GenNewKey
End Sub

Private Sub Check12_Click()
  Call GenNewKey
End Sub

Private Sub Check13_Click()
  Call GenNewKey
End Sub

Private Sub Check14_Click()
  Call GenNewKey
End Sub

Private Sub Check15_Click()
  Call GenNewKey
End Sub

Private Sub Check16_Click()
  Call GenNewKey
End Sub

Private Sub GenNewKey()
  Dim FeatID As Long
  
  FeatID = 0
  
  'Build bitmap from checkboxes
  
  If Check1 Then FeatID = FeatID Or 1
  If Check2 Then FeatID = FeatID Or 2
  If Check3 Then FeatID = FeatID Or 4
  If Check4 Then FeatID = FeatID Or 8
  If Check5 Then FeatID = FeatID Or 16
  If Check6 Then FeatID = FeatID Or 32
  If Check7 Then FeatID = FeatID Or 64
  If Check8 Then FeatID = FeatID Or 128
  If Check9 Then FeatID = FeatID Or 256
  If Check10 Then FeatID = FeatID Or 512
  If Check11 Then FeatID = FeatID Or 1024
  If Check12 Then FeatID = FeatID Or 2048
  If Check13 Then FeatID = FeatID Or 4096
  If Check14 Then FeatID = FeatID Or 8192
  If Check15 Then FeatID = FeatID Or 16384
  If Check16 Then FeatID = FeatID Or 32768
  
  ' Uncomment next line if you want to use hexadecimal keys instead
  'KeyCode = FormatKeyCode(GenKeyString(UserName, ProdName, FeatID))
  UserNameT = Trim(UserName)
  ProdNameT = Trim(ProdName)
  
  If Not (UserNameT = "") Or Not (ProdNameT = "") Then
    RawKey = GenKeyString(UserNameT, ProdNameT & MyProductName, FeatID)
    BinKey = HexStrToBinStr(RawKey)
    KeyCode = FormatKeyCode(Base32Enc(BinKey), 4)
  Else
    KeyCode = "Please Enter Licensee and/or Serial Number"
  End If
End Sub


Private Sub BtnChk_Click()
  Dim F2 As Form2
  Set F2 = New Form2
  F2.Show
End Sub


