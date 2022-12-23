//find primes in large numbers
#include <stdio.h>

int checkprime(unsigned long long int number); //define a function with suitable data type for our number
main()
{
	unsigned long long int i, number=600851475143;
	int counter;
	for(i=2;i<=number;i++)	
	{
		counter=0;
		while(checkprime(i)==1 &(number%i)==0) 	// before & function is controlling prime number or not 
		{					// after & check a remainder from division of the number
			number=number/i;
			counter++; 		
		}
		if (counter >0)
			printf("\n %llu to the power %d", i,counter);
	}
}

int checkprime(unsigned long long int number)
{
	int b,in=1;
	for (b=2;b<number/2;b++) //"number/2" to earn time 
	{
		if((number%b)==0)	//check prime
		{
			in=0;
			break;
		}
	}
	return in;
}
