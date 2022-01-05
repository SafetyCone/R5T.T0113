using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0113;


namespace System
{
    public static class IProjectOperatorExtensions
    {
        public static IEnumerable<string> DetermineMissingProjectReferences(this IProjectOperator _,
            IEnumerable<string> existingProjectReferences,
            IEnumerable<string> requiredProjectReferences)
        {
            var output = requiredProjectReferences.Except(existingProjectReferences);
            return output;
        }
    }
}