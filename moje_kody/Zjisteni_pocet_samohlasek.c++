#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                             

	char str[30];
	printf("Zadej libovolne slovo: ");
	scanf_s("%29s", str, 30);

	int smhlsky = 0;
	int i = 0;
	while (str[i] != '\0') {
		if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') {
			smhlsky += 1;
			i++;
		}
		else {
		i++;
		}
	}
	
	printf("\nPocet samohlasek: %d", smhlsky);
	return 0;