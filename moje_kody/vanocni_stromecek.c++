#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

void pyramida(int patra) {                    
	for (int i = 0; i < patra; i++) {
		for (int j = 0; j < i + 1; j++) {
			printf("#");
			}
		printf("\n");
		} 
	}

void stromecek(int patra) {
	printf("*\n");
	for (int i = 0; i < patra; i++) {
		pyramida(8);
	}
	
}

void stojan(int vyska) {
	for (int i = 0; i <= vyska; i++) {
		printf("|\n");
		if (i == vyska) {
			printf("---");
		}
	}
}

int main() {
	stromecek(2);
	stojan(3);

	return 0;
}