namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class TransitivityRelations
    {
        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            var matrix = new Matrix(stringMatrixes);
            return matrix.IsTransitive();
        }
    }
}
