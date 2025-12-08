#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

float obvodCtverce(float x) {             //Obvod čtverce
	  float y = 4 * x;
	  return y;
}


int main() {

	float a;
	printf("Zadej delku strany ctverce: ");
	scanf_s("%f", &a);

	float obvod_ctverce = obvodCtverce(a);
	printf("Obvod ctverce je %.2f.", obvod_ctverce);

	return 0;
}