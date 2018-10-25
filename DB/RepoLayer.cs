using System;
using System.Collections;
using System.Collections.Generic;

namespace DB
{
    public class RepoLayer : IRepoLayer
    {
        /// <summary>
        /// Returns a list of KVP numbers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<int, int>> GetNumbers()
        {
            return new List<KeyValuePair<int, int>>()
            {
                new KeyValuePair<int, int>(1,1),
                new KeyValuePair<int, int>(2,3)
            };
        }
    }
}
