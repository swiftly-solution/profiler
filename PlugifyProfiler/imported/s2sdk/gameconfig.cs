using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: gameconfig)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Closes a game configuration file.
		/// </summary>
		/// <param name="id">An id to the game configuration to be closed.</param>
		internal static delegate*<uint, void> CloseGameConfigFile = &___CloseGameConfigFile;
		internal static delegate* unmanaged[Cdecl]<uint, void> __CloseGameConfigFile;
		private static void ___CloseGameConfigFile(uint id)
		{
			__CloseGameConfigFile(id);
		}

		/// <summary>
		/// Loads a game configuration file.
		/// </summary>
		/// <param name="paths">The paths to the game configuration file to be loaded.</param>
		/// <returns>A id to the loaded game configuration object, or -1 if loading fails.</returns>
		internal static delegate*<string[], uint> LoadGameConfigFile = &___LoadGameConfigFile;
		internal static delegate* unmanaged[Cdecl]<Vector192*, uint> __LoadGameConfigFile;
		private static uint ___LoadGameConfigFile(string[] paths)
		{
			uint __retVal;
			var __paths = NativeMethods.ConstructVectorString(paths, paths.Length);
			try {
				__retVal = __LoadGameConfigFile(&__paths);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorString(&__paths);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves a patch associated with the game configuration.
		/// </summary>
		/// <param name="id">An id to the game configuration from which to retrieve the patch.</param>
		/// <param name="name">The name of the patch to be retrieved.</param>
		/// <returns>A string where the patch will be stored.</returns>
		internal static delegate*<uint, string, string> GetGameConfigPatch = &___GetGameConfigPatch;
		internal static delegate* unmanaged[Cdecl]<uint, String192*, String192> __GetGameConfigPatch;
		private static string ___GetGameConfigPatch(uint id, string name)
		{
			string __retVal;
			String192 __retVal_native;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal_native = __GetGameConfigPatch(id, &__name);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the offset associated with a name from the game configuration.
		/// </summary>
		/// <param name="id">An id to the game configuration from which to retrieve the offset.</param>
		/// <param name="name">The name whose offset is to be retrieved.</param>
		/// <returns>The offset associated with the specified name.</returns>
		internal static delegate*<uint, string, int> GetGameConfigOffset = &___GetGameConfigOffset;
		internal static delegate* unmanaged[Cdecl]<uint, String192*, int> __GetGameConfigOffset;
		private static int ___GetGameConfigOffset(uint id, string name)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetGameConfigOffset(id, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the address associated with a name from the game configuration.
		/// </summary>
		/// <param name="id">An id to the game configuration from which to retrieve the address.</param>
		/// <param name="name">The name whose address is to be retrieved.</param>
		/// <returns>A pointer to the address associated with the specified name.</returns>
		internal static delegate*<uint, string, nint> GetGameConfigAddress = &___GetGameConfigAddress;
		internal static delegate* unmanaged[Cdecl]<uint, String192*, nint> __GetGameConfigAddress;
		private static nint ___GetGameConfigAddress(uint id, string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetGameConfigAddress(id, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves a vtable associated with the game configuration.
		/// </summary>
		/// <param name="id">An id to the game configuration from which to retrieve the vtable.</param>
		/// <param name="name">The name of the vtable to be retrieved.</param>
		/// <returns>A pointer to the vtable associated with the specified name</returns>
		internal static delegate*<uint, string, nint> GetGameConfigVTable = &___GetGameConfigVTable;
		internal static delegate* unmanaged[Cdecl]<uint, String192*, nint> __GetGameConfigVTable;
		private static nint ___GetGameConfigVTable(uint id, string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetGameConfigVTable(id, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the signature associated with a name from the game configuration.
		/// </summary>
		/// <param name="id">An id to the game configuration from which to retrieve the signature.</param>
		/// <param name="name">The name whose signature is to be resolved and retrieved.</param>
		/// <returns>A pointer to the signature associated with the specified name.</returns>
		internal static delegate*<uint, string, nint> GetGameConfigSignature = &___GetGameConfigSignature;
		internal static delegate* unmanaged[Cdecl]<uint, String192*, nint> __GetGameConfigSignature;
		private static nint ___GetGameConfigSignature(uint id, string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetGameConfigSignature(id, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for GameConfig handle.
	/// </summary>
	internal sealed unsafe class GameConfig : SafeHandle
	{
		/// <summary>
		/// Loads a game configuration file.
		/// </summary>
		/// <param name="paths">The paths to the game configuration file to be loaded.</param>
		public GameConfig(string[] paths) : this(s2sdk.LoadGameConfigFile(paths), Ownership.Owned)
		{
		}

		/// <summary>
		/// Internal constructor for creating GameConfig from existing handle
		/// </summary>
		public GameConfig(uint handle, Ownership ownership = Ownership.Borrowed) : base((nint)handle, ownsHandle: ownership == Ownership.Owned)
		{
		}

		/// <summary>
		/// Releases the handle (called automatically by SafeHandle)
		/// </summary>
		protected override bool ReleaseHandle()
		{
			s2sdk.CloseGameConfigFile((uint)handle);
			return true;
		}

		/// <summary>
		/// Checks if the GameConfig has a valid handle
		/// </summary>
		public override bool IsInvalid => handle == 0;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public uint Handle => (uint)handle;

		/// <summary>
		/// Checks if the handle is valid
		/// </summary>
		public bool IsValid => handle != 0;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public uint Get() => (uint)handle;

		/// <summary>
		/// Releases ownership of the handle and returns it
		/// </summary>
		public uint Release()
		{
			var h = handle;
			SetHandleAsInvalid();
			return (uint)h;
		}

		/// <summary>
		/// Disposes the handle
		/// </summary>
		public void Reset()
		{
			Dispose();
		}

		/// <summary>
		/// Retrieves a patch associated with the game configuration.
		/// </summary>
		/// <param name="name">The name of the patch to be retrieved.</param>
		/// <returns>A string where the patch will be stored.</returns>
		public string GetPatch(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.GetGameConfigPatch(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Retrieves the offset associated with a name from the game configuration.
		/// </summary>
		/// <param name="name">The name whose offset is to be retrieved.</param>
		/// <returns>The offset associated with the specified name.</returns>
		public int GetOffset(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.GetGameConfigOffset(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Retrieves the address associated with a name from the game configuration.
		/// </summary>
		/// <param name="name">The name whose address is to be retrieved.</param>
		/// <returns>A pointer to the address associated with the specified name.</returns>
		public nint GetAddress(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.GetGameConfigAddress(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Retrieves a vtable associated with the game configuration.
		/// </summary>
		/// <param name="name">The name of the vtable to be retrieved.</param>
		/// <returns>A pointer to the vtable associated with the specified name</returns>
		public nint GetVTable(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.GetGameConfigVTable(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Retrieves the signature associated with a name from the game configuration.
		/// </summary>
		/// <param name="name">The name whose signature is to be resolved and retrieved.</param>
		/// <returns>A pointer to the signature associated with the specified name.</returns>
		public nint GetSignature(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.GetGameConfigSignature(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

	}

#pragma warning restore CS0649
}
