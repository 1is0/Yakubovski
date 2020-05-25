#include <stdio.h> 
#include <stdlib.h> 
#include <string.h> 
#include <windows.h>

void MyToUpper(char* str)
{
	int i = 0;
	while (str[i])
	{
		if ((str[i] >= -32 && str[i] <= -1) || (str[i] >= 97 && str[i] <= 122))
			str[i] -= 32;
		if (str[i] == -72)
			str[i] -= 16;
		i++;

	}
}
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char str[81], ch;
	int i = 0;
	printf("Input string(length <= 80):\n");
	while (((ch = getchar()) != '\n') && (i < 80)) {
		str[i++] = ch;
	}
	str[i] = '\0';
	printf("%d", 'ё');
	printf("%d", 'Ё');
	printf("%d", 'Ё' - 'ё');
	MyToUpper(str);
	i = 0;
	while (str[i])
	{
		switch (str[i])
		{
		case 'А':
		case 'A':
			printf(".- ");
			break;
		case 'Б':
		case 'B':
			printf("-... ");
			break;
		case 'В':
		case 'W':
			printf(".-- ");
			break;
		case 'Г':
		case 'G':
			printf("--. ");
			break;
		case 'Д':
		case 'D':
			printf("-.. ");
			break;
		case 'Е':
		case 'Ё':
		case 'E':
			printf(". ");
			break;
		case 'Ж':
		case 'V':
			printf("...- ");
			break;
		case 'З':
		case 'Z':
			printf("--.. ");
			break;
		case 'И':
		case 'I':
			printf(".. ");
			break;
		case 'Й':
		case 'J':
			printf(".--- ");
			break;
		case 'К':
		case 'K':
			printf("-.- ");
			break;
		case 'Л':
		case 'L':
			printf(".-.. ");
			break;
		case 'М':
		case 'M':
			printf("-- ");
			break;
		case 'Н':
		case 'N':
			printf("-. ");
			break;
		case 'О':
		case 'O':
			printf("--- ");
			break;
		case 'П':
		case 'P':
			printf(".--. ");
			break;
		case 'Р':
		case 'R':
			printf(".-. ");
			break;
		case 'С':
		case 'S':
			printf("... ");
			break;
		case 'Т':
		case 'T':
			printf("- ");
			break;
		case 'У':
		case 'U':
			printf("..- ");
			break;
		case 'Ф':
		case 'F':
			printf("..-. ");
			break;
		case 'Х':
		case 'H':
			printf(".... ");
			break;
		case 'Ц':
		case 'C':
			printf("-.-. ");
			break;
		case 'Ч':
			printf("---. ");
			break;
		case 'Ш':
			printf("---- ");
			break;
		case 'Щ':
		case 'Q':
			printf("--.- ");
			break;
		case 'Ъ':
			printf(".--.-. ");
			break;
		case 'Ы':
		case 'Y':
			printf("-.-- ");
			break;
		case 'Ь':
		case 'X':
			printf("-..- ");
			break;
		case 'Э':
			printf("...-...");
			break;
		case 'Ю':
			printf("..-- ");
			break;
		case 'Я':
			printf(".-.- ");
			break;
		case '1':
			printf(".---- ");
			break;
		case '2':
			printf("..--- ");
			break;
		case '3':
			printf("...-- ");
			break;
		case '4':
			printf("....- ");
			break;
		case '5':
			printf("..... ");
			break;
		case '6':
			printf("-.... ");
			break;
		case '7':
			printf("--... ");
			break;
		case '8':
			printf("---.. ");
			break;
		case '9':
			printf("----. ");
			break;
		case '0':
			printf("----- ");
			break;
		case '.':
			printf("");
			break;
		case ',':
			printf("");
			break;
		case ':':
			printf("");
			break;
		case '?':
			printf("");
			break;
		case '\'':
			printf("");
			break;
		case '-':
			printf("");
			break;
		case '/':
			printf("");
			break;
		case ';':
			printf("");
			break;
		default:
			putchar('#');
		}
		i++;
	}
}