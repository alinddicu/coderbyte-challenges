namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using System.Collections.Generic;

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
