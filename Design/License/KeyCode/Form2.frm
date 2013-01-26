VERSION 5.00
Begin VB.Form Form2 
   BackColor       =   &H00FFC0C0&
   Caption         =   "Enter Registration Information"
   ClientHeight    =   3915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6570
   LinkTopic       =   "Form2"
   ScaleHeight     =   3915
   ScaleWidth      =   6570
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton BtnReg 
      Caption         =   "Register"
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
      Left            =   480
      TabIndex        =   4
      Top             =   3120
      Width           =   5655
   End
   Begin VB.TextBox UName 
      Height          =   285
      Left            =   1560
      TabIndex        =   0
      Top             =   240
      Width           =   2775
   End
   Begin VB.TextBox SerNo 
      Height          =   285
      Left            =   1560
      TabIndex        =   1
      Top             =   600
      Width           =   2775
   End
   Begin VB.CheckBox Check1 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   720
      TabIndex        =   19
      Top             =   1560
      Width           =   255
   End
   Begin VB.CheckBox Check2 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   720
      TabIndex        =   18
      Top             =   1920
      Width           =   255
   End
   Begin VB.CheckBox Check3 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   720
      TabIndex        =   17
      Top             =   2280
      Width           =   255
   End
   Begin VB.CheckBox Check4 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   720
      TabIndex        =   16
      Top             =   2640
      Width           =   255
   End
   Begin VB.CheckBox Check5 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   2040
      TabIndex        =   15
      Top             =   1560
      Width           =   255
   End
   Begin VB.CheckBox Check6 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   2040
      TabIndex        =   14
      Top             =   1920
      Width           =   255
   End
   Begin VB.CheckBox Check7 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   2040
      TabIndex        =   13
      Top             =   2280
      Width           =   255
   End
   Begin VB.CheckBox Check8 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   2040
      TabIndex        =   12
      Top             =   2640
      Width           =   255
   End
   Begin VB.CheckBox Check9 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3240
      TabIndex        =   11
      Top             =   1560
      Width           =   255
   End
   Begin VB.CheckBox Check10 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3240
      TabIndex        =   10
      Top             =   1920
      Width           =   255
   End
   Begin VB.CheckBox Check11 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3240
      TabIndex        =   9
      Top             =   2280
      Width           =   255
   End
   Begin VB.CheckBox Check12 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   3240
      TabIndex        =   8
      Top             =   2640
      Width           =   255
   End
   Begin VB.CheckBox Check13 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4560
      TabIndex        =   7
      Top             =   1560
      Width           =   255
   End
   Begin VB.CheckBox Check14 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4560
      TabIndex        =   6
      Top             =   1920
      Width           =   255
   End
   Begin VB.CheckBox Check15 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4560
      TabIndex        =   5
      Top             =   2280
      Width           =   255
   End
   Begin VB.CheckBox Check16 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Check1"
      Height          =   255
      Left            =   4560
      TabIndex        =   2
      Top             =   2640
      Width           =   255
   End
   Begin VB.TextBox LKey 
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
      Left            =   1560
      TabIndex        =   3
      Top             =   960
      Width           =   4815
   End
   Begin VB.Label Stat 
      Alignment       =   2  'Center
      BackColor       =   &H000000FF&
      Caption         =   "Label3"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   0
      TabIndex        =   39
      Top             =   3600
      Width           =   6615
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFC0C0&
      Caption         =   "Your Name"
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
      Left            =   240
      TabIndex        =   38
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFC0C0&
      Caption         =   "Serial No."
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
      Left            =   360
      TabIndex        =   37
      Top             =   600
      Width           =   1095
   End
   Begin VB.Label Label5 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 1"
      Height          =   255
      Left            =   1080
      TabIndex        =   36
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label6 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 2"
      Height          =   255
      Left            =   1080
      TabIndex        =   35
      Top             =   1920
      Width           =   855
   End
   Begin VB.Label Label7 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 3"
      Height          =   255
      Left            =   1080
      TabIndex        =   34
      Top             =   2280
      Width           =   855
   End
   Begin VB.Label Label8 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 4"
      Height          =   255
      Left            =   1080
      TabIndex        =   33
      Top             =   2640
      Width           =   855
   End
   Begin VB.Label Label9 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 5"
      Height          =   255
      Left            =   2400
      TabIndex        =   32
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label10 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 6"
      Height          =   255
      Left            =   2400
      TabIndex        =   31
      Top             =   1920
      Width           =   855
   End
   Begin VB.Label Label11 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 7"
      Height          =   255
      Left            =   2400
      TabIndex        =   30
      Top             =   2280
      Width           =   855
   End
   Begin VB.Label Label12 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 8"
      Height          =   255
      Left            =   2400
      TabIndex        =   29
      Top             =   2640
      Width           =   855
   End
   Begin VB.Label Label13 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 9"
      Height          =   255
      Left            =   3600
      TabIndex        =   28
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label14 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 10"
      Height          =   255
      Left            =   3600
      TabIndex        =   27
      Top             =   1920
      Width           =   855
   End
   Begin VB.Label Label15 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 11"
      Height          =   255
      Left            =   3600
      TabIndex        =   26
      Top             =   2280
      Width           =   855
   End
   Begin VB.Label Label16 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 12"
      Height          =   255
      Left            =   3600
      TabIndex        =   25
      Top             =   2640
      Width           =   855
   End
   Begin VB.Label Label17 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 13"
      Height          =   255
      Left            =   4920
      TabIndex        =   24
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label18 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 14"
      Height          =   255
      Left            =   4920
      TabIndex        =   23
      Top             =   1920
      Width           =   855
   End
   Begin VB.Label Label19 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 15"
      Height          =   255
      Left            =   4920
      TabIndex        =   22
      Top             =   2280
      Width           =   855
   End
   Begin VB.Label Label20 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Feature 16"
      Height          =   255
      Left            =   4920
      TabIndex        =   21
      Top             =   2640
      Width           =   855
   End
   Begin VB.Label Label21 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00FFC0C0&
      Caption         =   "License Key"
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
      TabIndex        =   20
      Top             =   960
      Width           =   1335
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
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
' Check input KeyCode
' Must match with code calculated for Username/ProdName/MyProductName combo

