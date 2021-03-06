// ---------------------------------------------------------------------------

#pragma hdrstop

#include "HashTable.h"

HashTable::HashTable(int size) {
	this->size = size;
	hashArray = new Stack*[size];
	for (int i = 0; i < size; i++) {
		hashArray[i] = new Stack();
	}
}

void HashTable::Print(TMemo* Memo1) {
	Memo1->Clear();
	for (int i = 0; i < size; i++) {
		Memo1->Lines->Add("----------------------------");
		Memo1->Lines->Add(IntToStr(i + 1) + "-� ����");
		hashArray[i]->PrintStack(Memo1);
	}
}

int HashTable::HashFunc(int key) {
	return key % size;
}

void HashTable::Add(int key, UnicodeString name) {
	int index = HashFunc(key);
	hashArray[index]->push(key, name);
}

void HashTable::Delete(int key, UnicodeString name) {
	int index = HashFunc(key);
	hashArray[index]->DeleteNode(key, name);
}

void HashTable::DeleteByKeysInRange(int key1, int key2) {
	int index;
	for (int i = key1 + 1; i < key2; i++) {
		index = HashFunc(i);
		hashArray[index]->DeleteNodeByKey(i);
	}
}
// ---------------------------------------------------------------------------
#pragma package(smart_init)
