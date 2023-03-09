REM  *****  BASIC  *****

Global  oSheet  as  Object  ' 当前表
Global  old_tel$            ' 手机号 变更 前的 号码
Global  new_user as boolean ' 是否为 新用户
Global  user_Row%           ' 用户在 会员信息表 和 历史记录表 中的 行 位置

Public  line2%              ' 历史记录从 15 行开始

Dim  new_tel$
Dim  oCell as Object
Dim  oSheet2, oSheet3

Sub Main
    'oSheet = ThisComponent.CurrentController.getActiveSheet()
    'oCell.setFormula("=A1*A2")
    new_user = True
    oSheet = ThisComponent.Sheets(0)             ' 当前表为 日常
    oSheet.getCellRangeByName("c4").value = Now  ' 时间
    query
End Sub

Sub change

    'oSheet = ThisComponent.Sheets(0)
    oCell = oSheet.getCellRangeByName("c3")
    new_tel = oCell.string 
    if (old_tel <>  new_tel) then
        query
    end if

End sub

Sub query

    Dim oRa As Object
    Dim ran As Object
    dim odesc
    
    'oSheet = ThisComponent.Sheets(0)
    oCell = oSheet.getCellRangeByName("c3")
    new_tel = oCell.string 
    
    'msgbox("3=" & old_tel & new_tel & "=3")
    if (11  <> len(new_tel)) then
        msgbox("手机号码长度为 11 ！")
        ThisComponent.CurrentController.select(oCell)
        exit sub
    end if
    
    clear_data

    If old_tel <> new_tel Then
        old_tel = new_tel
    End If
        
    line2 = 14   '历史记录显示开始行

    oSheet3 = ThisComponent.Sheets(2)   ' 历史记录表
    oRa = oSheet3.Columns(2)            ' 历史记录 c 列 电话号码 
    odesc = oRa.createSearchDescriptor()
    odesc.SearchString = new_tel
    'odesc.SearchBackwards = True
    ran = oRa.findFirst(odesc)
    if Not isNull(ran) then
    	'dim b_row
    	'b_row = ran.RangeAddress.EndRow
    	'b_row = ran.CellAddress.Row
        do
            user_row = ran.CellAddress.Row + 1
            cell_copy(oSheet, oSheet.getCellByPosition(0, line2), oSheet3.getCellRangeByName("a" & user_row & ":g" & user_row) )
        	line2 = line2 + 1
        	ran = Ora.findNext(ran, odesc)
        loop until isNull(ran)

        oSheet2 = ThisComponent.Sheets(1)  ' 会员信息表
        oRa = oSheet2.Columns(2)           ' 会员信息 c 列 
        ran = oRa.findFirst(odesc)
        if Not isNull(ran) then
            user_row = ran.CellAddress.Row + 1
            cell_copy(oSheet, oSheet.getCellByPosition(0, 11), oSheet2.getCellRangeByName("a" & user_row & ":j" & user_row) )
        end if
        new_user = False
    end if

    ThisComponent.CurrentController.ActiveSheet = oSheet
    ThisComponent.CurrentController.select(oCell)

end sub

