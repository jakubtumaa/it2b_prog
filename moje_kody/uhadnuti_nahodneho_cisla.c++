#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {                            //Uhádnutí náhodného čísla
	
	int pokus = 0;

	srand(time(NULL));

	int cislo = rand() % 100 + 1;

	int uzivatel;
	printf("Zkus uhadnout cislo: ");
	scanf_s("%d", &uzivatel);

	if (uzivatel == cislo) {
		pokus += 1;
		printf("Spravne cislo na prvni pokus, gratulujeme!\n Zde mate pocet pokusu: %d", pokus);
		return 0;
	}

	while (uzivatel != cislo) {
		if (uzivatel < cislo) {
			printf("Moc nizko, zkus znovu: ");
			scanf_s("%d", &uzivatel);
			pokus += 1;
		}
		else if (uzivatel > cislo) {
			printf("Moc vysoko, zkus znovu: ");
			scanf_s("%d", &uzivatel);
			pokus += 1;
		}
	}
	
	printf("Spravne cislo!\nZde mas pocet pokusu: %d", pokus + 1);

	return 0;