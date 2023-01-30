// find the 10001st prime number
#include <stdio.h>
int checkprime (long long unsigned  number);
int main()
{
	long long unsigned int counter=1,number=1;
	while (1)
	{
		if (checkprime(number)==1 & counter!=10001)
		{
			counter++;	
		}
		else if (checkprime(number)==1 & counter==10001)
		{
			printf ("%llu",number);
			break;
		}
		number++;
	}
}
int checkprime (unsigned long long number)
{
	long long unsigned i;
	if (number==1) 
	{
		return 0;
	}
	else if (number==2) 
	{
		return 1;
	}
	else if (number>2) 
	{
		for (i=2;i<number;i++)
		{
			if (number%i==0)
			{	
				return 0;
			}
		}
		return 1;
	}
}
