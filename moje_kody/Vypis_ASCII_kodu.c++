#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                       

	char str[30];
	printf("Zadej slovo: ");
	scanf_s(" %29s", str, 29);

	int i = 0;
	while (str[i] != '\0') {
		printf("%d ", str[i]);
		i++;
	}

	return 0;
}