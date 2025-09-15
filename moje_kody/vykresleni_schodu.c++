#include <stdio.h>

int main() {                            //Vykreslení schodů

	int opakovani; 

	char znak;
	printf("Nacti znak: ");
	scanf_s(" %c", &znak);

	int vyska;
	printf("Nacti vysku: ");
	scanf_s("%d", &vyska);

	if (vyska < 0) {
		perror("Neplatny vstup");
		return 1;
	}

	for (int i = 0; i < vyska; i++) {
		for (int j = 0; j < i+1; j++) {
			printf(" %c", znak);
		}
		printf("\n");
	}
	return 0;
}