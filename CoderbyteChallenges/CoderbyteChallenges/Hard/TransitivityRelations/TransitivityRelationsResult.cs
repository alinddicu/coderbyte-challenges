namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TransitivityRelationsResult
    {
        public TransitivityRelationsResult(bool isTransitive, IEnumerable<string> missingConnections)
        {
            IsTransitive = isTransitive;
            MissingConnections = missingConnections;
        }

        public bool IsTransitive { get; private set; }

        public IEnumerable<string> MissingConnections { get; private set; }
    }
}
