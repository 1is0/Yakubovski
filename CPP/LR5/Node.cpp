// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Node.h"

std::string Node::GetData() {
	return data;
}

void Node::SetData(std::string data) {
	this->data = data;
}

Node::Node(std::string data) {
	this->data = data;
}
// ---------------------------------------------------------------------------
#pragma package(smart_init)
