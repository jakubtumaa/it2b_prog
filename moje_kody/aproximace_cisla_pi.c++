#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

int main() {                                            
	int body_v_kruhu = 0;
	int POCET_BODU = 1000000;
	float x, y;

	// Inicializace generátoru náhodných čísel
	srand(time(NULL));

	for (int i = 0; i < POCET_BODU; i++) {
		// Generování náhodného bodu v rozmezí <0,1>
		x = (float)rand() / RAND_MAX;
		y = (float)rand() / RAND_MAX;

		// Kontrola, zda bod leží uvnitř jednotkového kruhu
		if (x * x + y * y <= 1.0) {
			body_v_kruhu++;
		}
	}

	// Výpočet aproximace čísla Pí
	float pi = 4.0 * body_v_kruhu / POCET_BODU;
	printf("Aproximace cisla Pi pomoci metody Monte Carlo: %f\n", pi);

	return 0;
}