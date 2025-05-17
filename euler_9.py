#There exists exactly one Pythagorean triplet for which a + b + c = 1000.
#Find the product abc.
for a in range (1,1000):
    for b in range (a+1,1000):
        c=1000-(a+b)
        if ((c*c)==(a*a)+(b*b))and(a+b+c==1000):
            print(a*b*c)
