// ---------------------------------------------------------------------------

#ifndef ListH
#define ListH
#include "Node.h"

class List {
private:
	int size = 0;

public:
	Node* head = NULL;

	int GetSize() {
		return size;
	}

	void SetSize(int Size) {
		size = Size;
	}
	void AddElement(int SerialNumber, String Surname, String Name, String Patronymic,
		String HomeAddress, String RegistrationDate);
	void ShowList(TMemo* Memo1);
	void ShowSearchList(TMemo* Memo1, int search—riteria, String searchItem);
	static void CompleteElement(List &List1, List &List2, int comleteNumber);
	void DeleteDuplicate();
};
// ---------------------------------------------------------------------------
#endif
