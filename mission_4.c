//Find the largest palindrome made from the product of two 3-digit numbers.
#include <stdio.h>
int palindrome(unsigned long long int number);
main(){
	
	unsigned long long result, i,j;
	printf("largest palindrome made from the product of two 3-digit numbers is \n");
	for(i=999;i>=100;i--)
	{
		for(j=999;j>=100;j--)
		{
			result=i*j;
			palindrome(result);
		}
	}

}
int palindrome(unsigned long long result)
{
	int number,reverse_number=0;
	float remain;
	
	number=result;
	while (number>0)
	{
		remain=number%10;
		reverse_number=reverse_number*10+remain;
		number=number/10;
	}
	if (result==reverse_number) printf("%u \n",reverse_number);
}
