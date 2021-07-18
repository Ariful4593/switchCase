using System;
namespace switchProgram{
	public class Test{
		public static void Main(string[] args){
			int a;
			Console.Write("Please enter value of a: ");
			a = Convert.ToInt32(Console.ReadLine());
			switch(a){
				case 1:
					Console.WriteLine("It is One");
					break;
				case 2:
					Console.WriteLine("It is Two");
					break;
				case 3:
					Console.WriteLine("It is Three");
					break;
				case 4:
					Console.WriteLine("It is Four");
					break;
				default:
					Console.WriteLine("Nothing Found Value");
					break;
				
			}
		}
	}
}

