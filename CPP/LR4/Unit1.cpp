// ---------------------------------------------------------------------------

#include <vcl.h>
#include <string>
#pragma hdrstop

#include "Unit1.h"
#include "Calculator.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
bool isContains(char *array, char c);
TForm1 *Form1;
int numOfVars = 0;
Calculator Calc;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender) {
	Panel1->Visible = true;
	Edit3->Text = "";
	for (int i = 0; i < numOfVars; i++) {
		delete E[i];
        delete L[i];
	}
	numOfVars = 0;
	std::string str = AnsiString(Edit1->Text).c_str();
	char *array = new char[10];
	for (int i = 0; i < 10; i++) {
		array[i] = '_';
	}
	for (int i = 0; i < str.length(); i++) {
		if (isalpha(str[i])) {
			if (!isContains(array, str[i])) {
				array[numOfVars] = str[i];
				numOfVars++;
			}
		}
	}
	Panel1->Height = 100 + numOfVars * 40;
	Button2->Top = 60 + numOfVars * 40;
	for (int i = 0; i < numOfVars; i++) {
		E[i] = new TEdit(Panel1);
		E[i]->Name = "Edit_" + (String)array[i];
		E[i]->Text = "";
		E[i]->Top = 10 + i * 40;
		E[i]->Left = 30;
		E[i]->Width = 100;
		E[i]->Parent = Panel1;
		L[i] = new TLabel(Panel1);
		L[i]->Name = "Label_" + (String)array[i];
		L[i]->Caption = (String)array[i] + ":";
		L[i]->Top = 10 + i * 40;
		L[i]->Left = 5;
		L[i]->Width = 15;
		L[i]->Parent = Panel1;
	}
	delete[]array;
	Edit2->Text = (Calc.TransformIntoRPE(AnsiString(Edit1->Text).c_str()).c_str());
}
// ---------------------------------------------------------------------------

bool isContains(char *array, char c) {
	for (int i = 0; i < 10; i++) {
		if (array[i] == c) {
			return true;
		}
	}
	return false;
}

void __fastcall TForm1::Button2Click(TObject *Sender)
{
	for (int i = 0; i < numOfVars; i++) {
		if (E[i]->Text == "") {
			ShowMessage("���������� ����������. �� ��� �������� �������.");
			return;
		}
	}
	Edit3->Text = FloatToStr(Calc.�alculateRPE(AnsiString(Edit2->Text).c_str(), E, numOfVars));
}
//---------------------------------------------------------------------------

