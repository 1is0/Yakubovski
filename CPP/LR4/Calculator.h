// ---------------------------------------------------------------------------
#ifndef CalculatorH
#define CalculatorH
#include <iostream>
#include <vcl.h>

class Calculator {
public:
	std::string TransformIntoRPE(std::string input);
	int Priority(char c);
	bool IsOperation(char c);
	float ÑalculateRPE(std::string RPE,TEdit *E[10], int numOfVars);
	float Operation(float num1, float num2, char op);
};

// ---------------------------------------------------------------------------
#endif
