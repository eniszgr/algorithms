#include <stdio.h>
int palindrome(unsigned int number);
int main(){

    unsigned int result, i,j,b=0;
    printf("largest palindrome made from the product of two 3-digit numbers is \n");
    for(i=999;i>=100;i--)
    {
        for(j=999;j>=100;j--)
        {
            result=i*j;
            if(palindrome(result)&result>b)
            {
                b=result;
            }
        }
    }
    printf("%u",b);
}
int palindrome(unsigned int result)
{
    int number=result,reverse_number=0;
    float remain;
    while (number>0)
    {
        remain=number%10;
        reverse_number=reverse_number*10+remain;
        number=number/10;
    }
    return reverse_number==result;

}
