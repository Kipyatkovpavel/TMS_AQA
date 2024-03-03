using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Example
    {
        public void Run()
        {
            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();

            studentGrades.Add("Sasha", new List<int> { 7, 9, 10 });
            studentGrades.Add("Masha", new List<int> { 10, 9, 10 });
            studentGrades.Add("Stas", new List<int> { 6, 5, 4 });

            foreach (var item in studentGrades)
            {
                var averageMark = item.Value.Average();
                Console.WriteLine($"Средняя оценка : {averageMark}");
            }


        }
    }
}
