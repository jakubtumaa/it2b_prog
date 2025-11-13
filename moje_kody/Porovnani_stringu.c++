#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                                    

	char str1[30];
	printf("Zadej prvni slovo: ");
	scanf_s("%29s", str1, 30);

	char str2[30];
	printf("Zadej druhe slovo: ");
	scanf_s("%29s", str2, 30);

	if (strcmp(str1, str2) == 0) {
		printf("Stringy jsou stejne");
	} else {
		printf("Stringy nejsou stejne");
	} 

	return 0;
}