#include <stdio.h>

int main() {               //Vypsání dělitelů

	int cislo;
	printf("Zadej cislo: ");
	scanf_s("%d", &cislo);

	for (int i = 1; i < cislo; i++) {
		if (cislo % i == 0) {
			printf("%d\n", i);
		}
	}

	return 0;
}