<<<<<<< HEAD
﻿#include <stdio.h>
#include <conio.h>
#include <ctype.h>
#include <stdlib.h>
int readInt()
{
	char arr[7];
	char ch;
	int counter = 0;
	while ((ch = _getch()) != 13)
	{
		if ((ch == '\b') && counter > 0)
		{
			putchar(ch);
			putchar(' ');
			putchar(ch);
			arr[counter - 1] = '\0';
			counter--;
		}
		else if (ch > 40 && isdigit(ch) && counter < 6)
		{
			putchar(ch);
			arr[counter] = ch;
			counter++;
		}
	}
	putchar('\n');
	return atoi(arr);
}

void showMatrix(int** array, int size)
{
	int i = 0, j = 0;
	for (i = 0;i < size;i++)
	{
		for (j = 0;j < size;j++)
		{
			printf("%d\t", array[i][j]);
		}
		printf("\n");
	}
}

int main()
{
	printf("Enter an odd matrix order: ");
	int size = readInt();
	while (size < 1 || (size % 2 == 0))
	{
		printf("Invalid input.\n");
		_getch();
		size = readInt();
	}

	int i = 0, j = 0;
	int** array = (int**)malloc(size * sizeof(int*));
	for (i = 0; i < size; i++)
	{
		array[i] = (int*)malloc(size * sizeof(int));
		for (j = 0; j < size; j++)
		{
			array[i][j] = i * size + j;
		}
	}
	showMatrix(array, size);
	int length = 2;
	int k = 0, f = 0;
	int center = i = j = size / 2;
	printf("----------------------------------\n");
	printf("%d ", array[i][j]);
	while (length < size)
	{
		for (i -= 1;j < center + length / 2 + 1;j++)
		{
			printf("%d ", array[i][j]);
		}
		for (j -= 1, i += 1;i < center + length / 2 + 1;i++)
		{
			printf("%d ", array[i][j]);
		}
		for (i -= 1, j -= 1;j > center - length / 2 - 1;j--)
		{
			printf("%d ", array[i][j]);
		}
		for (i -= 1, j += 1;i > center - length / 2 - 1;i--)
		{
			printf("%d ", array[i][j]);
		}
		length += 2;
		i += 1;
	}
	
=======
﻿#include <stdio.h>
#include <conio.h>
#include <ctype.h>
#include <stdlib.h>
int readInt()
{
	char arr[7];
	char ch;
	int counter = 0;
	while ((ch = _getch()) != 13)
	{
		if ((ch == '\b') && counter > 0)
		{
			putchar(ch);
			putchar(' ');
			putchar(ch);
			arr[counter - 1] = '\0';
			counter--;
		}
		else if (ch > 40 && isdigit(ch) && counter < 6)
		{
			putchar(ch);
			arr[counter] = ch;
			counter++;
		}
	}
	putchar('\n');
	return atoi(arr);
}

void showMatrix(int** array, int size)
{
	int i = 0, j = 0;
	for (i = 0;i < size;i++)
	{
		for (j = 0;j < size;j++)
		{
			printf("%d\t", array[i][j]);
		}
		printf("\n");
	}
}

int main()
{
	printf("Enter an odd matrix order: ");
	int size = readInt();
	while (size < 1 || (size % 2 == 0))
	{
		printf("Invalid input.\n");
		_getch();
		size = readInt();
	}

	int i = 0, j = 0;
	int** array = (int**)malloc(size * sizeof(int*));
	for (i = 0; i < size; i++)
	{
		array[i] = (int*)malloc(size * sizeof(int));
		for (j = 0; j < size; j++)
		{
			array[i][j] = i * size + j;
		}
	}
	showMatrix(array, size);
	int length = 2;
	int k = 0, f = 0;
	int center = i = j = size / 2;
	printf("----------------------------------\n");
	printf("%d ", array[i][j]);
	while (length < size)
	{
		for (i -= 1;j < center + length / 2 + 1;j++)
		{
			printf("%d ", array[i][j]);
		}
		for (j -= 1, i += 1;i < center + length / 2 + 1;i++)
		{
			printf("%d ", array[i][j]);
		}
		for (i -= 1, j -= 1;j > center - length / 2 - 1;j--)
		{
			printf("%d ", array[i][j]);
		}
		for (i -= 1, j += 1;i > center - length / 2 - 1;i--)
		{
			printf("%d ", array[i][j]);
		}
		length += 2;
		i += 1;
	}
	
>>>>>>> 328a3232ad7e02f3d5fdbc4ef14646968fa87c2b
}