sub add

    Dim cdate$
    Dim amount%
    Dim balance%

    'oSheet = ThisComponent.Sheets(0)
    oSheet2 = ThisComponent.Sheets(1)  ' 会员信息表
    oSheet3 = ThisComponent.Sheets(2)  ' 历史记录表

    If new_user Then
        oCell = oSheet.getCellRangeByName("c1")
        If IsEmpty(oCell.string) Then
            MsgBox ("需先填写卡号!")
            ThisComponent.CurrentController.select(oCell)
            Exit Sub
        End If
        
        oCell = oSheet.getCellRangeByName("c2")
        If IsEmpty(oCell.string) Then
            MsgBox ("需先填写姓名!")
            ThisComponent.CurrentController.select(oCell)
            Exit Sub
        End If
        balance = 0
    Else
        balance = oSheet2.getCellRangeByName("j" & user_Row).Value
    End If

    variety = oSheet.getCellRangeByName("n1").string
    If ("充值" <> variety) And new_user Then
        MsgBox ("新用户需先充值，再消费!")
        Exit Sub
    End If

    oCell = oSheet.getCellRangeByName("c8")
    If IsEmpty(oCell.string) Then
        MsgBox ("需先填写金额!")
        ThisComponent.CurrentController.select(oCell)
        Exit Sub
    End If
    
    amount = oCell.Value
    
    If ("充值" = variety) Then
        balance = balance + amount
    Else
        balance = balance - amount
        If (0 > balance) Then
            MsgBox ("用户余额不足，请先充值!")
            ThisComponent.CurrentController.select(oCell)
            Exit Sub
        End If
    End If
    
    oCell = oSheet.getCellRangeByName("c3")

    oSheet3.Rows.insertByIndex(1,1) '历史记录表增加在第二行
    
    cdate = oSheet.getCellRangeByName("c4").string
    oSheet3.getCellRangeByName("d2").string = cdate    '日期
    oSheet3.getCellRangeByName("e2").string = variety  '项目
    oSheet3.getCellRangeByName("f2").Value = amount    '金额
    
    If new_user Then

        '历史记录表 增加 : 新会员使用新填写信息
        oSheet3.getCellRangeByName("a2").string = oSheet.getCellRangeByName("c1").string '会员卡号
        oSheet3.getCellRangeByName("b2").string = oSheet.getCellRangeByName("c2").string '姓名
        oSheet3.getCellRangeByName("c2").string = oCell.string  '手机号

        oSheet3.getCellRangeByName("g2").Value = balance   '历史记录表 余额

        '会员信息表 : 新会员增加在第二行
        oSheet2.Rows.insertByIndex(1,1)

        oSheet2.getCellRangeByName("a2").string = oSheet.getCellRangeByName("c1").string
        oSheet2.getCellRangeByName("b2").string = oSheet.getCellRangeByName("c2").string
        oSheet2.getCellRangeByName("c2").string = oCell.string
        oSheet2.getCellRangeByName("d2").string = cdate         '办卡日期
        oSheet2.getCellRangeByName("h2").string = cdate         '最近充值日期
        oSheet2.getCellRangeByName("e2").Value = amount         '充值金额
        oSheet2.getCellRangeByName("j2").Value = amount         '会员信息表 卡余额
        
        oSheet2.getCellRangeByName("f2").Value = 1  '充值次数
        oSheet2.getCellRangeByName("g2").Value = 0  '消费次数
        
    Else
        '历史记录表 增加 : 老会员引用 第 12 行 原有信息
        oSheet3.getCellRangeByName("a2").string = oSheet.getCellRangeByName("a12").string
        oSheet3.getCellRangeByName("b2").string = oSheet.getCellRangeByName("b12").string
        oSheet3.getCellRangeByName("c2").string = oSheet.getCellRangeByName("c12").string
        
        '会员信息表 : 老会员信息修改
        If "充值" = variety Then
            oSheet2.getCellRangeByName("h" & user_Row).string = cdate  '充值日期
            oSheet2.getCellRangeByName("f" & user_Row).Value =oSheet2.getCellRangeByName("f" & user_Row).Value + 1 '充值次数
        Else
            oSheet2.getCellRangeByName("i" & user_Row).string = cdate  '消费日期
            oSheet2.getCellRangeByName("g" & user_Row).Value = oSheet2.getCellRangeByName("g" & user_Row).Value + 1 '消费次数
        End If
        oSheet2.getCellRangeByName("j" & user_Row).Value = balance '会员信息余额
        oSheet3.getCellRangeByName("g2").value = balance  '历史记录余额
    
    End If
    
    If ("充值" <> variety) Then
        oSheet3.getCellRangeByName("f2").CellBackColor = RGB(255, 255, 0)
        oSheet3.getCellRangeByName("g2").CellBackColor = RGB(255, 255, 0)
    End If
    
    query

end sub

Sub clear_data()

    Dim oFlag, oCursor, ran, b_row

	'清除第 12 行 的 会员信息
    With com.sun.star.sheet.CellFlags
        oFlag = .VALUE + .STRING + .DATETIME + .FORMULA + .HARDATTR
    End With
    oSheet.getCellRangeByName("a12:j12").clearContents(oFlag)

	'清除第 15 行 开始的 历史记录信息
    ran = oSheet.getCellRangeByName("g15")
    If ("" <> ran.string) Then
   	    oCursor = oSheet.CreateCursorByRange(ran)
   	    oCursor.gotoEndOfUsedArea(True)
   	    b_row = oCursor.RangeAddress.EndRow + 1
        oSheet.getCellRangeByName("a15:g" & b_row).clearContents(oFlag)
    End If

End Sub

sub cell_copy(oSheet, oCell, oRan)
    dim d, s
    d = oCell.getCellAddress()
    s = oRan.getRangeAddress()
    oSheet.copyRange(d, s)
end sub


Function check(oCell, text)
	dim flag
	If IsEmpty(oCell.string) Then
	    MsgBox (text)
	    flag = true
	    ThisComponent.CurrentController.select(oCell)
	End If
	check = flag
end Function

sub close_doc
	ThisComponent.store
end sub
