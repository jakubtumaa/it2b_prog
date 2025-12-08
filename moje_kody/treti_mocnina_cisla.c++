#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int umocni3(int x) {                 
	int y = x * x * x;
		return y;
}


int main() {
	
	int a;
	printf("Nacti cislo: ");
	scanf_s("%d", &a);

	int treti_mocnina_c = umocni3(a);
	printf("%d", treti_mocnina_c);

	return 0;
}