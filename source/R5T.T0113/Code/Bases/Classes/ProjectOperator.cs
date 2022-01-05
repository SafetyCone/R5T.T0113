using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectOperator : IProjectOperator
    {
        #region Static
        
        public static ProjectOperator Instance { get; } = new();

        #endregion
    }
}