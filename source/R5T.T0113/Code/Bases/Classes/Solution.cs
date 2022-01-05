using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Solution : ISolution
    {
        #region Static
        
        public static Solution Instance { get; } = new();

        #endregion
    }
}