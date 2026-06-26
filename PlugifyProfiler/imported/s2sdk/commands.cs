using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: commands)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a console command as an administrative command.
		/// </summary>
		/// <param name="name">The name of the console command.</param>
		/// <param name="adminFlags">The admin flags that indicate which admin level can use this command.</param>
		/// <param name="description">A brief description of what the command does.</param>
		/// <param name="flags">Command flags that define the behavior of the command.</param>
		/// <param name="callback">A callback function that is invoked when the command is executed.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>true if the command was successfully created; otherwise, false.</returns>
		internal static delegate*<string, long, string, ConVarFlag, CommandCallback, HookMode, Bool8> AddAdminCommand = &___AddAdminCommand;
		internal static delegate* unmanaged[Cdecl]<String192*, long, String192*, ConVarFlag, nint, HookMode, Bool8> __AddAdminCommand;
		private static Bool8 ___AddAdminCommand(string name, long adminFlags, string description, ConVarFlag flags, CommandCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __AddAdminCommand(&__name, adminFlags, &__description, flags, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a console command or hooks an already existing one.
		/// </summary>
		/// <param name="name">The name of the console command.</param>
		/// <param name="description">A brief description of what the command does.</param>
		/// <param name="flags">Command flags that define the behavior of the command.</param>
		/// <param name="callback">A callback function that is invoked when the command is executed.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>true if the command was successfully created; otherwise, false.</returns>
		internal static delegate*<string, string, ConVarFlag, CommandCallback, HookMode, Bool8> AddConsoleCommand = &___AddConsoleCommand;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, ConVarFlag, nint, HookMode, Bool8> __AddConsoleCommand;
		private static Bool8 ___AddConsoleCommand(string name, string description, ConVarFlag flags, CommandCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __AddConsoleCommand(&__name, &__description, flags, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a console command from the system.
		/// </summary>
		/// <param name="name">The name of the command to be removed.</param>
		/// <param name="callback">The callback function associated with the command to be removed.</param>
		/// <returns>true if the command was successfully removed; otherwise, false.</returns>
		internal static delegate*<string, CommandCallback, Bool8> RemoveCommand = &___RemoveCommand;
		internal static delegate* unmanaged[Cdecl]<String192*, nint, Bool8> __RemoveCommand;
		private static Bool8 ___RemoveCommand(string name, CommandCallback callback)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __RemoveCommand(&__name, Marshalling.GetFunctionPointerForDelegate(callback));
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a callback that will fire when a command is sent to the server.
		/// </summary>
		/// <param name="name">The name of the command.</param>
		/// <param name="callback">The callback function that will be invoked when the command is executed.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>Returns true if the callback was successfully added, false otherwise.</returns>
		internal static delegate*<string, CommandCallback, HookMode, Bool8> AddCommandListener = &___AddCommandListener;
		internal static delegate* unmanaged[Cdecl]<String192*, nint, HookMode, Bool8> __AddCommandListener;
		private static Bool8 ___AddCommandListener(string name, CommandCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __AddCommandListener(&__name, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a callback that fires when a command is sent to the server.
		/// </summary>
		/// <param name="name">The name of the command.</param>
		/// <param name="callback">The callback function to be removed.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>Returns true if the callback was successfully removed, false otherwise.</returns>
		internal static delegate*<string, CommandCallback, HookMode, Bool8> RemoveCommandListener = &___RemoveCommandListener;
		internal static delegate* unmanaged[Cdecl]<String192*, nint, HookMode, Bool8> __RemoveCommandListener;
		private static Bool8 ___RemoveCommandListener(string name, CommandCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __RemoveCommandListener(&__name, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Executes a server command as if it were run on the server console or through RCON.
		/// </summary>
		/// <param name="command">The command to execute on the server.</param>
		internal static delegate*<string, void> ServerCommand = &___ServerCommand;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __ServerCommand;
		private static void ___ServerCommand(string command)
		{
			var __command = NativeMethods.ConstructString(command);
			try {
				__ServerCommand(&__command);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__command);
			}
		}

		/// <summary>
		/// Executes a server command as if it were on the server console (or RCON) and stores the printed text into buffer.
		/// </summary>
		/// <param name="command">The command to execute on the server.</param>
		/// <returns>String to store command result into.</returns>
		internal static delegate*<string, string> ServerCommandEx = &___ServerCommandEx;
		internal static delegate* unmanaged[Cdecl]<String192*, String192> __ServerCommandEx;
		private static string ___ServerCommandEx(string command)
		{
			string __retVal;
			String192 __retVal_native;
			var __command = NativeMethods.ConstructString(command);
			try {
				__retVal_native = __ServerCommandEx(&__command);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__command);
			}
			return __retVal;
		}

		/// <summary>
		/// Executes a client command.
		/// </summary>
		/// <param name="playerSlot">The index of the client executing the command.</param>
		/// <param name="command">The command to execute on the client.</param>
		internal static delegate*<int, string, void> ClientCommand = &___ClientCommand;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __ClientCommand;
		private static void ___ClientCommand(int playerSlot, string command)
		{
			var __command = NativeMethods.ConstructString(command);
			try {
				__ClientCommand(playerSlot, &__command);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__command);
			}
		}

		/// <summary>
		/// Executes a client command on the server without network communication.
		/// </summary>
		/// <param name="playerSlot">The index of the client.</param>
		/// <param name="command">The command to be executed by the client.</param>
		internal static delegate*<int, string, void> FakeClientCommand = &___FakeClientCommand;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __FakeClientCommand;
		private static void ___FakeClientCommand(int playerSlot, string command)
		{
			var __command = NativeMethods.ConstructString(command);
			try {
				__FakeClientCommand(playerSlot, &__command);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__command);
			}
		}

	}

#pragma warning restore CS0649
}