' Make sure this matches the MyProductName used in key generation!
Private Const MyProductName = "KeyCodeDemoV1"

Private Function IsKeyValid(ByVal KeyCode, UserName, ProdName As String) As Boolean
  Dim BinKey As String
  Dim IsValid As Boolean
  Dim HexKey As String
  
  IsValid = False
  
  ' First, decode Base32 string into binary one
  ' Remove any dashes in input string
  
  BinKey = Base32Dec(RemoveDashes(KeyCode))

  HexKey = BinStrToHexStr(BinKey)
  IsValid = ValidateKeyCode(HexKey, UserName, ProdName & MyProductName)

  
  IsKeyValid = IsValid
  
End Function

Private Function GetKeyFeat(ByVal KeyCode, UserName, ProdName As String) As Long
  Dim BinKey As String
  Dim FeatBMP As Long
  Dim HexKey As String
  
  IsValid = False
  
  ' First, decode Base32 string into binary one
  ' Remove any dashes in input string
  
  BinKey = Base32Dec(RemoveDashes(KeyCode))
  
  ' Check length of BinKey - must be 16 to be valid
  If Len(BinKey) = 16 Then
    HexKey = BinStrToHexStr(BinKey)
    FeatBMP = ExtractKeyFBits(HexKey, UserName, ProdName & MyProductName)
  Else
    FeatBMP = 0
  End If
  
  GetKeyFeat = FeatBMP
  
End Function

Private Sub BtnReg_Click()
  Dim UNameT As String
  Dim SerNoT As String
  Dim LKeyT As String
    
  UNameT = Trim(UName)
  SerNoT = Trim(SerNo)
  LKeyT = Trim(LKey)
    
  If IsKeyValid(LKeyT, UNameT, SerNoT) Then
 
    
    'X = MsgBox("License Key Okay", vbInformation, "Success")

    features = GetKeyFeat(LKeyT, UNameT, SerNoT)
    Stat.Caption = "Key Validated."
    Call DoCheckBoxes(features)
  Else
    Call DoCheckBoxes(0)
    Stat.Caption = "Invalid Key.  Please try again!"
  End If
  

End Sub

Private Sub DoCheckBoxes(ByVal ChkVal As Long)
  Check1 = ChkVal And 1
  Check2 = (ChkVal And 2) / 2
  Check3 = (ChkVal And 4) / 4
  Check4 = (ChkVal And 8) / 8
  Check5 = (ChkVal And 16) / 16
  Check6 = (ChkVal And 32) / 32
  Check7 = (ChkVal And 64) / 64
  Check8 = (ChkVal And 128) / 128
  Check9 = (ChkVal And 256) / 256
  Check10 = (ChkVal And 512) / 512
  Check11 = (ChkVal And 1024) / 1024
  Check12 = (ChkVal And 2048) / 2048
  Check13 = (ChkVal And 4096) / 4096
  Check14 = (ChkVal And 8192) / 8192
  Check15 = (ChkVal And 16384) / 16384
  Check16 = (ChkVal And 32768) / 32768
  
  

End Sub
Private Sub form_load()
  Stat.Caption = "Enter Registration Information"
  Check1.Enabled = False
  Check2.Enabled = False
  Check3.Enabled = False
  Check4.Enabled = False
  Check5.Enabled = False
  Check6.Enabled = False
  Check7.Enabled = False
  Check8.Enabled = False
  Check9.Enabled = False
  Check10.Enabled = False
  Check11.Enabled = False
  Check12.Enabled = False
  Check13.Enabled = False
  Check14.Enabled = False
  Check15.Enabled = False
  Check16.Enabled = False
  Call DoCheckBoxes(0)
  
  
  
End Sub
