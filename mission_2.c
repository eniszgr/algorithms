//4000000 geçmeyen Fibonacci dizisindeki cift terimlerin toplami
#include<stdio.h>
main()
{
	int a=1,b=2,c=3,t=2;
	printf("%d, %d, %d,",a,b,c);
	while(c<4000000){
		a=b;
		b=c;
		c=a+b;
		if(c<4000000){
			printf(",%d",c);
			if(c%2==0){
				t=t+c;
			}
		}
	}
	printf("\ntoplam %d",t);
}
