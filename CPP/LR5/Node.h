// ---------------------------------------------------------------------------

#ifndef NodeH
#define NodeH
#include <string>

class Node {
private:
	std::string data;

public:
	std::string GetData();
	void SetData(std::string data);
	Node(std::string data);
	Node* pNext = NULL;
	Node* pPrev = NULL;
};

// ---------------------------------------------------------------------------
#endif
