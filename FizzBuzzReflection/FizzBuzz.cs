namespace FizzBuzzReflection
{
    public class FizzBuzz
    {
        private List<IRuleInterface> rules = new List<IRuleInterface>();

        public FizzBuzz()
        {
            IEnumerable<Type> childRules = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(t => t.GetInterfaces().Contains(typeof(IRuleInterface)));

            foreach (Type childtype in childRules)
            {
                rules.Add((IRuleInterface)Activator.CreateInstance(childtype));
            }
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
