using System.Collections.Generic;

namespace FBJ.Api.Interfaces
{
    public interface ISequenceProvider
    {
        List<string> GenerateSequence(int number);
    }
}
