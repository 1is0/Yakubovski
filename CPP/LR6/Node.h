// ---------------------------------------------------------------------------

#ifndef NodeH
#define NodeH

// ---------------------------------------------------------------------------
class Node {
private:
	UnicodeString surname;
	int id;

public:
	Node(int id, UnicodeString surname) {
		this->id = id;
		this->surname = surname;
		pLeft = NULL;
		pRight = NULL;
	}

	Node *pLeft;
	Node *pRight;

	UnicodeString GetSurname() {
		return surname;
	}

	void SetSurname(UnicodeString surname) {
		this->surname = surname;
	}

	int GetID() {
		return id;
	}

	void SetID(int id) {
		this->id = id;
	}
};
#endif
