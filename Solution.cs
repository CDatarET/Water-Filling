using System;

public class Test
{
	public static void Main()
	{
		int cases = Convert.ToInt32(Console.ReadLine());
		for(int c = 0; c < cases; c++){
			string[] inputs = Console.ReadLine().Split();
            int b1 = int.Parse(inputs[0]);
            int b2 = int.Parse(inputs[1]);
            int b3 = int.Parse(inputs[2]);
                
            int t = b1+b2+b3;
            if(t >= 2){
                Console.WriteLine("Not now");
            }
            else{
                Console.WriteLine("Water filling time");
            }
		}
	}
}
