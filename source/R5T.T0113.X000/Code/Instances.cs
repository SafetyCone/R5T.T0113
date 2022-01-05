using System;

using R5T.T0040;
using R5T.T0041;
using R5T.T0112;


namespace R5T.T0113.X000
{
    public static class Instances
    {
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IProjectNameOperator ProjectNameOperator { get; } = T0112.ProjectNameOperator.Instance;
        public static IProjectPathsOperator ProjectPathsOperator { get; } = T0040.ProjectPathsOperator.Instance;
        public static ISolutionFileNameOperator SolutionFileNameOperator { get; } = T0040.SolutionFileNameOperator.Instance;
    }
}
