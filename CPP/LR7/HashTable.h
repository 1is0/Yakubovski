// ---------------------------------------------------------------------------

#ifndef HashTableH
#define HashTableH
#include "Stack.h"

class HashTable {
protected:
	Stack** hashArray;
	int size;

	int HashFunc(int key);

public:
	HashTable(int size);
	void Print(TMemo* Memo1);
	void Add(int key, UnicodeString name);
	void Delete(int key, UnicodeString name);
	void DeleteByKeysInRange(int key1, int key2);
};

// ---------------------------------------------------------------------------
#endif
