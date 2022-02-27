﻿namespace Jint.DebugAdapter.Protocol.Types
{
    /// <summary>
    /// Provides formatting information for a stack frame.
    /// </summary>
    public class StackFrameFormat
    {
        /// <summary>
        /// Displays parameters for the stack frame.
        /// </summary>
        public bool? Parameters { get; set; }

        /// <summary>
        /// Displays the types of parameters for the stack frame.
        /// </summary>
        public bool? ParameterTypes { get; set; }

        /// <summary>
        /// Displays the names of parameters for the stack frame.
        /// </summary>
        public bool? ParameterNames { get; set; }

        /// <summary>
        /// Displays the values of parameters for the stack frame.
        /// </summary>
        public bool? ParameterValues { get; set; }

        /// <summary>
        /// Displays the line number of the stack frame.
        /// </summary>
        public bool? Line { get; set; }

        /// <summary>
        /// Displays the module of the stack frame.
        /// </summary>
        public bool? Module { get; set; }

        /// <summary>
        /// Includes all stack frames, including those the debug adapter might otherwise hide.
        /// </summary>
        public bool? IncludeAll { get; set; }
    }
}
