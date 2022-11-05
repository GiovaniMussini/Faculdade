#include <stdio.h>
#include <locale.h>

int main (){
	setLocale(LC_ALL, "Portuguese");
	float baseValue, highValue;
	
	printf("Insira os valores da base e da altura do triangulo respectivamente:");
	scanf("%f",&baseValue);
	scanf("%f",&highValue);
	
	double triangleArea = baseValue * highValue/2;
	
	printf("A Area Do Triangulo E %lf",triangleArea);
}
