using FBJ.Api.Interfaces;
using System.Collections.Generic;

namespace FBJ.Api.Implementations
{
    public class DefaultSequenceProvider : ISequenceProvider
    {
        private Dictionary<int, string> _keysByNumber = new Dictionary<int, string>
        {
            { 3 , "Fizz" },
            { 5 , "Buzz" },
            { 7 , "Jazz" },
        };

        
        public List<string> GenerateSequence(int size)
        {
            var numbersOutput = new List<string>();
            for (int currentNumber = 1; currentNumber <= size; currentNumber++)
            {
                var encodedValue = GetStringMatch(currentNumber);
                var output = string.IsNullOrEmpty(encodedValue) ? currentNumber.ToString() : encodedValue;
                numbersOutput.Add(output);
            }

            return numbersOutput;
        }

        private string GetStringMatch(int currentNumber)
        {
            var encodedValue = string.Empty;
            foreach (var key in _keysByNumber.Keys)
            {
                if (currentNumber % key == 0 && _keysByNumber.TryGetValue(key, out var match))
                {
                    encodedValue = $"{encodedValue}{match}";
                }
            }

            return encodedValue;
        }
    }
}
