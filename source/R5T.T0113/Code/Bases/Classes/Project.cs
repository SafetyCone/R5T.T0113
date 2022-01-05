using System;


namespace R5T.T0113
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Project : IProject
    {
        #region Static
        
        public static Project Instance { get; } = new();

        #endregion
    }
}