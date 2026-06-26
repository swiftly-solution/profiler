using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: events)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a hook for when a game event is fired.
		/// </summary>
		/// <param name="name">The name of the event to hook.</param>
		/// <param name="callback">The callback function to call when the event is fired.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>An integer indicating the result of the hook operation.</returns>
		internal static delegate*<string, EventCallback, HookMode, EventHookError> HookEvent = &___HookEvent;
		internal static delegate* unmanaged[Cdecl]<String192*, nint, HookMode, EventHookError> __HookEvent;
		private static EventHookError ___HookEvent(string name, EventCallback callback, HookMode type)
		{
			EventHookError __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __HookEvent(&__name, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a hook for when a game event is fired.
		/// </summary>
		/// <param name="name">The name of the event to unhook.</param>
		/// <param name="callback">The callback function to remove.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>An integer indicating the result of the unhook operation.</returns>
		internal static delegate*<string, EventCallback, HookMode, EventHookError> UnhookEvent = &___UnhookEvent;
		internal static delegate* unmanaged[Cdecl]<String192*, nint, HookMode, EventHookError> __UnhookEvent;
		private static EventHookError ___UnhookEvent(string name, EventCallback callback, HookMode type)
		{
			EventHookError __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __UnhookEvent(&__name, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a game event to be fired later.
		/// </summary>
		/// <param name="name">The name of the event to create.</param>
		/// <param name="force">A boolean indicating whether to force the creation of the event.</param>
		/// <returns>A pointer to the created IGameEvent object.</returns>
		internal static delegate*<string, Bool8, nint> CreateEvent = &___CreateEvent;
		internal static delegate* unmanaged[Cdecl]<String192*, Bool8, nint> __CreateEvent;
		private static nint ___CreateEvent(string name, Bool8 force)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __CreateEvent(&__name, force);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Fires a game event.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="dontBroadcast">A boolean indicating whether to broadcast the event.</param>
		internal static delegate*<nint, Bool8, void> FireEvent = &___FireEvent;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, void> __FireEvent;
		private static void ___FireEvent(nint event_, Bool8 dontBroadcast)
		{
			__FireEvent(event_, dontBroadcast);
		}

		/// <summary>
		/// Fires a game event to a specific client.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="playerSlot">The index of the client to fire the event to.</param>
		internal static delegate*<nint, int, void> FireEventToClient = &___FireEventToClient;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __FireEventToClient;
		private static void ___FireEventToClient(nint event_, int playerSlot)
		{
			__FireEventToClient(event_, playerSlot);
		}

		/// <summary>
		/// Cancels a previously created game event that has not been fired.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object of the event to cancel.</param>
		internal static delegate*<nint, void> CancelCreatedEvent = &___CancelCreatedEvent;
		internal static delegate* unmanaged[Cdecl]<nint, void> __CancelCreatedEvent;
		private static void ___CancelCreatedEvent(nint event_)
		{
			__CancelCreatedEvent(event_);
		}

		/// <summary>
		/// Retrieves the boolean value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the boolean value.</param>
		/// <returns>The boolean value associated with the key.</returns>
		internal static delegate*<nint, string, Bool8> GetEventBool = &___GetEventBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8> __GetEventBool;
		private static Bool8 ___GetEventBool(nint event_, string key)
		{
			Bool8 __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventBool(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the float value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the float value.</param>
		/// <returns>The float value associated with the key.</returns>
		internal static delegate*<nint, string, float> GetEventFloat = &___GetEventFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float> __GetEventFloat;
		private static float ___GetEventFloat(nint event_, string key)
		{
			float __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventFloat(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the integer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the integer value.</param>
		/// <returns>The integer value associated with the key.</returns>
		internal static delegate*<nint, string, int> GetEventInt = &___GetEventInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int> __GetEventInt;
		private static int ___GetEventInt(nint event_, string key)
		{
			int __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventInt(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the long integer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the long integer value.</param>
		/// <returns>The long integer value associated with the key.</returns>
		internal static delegate*<nint, string, ulong> GetEventUInt64 = &___GetEventUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong> __GetEventUInt64;
		private static ulong ___GetEventUInt64(nint event_, string key)
		{
			ulong __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventUInt64(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the string value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the string value.</param>
		/// <returns>A string where the result will be stored.</returns>
		internal static delegate*<nint, string, string> GetEventString = &___GetEventString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192> __GetEventString;
		private static string ___GetEventString(nint event_, string key)
		{
			string __retVal;
			String192 __retVal_native;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal_native = __GetEventString(event_, &__key);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the pointer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the pointer value.</param>
		/// <returns>The pointer value associated with the key.</returns>
		internal static delegate*<nint, string, nint> GetEventPtr = &___GetEventPtr;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __GetEventPtr;
		private static nint ___GetEventPtr(nint event_, string key)
		{
			nint __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventPtr(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the player controller address of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the player controller address.</param>
		/// <returns>A pointer to the player controller associated with the key.</returns>
		internal static delegate*<nint, string, nint> GetEventPlayerController = &___GetEventPlayerController;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __GetEventPlayerController;
		private static nint ___GetEventPlayerController(nint event_, string key)
		{
			nint __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventPlayerController(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the player index of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the player index.</param>
		/// <returns>The player index associated with the key.</returns>
		internal static delegate*<nint, string, int> GetEventPlayerIndex = &___GetEventPlayerIndex;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int> __GetEventPlayerIndex;
		private static int ___GetEventPlayerIndex(nint event_, string key)
		{
			int __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventPlayerIndex(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the player pawn address of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the player pawn address.</param>
		/// <returns>A pointer to the player pawn associated with the key.</returns>
		internal static delegate*<nint, string, nint> GetEventPlayerPawn = &___GetEventPlayerPawn;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __GetEventPlayerPawn;
		private static nint ___GetEventPlayerPawn(nint event_, string key)
		{
			nint __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventPlayerPawn(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity address of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the entity address.</param>
		/// <returns>A pointer to the entity associated with the key.</returns>
		internal static delegate*<nint, string, nint> GetEventEntity = &___GetEventEntity;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __GetEventEntity;
		private static nint ___GetEventEntity(nint event_, string key)
		{
			nint __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventEntity(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity index of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the entity index.</param>
		/// <returns>The entity index associated with the key.</returns>
		internal static delegate*<nint, string, int> GetEventEntityIndex = &___GetEventEntityIndex;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int> __GetEventEntityIndex;
		private static int ___GetEventEntityIndex(nint event_, string key)
		{
			int __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventEntityIndex(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity handle of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to retrieve the entity handle.</param>
		/// <returns>The entity handle associated with the key.</returns>
		internal static delegate*<nint, string, int> GetEventEntityHandle = &___GetEventEntityHandle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int> __GetEventEntityHandle;
		private static int ___GetEventEntityHandle(nint event_, string key)
		{
			int __retVal;
			var __key = NativeMethods.ConstructString(key);
			try {
				__retVal = __GetEventEntityHandle(event_, &__key);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the name of a game event.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <returns>A string where the result will be stored.</returns>
		internal static delegate*<nint, string> GetEventName = &___GetEventName;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __GetEventName;
		private static string ___GetEventName(nint event_)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEventName(event_);
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
		/// Sets the boolean value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the boolean value.</param>
		/// <param name="value">The boolean value to set.</param>
		internal static delegate*<nint, string, Bool8, void> SetEventBool = &___SetEventBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, void> __SetEventBool;
		private static void ___SetEventBool(nint event_, string key, Bool8 value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventBool(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the floating point value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the float value.</param>
		/// <param name="value">The float value to set.</param>
		internal static delegate*<nint, string, float, void> SetEventFloat = &___SetEventFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, void> __SetEventFloat;
		private static void ___SetEventFloat(nint event_, string key, float value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventFloat(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the integer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the integer value.</param>
		/// <param name="value">The integer value to set.</param>
		internal static delegate*<nint, string, int, void> SetEventInt = &___SetEventInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __SetEventInt;
		private static void ___SetEventInt(nint event_, string key, int value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventInt(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the long integer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the long integer value.</param>
		/// <param name="value">The long integer value to set.</param>
		internal static delegate*<nint, string, ulong, void> SetEventUInt64 = &___SetEventUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong, void> __SetEventUInt64;
		private static void ___SetEventUInt64(nint event_, string key, ulong value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventUInt64(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the string value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the string value.</param>
		/// <param name="value">The string value to set.</param>
		internal static delegate*<nint, string, string, void> SetEventString = &___SetEventString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, void> __SetEventString;
		private static void ___SetEventString(nint event_, string key, string value)
		{
			var __key = NativeMethods.ConstructString(key);
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetEventString(event_, &__key, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Sets the pointer value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the pointer value.</param>
		/// <param name="value">The pointer value to set.</param>
		internal static delegate*<nint, string, nint, void> SetEventPtr = &___SetEventPtr;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __SetEventPtr;
		private static void ___SetEventPtr(nint event_, string key, nint value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventPtr(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the player controller address of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the player controller address.</param>
		/// <param name="value">A pointer to the player controller to set.</param>
		internal static delegate*<nint, string, nint, void> SetEventPlayerController = &___SetEventPlayerController;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __SetEventPlayerController;
		private static void ___SetEventPlayerController(nint event_, string key, nint value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventPlayerController(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the player index value of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the player index value.</param>
		/// <param name="value">The player index value to set.</param>
		internal static delegate*<nint, string, int, void> SetEventPlayerIndex = &___SetEventPlayerIndex;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __SetEventPlayerIndex;
		private static void ___SetEventPlayerIndex(nint event_, string key, int value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventPlayerIndex(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the entity address of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the entity address.</param>
		/// <param name="value">A pointer to the entity to set.</param>
		internal static delegate*<nint, string, nint, void> SetEventEntity = &___SetEventEntity;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __SetEventEntity;
		private static void ___SetEventEntity(nint event_, string key, nint value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventEntity(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the entity index of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the entity index.</param>
		/// <param name="value">The entity index value to set.</param>
		internal static delegate*<nint, string, int, void> SetEventEntityIndex = &___SetEventEntityIndex;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __SetEventEntityIndex;
		private static void ___SetEventEntityIndex(nint event_, string key, int value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventEntityIndex(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets the entity handle of a game event's key.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="key">The key for which to set the entity handle.</param>
		/// <param name="value">The entity handle value to set.</param>
		internal static delegate*<nint, string, int, void> SetEventEntityHandle = &___SetEventEntityHandle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __SetEventEntityHandle;
		private static void ___SetEventEntityHandle(nint event_, string key, int value)
		{
			var __key = NativeMethods.ConstructString(key);
			try {
				__SetEventEntityHandle(event_, &__key, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__key);
			}
		}

		/// <summary>
		/// Sets whether an event's broadcasting will be disabled or not.
		/// </summary>
		/// <param name="event_">A pointer to the IGameEvent object containing event data.</param>
		/// <param name="dontBroadcast">A boolean indicating whether to disable broadcasting.</param>
		internal static delegate*<nint, Bool8, void> SetEventBroadcast = &___SetEventBroadcast;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, void> __SetEventBroadcast;
		private static void ___SetEventBroadcast(nint event_, Bool8 dontBroadcast)
		{
			__SetEventBroadcast(event_, dontBroadcast);
		}

		/// <summary>
		/// Load game event descriptions from a file (e.g., "resource/gameevents.res").
		/// </summary>
		/// <param name="path">The path to the file containing event descriptions.</param>
		/// <param name="searchAll">A boolean indicating whether to search all paths for the file.</param>
		/// <returns>An integer indicating the result of the loading operation.</returns>
		internal static delegate*<string, Bool8, int> LoadEventsFromFile = &___LoadEventsFromFile;
		internal static delegate* unmanaged[Cdecl]<String192*, Bool8, int> __LoadEventsFromFile;
		private static int ___LoadEventsFromFile(string path, Bool8 searchAll)
		{
			int __retVal;
			var __path = NativeMethods.ConstructString(path);
			try {
				__retVal = __LoadEventsFromFile(&__path, searchAll);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__path);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for EventInfo pointer.
	/// </summary>
	internal sealed unsafe class EventInfo
	{
		private nint handle;

		/// <summary>
		/// Creates a game event to be fired later.
		/// </summary>
		/// <param name="name">The name of the event to create.</param>
		/// <param name="force">A boolean indicating whether to force the creation of the event.</param>
		public EventInfo(string name, Bool8 force)
		{
			this.handle = s2sdk.CreateEvent(name, force);
		}

		/// <summary>
		/// Internal constructor for creating EventInfo from existing handle
		/// </summary>
		public EventInfo(nint handle, Ownership ownership = Ownership.Borrowed)
		{
			this.handle = handle;
		}

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Handle => handle;

		/// <summary>
		/// Checks if the handle is valid
		/// </summary>
		public bool IsValid => handle != nint.Zero;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Get() => handle;

		/// <summary>
		/// Releases ownership of the handle and returns it
		/// </summary>
		public nint Release()
		{
			var h = handle;
			handle = nint.Zero;
			return h;
		}

		/// <summary>
		/// Resets the handle to invalid
		/// </summary>
		public void Reset()
		{
			handle = nint.Zero;
		}

		/// <summary>
		/// Fires a game event.
		/// </summary>
		/// <param name="dontBroadcast">A boolean indicating whether to broadcast the event.</param>
		public void Fire(Bool8 dontBroadcast)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.FireEvent(handle, dontBroadcast);
		}

		/// <summary>
		/// Fires a game event to a specific client.
		/// </summary>
		/// <param name="playerSlot">The index of the client to fire the event to.</param>
		public void FireToClient(int playerSlot)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.FireEventToClient(handle, playerSlot);
		}

		/// <summary>
		/// Cancels a previously created game event that has not been fired.
		/// </summary>
		public void Cancel()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.CancelCreatedEvent(handle);
		}

		/// <summary>
		/// Retrieves the boolean value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the boolean value.</param>
		/// <returns>The boolean value associated with the key.</returns>
		public Bool8 GetBool(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventBool(handle, key);
		}

		/// <summary>
		/// Retrieves the float value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the float value.</param>
		/// <returns>The float value associated with the key.</returns>
		public float GetFloat(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventFloat(handle, key);
		}

		/// <summary>
		/// Retrieves the integer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the integer value.</param>
		/// <returns>The integer value associated with the key.</returns>
		public int GetInt(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventInt(handle, key);
		}

		/// <summary>
		/// Retrieves the long integer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the long integer value.</param>
		/// <returns>The long integer value associated with the key.</returns>
		public ulong GetUInt64(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventUInt64(handle, key);
		}

		/// <summary>
		/// Retrieves the string value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the string value.</param>
		/// <returns>A string where the result will be stored.</returns>
		public string GetString(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventString(handle, key);
		}

		/// <summary>
		/// Retrieves the pointer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the pointer value.</param>
		/// <returns>The pointer value associated with the key.</returns>
		public nint GetPtr(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventPtr(handle, key);
		}

		/// <summary>
		/// Retrieves the player controller address of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the player controller address.</param>
		/// <returns>A pointer to the player controller associated with the key.</returns>
		public nint GetPlayerController(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventPlayerController(handle, key);
		}

		/// <summary>
		/// Retrieves the player index of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the player index.</param>
		/// <returns>The player index associated with the key.</returns>
		public int GetPlayerIndex(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventPlayerIndex(handle, key);
		}

		/// <summary>
		/// Retrieves the player pawn address of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the player pawn address.</param>
		/// <returns>A pointer to the player pawn associated with the key.</returns>
		public nint GetPlayerPawn(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventPlayerPawn(handle, key);
		}

		/// <summary>
		/// Retrieves the entity address of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the entity address.</param>
		/// <returns>A pointer to the entity associated with the key.</returns>
		public nint GetEntity(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventEntity(handle, key);
		}

		/// <summary>
		/// Retrieves the entity index of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the entity index.</param>
		/// <returns>The entity index associated with the key.</returns>
		public int GetEntityIndex(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventEntityIndex(handle, key);
		}

		/// <summary>
		/// Retrieves the entity handle of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to retrieve the entity handle.</param>
		/// <returns>The entity handle associated with the key.</returns>
		public int GetEntityHandle(string key)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventEntityHandle(handle, key);
		}

		/// <summary>
		/// Retrieves the name of a game event.
		/// </summary>
		/// <returns>A string where the result will be stored.</returns>
		public string GetName()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetEventName(handle);
		}

		/// <summary>
		/// Sets the boolean value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the boolean value.</param>
		/// <param name="value">The boolean value to set.</param>
		public void SetBool(string key, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventBool(handle, key, value);
		}

		/// <summary>
		/// Sets the floating point value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the float value.</param>
		/// <param name="value">The float value to set.</param>
		public void SetFloat(string key, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventFloat(handle, key, value);
		}

		/// <summary>
		/// Sets the integer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the integer value.</param>
		/// <param name="value">The integer value to set.</param>
		public void SetInt(string key, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventInt(handle, key, value);
		}

		/// <summary>
		/// Sets the long integer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the long integer value.</param>
		/// <param name="value">The long integer value to set.</param>
		public void SetUInt64(string key, ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventUInt64(handle, key, value);
		}

		/// <summary>
		/// Sets the string value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the string value.</param>
		/// <param name="value">The string value to set.</param>
		public void SetString(string key, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventString(handle, key, value);
		}

		/// <summary>
		/// Sets the pointer value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the pointer value.</param>
		/// <param name="value">The pointer value to set.</param>
		public void SetPtr(string key, nint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventPtr(handle, key, value);
		}

		/// <summary>
		/// Sets the player controller address of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the player controller address.</param>
		/// <param name="value">A pointer to the player controller to set.</param>
		public void SetPlayerController(string key, nint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventPlayerController(handle, key, value);
		}

		/// <summary>
		/// Sets the player index value of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the player index value.</param>
		/// <param name="value">The player index value to set.</param>
		public void SetPlayerIndex(string key, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventPlayerIndex(handle, key, value);
		}

		/// <summary>
		/// Sets the entity address of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the entity address.</param>
		/// <param name="value">A pointer to the entity to set.</param>
		public void SetEntity(string key, nint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventEntity(handle, key, value);
		}

		/// <summary>
		/// Sets the entity index of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the entity index.</param>
		/// <param name="value">The entity index value to set.</param>
		public void SetEntityIndex(string key, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventEntityIndex(handle, key, value);
		}

		/// <summary>
		/// Sets the entity handle of a game event's key.
		/// </summary>
		/// <param name="key">The key for which to set the entity handle.</param>
		/// <param name="value">The entity handle value to set.</param>
		public void SetEntityHandle(string key, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventEntityHandle(handle, key, value);
		}

		/// <summary>
		/// Sets whether an event's broadcasting will be disabled or not.
		/// </summary>
		/// <param name="dontBroadcast">A boolean indicating whether to disable broadcasting.</param>
		public void SetBroadcast(Bool8 dontBroadcast)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetEventBroadcast(handle, dontBroadcast);
		}

	}

#pragma warning restore CS0649
}
