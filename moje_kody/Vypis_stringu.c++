#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

int main() {                       

	char str[30];
	printf("Zadej nejake slovo: ");
	scanf_s("%29s", str, 30);

	printf("%s", str);

	return 0;