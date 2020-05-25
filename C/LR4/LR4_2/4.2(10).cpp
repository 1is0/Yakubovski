#include <stdio.h>
#include <locale.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>

int GetNumOfLinesInfile(FILE* f)
{
	int count = 0;
	char buffer[255];
	while (!feof(f))
	{
		fgets(buffer, 255, f);
		count++;
	}
	fseek(f, 0, SEEK_SET);
	return count;
}

void ToLowerStr(char* str)
{
	int i = 0;
	while (str[i])
		str[i++] = tolower(str[i]);
}

void ToUpperWordInStr(char* str, int start, int end)
{
	int i = start;
	while (str[i] && i < end)
		str[i++] = toupper(str[i]);
}

int IsSeparator(char c)
{
	char separators[] = " (){}&?!.,<>=#-+':^;%@*\"\n\t\\\0";
	int i = 0;
	while (separators[i])
	{
		if (separators[i] == c)
			return 1;
		i++;
	}
	return 0;
}

int IsKeyword(const char* word, char** KeywordsArray, int NumOfKeywords)
{
	for (int i = 0; i < NumOfKeywords; i++)
		if (strcmp(word, KeywordsArray[i]) == 0)
			return 1;
	return 0;
}

void ConvertKeywordsInStr(char* str, char** KeywordsArray, int NumOfKeywords)
{
	int start = 0, end = 0;
	char word[255];
	for (int i = 0;str[i];i++)
	{
		if (!IsSeparator(str[i]) && (i == 0 || IsSeparator(str[i - 1])))
			start = i;
		if (!IsSeparator(str[i]) && (i == 0 || IsSeparator(str[i + 1])))
		{
			end = i;
			strncpy_s(word, str + start, end - start + 1);
			word[end - start + 1] = '\0';
			if (IsKeyword(word, KeywordsArray, NumOfKeywords))
				ToUpperWordInStr(str, start, end + 1);

				//printf("%s\n", word);
		}
	}


}
int main()
{
	setlocale(LC_ALL, "Ru");
	char fileName1[] = "D:\\Proga_2sem_re\\LR4\\LR4_2\\4.2(10)\\program.txt";
	char fileName2[] = "D:\\Proga_2sem_re\\LR4\\LR4_2\\4.2(10)\\keywords.txt";
	char fileName3[] = "D:\\Proga_2sem_re\\LR4\\LR4_2\\4.2(10)\\result.txt";
	FILE* fpProgram;
	fopen_s(&fpProgram, fileName1, "r");
	if (fpProgram == NULL)
	{
		printf("Не удалось открыть файл");
		return 1;
	}
	FILE* fpKeywords;
	fopen_s(&fpKeywords, fileName2, "r");
	if (fpKeywords == NULL)
	{
		printf("Не удалось открыть файл");
		return 2;
	}
	FILE* fpResult;
	fopen_s(&fpResult, fileName3, "w");
	if (fpResult == NULL)
	{
		printf("Не удалось открыть файл");
		return 3;
	}

	char buffer[255];
	int NumOfKeywords = GetNumOfLinesInfile(fpKeywords);

	char** KeywordsArray = (char**)malloc(NumOfKeywords * sizeof(char*));
	for (int i = 0; i < NumOfKeywords; i++)
	{
		fgets(buffer, 255, fpKeywords);
		if (buffer[strlen(buffer) - 1] == '\n')
			buffer[strlen(buffer) - 1] = '\0';

		KeywordsArray[i] = (char*)malloc((strlen(buffer) + 1) * sizeof(char));
		strcpy_s(KeywordsArray[i], strlen(buffer) + 1, buffer);
	}
	fclose(fpKeywords);

	while (!feof(fpProgram))
	{
		fgets(buffer, 255, fpProgram);
		ToLowerStr(buffer);
		ConvertKeywordsInStr(buffer, KeywordsArray, NumOfKeywords);
		//fprintf(fpResult, buffer);
		fputs(buffer, fpResult);
		//printf("%s", buffer);
	}










	fclose(fpProgram);
	fclose(fpResult);
	return 0;
}