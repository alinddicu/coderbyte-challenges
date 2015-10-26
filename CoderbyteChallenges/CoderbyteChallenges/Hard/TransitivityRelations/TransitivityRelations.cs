namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    public class TransitivityRelations
    {
        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            return new Matrix(stringMatrixes).IsTransitive();
        }
    }
}
