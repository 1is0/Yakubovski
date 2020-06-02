// ---------------------------------------------------------------------------

#ifndef TreeH
#define TreeH

#include "Node.h"
class Tree {
public:
	Node* root;

	Tree() {
        root = NULL;
	}
	void PrintMiniTree(Node* tmp, TTreeView* TreeView1, int &index);
	void PrintTree(TTreeView *TreeView1);
	void AddNode(Node*& tmp, int id, UnicodeString surname);
	void CreateTreeFromArray(Node*& tmp, int* idArray, UnicodeString* surnameArray, int left, int right);
	Node* SearchByKey(Node* tmp, int keyID);
	void DeleteNode(int keyID);
	void DirectBypass(TMemo *Memo1, Node* tmp);
	void BackwardBypass(TMemo *Memo1, Node* tmp);
    void KeyBypass(TMemo *Memo1, Node* tmp);

};
// ---------------------------------------------------------------------------
#endif
