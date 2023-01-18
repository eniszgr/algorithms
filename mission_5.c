#include <stdio.h>
int divisible(unsigned number);
main()
{
	unsigned number=20;
	while(1)
	{
		if(divisible (number)==0)
		{
			number++;
		}
		else if(divisible (number)==1)
		{
			break;
		}
	}
	printf("%u",number);
	
}
int divisible(unsigned number)
{
	int i;
	for(i=1;i<=20;i++)
	{
		if(number%i!=0)
		{
			return 0;
		}
	}
	return 1;
}

