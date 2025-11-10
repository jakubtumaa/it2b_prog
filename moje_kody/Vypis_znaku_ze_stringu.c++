#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#include <string.h>

int main() {                      
	
    char str[] = "nastaveni";

	int i = 0;
	while (str[i] != '\0') {
		printf("%c\n", str[i]);
		i++;
	}
	printf("\nDelka stringu: %d", i);
	return 0;