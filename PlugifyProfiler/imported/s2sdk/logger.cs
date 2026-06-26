using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: logger)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Registers a new logging channel with specified properties.
		/// </summary>
		/// <param name="name">The name of the logging channel.</param>
		/// <param name="iFlags">Flags associated with the logging channel.</param>
		/// <param name="verbosity">The verbosity level for the logging channel.</param>
		/// <param name="color">The color for messages logged to this channel.</param>
		/// <returns>The ID of the newly created logging channel.</returns>
		internal static delegate*<string, int, LoggingVerbosity, int, int> RegisterLoggingChannel = &___RegisterLoggingChannel;
		internal static delegate* unmanaged[Cdecl]<String192*, int, LoggingVerbosity, int, int> __RegisterLoggingChannel;
		private static int ___RegisterLoggingChannel(string name, int iFlags, LoggingVerbosity verbosity, int color)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __RegisterLoggingChannel(&__name, iFlags, verbosity, color);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a tag to a specified logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel to which the tag will be added.</param>
		/// <param name="tagName">The name of the tag to add to the channel.</param>
		internal static delegate*<int, string, void> AddLoggerTagToChannel = &___AddLoggerTagToChannel;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __AddLoggerTagToChannel;
		private static void ___AddLoggerTagToChannel(int channelID, string tagName)
		{
			var __tagName = NativeMethods.ConstructString(tagName);
			try {
				__AddLoggerTagToChannel(channelID, &__tagName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__tagName);
			}
		}

		/// <summary>
		/// Checks if a specified tag exists in a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="tag">The name of the tag to check for.</param>
		/// <returns>True if the tag exists in the channel, otherwise false.</returns>
		internal static delegate*<int, string, Bool8> HasLoggerTag = &___HasLoggerTag;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Bool8> __HasLoggerTag;
		private static Bool8 ___HasLoggerTag(int channelID, string tag)
		{
			Bool8 __retVal;
			var __tag = NativeMethods.ConstructString(tag);
			try {
				__retVal = __HasLoggerTag(channelID, &__tag);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__tag);
			}
			return __retVal;
		}

		/// <summary>
		/// Checks if a logging channel is enabled based on severity.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="severity">The severity of a logging operation.</param>
		/// <returns>True if the channel is enabled for the specified severity, otherwise false.</returns>
		internal static delegate*<int, LoggingSeverity, Bool8> IsLoggerChannelEnabledBySeverity = &___IsLoggerChannelEnabledBySeverity;
		internal static delegate* unmanaged[Cdecl]<int, LoggingSeverity, Bool8> __IsLoggerChannelEnabledBySeverity;
		private static Bool8 ___IsLoggerChannelEnabledBySeverity(int channelID, LoggingSeverity severity)
		{
			Bool8 __retVal = __IsLoggerChannelEnabledBySeverity(channelID, severity);
			return __retVal;
		}

		/// <summary>
		/// Checks if a logging channel is enabled based on verbosity.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="verbosity">The verbosity level to check.</param>
		/// <returns>True if the channel is enabled for the specified verbosity, otherwise false.</returns>
		internal static delegate*<int, LoggingVerbosity, Bool8> IsLoggerChannelEnabledByVerbosity = &___IsLoggerChannelEnabledByVerbosity;
		internal static delegate* unmanaged[Cdecl]<int, LoggingVerbosity, Bool8> __IsLoggerChannelEnabledByVerbosity;
		private static Bool8 ___IsLoggerChannelEnabledByVerbosity(int channelID, LoggingVerbosity verbosity)
		{
			Bool8 __retVal = __IsLoggerChannelEnabledByVerbosity(channelID, verbosity);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the verbosity level of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <returns>The verbosity level of the specified logging channel.</returns>
		internal static delegate*<int, int> GetLoggerChannelVerbosity = &___GetLoggerChannelVerbosity;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetLoggerChannelVerbosity;
		private static int ___GetLoggerChannelVerbosity(int channelID)
		{
			int __retVal = __GetLoggerChannelVerbosity(channelID);
			return __retVal;
		}

		/// <summary>
		/// Sets the verbosity level of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="verbosity">The new verbosity level to set.</param>
		internal static delegate*<int, LoggingVerbosity, void> SetLoggerChannelVerbosity = &___SetLoggerChannelVerbosity;
		internal static delegate* unmanaged[Cdecl]<int, LoggingVerbosity, void> __SetLoggerChannelVerbosity;
		private static void ___SetLoggerChannelVerbosity(int channelID, LoggingVerbosity verbosity)
		{
			__SetLoggerChannelVerbosity(channelID, verbosity);
		}

		/// <summary>
		/// Sets the verbosity level of a logging channel by name.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="name">The name of the logging channel.</param>
		/// <param name="verbosity">The new verbosity level to set.</param>
		internal static delegate*<int, string, LoggingVerbosity, void> SetLoggerChannelVerbosityByName = &___SetLoggerChannelVerbosityByName;
		internal static delegate* unmanaged[Cdecl]<int, String192*, LoggingVerbosity, void> __SetLoggerChannelVerbosityByName;
		private static void ___SetLoggerChannelVerbosityByName(int channelID, string name, LoggingVerbosity verbosity)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__SetLoggerChannelVerbosityByName(channelID, &__name, verbosity);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets the verbosity level of a logging channel by tag.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="tag">The name of the tag.</param>
		/// <param name="verbosity">The new verbosity level to set.</param>
		internal static delegate*<int, string, LoggingVerbosity, void> SetLoggerChannelVerbosityByTag = &___SetLoggerChannelVerbosityByTag;
		internal static delegate* unmanaged[Cdecl]<int, String192*, LoggingVerbosity, void> __SetLoggerChannelVerbosityByTag;
		private static void ___SetLoggerChannelVerbosityByTag(int channelID, string tag, LoggingVerbosity verbosity)
		{
			var __tag = NativeMethods.ConstructString(tag);
			try {
				__SetLoggerChannelVerbosityByTag(channelID, &__tag, verbosity);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__tag);
			}
		}

		/// <summary>
		/// Retrieves the color setting of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <returns>The color value of the specified logging channel.</returns>
		internal static delegate*<int, int> GetLoggerChannelColor = &___GetLoggerChannelColor;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetLoggerChannelColor;
		private static int ___GetLoggerChannelColor(int channelID)
		{
			int __retVal = __GetLoggerChannelColor(channelID);
			return __retVal;
		}

		/// <summary>
		/// Sets the color setting of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="color">The new color value to set for the channel.</param>
		internal static delegate*<int, int, void> SetLoggerChannelColor = &___SetLoggerChannelColor;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetLoggerChannelColor;
		private static void ___SetLoggerChannelColor(int channelID, int color)
		{
			__SetLoggerChannelColor(channelID, color);
		}

		/// <summary>
		/// Retrieves the flags of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <returns>The flags of the specified logging channel.</returns>
		internal static delegate*<int, int> GetLoggerChannelFlags = &___GetLoggerChannelFlags;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetLoggerChannelFlags;
		private static int ___GetLoggerChannelFlags(int channelID)
		{
			int __retVal = __GetLoggerChannelFlags(channelID);
			return __retVal;
		}

		/// <summary>
		/// Sets the flags of a logging channel.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="eFlags">The new flags to set for the channel.</param>
		internal static delegate*<int, LoggingChannelFlags, void> SetLoggerChannelFlags = &___SetLoggerChannelFlags;
		internal static delegate* unmanaged[Cdecl]<int, LoggingChannelFlags, void> __SetLoggerChannelFlags;
		private static void ___SetLoggerChannelFlags(int channelID, LoggingChannelFlags eFlags)
		{
			__SetLoggerChannelFlags(channelID, eFlags);
		}

		/// <summary>
		/// Logs a message to a specified channel with a severity level.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="severity">The severity level for the log message.</param>
		/// <param name="message">The message to log.</param>
		/// <returns>An integer indicating the result of the logging operation.</returns>
		internal static delegate*<int, LoggingSeverity, string, int> Log = &___Log;
		internal static delegate* unmanaged[Cdecl]<int, LoggingSeverity, String192*, int> __Log;
		private static int ___Log(int channelID, LoggingSeverity severity, string message)
		{
			int __retVal;
			var __message = NativeMethods.ConstructString(message);
			try {
				__retVal = __Log(channelID, severity, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
			return __retVal;
		}

		/// <summary>
		/// Logs a colored message to a specified channel with a severity level.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="severity">The severity level for the log message.</param>
		/// <param name="color">The color for the log message.</param>
		/// <param name="message">The message to log.</param>
		/// <returns>An integer indicating the result of the logging operation.</returns>
		internal static delegate*<int, LoggingSeverity, int, string, int> LogColored = &___LogColored;
		internal static delegate* unmanaged[Cdecl]<int, LoggingSeverity, int, String192*, int> __LogColored;
		private static int ___LogColored(int channelID, LoggingSeverity severity, int color, string message)
		{
			int __retVal;
			var __message = NativeMethods.ConstructString(message);
			try {
				__retVal = __LogColored(channelID, severity, color, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
			return __retVal;
		}

		/// <summary>
		/// Logs a detailed message to a specified channel, including source code info.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="severity">The severity level for the log message.</param>
		/// <param name="file">The file name where the log call occurred.</param>
		/// <param name="line">The line number where the log call occurred.</param>
		/// <param name="function">The name of the function where the log call occurred.</param>
		/// <param name="message">The message to log.</param>
		/// <returns>An integer indicating the result of the logging operation.</returns>
		internal static delegate*<int, LoggingSeverity, string, int, string, string, int> LogFull = &___LogFull;
		internal static delegate* unmanaged[Cdecl]<int, LoggingSeverity, String192*, int, String192*, String192*, int> __LogFull;
		private static int ___LogFull(int channelID, LoggingSeverity severity, string file, int line, string function, string message)
		{
			int __retVal;
			var __file = NativeMethods.ConstructString(file);
			var __function = NativeMethods.ConstructString(function);
			var __message = NativeMethods.ConstructString(message);
			try {
				__retVal = __LogFull(channelID, severity, &__file, line, &__function, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__file);
				NativeMethods.DestroyString(&__function);
				NativeMethods.DestroyString(&__message);
			}
			return __retVal;
		}

		/// <summary>
		/// Logs a detailed colored message to a specified channel, including source code info.
		/// </summary>
		/// <param name="channelID">The ID of the logging channel.</param>
		/// <param name="severity">The severity level for the log message.</param>
		/// <param name="file">The file name where the log call occurred.</param>
		/// <param name="line">The line number where the log call occurred.</param>
		/// <param name="function">The name of the function where the log call occurred.</param>
		/// <param name="color">The color for the log message.</param>
		/// <param name="message">The message to log.</param>
		/// <returns>An integer indicating the result of the logging operation.</returns>
		internal static delegate*<int, LoggingSeverity, string, int, string, int, string, int> LogFullColored = &___LogFullColored;
		internal static delegate* unmanaged[Cdecl]<int, LoggingSeverity, String192*, int, String192*, int, String192*, int> __LogFullColored;
		private static int ___LogFullColored(int channelID, LoggingSeverity severity, string file, int line, string function, int color, string message)
		{
			int __retVal;
			var __file = NativeMethods.ConstructString(file);
			var __function = NativeMethods.ConstructString(function);
			var __message = NativeMethods.ConstructString(message);
			try {
				__retVal = __LogFullColored(channelID, severity, &__file, line, &__function, color, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__file);
				NativeMethods.DestroyString(&__function);
				NativeMethods.DestroyString(&__message);
			}
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
