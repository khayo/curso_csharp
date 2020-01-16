#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	
	int cod, qtd;
	float val, total;
	
	printf("Digite o codigo do item: ");
	scanf("%d", &cod);
	
	switch(cod){
		case 1: 
			val = 4;
			break;
		case 2:
			val = 4.5;
			break;
		case 3:
			val = 5;
			break;
		case 4:
			val = 2;
			break;
		case 5:
			val = 1.5;
			break;
	}
	
	printf("Digite a quantidade: ");
	scanf("%d", &qtd);
	
	total = val * qtd;
	
	printf("Total: %.2f", total);
	
	
	return 0;
}
