using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questrade.ResharperBenefits.Infrastructure
{
    public class Helpers
    {
        public static StringBuilder BuildNames(IEnumerable<string> names)
        {
            var enumerable = names as string[] ?? names.ToArray();
            foreach (var name in enumerable)
            {
                Console.WriteLine("Found" + name);
            }

            var allNames = new StringBuilder();

            foreach (var name in enumerable)
            {
                allNames.AppendFormat("my Name : {0}", name);
            }

            return allNames;
        }

        public async Task<int> GetLongRunningResults()
        {
            int result = await GetLongRunningAsync();
            return result;
        }

        private Task<int> GetLongRunningAsync()
        {
            throw new NotImplementedException();
        }
    }
}
