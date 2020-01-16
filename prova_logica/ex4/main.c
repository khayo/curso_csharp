#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	float a, b, c, delta, x1, x2;
	
	printf("Calculadora de equancao de segundo grau\n");
	printf("Entre com o valor de a: ");
	scanf("%f", &a);
	printf("Entre com o valor de b: ");
	scanf("%f", &b);
	printf("Entre com o valor de c: ");
	scanf("%f", &c);
	
	delta = pow(b,2)- (4 * a * c) ;
	
	printf("delta = %.2f\n", delta);
	
	if(delta < 0 || a == 0){
		printf("Impossivel calcular");
		exit(1);
	}
	
	x1 = (-b+sqrt(delta)) / (2 * a);
	x2 = (-b-sqrt(delta)) / (2 * a);
	
	printf("x1 = %.2f\n", x1);
	printf("x2 = %.2f\n", x2);
	
	return 0;
}
