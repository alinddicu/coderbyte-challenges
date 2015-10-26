namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    public class TransitivityRelations
    {
        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            var matrix = new Matrix(stringMatrixes);
            return matrix.IsTransitive();
        }
    }
}
