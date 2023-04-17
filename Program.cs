using System.Text;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "VW Golf",
                                "Opel Astra",
                                "Audi A4",
                                "Ford Focus",
                                "Seat Leon",
                                "VW Passat",
                                "VW Polo",
                                "Mercedes C-Class" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("+++++++++");


            //using 'var'to not specify the data type
            var listCars = from car in cars select car; //object on the right side where want LINQ to use, left side represents one object
                                                        //result should be the same as for loop (for each car in cars list)


            Console.WriteLine(listCars);

            ShowElementValues(listCars);

            var listCarsContains = from car in cars where car.Contains("VW") select car;


            Console.WriteLine("+++++++++++++++++++");
            ShowElementValues(listCarsContains);

            var listCarsOrderBy = from car in cars orderby car ascending select car; //!orderby comes with ascending or descending

            Console.WriteLine("+++++++++++++++++++");
            ShowElementValues(listCarsOrderBy);

        }

            static void ShowElementValues(IEnumerable<string> list)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (string car in list)
                {
                    stringBuilder.Append(car + "\n"); //passing array objects into string builder that will help build the string. 
                                                      //'append'works as characters and string data
                }
                Console.WriteLine(stringBuilder.ToString());

                
             } 
            
            
            



            

     }
}
