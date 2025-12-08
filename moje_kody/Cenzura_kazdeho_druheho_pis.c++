#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {

	char str[30];                         
	printf("Zadej libovolne slovo: ");
	scanf_s("%29s", str, 30);

	int i = 0;
	while (str[i] != '\0') {
		if (i % 2 != 0) {
			printf(" #");
		} else {
			printf(" %c", str[i]);
		}
		i++;
	}

	return 0;
}