#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                                     

	char str[30];
	printf("Zadej slovo: ");
	scanf_s("%29s", str, 30);

	int i = 0;
	char opak[30];
	
	for (int i = 0; i < strlen(str); i++) {
		opak[strlen(str) - i - 1] = str[i];
	}
	opak[strlen(str)] = '\0';

	if (strcmp(str, opak) == 0) {
		printf("Slovo je palindrom");
	} else {
		printf("Slovo neni palindrom");
	}

	return 0;
}