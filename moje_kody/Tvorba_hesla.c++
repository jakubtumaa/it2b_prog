#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                                   

	char str[30];
	printf("Vytvor heslo: ");
	scanf_s(" %29s", str, 29);

	int mp = 0;
	int vp = 0;
	int c = 0;
	int z = 0;
	int i = 0;
	
	while(str[i] != '\0') {
		if (str[i] >= 'a' && str[i] <= 'z') {
			mp++;
		}
		else if (str[i] >= 'A' && str[i] <= 'Z') {
			vp++;
		}
		else if (str[i] >= '0' && str[i] <= '9') {
			c++;
		}
		else if (str[i] >= 33 && str[i] <= 47) {
			z++;
		}
		i++;
	}


	if (mp < 3) {
		printf("Prilis malo malych znaku, zmen heslo!");
	}
	else if (vp < 2) {
		printf("Prilis malo velkych znaku, zmen heslo!");
	}
	else if (c < 1) {
		printf("Prilis malo cislic, zmen heslo!");
	}
	else if (z < 1) {
		printf("Prilis malo specialnich znaku, zmen heslo!");
	}
	else {
		printf("Heslo je podle pozadavku.");
	}

	return 0;
}