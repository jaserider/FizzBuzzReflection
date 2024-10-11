using FizzBuzzReflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzReflection
{
    public class FizzBuzzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Fizzbuzz";
        }
    }

    public class FizzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 3 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Fizz";
        }
    }

    public class BuzzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 5 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Buzz";
        }
    }
}
