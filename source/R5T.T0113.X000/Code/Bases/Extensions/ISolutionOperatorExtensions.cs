using System;

using R5T.T0113;
using R5T.T0114;

using Instances = R5T.T0113.X000.Instances;


namespace System
{
    public static class ISolutionOperatorExtensions
    {
        /// <summary>
        /// Just generates the solution file path required for the solution file specification.
        /// </summary>
        public static SolutionFileSpecification GetSolutionFileSpecification(this ISolutionOperator _,
            string solutionName,
            string solutionDirectoryPath)
        {
            var solutionFileName = Instances.SolutionFileNameOperator.GetSolutionFileName(solutionName);
            var solutionFilePath = Instances.PathOperator.GetFilePath(
                solutionDirectoryPath,
                solutionFileName);

            var output = new SolutionFileSpecification
            {
                Name = solutionName,
                FilePath = solutionFilePath,
            };

            return output;
        }
    }
}
