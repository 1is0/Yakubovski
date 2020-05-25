//---------------------------------------------------------------------------

#pragma hdrstop

#include "Node.h"
Node::Node()
{

}

Node::Node(int SerialNumber,String Surname,String Name,String Patronymic,String HomeAddress,String RegistrationDate)
{
	serialNumber = SerialNumber;
	surname = Surname;
	name = Name;
	patronymic = Patronymic;
	homeAddress = HomeAddress;
	registrationDate = RegistrationDate;
}
//---------------------------------------------------------------------------
#pragma package(smart_init)
