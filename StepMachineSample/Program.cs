using StepMachine;
using System;

namespace StepMachineSample
{
    /// <summary>
    /// Sample StepMachine usage
    /// </summary>
    internal class Program
    {
        private static void SampleBruteForce(long maxValue)
        {
            Stepper.Start();
            Console.WriteLine("BruteForce : count sum of numbers devisable by two for <= {0}", maxValue);
            var max = Stepper.NewLong(maxValue);
            var sum = Stepper.NewLong();
            var two = Stepper.NewLong(2);
            var zero = Stepper.NewLong(); // it's initialized to zero
            for (var i = Stepper.NewLong(1); i <= max; i++)
            {
                if ((i % two) == zero)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum={0}, Steps={1}", sum, Stepper.TotalSteps);
        }

        private static void SampleUseFormula(long maxValue)
        {
            Stepper.Start();
            Console.WriteLine("Formula : count sum of numbers devisable by two for <= {0}", maxValue);
            var max = Stepper.NewLong(maxValue);

            var two = Stepper.NewLong(2);
            var numberOfTerms = max / two;
            var sum = (numberOfTerms * (numberOfTerms + Stepper.NewLong(1)));
            Console.WriteLine("Sum={0}, Steps={1}", sum, Stepper.TotalSteps);
        }

        private static void Main()
        {
            Console.WriteLine("BruteForce : O(n) vs Formula : O(1)");
            Console.WriteLine("---------------------------------------");

            SampleBruteForce(9);
            SampleUseFormula(9);

            SampleBruteForce(10);
            SampleUseFormula(10);

            SampleBruteForce(10000);
            SampleUseFormula(10000);

            SampleBruteForce(1000000);
            SampleUseFormula(1000000);

            Console.ReadLine();
        }
    }
}