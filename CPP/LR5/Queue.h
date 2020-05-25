// ---------------------------------------------------------------------------

#ifndef QueueH
#define QueueH
#include <string>
#include "Node.h"

class Queue {
public:
	Node* head = NULL;
	Node* tail = NULL;
	void Refresh(TListBox *ListBox1);
	void PushFront(std::string data);
	void PopBack();
	std::string GetFront();
	std::string GetBack();
	bool Empty();
};
// ---------------------------------------------------------------------------
#endif
