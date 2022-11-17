// 1000'nin altındaki 3 ve 5'in katları
#include <stdio.h>
main(){
	int i ,t=0 ;
	for(i=0; i<1000;i++){
		if(i%3==0){
			printf("%d\n",i);
			t=t+i;
		}
		else if(i%5==0){
			printf("%d\n",i);
			t=t+i;
		}
	}
	printf("toplam: %d", t);
}
