using System;

namespace _2PrintCompanyInformation
{
    class Program
    {
        static void Main()
        {
            Console.Write("Company name:");
            string comName = Console.ReadLine();
            Console.Write("Company address:");
            string comAdr = Console.ReadLine();
            Console.Write("Phone number:");
            string comPhone = Console.ReadLine();
            Console.Write("Fax number:");
            string comFax = Console.ReadLine();
            Console.Write("Web site:");
            string comWeb = Console.ReadLine();
            Console.Write("Manager first name:");
            string mngrFName = Console.ReadLine();
            Console.Write("Manager last name:");
            string mngrLName = Console.ReadLine();
            Console.Write("Manager age:");
            int mngrAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone:");
            string mngrPhone = Console.ReadLine();

           
             

            Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})" ,comName,comAdr,comPhone,comFax,comWeb,mngrFName,mngrLName,mngrAge,mngrPhone);
            
            



           

        }
    }
}
