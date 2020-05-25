// ---------------------------------------------------------------------------

#ifndef StackH
#define StackH
#include "Node.h"

template<typename T>
class Stack {
public:
	Node<T> *head = 0;
	void push(T data);
	void pop();
	T top();

	bool empty();

};

template<typename T>
void Stack<T>::push(T data) {
	Node<T> *tmp = new Node(data);
	tmp->pNext = head;
	head = tmp;
}

template<typename T>
void Stack<T>::pop() {
	if (head == 0) {
		return;
	}
	Node<T> *toDelete = head;
	head = toDelete->pNext;
	delete toDelete;
}

template<typename T>
T Stack<T>::top() {
	return head->GetData();
}

template<typename T>
bool Stack<T>::empty() {
	return (head == 0);
}

// ---------------------------------------------------------------------------
#endif
