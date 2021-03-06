// ---------------------------------------------------------------------------

#ifndef NodeH
#define NodeH

class Node {
private:
	int key;
	UnicodeString name;

public:
	Node* pNext = 0;

	int GetKey() {
		return key;
	}

	void SetKey(int key) {
		this->key = key;
	}

	UnicodeString GetName() {
		return name;
	}

	void SetName(UnicodeString name) {
		this->name = name;
	}

	Node(int key, UnicodeString name) {
		this->key = key;
		this->name = name;
	}
};
// ---------------------------------------------------------------------------
#endif
