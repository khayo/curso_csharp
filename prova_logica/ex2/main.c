#include <iostream>
#include <math.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	
	float raio, area;
	
	printf("Digite o valor do raio: ");
	scanf("%f", &raio);
	area = pow(raio,2) * 3.141590;
	printf("area: %.2f", area);
	return 0;
}
