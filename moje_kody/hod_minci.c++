#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	srand(time(NULL));

	int cislo = rand() % 2;

	if (cislo == 0) {
		printf("Panna");
	} else if (cislo == 1) {
		printf("Orel");
	}

	return 0;
}