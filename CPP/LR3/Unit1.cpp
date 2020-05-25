// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "List.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
List WaitList;
List CompletedList;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender) {
	if (Edit1->Text == "" || Edit2->Text == "" || Edit3->Text == "" ||
		Edit4->Text == "" || Edit5->Text == "" || Edit6->Text == "") {
		ShowMessage("Необходимо заполнить все поля");
		return;
	}
	WaitList.AddElement(StrToInt(Edit1->Text), Edit2->Text, Edit3->Text,
		Edit4->Text, Edit5->Text, Edit6->Text);
	if (RadioGroup1->ItemIndex == 0) {
		WaitList.ShowList(Memo1);
	}
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::RadioGroup1Click(TObject *Sender) {
	switch (RadioGroup1->ItemIndex) {
	case 0:
		WaitList.ShowList(Memo1);
		Panel3->Visible = true;
		break;
	case 1:
		CompletedList.ShowList(Memo1);
		Panel3->Visible = false;
		break;
	}
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender) {
	Edit1->Clear();
	Edit2->Clear();
	Edit3->Clear();
	Edit4->Clear();
	Edit5->Clear();
	Edit6->Clear();
	Panel1->Visible = false;
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender) {
	Panel1->Visible = true;
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender) {
	Panel2->Visible = true;
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button6Click(TObject *Sender) {
	Memo2->Lines->Clear();
	Panel2->Visible = false;
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button5Click(TObject *Sender) {
	switch (ComboBox1->ItemIndex) {
	case 0:
		WaitList.ShowSearchList(Memo2, ComboBox2->ItemIndex, Edit7->Text);
		break;
	case 1:
		CompletedList.ShowSearchList(Memo2, ComboBox2->ItemIndex, Edit7->Text);
		break;
	}
}
// ---------------------------------------------------------------------------

void __fastcall TForm1::Button7Click(TObject *Sender) {
	int comleteNumber = StrToInt(Edit8->Text);
	if (comleteNumber < 1 || comleteNumber > WaitList.GetSize()) {
		ShowMessage("Такой номер записи отсутствует");
		return;
	}
	List::CompleteElement(WaitList, CompletedList, comleteNumber);
	switch (RadioGroup1->ItemIndex) {
	case 0:
		WaitList.ShowList(Memo1);
		break;
	case 1:
		CompletedList.ShowList(Memo1);
		break;
	}

}
// ---------------------------------------------------------------------------


void __fastcall TForm1::Button8Click(TObject *Sender) {
	switch (RadioGroup1->ItemIndex) {
	case 0:
		WaitList.DeleteDuplicate();
		WaitList.ShowList(Memo1);
		break;
	case 1:
		CompletedList.DeleteDuplicate();
		CompletedList.ShowList(Memo1);
		break;
	}
}
// ---------------------------------------------------------------------------
