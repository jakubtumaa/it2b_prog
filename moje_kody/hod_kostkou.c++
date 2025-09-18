#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	srand(time(NULL));

	int kostka;
	printf("Zvol pocet kostek: ");
	scanf_s("%d", &kostka);

	int strany;
	printf("Zvol pocet stran kostky: ");
	scanf_s("%d", &strany);

	for (int i = 0; i < kostka; i++) {
		int cislo = rand() % strany + 1;
		printf("Padlo cislo: %d\n", cislo);
	}

	return 0;
}