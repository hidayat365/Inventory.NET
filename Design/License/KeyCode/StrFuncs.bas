Attribute VB_Name = "StrFuncs"
' *
' * StrFuncs Module
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
' PURPOSE
'    String manipulation routines
'
' LANGUAGE
'    Visual Basic 6.0 or VBA6
'    Should work in VB.NET as well
'
' DEPENDENCIES:
'    None known
'


' Helper for Base32 numbers
Const B32Map = "0123456789ABCDEFGHJKLMNPRSTVWXYZ"


' General String Functions

' RemoveDashes() - Trivial function to delete "-" character from a string

Public Function RemoveDashes(ByVal StrIn As String) As String
  RemoveDashes = Replace(StrIn, "-", "")
End Function


' ShiftStrLeft() - Shift a string left by a number of bits

Public Function ShiftStrLeft(ByVal StrIn As String, ByVal Bits As Long) As String
  Dim CurPos As Long
  Dim WorkStr As String
  Dim RetStr As String
  Dim CurByteVal As Byte
  Dim BitMask As Byte
  Dim InvMask As Byte
  Dim ShiftBits As Byte
  Dim WholeBytes As Long
  Dim LeftPart As Byte
  Dim RightPart As Byte
  Dim Carry As Byte
  Dim PrevChar As Byte
  Dim TrimMask As Byte
  
  ' Figure out some metrics on our input string
  
  WholeBytes = Int(Bits / 8)
  ShiftBits = Bits Mod 8
  
  BitMask = 255 - (2 ^ (8 - ShiftBits) - 1)
  InvMask = Not (BitMask)
  TrimMask = (2 ^ ShiftBits) - 1
  
  CurPos = 1
  StrLen = Len(StrIn)
  StrBits = StrLen * 8
  WorkStr = StrIn
  
  ' Check we're not trying to shift more bits than
  ' we have in the string.
  
  If (StrBits > Bits) Then
  ' First, shift string by whole bytes
    If (WholeBytes > 0) Then
      WorkStr = Right(WorkStr, StrLen - WholeBytes)
      
      ' Pad zero bytes to end of WorkStr to make length match
      
      For CurPos = 1 To WholeBytes
        WorkStr = WorkStr & Chr(0)
      Next CurPos
      
      ' Ensure RetStr contains shifted string in case no other
      ' bitwise shifting is performed later
      
      RetStr = WorkStr
    End If
    
    ' Now handle the bitwise shift
    If (ShiftBits > 0) Then
    
      For CurPos = 1 To Len(WorkStr)
        ' Read next character of input and mask it appropriately
        CurByteVal = Asc(Mid(WorkStr, CurPos, 1))
        LeftPart = (CurByteVal And BitMask) And &HFF
        RightPart = (CurByteVal And InvMask) And &HFF
        
        ' Shift the masked portions
        LeftPart = Int(LeftPart / (2 ^ (8 - ShiftBits)))
        RightPart = (RightPart * (2 ^ ShiftBits))
          
        If CurPos = 1 Then
          ' Put the non-discarded part into PrevChar for later use
          PrevChar = (RightPart)
          RetStr = ""
        Else
          ' Put carryover part into PrevChar and combine
          ' the other bits with the carry from previous step
          PrevChar = PrevChar Or LeftPart
          RetStr = RetStr & Chr(PrevChar)
          PrevChar = RightPart
        End If
        
        Next CurPos
        
        ' Combine our final carry with last char of string and mask off
        PrevChar = (PrevChar Or (LeftPart And Not (TrimMask)))
        RetStr = RetStr & Chr(PrevChar)
      
    End If
    
  Else
    ' If we're trying to shift by more bits than
    ' input string, return an equal length string
    ' full of zeroes (null characters).
    
    For CurPos = 1 To StrLen
      RetStr = RetStr & Chr(0)
    Next CurPos
  End If
  
  ShiftStrLeft = RetStr
  
End Function

' ShiftStringRight() - Shift a string right a number of bits

Public Function ShiftStrRight(ByVal StrIn As String, ByVal Bits As Long) As String
  Dim CurPos As Long
  Dim WorkStr As String
  Dim RetStr As String
  Dim CurByteVal As Byte
  Dim BitMask As Byte
  Dim InvMask As Byte
  Dim ShiftBits As Byte
  Dim WholeBytes As Long
  Dim LeftPart As Byte
  Dim RightPart As Byte
  Dim Carry As Byte
  Dim PrevChar As Byte
  Dim TrimMask As Byte
  
  ' Calculate metrics on input
  
  WholeBytes = Int(Bits / 8)
  ShiftBits = Bits Mod 8
  
  BitMask = 255 - ((2 ^ ShiftBits) - 1)
  InvMask = Not (BitMask)
  TrimMask = (2 ^ ShiftBits) - 1
  
  CurPos = 1
  StrLen = Len(StrIn)
  StrBits = StrLen * 8
  
  ' Check we're not trying to shift more bits than
  ' we have in the string.
  WorkStr = StrIn
  
  If (StrBits > Bits) Then
  
    ' First, shift string by whole bytes
    
    If (WholeBytes > 0) Then
      WorkStr = Left(WorkStr, StrLen - WholeBytes)
      
      ' Pad zero bytes to end of WorkStr
      
      For CurPos = 1 To WholeBytes
        WorkStr = Chr(0) & WorkStr
      Next CurPos
      
      ' Ensure RetStr contains shifted string in case no other
      ' bitwise shifting later
      
      RetStr = WorkStr
    End If
    
    ' Now handle the bitwise shift
    If (ShiftBits > 0) Then
    
      RetStr = ""
    
      For CurPos = Len(WorkStr) To 1 Step -1
      
        CurByteVal = Asc(Mid(WorkStr, CurPos, 1))
        
        LeftPart = CurByteVal And BitMask
        LeftPart = LeftPart / (2 ^ ShiftBits)
        
        RightPart = CurByteVal And InvMask
        RightPart = RightPart * (2 ^ (8 - ShiftBits))
        
        If CurPos = Len(WorkStr) Then
          Carry = LeftPart
        Else
          CurByteVal = RightPart Or Carry
          Carry = LeftPart
          RetStr = Chr(CurByteVal) & RetStr
        End If
        
      Next CurPos
   
      RetStr = Chr(Carry) & RetStr
      
    End If
    
  Else
    ' If we're trying to shift by more bits than
    ' input string, return an equal length string
    ' full of zeroes.
    
    For CurPos = 1 To StrLen
      RetStr = RetStr & Chr(0)
    Next CurPos
  End If
  
  ShiftStrRight = RetStr
  
