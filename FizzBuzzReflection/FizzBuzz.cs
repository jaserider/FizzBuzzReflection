namespace FizzBuzzReflection
{
    public class FizzBuzz
    {
        private List<IRuleInterface> rules = new List<IRuleInterface>();

        public FizzBuzz()
        {
            IEnumerable<Type> rulesImplemented = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(t => t.GetInterfaces().Contains(typeof(IRuleInterface)));

            foreach (Type ruleType in rulesImplemented)
            {
                rules.Add((IRuleInterface?)Activator.CreateInstance(ruleType)!);
            }
        }

        public List<Tuple<string, string>> GenerateList(int number)
        {
            var output = new List<Tuple<string, string>>();

            for (int i = 1; i <= number; i++)
            {
                output.Add(Tuple.Create(i.ToString(), GetStringFromNumber(i)));
            }

            return output;
        }

        public string GetStringFromNumber(int number)
        {
            foreach (IRuleInterface rule in rules)
            {
                if (rule.MatchesRule(number))
                {
                    return rule.GetFizzBuzzString();
                }
            }
            return number.ToString();
        }

    }
}
