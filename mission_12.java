//What is the value of the first triangle number to have over five hundred divisors?
package euler;

public class mission_12 {
	static int dividers_counter(long number) {
		int counter=2; 	//counter was started with 2 to earn time because every number can be divided 1 and itself
		for (int i=2; i<=(number/2);i++) {
			if (number%i==0) {
				counter++;
			}
		}
		return counter;
	}

	public static void main(String[] args) {
		
		long number=1,adding=2;
		while(true) {
			if (dividers_counter(number)>500) {
				System.out.println(number);
				break;
			}
			else {
				number+=adding;
				adding++;
			}
		}

	}

}
