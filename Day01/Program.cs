namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reading input
            String[] input = File.ReadAllLines("input.txt");
            
            // list for calories
            List<int> calories = new List<int>();

            int totalCalories = 0;

            // for - loop through whole input
            for (int i = 0; i < input.Length; i++)
            {
                // if - line = empty
                if (input[i] == "")
                {
                    // add calories to list and reset
                    calories.Add(totalCalories);
                    totalCalories = 0;
                }

                // else - add current calories to total
                else
                {
                    totalCalories += int.Parse(input[i]);
                }
            }

            // add last total and sort list
            calories.Add (totalCalories);
            calories.Sort();

            // write - highest calorie count
            Console.WriteLine($"Top Elf: {calories[calories.Count - 1]} Calories");

            // create sum of top 3
            Console.WriteLine(
                "The  total calories of top 3 are: "
                    + (
                        calories[calories.Count - 1]
                        + calories[calories.Count - 2]
                        + calories[calories.Count - 3]
                    )
            );
            // wait for output
            Console.ReadLine(); 
        }
    }
}