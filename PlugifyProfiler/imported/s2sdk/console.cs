using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: console)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Sends a message to the server console.
		/// </summary>
		/// <param name="msg">The message to be sent to the server console.</param>
		internal static delegate*<string, void> PrintToServer = &___PrintToServer;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintToServer;
		private static void ___PrintToServer(string msg)
		{
			var __msg = NativeMethods.ConstructString(msg);
			try {
				__PrintToServer(&__msg);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__msg);
			}
		}

		/// <summary>
		/// Sends a message to a client's console.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The message to be sent to the client's console.</param>
		internal static delegate*<int, string, void> PrintToConsole = &___PrintToConsole;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __PrintToConsole;
		private static void ___PrintToConsole(int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToConsole(playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to a specific client in the chat area.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The message to be printed in the chat area.</param>
		internal static delegate*<int, string, void> PrintToChat = &___PrintToChat;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __PrintToChat;
		private static void ___PrintToChat(int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToChat(playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to a specific client in the center of the screen.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The message to be printed in the center of the screen.</param>
		internal static delegate*<int, string, void> PrintCenterText = &___PrintCenterText;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __PrintCenterText;
		private static void ___PrintCenterText(int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintCenterText(playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to a specific client with an alert box.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The message to be printed in the alert box.</param>
		internal static delegate*<int, string, void> PrintAlertText = &___PrintAlertText;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __PrintAlertText;
		private static void ___PrintAlertText(int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintAlertText(playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a html message to a specific client in the center of the screen.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The HTML-formatted message to be printed.</param>
		/// <param name="duration">The duration of the message in seconds.</param>
		internal static delegate*<int, string, int, void> PrintCentreHtml = &___PrintCentreHtml;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, void> __PrintCentreHtml;
		private static void ___PrintCentreHtml(int playerSlot, string message, int duration)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintCentreHtml(playerSlot, &__message, duration);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Sends a message to every client's console.
		/// </summary>
		/// <param name="message">The message to be sent to all clients' consoles.</param>
		internal static delegate*<string, void> PrintToConsoleAll = &___PrintToConsoleAll;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintToConsoleAll;
		private static void ___PrintToConsoleAll(string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToConsoleAll(&__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to all clients in the chat area.
		/// </summary>
		/// <param name="message">The message to be printed in the chat area for all clients.</param>
		internal static delegate*<string, void> PrintToChatAll = &___PrintToChatAll;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintToChatAll;
		private static void ___PrintToChatAll(string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToChatAll(&__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to all clients in the center of the screen.
		/// </summary>
		/// <param name="message">The message to be printed in the center of the screen for all clients.</param>
		internal static delegate*<string, void> PrintCenterTextAll = &___PrintCenterTextAll;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintCenterTextAll;
		private static void ___PrintCenterTextAll(string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintCenterTextAll(&__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a message to all clients with an alert box.
		/// </summary>
		/// <param name="message">The message to be printed in an alert box for all clients.</param>
		internal static delegate*<string, void> PrintAlertTextAll = &___PrintAlertTextAll;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintAlertTextAll;
		private static void ___PrintAlertTextAll(string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintAlertTextAll(&__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a html message to all clients in the center of the screen.
		/// </summary>
		/// <param name="message">The HTML-formatted message to be printed in the center of the screen for all clients.</param>
		/// <param name="duration">The duration of the message in seconds.</param>
		internal static delegate*<string, int, void> PrintCentreHtmlAll = &___PrintCentreHtmlAll;
		internal static delegate* unmanaged[Cdecl]<String192*, int, void> __PrintCentreHtmlAll;
		private static void ___PrintCentreHtmlAll(string message, int duration)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintCentreHtmlAll(&__message, duration);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a colored message to a specific client in the chat area.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to whom the message will be sent.</param>
		/// <param name="message">The message to be printed in the chat area with color.</param>
		internal static delegate*<int, string, void> PrintToChatColored = &___PrintToChatColored;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __PrintToChatColored;
		private static void ___PrintToChatColored(int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToChatColored(playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Prints a colored message to all clients in the chat area.
		/// </summary>
		/// <param name="message">The colored message to be printed in the chat area for all clients.</param>
		internal static delegate*<string, void> PrintToChatColoredAll = &___PrintToChatColoredAll;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __PrintToChatColoredAll;
		private static void ___PrintToChatColoredAll(string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__PrintToChatColoredAll(&__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

		/// <summary>
		/// Sends a reply message to a player or to the server console depending on the command context.
		/// </summary>
		/// <param name="context">The context from which the command was called (e.g., Console or Chat).</param>
		/// <param name="playerSlot">The slot/index of the player receiving the message.</param>
		/// <param name="message">The message string to be sent as a reply.</param>
		internal static delegate*<CommandCallingContext, int, string, void> ReplyToCommand = &___ReplyToCommand;
		internal static delegate* unmanaged[Cdecl]<CommandCallingContext, int, String192*, void> __ReplyToCommand;
		private static void ___ReplyToCommand(CommandCallingContext context, int playerSlot, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__ReplyToCommand(context, playerSlot, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

	}

#pragma warning restore CS0649
}
