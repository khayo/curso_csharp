#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int qtd, in = 0, out = 0, i = 0;
	
	printf("Quantos valores deseja testar:");
	scanf("%d", &qtd);
	
	int valores[qtd];
	
	for(i = 0; i < qtd; i++){
		scanf("%d", &valores[i]);
	}
	
	for(i = 0; i < qtd; i++){
		//printf("valor %d: %d\n", i, valores[i]);
		if(valores[i] >= 10 && valores[i] <= 20){
			in++;
		} else {
			out++;
		}
	}
	
	printf("in: %d\n", in);
	printf("out: %d", out);
	return 0;
}
