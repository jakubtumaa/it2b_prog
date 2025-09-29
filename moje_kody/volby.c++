#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	int pocetstr = 8;
	char strany[][14] = { "ANO", "SPOLU", "SPD", "STAN", "Pirati", "Motoriste" ,"Stacilo", "Jine" };

	float preference[8] = { 29.3, 20.5, 13.4, 11.1, 10, 6, 5.5,  4.2 };

	srand(time(NULL));

	float volici = rand() % 31 + 50;

	float ano = 0, spolu = 0, spd = 0, stan = 0, pirati = 0, motoriste = 0, stacilo = 0, jine = 0;

	float sance = rand() % 100 + 1; //vygenerovani sance



	//generator hlasu podle sance
	for (float i = 0; i < volici; i++) {
		if ((0 < sance) && (sance <= 4.2)) {
			jine++;
			sance = rand() % 100 + 1;
		}
		else if ((4.2 < sance) && (sance <= 9.7)) {
			stacilo++;
			sance = rand() % 100 + 1;
		}
		else if ((9.7 < sance) && (sance <= 15.7)) {
			motoriste++;
			sance = rand() % 100 + 1;
		}
		else if ((15.7 < sance) && (sance <= 25.7)) {
			pirati++;
			sance = rand() % 100 + 1;
		}
		else if ((25.7 < sance) && (sance <= 36.8)) {
			stan++;
			sance = rand() % 100 + 1;
		}
		else if ((36.8 < sance) && (sance <= 50.2)) {
			spd++;
			sance = rand() % 100 + 1;
		}
		else if ((50.2 < sance) && (sance <= 70.7)) {
			spolu++;
			sance = rand() % 100 + 1;
		}
		else if ((70.7 < sance) && (sance <= 100)) {
			ano++;
			sance = rand() % 100 + 1;
		}
	}

	// Prevod pocet hlasu na procenta
	ano = (ano / volici) * 100;
	spolu = (spolu / volici) * 100;
	spd = (spd / volici) * 100;
	stan = (stan / volici) * 100;
	pirati = (pirati / volici) * 100;
	motoriste = (motoriste / volici) * 100;
	stacilo = (stacilo / volici) * 100;
	jine = (jine / volici) * 100;

	printf("ANO: %.2f\n SPOLU: %.2f\n SPD: %.2f\n STAN: %.2f\n Pirati: %.2f\n Motoriste: %.2f\n Stacilo: %.2f\n Jine: %.2f", ano, spolu, spd, stan, pirati, motoriste, stacilo, jine);

	return 0;
}