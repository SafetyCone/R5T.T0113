using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0113;

using Instances = R5T.T0113.X002.Instances;


namespace System
{
    public static class IProjectOperatorExtensions
    {
        public static Guid GetProjectIdentity(this IProjectOperator _,
            string projectIdentityString)
        {
            var output = Instances.GuidOperator.FromStringStandard(projectIdentityString);
            return output;
        }

        public static IEnumerable<Guid> GetProjectIdentities(this IProjectOperator _,
            IEnumerable<string> projectIdentityStrings)
        {
            var output = projectIdentityStrings
                .Select(xProjectIdentityString => _.GetProjectIdentity(xProjectIdentityString))
                ;

            return output;
        }
    }
}