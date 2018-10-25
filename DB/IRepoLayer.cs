using System.Collections.Generic;

namespace DB
{
    public interface IRepoLayer
    {
        IEnumerable<KeyValuePair<int, int>> GetNumbers();
    }
}