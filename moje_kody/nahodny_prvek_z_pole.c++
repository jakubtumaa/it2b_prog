#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {                              //Náhodný prvek z pole

	srand(time(NULL));

	char arr[5] = { 'a','b','c','d','e' };
	
	int cislo = rand() % 6;

	printf(" %c", arr[cislo]);

	return 0;