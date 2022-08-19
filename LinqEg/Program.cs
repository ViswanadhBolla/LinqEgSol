
namespace LinqEg
{
    class Program
    {
        static void main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(50);
            numbers.Add(80);
            numbers.Add(12);
            numbers.Add(23);
            // Query syntax
            var result = (from i in numbers
                          where i>45
                          select i).ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            //method syntax
            var resnumbers = numbers.Where(x => x > 45).Select(x =>x).ToList();
            foreach (var item in resnumbers)
            {
                Console.WriteLine(item);
            }

            List<string> fruits= new List<string>();
            fruits.Add("Avacado");
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Grapes");

            var res = (from i in fruits
                       where i.StartsWith("A")
                       select i).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }

            var resultfruits = fruits.Where(x => x.StartsWith("A")).Select(x=>x).ToList();
            foreach(var item in resultfruits)
            {
                Console.WriteLine(item);
            }

        }
    }
}