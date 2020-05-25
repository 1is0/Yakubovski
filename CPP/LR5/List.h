// ---------------------------------------------------------------------------

#ifndef ListH
#define ListH
#include "Queue.h"

class List : public Queue {
public:
	void PushBack(std::string data);
	void PopFront();
	void Move(int min, int max, int point);
};
// ---------------------------------------------------------------------------
#endif
