//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TMemo *Memo1;
	TButton *Button1;
	TPanel *Panel1;
	TLabel *Label1;
	TLabel *Label2;
	TEdit *Edit1;
	TLabel *Label3;
	TEdit *Edit2;
	TLabel *Label4;
	TEdit *Edit3;
	TLabel *Label5;
	TLabel *Label6;
	TEdit *Edit5;
	TLabel *Label7;
	TEdit *Edit6;
	TEdit *Edit4;
	TButton *Button2;
	TButton *Button3;
	TRadioGroup *RadioGroup1;
	TComboBox *ComboBox1;
	TPanel *Panel2;
	TLabel *Label8;
	TLabel *Label9;
	TLabel *Label10;
	TComboBox *ComboBox2;
	TMemo *Memo2;
	TButton *Button5;
	TButton *Button4;
	TButton *Button6;
	TEdit *Edit7;
	TLabel *Label11;
	TEdit *Edit8;
	TButton *Button7;
	TPanel *Panel3;
	TButton *Button8;
	void __fastcall Button2Click(TObject *Sender);
	void __fastcall RadioGroup1Click(TObject *Sender);
	void __fastcall Button3Click(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Button4Click(TObject *Sender);
	void __fastcall Button6Click(TObject *Sender);
	void __fastcall Button5Click(TObject *Sender);
	void __fastcall Button7Click(TObject *Sender);
	void __fastcall Button8Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
