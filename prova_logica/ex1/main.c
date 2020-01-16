#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int cod1, qtd1, cod2, qtd2;
	float val1, val2, total;
	
	printf("entre com o codigo da peca 1: ");
	scanf("%d", &cod1);	
	printf("entre com a quantidade de pecas: ");
	scanf("%d", &qtd1);	
	printf("entre com o valor unitario da peca : ");
	scanf("%f", &val1);	
	
	printf("entre com o codigo da peca 2: ");
	scanf("%d", &cod2);	
	printf("entre com a quantidade de pecas: ");
	scanf("%d", &qtd2);	
	printf("entre com o valor unitario da peca : ");
	scanf("%f", &val2);
	
	total = (val1 * qtd1) + (val2 * qtd2);
	
	
	printf("VALOR A PAGAR: %.2f", total); 
	return 0;
}
