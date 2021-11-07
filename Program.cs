using System;
using System.Linq;

namespace office
{
    class Program
    {
		static void Main(string[] args)
		{
			int companycount;
			Comp[] emp;
			Console.WriteLine("How many companys do you want to Enter:");
			companycount = int.Parse(Console.ReadLine());
			emp = new Comp[companycount];
			for (int i = 0; i < companycount; i++)
			{
				string name;
				string sector;
				string location;
				int age;
				Console.WriteLine("Enter the Name of the organisation:");
				name = Console.ReadLine();
				Console.WriteLine("Enter the Sector of the organisation:");
				sector = Console.ReadLine();
				Console.WriteLine("Enter the Location of the organisation:");
				location = Console.ReadLine();
				Console.WriteLine("Enter the Age of the organisation:");
				age = int.Parse(Console.ReadLine());
				Comp aa = new Comp(name, sector, location, age);
				if (!emp.Contains(aa))
				{
					emp[i] = aa;
				}
				else
				{
					Console.WriteLine("Company is already present:");
					i--;
				}
			}

		}	
    }
}
