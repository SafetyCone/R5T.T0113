using System;
using System.Collections.Generic;

using R5T.T0113;

using Instances = R5T.T0113.X001.Instances;


namespace System
{
    public static class ISolutionOperatorExtensions
    {
        public static IEnumerable<string> DetermineMissingProjectReferences(this ISolutionOperator _,
            IEnumerable<string> existingProjectReferences,
            IEnumerable<string> requiredProjectReferences)
        {
            var output = Instances.ProjectOperator.DetermineMissingProjectReferences(
                existingProjectReferences,
                requiredProjectReferences);

            return output;
        }
    }
}
