#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                                

	char text[30];

	printf("Zadej libovolne slovo: ");
	scanf_s("%29s", text, 30);

	int delka = strlen(text);

	printf("%s ma delku %d.", text, delka);

	return 0;