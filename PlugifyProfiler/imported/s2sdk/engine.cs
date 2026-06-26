using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: engine)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Finds a module by name.
		/// </summary>
		/// <param name="name">The name of the module to find.</param>
		/// <returns>A pointer to the specified module.</returns>
		internal static delegate*<string, nint> FindModule = &___FindModule;
		internal static delegate* unmanaged[Cdecl]<String192*, nint> __FindModule;
		private static nint ___FindModule(string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindModule(&__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an interface by name.
		/// </summary>
		/// <param name="name">The name of the interface to find.</param>
		/// <returns>A pointer to the interface.</returns>
		internal static delegate*<string, nint> FindInterface = &___FindInterface;
		internal static delegate* unmanaged[Cdecl]<String192*, nint> __FindInterface;
		private static nint ___FindInterface(string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindInterface(&__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Queries an interface from a specified module.
		/// </summary>
		/// <param name="module">The name of the module to query the interface from.</param>
		/// <param name="name">The name of the interface to find.</param>
		/// <returns>A pointer to the queried interface.</returns>
		internal static delegate*<string, string, nint> QueryInterface = &___QueryInterface;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, nint> __QueryInterface;
		private static nint ___QueryInterface(string module, string name)
		{
			nint __retVal;
			var __module = NativeMethods.ConstructString(module);
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __QueryInterface(&__module, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__module);
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns the path of the game's directory.
		/// </summary>
		/// <returns>A reference to a string where the game directory path will be stored.</returns>
		internal static delegate*<string> GetGameDirectory = &___GetGameDirectory;
		internal static delegate* unmanaged[Cdecl]<String192> __GetGameDirectory;
		private static string ___GetGameDirectory()
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetGameDirectory();
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns the current map name.
		/// </summary>
		/// <returns>A reference to a string where the current map name will be stored.</returns>
		internal static delegate*<string> GetCurrentMap = &___GetCurrentMap;
		internal static delegate* unmanaged[Cdecl]<String192> __GetCurrentMap;
		private static string ___GetCurrentMap()
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetCurrentMap();
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns whether a specified map is valid or not.
		/// </summary>
		/// <param name="mapname">The name of the map to check for validity.</param>
		/// <returns>True if the map is valid, false otherwise.</returns>
		internal static delegate*<string, Bool8> IsMapValid = &___IsMapValid;
		internal static delegate* unmanaged[Cdecl]<String192*, Bool8> __IsMapValid;
		private static Bool8 ___IsMapValid(string mapname)
		{
			Bool8 __retVal;
			var __mapname = NativeMethods.ConstructString(mapname);
			try {
				__retVal = __IsMapValid(&__mapname);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__mapname);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns the game time based on the game tick.
		/// </summary>
		/// <returns>The current game time.</returns>
		internal static delegate*<float> GetGameTime = &___GetGameTime;
		internal static delegate* unmanaged[Cdecl]<float> __GetGameTime;
		private static float ___GetGameTime()
		{
			float __retVal = __GetGameTime();
			return __retVal;
		}

		/// <summary>
		/// Returns the game's internal tick count.
		/// </summary>
		/// <returns>The current tick count of the game.</returns>
		internal static delegate*<int> GetGameTickCount = &___GetGameTickCount;
		internal static delegate* unmanaged[Cdecl]<int> __GetGameTickCount;
		private static int ___GetGameTickCount()
		{
			int __retVal = __GetGameTickCount();
			return __retVal;
		}

		/// <summary>
		/// Returns the time the game took processing the last frame.
		/// </summary>
		/// <returns>The frame time of the last processed frame.</returns>
		internal static delegate*<float> GetGameFrameTime = &___GetGameFrameTime;
		internal static delegate* unmanaged[Cdecl]<float> __GetGameFrameTime;
		private static float ___GetGameFrameTime()
		{
			float __retVal = __GetGameFrameTime();
			return __retVal;
		}

		/// <summary>
		/// Returns a high-precision time value for profiling the engine.
		/// </summary>
		/// <returns>A high-precision time value.</returns>
		internal static delegate*<double> GetEngineTime = &___GetEngineTime;
		internal static delegate* unmanaged[Cdecl]<double> __GetEngineTime;
		private static double ___GetEngineTime()
		{
			double __retVal = __GetEngineTime();
			return __retVal;
		}

		/// <summary>
		/// Returns the maximum number of clients that can connect to the server.
		/// </summary>
		/// <returns>The maximum client count, or -1 if global variables are not initialized.</returns>
		internal static delegate*<int> GetMaxClients = &___GetMaxClients;
		internal static delegate* unmanaged[Cdecl]<int> __GetMaxClients;
		private static int ___GetMaxClients()
		{
			int __retVal = __GetMaxClients();
			return __retVal;
		}

		/// <summary>
		/// Precaches a given file.
		/// </summary>
		/// <param name="resource">The name of the resource to be precached.</param>
		internal static delegate*<string, void> Precache = &___Precache;
		internal static delegate* unmanaged[Cdecl]<String192*, void> __Precache;
		private static void ___Precache(string resource)
		{
			var __resource = NativeMethods.ConstructString(resource);
			try {
				__Precache(&__resource);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__resource);
			}
		}

		/// <summary>
		/// Checks if a specified file is precached.
		/// </summary>
		/// <param name="resource">The name of the file to check.</param>
		internal static delegate*<string, Bool8> IsPrecached = &___IsPrecached;
		internal static delegate* unmanaged[Cdecl]<String192*, Bool8> __IsPrecached;
		private static Bool8 ___IsPrecached(string resource)
		{
			Bool8 __retVal;
			var __resource = NativeMethods.ConstructString(resource);
			try {
				__retVal = __IsPrecached(&__resource);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__resource);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns a pointer to the Economy Item System.
		/// </summary>
		/// <returns>A pointer to the Econ Item System.</returns>
		internal static delegate*<nint> GetEconItemSystem = &___GetEconItemSystem;
		internal static delegate* unmanaged[Cdecl]<nint> __GetEconItemSystem;
		private static nint ___GetEconItemSystem()
		{
			nint __retVal = __GetEconItemSystem();
			return __retVal;
		}

		/// <summary>
		/// Checks if the server is currently paused.
		/// </summary>
		/// <returns>True if the server is paused, false otherwise.</returns>
		internal static delegate*<Bool8> IsServerPaused = &___IsServerPaused;
		internal static delegate* unmanaged[Cdecl]<Bool8> __IsServerPaused;
		private static Bool8 ___IsServerPaused()
		{
			Bool8 __retVal = __IsServerPaused();
			return __retVal;
		}

		/// <summary>
		/// Queues a task to be executed on the next frame.
		/// </summary>
		/// <param name="callback">A callback function to be executed on the next frame.</param>
		/// <param name="userData">An array intended to hold user-related data, allowing for elements of any type.</param>
		internal static delegate*<TaskCallback, object[], void> QueueTaskForNextFrame = &___QueueTaskForNextFrame;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192*, void> __QueueTaskForNextFrame;
		private static void ___QueueTaskForNextFrame(TaskCallback callback, object[] userData)
		{
			var __userData = NativeMethods.ConstructVectorVariant(userData, userData.Length);
			try {
				__QueueTaskForNextFrame(Marshalling.GetFunctionPointerForDelegate(callback), &__userData);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorVariant(&__userData);
			}
		}

		/// <summary>
		/// Queues a task to be executed on the next world update.
		/// </summary>
		/// <param name="callback">A callback function to be executed on the next world update.</param>
		/// <param name="userData">An array intended to hold user-related data, allowing for elements of any type.</param>
		internal static delegate*<TaskCallback, object[], void> QueueTaskForNextWorldUpdate = &___QueueTaskForNextWorldUpdate;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192*, void> __QueueTaskForNextWorldUpdate;
		private static void ___QueueTaskForNextWorldUpdate(TaskCallback callback, object[] userData)
		{
			var __userData = NativeMethods.ConstructVectorVariant(userData, userData.Length);
			try {
				__QueueTaskForNextWorldUpdate(Marshalling.GetFunctionPointerForDelegate(callback), &__userData);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorVariant(&__userData);
			}
		}

		/// <summary>
		/// Returns the duration of a specified sound.
		/// </summary>
		/// <param name="name">The name of the sound to check.</param>
		/// <returns>The duration of the sound in seconds.</returns>
		internal static delegate*<string, float> GetSoundDuration = &___GetSoundDuration;
		internal static delegate* unmanaged[Cdecl]<String192*, float> __GetSoundDuration;
		private static float ___GetSoundDuration(string name)
		{
			float __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetSoundDuration(&__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Emits a sound from a specified entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity that will emit the sound.</param>
		/// <param name="sound">The name of the sound to emit.</param>
		/// <param name="pitch">The pitch of the sound.</param>
		/// <param name="volume">The volume of the sound.</param>
		/// <param name="delay">The delay before the sound is played.</param>
		internal static delegate*<int, string, int, float, float, void> EmitSound = &___EmitSound;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, float, float, void> __EmitSound;
		private static void ___EmitSound(int entityHandle, string sound, int pitch, float volume, float delay)
		{
			var __sound = NativeMethods.ConstructString(sound);
			try {
				__EmitSound(entityHandle, &__sound, pitch, volume, delay);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__sound);
			}
		}

		/// <summary>
		/// Stops a sound from a specified entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity that will stop the sound.</param>
		/// <param name="sound">The name of the sound to stop.</param>
		internal static delegate*<int, string, void> StopSound = &___StopSound;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __StopSound;
		private static void ___StopSound(int entityHandle, string sound)
		{
			var __sound = NativeMethods.ConstructString(sound);
			try {
				__StopSound(entityHandle, &__sound);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__sound);
			}
		}

		/// <summary>
		/// Emits a sound to a specific client.
		/// </summary>
		/// <param name="playerSlot">The index of the client to whom the sound will be emitted.</param>
		/// <param name="channel">The channel through which the sound will be played.</param>
		/// <param name="sound">The name of the sound to emit.</param>
		/// <param name="volume">The volume of the sound.</param>
		/// <param name="soundLevel">The level of the sound.</param>
		/// <param name="flags">Additional flags for sound playback.</param>
		/// <param name="pitch">The pitch of the sound.</param>
		/// <param name="origin">The origin of the sound in 3D space.</param>
		/// <param name="soundTime">The time at which the sound should be played.</param>
		internal static delegate*<int, int, string, float, int, int, int, Vector3, float, void> EmitSoundToClient = &___EmitSoundToClient;
		internal static delegate* unmanaged[Cdecl]<int, int, String192*, float, int, int, int, Vector3*, float, void> __EmitSoundToClient;
		private static void ___EmitSoundToClient(int playerSlot, int channel, string sound, float volume, int soundLevel, int flags, int pitch, Vector3 origin, float soundTime)
		{
			var __sound = NativeMethods.ConstructString(sound);
			try {
				__EmitSoundToClient(playerSlot, channel, &__sound, volume, soundLevel, flags, pitch, &origin, soundTime);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__sound);
			}
		}

	}

#pragma warning restore CS0649
}
