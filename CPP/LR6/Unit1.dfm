object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 450
  ClientWidth = 878
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object StringGrid1: TStringGrid
    Left = 8
    Top = 8
    Width = 329
    Height = 337
    ColCount = 2
    DefaultColWidth = 160
    RowCount = 12
    GridLineWidth = 5
    TabOrder = 0
    RowHeights = (
      24
      24
      24
      24
      24
      24
      24
      24
      24
      24
      24
      24)
  end
  object TreeView1: TTreeView
    Left = 601
    Top = 8
    Width = 269
    Height = 337
    Indent = 19
    TabOrder = 1
  end
  object Memo1: TMemo
    Left = 343
    Top = 8
    Width = 252
    Height = 337
    TabOrder = 2
  end
  object Panel1: TPanel
    Left = 601
    Top = 351
    Width = 269
    Height = 84
    TabOrder = 3
    object Label1: TLabel
      Left = 64
      Top = 0
      Width = 158
      Height = 23
      Caption = #1044#1086#1073#1072#1074#1083#1077#1085#1080#1077' '#1091#1079#1083#1072':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label2: TLabel
      Left = 41
      Top = 29
      Width = 17
      Height = 16
      Caption = 'ID:'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label3: TLabel
      Left = 8
      Top = 59
      Width = 48
      Height = 13
      Caption = #1060#1072#1084#1080#1083#1080#1103':'
    end
    object Edit1: TEdit
      Left = 72
      Top = 29
      Width = 121
      Height = 21
      TabOrder = 0
    end
    object Edit2: TEdit
      Left = 72
      Top = 56
      Width = 121
      Height = 21
      TabOrder = 1
    end
    object Button1: TButton
      Left = 216
      Top = 56
      Width = 43
      Height = 25
      Caption = 'OK'
      TabOrder = 2
      OnClick = Button1Click
    end
  end
  object Panel2: TPanel
    Left = 8
    Top = 351
    Width = 233
    Height = 84
    TabOrder = 4
    object Label4: TLabel
      Left = 16
      Top = 0
      Width = 194
      Height = 23
      Caption = #1055#1086#1080#1089#1082'/'#1091#1076#1072#1083#1077#1085#1080#1077' '#1091#1079#1083#1072':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label5: TLabel
      Left = 9
      Top = 29
      Width = 17
      Height = 16
      Caption = 'ID:'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Edit3: TEdit
      Left = 32
      Top = 29
      Width = 121
      Height = 21
      TabOrder = 0
    end
    object Button2: TButton
      Left = 95
      Top = 56
      Width = 58
      Height = 25
      Caption = #1053#1072#1081#1090#1080
      TabOrder = 1
      OnClick = Button2Click
    end
    object Button3: TButton
      Left = 32
      Top = 56
      Width = 57
      Height = 25
      Caption = #1059#1076#1072#1083#1080#1090#1100
      TabOrder = 2
      OnClick = Button3Click
    end
  end
  object Button4: TButton
    Left = 343
    Top = 351
    Width = 122
    Height = 25
    Caption = #1055#1088#1103#1084#1086#1081' '#1086#1073#1093#1086#1076
    TabOrder = 5
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 343
    Top = 382
    Width = 122
    Height = 25
    Caption = #1054#1073#1088#1072#1090#1085#1099#1081' '#1086#1073#1093#1086#1076
    TabOrder = 6
    OnClick = Button5Click
  end
  object Button6: TButton
    Left = 343
    Top = 413
    Width = 122
    Height = 25
    Caption = #1042#1086#1079#1088#1072#1089#1090#1072#1085#1080#1077' '#1082#1083#1102#1095#1077#1081
    TabOrder = 7
    OnClick = Button6Click
  end
  object Button7: TButton
    Left = 471
    Top = 351
    Width = 106
    Height = 25
    Caption = #1055#1086#1076#1089#1095#1080#1090#1072#1090#1100' '#1091#1079#1083#1099
    TabOrder = 8
    OnClick = Button7Click
  end
end
