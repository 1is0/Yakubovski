#include <malloc.h>
#include "Tree.h" 

void AddNode(Node** tmp, int num)
{
	if (*tmp == NULL)
	{
		*tmp = (Node*)malloc(sizeof(Node));
		(*tmp)->pLeft = NULL;
		(*tmp)->pRight = NULL;
		(*tmp)->num = num;
	}
	else if (num > (*tmp)->num)
	{
		AddNode(&(*tmp)->pRight, num);
	}
	else if (num < (*tmp)->num)
	{
		AddNode(&(*tmp)->pLeft, num);
	}
}

void PrintTreeInAscendingOrder(Node* tmp)
{
	if (tmp == NULL)   // Базовый случай
	{
		return;
	}
	PrintTreeInAscendingOrder(tmp->pLeft);   //рекурсивный вызов левого поддерева
	printf("%d\t", tmp->num);
	PrintTreeInAscendingOrder(tmp->pRight);  //рекурсивный вызов правого поддерева
}

void PrintTreeInDescendingOrder(Node* tmp)
{
	if (tmp == NULL)   // Базовый случай
	{
		return;
	}
	PrintTreeInDescendingOrder(tmp->pRight);  //рекурсивный вызов правого поддерева
	printf("%d\t", tmp->num);
	PrintTreeInDescendingOrder(tmp->pLeft);   //рекурсивный вызов левого поддерева
}

int CalculateSum(Node* tmp)
{
	if (tmp == 0)   // Базовый случай
	{
		return 0;
	}
	return tmp->num + CalculateSum(tmp->pLeft) + CalculateSum(tmp->pRight);
}