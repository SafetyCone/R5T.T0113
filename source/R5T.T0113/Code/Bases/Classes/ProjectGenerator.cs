using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectGenerator : IProjectGenerator
    {
        #region Static
        
        public static ProjectGenerator Instance { get; } = new();

        #endregion
    }
}