End Function

' Base32Enc() - Takes a "binary" string and represents as a Base32 number
' Net result is an encoding where each "character" represents 5 bits

Public Function Base32Enc(ByVal StrIn As String) As String
  Dim CurBit As Long
  Dim Mask32 As Byte
  Dim CurPos As Long
  Dim CurVal As Byte
  Dim StrBits As Long
  Dim BitsProc As Long
  Dim WorkStr As String
  Dim RetStr As String
  Dim CurConv As String
    
  RetStr = ""
  WorkStr = StrIn
  StrBits = Len(StrIn) * 8
  StrGroups = Int(StrBits / 5)
  
  If (StrBits Mod 5) <> 0 Then StrGroups = StrGroups + 1
  
  StrChar = Len(StrIn)
  BitsProc = 0
  Mask32 = &H1F
  
  ' Work from back of string to front.
  ' and output the character representing each 5-bit group
  
  For CurPos = 1 To StrGroups
    CurVal = Asc(Mid(WorkStr, Len(WorkStr), 1))
    CurVal = (CurVal And Mask32) + 1
    CurConv = Mid(B32Map, CurVal, 1)
    WorkStr = ShiftStrRight(WorkStr, 5)
    RetStr = CurConv & RetStr
  Next CurPos
  
  Base32Enc = RetStr
  
End Function

' Base32Dec() - Takes a string encoded with Base32Enc() and returns the
' original "binary" string it represents.

Public Function Base32Dec(ByVal StrIn As String) As String
  Dim CurPos As Long
  Dim CurVal As Byte
  Dim CurChr As String
  Dim RetStr As String
  Dim WorkStr As String
  Dim Carry As Byte
  Dim CarryMask As Byte
  Dim CurMask As Byte
  Dim ThisVal As Byte
  Dim ThisChar As String
  Dim ShiftBits As Long
  Dim OutBytes As Long
  Dim InBits As Long
  
  ' Calculate metrics
  
  BitsProc = 0
  BaseMask = &H1F
  Carry = 0
  WorkStr = StrIn
  
  InBits = Len(StrIn) * 5
  OutBytes = Int(InBits / 8)
    
  ' Setup a string of zero bytes to push values into later
  
  For CurPos = 1 To OutBytes
    RetStr = RetStr & Chr(0)
  Next CurPos
    
  ' Convert input string into binary representation
  
  For CurPos = 1 To Len(StrIn)
  
    ' Derive 5-bit value of current char in StrIn
    CurChr = Mid(WorkStr, CurPos, 1)
    CurVal = InStr(1, B32Map, CurChr)
    CurVal = CurVal - 1
    
    ' Now, shift RetStr left 5 bits and pop last char off
    RetStr = ShiftStrLeft(RetStr, 5)
    ThisChar = Mid(RetStr, Len(RetStr), 1)
    RetStr = Left(RetStr, Len(RetStr) - 1)
    
    ' Now, OR our CurChr with the popped value
    ' and push result back to end of string
    ThisVal = Asc(ThisChar)
    ThisVal = ThisVal Or CurVal
    ThisChar = Chr(ThisVal)
    RetStr = RetStr & ThisChar
  Next CurPos
  
  Base32Dec = RetStr
  
End Function

' HexStrToBinStr() - Convert a hexadecimal string into a binary representation

Public Function HexStrToBinStr(ByVal StrIn As String) As String
  Dim StrOut As String
  Dim Ch As Long
  Dim HexByte As String
  Dim ByteVal As Long
  Dim ByteCh As String
  
  StrOut = ""
  
  For Ch = 1 To Len(StrIn) Step 2
    HexByte = Mid(StrIn, Ch, 2)
    ByteVal = Val("&H" & HexByte)
    ByteCh = Chr(ByteVal)
    StrOut = StrOut & ByteCh
  Next Ch
  
  HexStrToBinStr = StrOut
  
End Function

' BinStrToHexStr() - Convert a binary string to a hexadecimal representation

Public Function BinStrToHexStr(ByVal StrIn As String) As String
  Dim StrOut As String
  Dim Ch As Long
  Dim HexByte As String
  Dim HexChr As String
  
  StrOut = ""
  
   For Ch = 1 To Len(StrIn)
    HexByte = Mid(StrIn, Ch, 1)
    HexChr = Hex$(Asc(HexByte))
    If Len(HexChr) = 1 Then HexChr = "0" & HexChr
    StrOut = StrOut & HexChr
  Next Ch
  
  BinStrToHexStr = StrOut
  
End Function

