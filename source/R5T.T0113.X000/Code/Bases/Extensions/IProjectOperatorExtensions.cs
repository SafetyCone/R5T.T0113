using System;

using R5T.T0113;
using R5T.T0114;

using Instances = R5T.T0113.X000.Instances;


namespace System
{
    public static class IProjectOperatorExtensions
    {
        public static ProjectFileSpecification GetProjectFileSpecification(this IProjectOperator _,
            string projectName,
            string projectDescription,
            string projectDirectoryParentDirectoryPath,
            string[] projectReferenceFilePaths = default,
            string[] dependencyProjectReferenceFilePaths = default)
        {
            var projectDocumentation = projectDescription; // Reuse the description.
            var projectDefaultNamespaceName = Instances.ProjectNameOperator.GetDefaultNamespaceNameFromProjectName(projectName);

            var projectDirectoryPath = Instances.ProjectPathsOperator.GetProjectDirectoryPath(projectDirectoryParentDirectoryPath, projectName);
            var projectFilePath = Instances.ProjectPathsOperator.GetProjectFilePath(projectDirectoryPath, projectName);

            var output = new ProjectFileSpecification
            {
                DefaultNamespaceName = projectDefaultNamespaceName,
                DependencyProjectReferenceFilePaths = dependencyProjectReferenceFilePaths.EmptyIfDefault(),
                Description = projectDescription,
                Documentation = projectDocumentation,
                FilePath = projectFilePath,
                Name = projectName,
                ProjectReferenceFilePaths = projectReferenceFilePaths.EmptyIfDefault(),
            };

            return output;
        }
    }
}