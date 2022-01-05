using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionOperator : ISolutionOperator
    {
        #region Static
        
        public static SolutionOperator Instance { get; } = new();

        #endregion
    }
}