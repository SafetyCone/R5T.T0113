using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionGenerator : ISolutionGenerator
    {
        #region Static
        
        public static SolutionGenerator Instance { get; } = new();

        #endregion
    }
}