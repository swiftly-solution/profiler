using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: entities)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Converts an entity index into an entity pointer.
		/// </summary>
		/// <param name="entityIndex">The index of the entity to convert.</param>
		/// <returns>A pointer to the entity instance, or nullptr if the entity does not exist.</returns>
		internal static delegate*<int, nint> EntIndexToEntPointer = &___EntIndexToEntPointer;
		internal static delegate* unmanaged[Cdecl]<int, nint> __EntIndexToEntPointer;
		private static nint ___EntIndexToEntPointer(int entityIndex)
		{
			nint __retVal = __EntIndexToEntPointer(entityIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity index from an entity pointer.
		/// </summary>
		/// <param name="entity">A pointer to the entity whose index is to be retrieved.</param>
		/// <returns>The index of the entity, or -1 if the entity is nullptr.</returns>
		internal static delegate*<nint, int> EntPointerToEntIndex = &___EntPointerToEntIndex;
		internal static delegate* unmanaged[Cdecl]<nint, int> __EntPointerToEntIndex;
		private static int ___EntPointerToEntIndex(nint entity)
		{
			int __retVal = __EntPointerToEntIndex(entity);
			return __retVal;
		}

		/// <summary>
		/// Converts an entity pointer into an entity handle.
		/// </summary>
		/// <param name="entity">A pointer to the entity to convert.</param>
		/// <returns>The entity handle as an integer, or INVALID_EHANDLE_INDEX if the entity is nullptr.</returns>
		internal static delegate*<nint, int> EntPointerToEntHandle = &___EntPointerToEntHandle;
		internal static delegate* unmanaged[Cdecl]<nint, int> __EntPointerToEntHandle;
		private static int ___EntPointerToEntHandle(nint entity)
		{
			int __retVal = __EntPointerToEntHandle(entity);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity pointer from an entity handle.
		/// </summary>
		/// <param name="entityHandle">The entity handle to convert.</param>
		/// <returns>A pointer to the entity instance, or nullptr if the handle is invalid.</returns>
		internal static delegate*<int, nint> EntHandleToEntPointer = &___EntHandleToEntPointer;
		internal static delegate* unmanaged[Cdecl]<int, nint> __EntHandleToEntPointer;
		private static nint ___EntHandleToEntPointer(int entityHandle)
		{
			nint __retVal = __EntHandleToEntPointer(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Converts an entity index into an entity handle.
		/// </summary>
		/// <param name="entityIndex">The index of the entity to convert.</param>
		/// <returns>The entity handle as an integer, or -1 if the entity index is invalid.</returns>
		internal static delegate*<int, int> EntIndexToEntHandle = &___EntIndexToEntHandle;
		internal static delegate* unmanaged[Cdecl]<int, int> __EntIndexToEntHandle;
		private static int ___EntIndexToEntHandle(int entityIndex)
		{
			int __retVal = __EntIndexToEntHandle(entityIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the entity index from an entity handle.
		/// </summary>
		/// <param name="entityHandle">The entity handle from which to retrieve the index.</param>
		/// <returns>The index of the entity, or -1 if the handle is invalid.</returns>
		internal static delegate*<int, int> EntHandleToEntIndex = &___EntHandleToEntIndex;
		internal static delegate* unmanaged[Cdecl]<int, int> __EntHandleToEntIndex;
		private static int ___EntHandleToEntIndex(int entityHandle)
		{
			int __retVal = __EntHandleToEntIndex(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Checks if the provided entity handle is valid.
		/// </summary>
		/// <param name="entityHandle">The entity handle to check.</param>
		/// <returns>True if the entity handle is valid, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsValidEntHandle = &___IsValidEntHandle;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsValidEntHandle;
		private static Bool8 ___IsValidEntHandle(int entityHandle)
		{
			Bool8 __retVal = __IsValidEntHandle(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Checks if the provided entity pointer is valid.
		/// </summary>
		/// <param name="entity">The entity pointer to check.</param>
		/// <returns>True if the entity pointer is valid, false otherwise.</returns>
		internal static delegate*<nint, Bool8> IsValidEntPointer = &___IsValidEntPointer;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __IsValidEntPointer;
		private static Bool8 ___IsValidEntPointer(nint entity)
		{
			Bool8 __retVal = __IsValidEntPointer(entity);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the pointer to the first active entity.
		/// </summary>
		/// <returns>A handle to the first active entity.</returns>
		internal static delegate*<int> GetFirstActiveEntity = &___GetFirstActiveEntity;
		internal static delegate* unmanaged[Cdecl]<int> __GetFirstActiveEntity;
		private static int ___GetFirstActiveEntity()
		{
			int __retVal = __GetFirstActiveEntity();
			return __retVal;
		}

		/// <summary>
		/// Retrieves the previous active entity.
		/// </summary>
		/// <param name="entityHandle"></param>
		/// <returns>Handle to the previous entity.</returns>
		internal static delegate*<int, int> GetPrevActiveEntity = &___GetPrevActiveEntity;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetPrevActiveEntity;
		private static int ___GetPrevActiveEntity(int entityHandle)
		{
			int __retVal = __GetPrevActiveEntity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the next active entity.
		/// </summary>
		/// <param name="entityHandle"></param>
		/// <returns>Handle to the next entity.</returns>
		internal static delegate*<int, int> GetNextActiveEntity = &___GetNextActiveEntity;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetNextActiveEntity;
		private static int ___GetNextActiveEntity(int entityHandle)
		{
			int __retVal = __GetNextActiveEntity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Adds an entity output hook on a specified entity class name.
		/// </summary>
		/// <param name="classname">The class name of the entity to hook the output for.</param>
		/// <param name="output">The output event name to hook.</param>
		/// <param name="callback">The callback function to invoke when the output is fired.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>True if the hook was successfully added, false otherwise.</returns>
		internal static delegate*<string, string, HookEntityOutputCallback, HookMode, Bool8> HookEntityOutput = &___HookEntityOutput;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, nint, HookMode, Bool8> __HookEntityOutput;
		private static Bool8 ___HookEntityOutput(string classname, string output, HookEntityOutputCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __classname = NativeMethods.ConstructString(classname);
			var __output = NativeMethods.ConstructString(output);
			try {
				__retVal = __HookEntityOutput(&__classname, &__output, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__classname);
				NativeMethods.DestroyString(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes an entity output hook.
		/// </summary>
		/// <param name="classname">The class name of the entity from which to unhook the output.</param>
		/// <param name="output">The output event name to unhook.</param>
		/// <param name="callback">The callback function that was previously hooked.</param>
		/// <param name="type">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>True if the hook was successfully removed, false otherwise.</returns>
		internal static delegate*<string, string, HookEntityOutputCallback, HookMode, Bool8> UnhookEntityOutput = &___UnhookEntityOutput;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, nint, HookMode, Bool8> __UnhookEntityOutput;
		private static Bool8 ___UnhookEntityOutput(string classname, string output, HookEntityOutputCallback callback, HookMode type)
		{
			Bool8 __retVal;
			var __classname = NativeMethods.ConstructString(classname);
			var __output = NativeMethods.ConstructString(output);
			try {
				__retVal = __UnhookEntityOutput(&__classname, &__output, Marshalling.GetFunctionPointerForDelegate(callback), type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__classname);
				NativeMethods.DestroyString(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity by classname with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="classname">The class name to search for.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, int> FindEntityByClassname = &___FindEntityByClassname;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __FindEntityByClassname;
		private static int ___FindEntityByClassname(int startFrom, string classname)
		{
			int __retVal;
			var __classname = NativeMethods.ConstructString(classname);
			try {
				__retVal = __FindEntityByClassname(startFrom, &__classname);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__classname);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds the nearest entity by classname to a point.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="classname">The class name to search for.</param>
		/// <param name="origin">The center point to search around.</param>
		/// <param name="maxRadius">Maximum search radius.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, Vector3, float, int> FindEntityByClassnameNearest = &___FindEntityByClassnameNearest;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Vector3*, float, int> __FindEntityByClassnameNearest;
		private static int ___FindEntityByClassnameNearest(int startFrom, string classname, Vector3 origin, float maxRadius)
		{
			int __retVal;
			var __classname = NativeMethods.ConstructString(classname);
			try {
				__retVal = __FindEntityByClassnameNearest(startFrom, &__classname, &origin, maxRadius);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__classname);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity by classname within a radius with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="classname">The class name to search for.</param>
		/// <param name="origin">The center of the search sphere.</param>
		/// <param name="radius">The search radius.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, Vector3, float, int> FindEntityByClassnameWithin = &___FindEntityByClassnameWithin;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Vector3*, float, int> __FindEntityByClassnameWithin;
		private static int ___FindEntityByClassnameWithin(int startFrom, string classname, Vector3 origin, float radius)
		{
			int __retVal;
			var __classname = NativeMethods.ConstructString(classname);
			try {
				__retVal = __FindEntityByClassnameWithin(startFrom, &__classname, &origin, radius);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__classname);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity by name with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="name">The targetname to search for.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, int> FindEntityByName = &___FindEntityByName;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __FindEntityByName;
		private static int ___FindEntityByName(int startFrom, string name)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindEntityByName(startFrom, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds the nearest entity by name to a point.
		/// </summary>
		/// <param name="name">The targetname to search for.</param>
		/// <param name="origin">The point to search around.</param>
		/// <param name="maxRadius">Maximum search radius.</param>
		/// <returns>The handle of the nearest entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<string, Vector3, float, int> FindEntityByNameNearest = &___FindEntityByNameNearest;
		internal static delegate* unmanaged[Cdecl]<String192*, Vector3*, float, int> __FindEntityByNameNearest;
		private static int ___FindEntityByNameNearest(string name, Vector3 origin, float maxRadius)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindEntityByNameNearest(&__name, &origin, maxRadius);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity by name within a radius with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="name">The targetname to search for.</param>
		/// <param name="origin">The center of the search sphere.</param>
		/// <param name="radius">The search radius.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, Vector3, float, int> FindEntityByNameWithin = &___FindEntityByNameWithin;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Vector3*, float, int> __FindEntityByNameWithin;
		private static int ___FindEntityByNameWithin(int startFrom, string name, Vector3 origin, float radius)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindEntityByNameWithin(startFrom, &__name, &origin, radius);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity by targetname with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="name">The targetname to search for.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, string, int> FindEntityByTarget = &___FindEntityByTarget;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __FindEntityByTarget;
		private static int ___FindEntityByTarget(int startFrom, string name)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindEntityByTarget(startFrom, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds an entity within a sphere with iteration.
		/// </summary>
		/// <param name="startFrom">The handle of the entity to start from, or INVALID_EHANDLE_INDEX to start fresh.</param>
		/// <param name="origin">The center of the search sphere.</param>
		/// <param name="radius">The search radius.</param>
		/// <returns>The handle of the found entity, or INVALID_EHANDLE_INDEX if none found.</returns>
		internal static delegate*<int, Vector3, float, int> FindEntityInSphere = &___FindEntityInSphere;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, float, int> __FindEntityInSphere;
		private static int ___FindEntityInSphere(int startFrom, Vector3 origin, float radius)
		{
			int __retVal = __FindEntityInSphere(startFrom, &origin, radius);
			return __retVal;
		}

		/// <summary>
		/// Creates an entity by classname.
		/// </summary>
		/// <param name="className">The class name of the entity to create.</param>
		/// <returns>The handle of the created entity, or INVALID_EHANDLE_INDEX if creation failed.</returns>
		internal static delegate*<string, int> SpawnEntityByName = &___SpawnEntityByName;
		internal static delegate* unmanaged[Cdecl]<String192*, int> __SpawnEntityByName;
		private static int ___SpawnEntityByName(string className)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			try {
				__retVal = __SpawnEntityByName(&__className);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates an entity by string name but does not spawn it.
		/// </summary>
		/// <param name="className">The class name of the entity to create.</param>
		/// <returns>The entity handle of the created entity, or INVALID_EHANDLE_INDEX if the entity could not be created.</returns>
		internal static delegate*<string, int> CreateEntityByName = &___CreateEntityByName;
		internal static delegate* unmanaged[Cdecl]<String192*, int> __CreateEntityByName;
		private static int ___CreateEntityByName(string className)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			try {
				__retVal = __CreateEntityByName(&__className);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
			}
			return __retVal;
		}

		/// <summary>
		/// Spawns an entity into the game.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to spawn.</param>
		internal static delegate*<int, void> DispatchSpawn = &___DispatchSpawn;
		internal static delegate* unmanaged[Cdecl]<int, void> __DispatchSpawn;
		private static void ___DispatchSpawn(int entityHandle)
		{
			__DispatchSpawn(entityHandle);
		}

		/// <summary>
		/// Spawns an entity into the game with key-value properties.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to spawn.</param>
		/// <param name="keys">A vector of keys representing the property names to set on the entity.</param>
		/// <param name="values">A vector of values corresponding to the keys, representing the property values to set on the entity.</param>
		internal static delegate*<int, string[], object[], void> DispatchSpawn2 = &___DispatchSpawn2;
		internal static delegate* unmanaged[Cdecl]<int, Vector192*, Vector192*, void> __DispatchSpawn2;
		private static void ___DispatchSpawn2(int entityHandle, string[] keys, object[] values)
		{
			var __keys = NativeMethods.ConstructVectorString(keys, keys.Length);
			var __values = NativeMethods.ConstructVectorVariant(values, values.Length);
			try {
				__DispatchSpawn2(entityHandle, &__keys, &__values);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorString(&__keys);
				NativeMethods.DestroyVectorVariant(&__values);
			}
		}

		/// <summary>
		/// Marks an entity for deletion.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to be deleted.</param>
		internal static delegate*<int, void> RemoveEntity = &___RemoveEntity;
		internal static delegate* unmanaged[Cdecl]<int, void> __RemoveEntity;
		private static void ___RemoveEntity(int entityHandle)
		{
			__RemoveEntity(entityHandle);
		}

		/// <summary>
		/// Checks if an entity is a player controller.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>True if the entity is a player controller, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsEntityPlayerController = &___IsEntityPlayerController;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsEntityPlayerController;
		private static Bool8 ___IsEntityPlayerController(int entityHandle)
		{
			Bool8 __retVal = __IsEntityPlayerController(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Checks if an entity is a player pawn.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>True if the entity is a player pawn, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsEntityPlayerPawn = &___IsEntityPlayerPawn;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsEntityPlayerPawn;
		private static Bool8 ___IsEntityPlayerPawn(int entityHandle)
		{
			Bool8 __retVal = __IsEntityPlayerPawn(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the class name of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose class name is to be retrieved.</param>
		/// <returns>A string where the class name will be stored.</returns>
		internal static delegate*<int, string> GetEntityClassname = &___GetEntityClassname;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetEntityClassname;
		private static string ___GetEntityClassname(int entityHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEntityClassname(entityHandle);
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
		/// Retrieves the name of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose name is to be retrieved.</param>
		internal static delegate*<int, string> GetEntityName = &___GetEntityName;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetEntityName;
		private static string ___GetEntityName(int entityHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEntityName(entityHandle);
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
		/// Sets the name of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose name is to be set.</param>
		/// <param name="name">The new name to set for the entity.</param>
		internal static delegate*<int, string, void> SetEntityName = &___SetEntityName;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetEntityName;
		private static void ___SetEntityName(int entityHandle, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__SetEntityName(entityHandle, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Retrieves the movement type of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose movement type is to be retrieved.</param>
		/// <returns>The movement type of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, MoveType> GetEntityMoveType = &___GetEntityMoveType;
		internal static delegate* unmanaged[Cdecl]<int, MoveType> __GetEntityMoveType;
		private static MoveType ___GetEntityMoveType(int entityHandle)
		{
			MoveType __retVal = __GetEntityMoveType(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the movement type of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose movement type is to be set.</param>
		/// <param name="moveType">The new movement type to set for the entity.</param>
		internal static delegate*<int, MoveType, void> SetEntityMoveType = &___SetEntityMoveType;
		internal static delegate* unmanaged[Cdecl]<int, MoveType, void> __SetEntityMoveType;
		private static void ___SetEntityMoveType(int entityHandle, MoveType moveType)
		{
			__SetEntityMoveType(entityHandle, moveType);
		}

		/// <summary>
		/// Retrieves the gravity scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose gravity scale is to be retrieved.</param>
		/// <returns>The gravity scale of the entity, or 0.0f if the entity is invalid.</returns>
		internal static delegate*<int, float> GetEntityGravity = &___GetEntityGravity;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityGravity;
		private static float ___GetEntityGravity(int entityHandle)
		{
			float __retVal = __GetEntityGravity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the gravity scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose gravity scale is to be set.</param>
		/// <param name="gravity">The new gravity scale to set for the entity.</param>
		internal static delegate*<int, float, void> SetEntityGravity = &___SetEntityGravity;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetEntityGravity;
		private static void ___SetEntityGravity(int entityHandle, float gravity)
		{
			__SetEntityGravity(entityHandle, gravity);
		}

		/// <summary>
		/// Retrieves the flags of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose flags are to be retrieved.</param>
		/// <returns>The flags of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityFlags = &___GetEntityFlags;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityFlags;
		private static int ___GetEntityFlags(int entityHandle)
		{
			int __retVal = __GetEntityFlags(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the flags of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose flags are to be set.</param>
		/// <param name="flags">The new flags to set for the entity.</param>
		internal static delegate*<int, int, void> SetEntityFlags = &___SetEntityFlags;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityFlags;
		private static void ___SetEntityFlags(int entityHandle, int flags)
		{
			__SetEntityFlags(entityHandle, flags);
		}

		/// <summary>
		/// Retrieves the render color of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose render color is to be retrieved.</param>
		/// <returns>The raw color value of the entity's render color, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityRenderColor = &___GetEntityRenderColor;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityRenderColor;
		private static int ___GetEntityRenderColor(int entityHandle)
		{
			int __retVal = __GetEntityRenderColor(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the render color of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose render color is to be set.</param>
		/// <param name="color">The new raw color value to set for the entity's render color.</param>
		internal static delegate*<int, int, void> SetEntityRenderColor = &___SetEntityRenderColor;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityRenderColor;
		private static void ___SetEntityRenderColor(int entityHandle, int color)
		{
			__SetEntityRenderColor(entityHandle, color);
		}

		/// <summary>
		/// Retrieves the render mode of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose render mode is to be retrieved.</param>
		/// <returns>The render mode of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, RenderMode> GetEntityRenderMode = &___GetEntityRenderMode;
		internal static delegate* unmanaged[Cdecl]<int, RenderMode> __GetEntityRenderMode;
		private static RenderMode ___GetEntityRenderMode(int entityHandle)
		{
			RenderMode __retVal = __GetEntityRenderMode(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the render mode of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose render mode is to be set.</param>
		/// <param name="renderMode">The new render mode to set for the entity.</param>
		internal static delegate*<int, RenderMode, void> SetEntityRenderMode = &___SetEntityRenderMode;
		internal static delegate* unmanaged[Cdecl]<int, RenderMode, void> __SetEntityRenderMode;
		private static void ___SetEntityRenderMode(int entityHandle, RenderMode renderMode)
		{
			__SetEntityRenderMode(entityHandle, renderMode);
		}

		/// <summary>
		/// Retrieves the mass of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose mass is to be retrieved.</param>
		/// <returns>The mass of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityMass = &___GetEntityMass;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityMass;
		private static int ___GetEntityMass(int entityHandle)
		{
			int __retVal = __GetEntityMass(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the mass of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose mass is to be set.</param>
		/// <param name="mass">The new mass value to set for the entity.</param>
		internal static delegate*<int, int, void> SetEntityMass = &___SetEntityMass;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityMass;
		private static void ___SetEntityMass(int entityHandle, int mass)
		{
			__SetEntityMass(entityHandle, mass);
		}

		/// <summary>
		/// Retrieves the friction of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose friction is to be retrieved.</param>
		/// <returns>The friction of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, float> GetEntityFriction = &___GetEntityFriction;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityFriction;
		private static float ___GetEntityFriction(int entityHandle)
		{
			float __retVal = __GetEntityFriction(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the friction of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose friction is to be set.</param>
		/// <param name="friction">The new friction value to set for the entity.</param>
		internal static delegate*<int, float, void> SetEntityFriction = &___SetEntityFriction;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetEntityFriction;
		private static void ___SetEntityFriction(int entityHandle, float friction)
		{
			__SetEntityFriction(entityHandle, friction);
		}

		/// <summary>
		/// Retrieves the health of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose health is to be retrieved.</param>
		/// <returns>The health of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityHealth = &___GetEntityHealth;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityHealth;
		private static int ___GetEntityHealth(int entityHandle)
		{
			int __retVal = __GetEntityHealth(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the health of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose health is to be set.</param>
		/// <param name="health">The new health value to set for the entity.</param>
		internal static delegate*<int, int, void> SetEntityHealth = &___SetEntityHealth;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityHealth;
		private static void ___SetEntityHealth(int entityHandle, int health)
		{
			__SetEntityHealth(entityHandle, health);
		}

		/// <summary>
		/// Retrieves the max health of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose max health is to be retrieved.</param>
		/// <returns>The max health of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityMaxHealth = &___GetEntityMaxHealth;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityMaxHealth;
		private static int ___GetEntityMaxHealth(int entityHandle)
		{
			int __retVal = __GetEntityMaxHealth(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the max health of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose max health is to be set.</param>
		/// <param name="maxHealth">The new max health value to set for the entity.</param>
		internal static delegate*<int, int, void> SetEntityMaxHealth = &___SetEntityMaxHealth;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityMaxHealth;
		private static void ___SetEntityMaxHealth(int entityHandle, int maxHealth)
		{
			__SetEntityMaxHealth(entityHandle, maxHealth);
		}

		/// <summary>
		/// Retrieves the team number of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose team number is to be retrieved.</param>
		/// <returns>The team number of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, CSTeam> GetEntityTeam = &___GetEntityTeam;
		internal static delegate* unmanaged[Cdecl]<int, CSTeam> __GetEntityTeam;
		private static CSTeam ___GetEntityTeam(int entityHandle)
		{
			CSTeam __retVal = __GetEntityTeam(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the team number of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose team number is to be set.</param>
		/// <param name="team">The new team number to set for the entity.</param>
		internal static delegate*<int, CSTeam, void> SetEntityTeam = &___SetEntityTeam;
		internal static delegate* unmanaged[Cdecl]<int, CSTeam, void> __SetEntityTeam;
		private static void ___SetEntityTeam(int entityHandle, CSTeam team)
		{
			__SetEntityTeam(entityHandle, team);
		}

		/// <summary>
		/// Retrieves the owner of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose owner is to be retrieved.</param>
		/// <returns>The handle of the owner entity, or INVALID_EHANDLE_INDEX if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityOwner = &___GetEntityOwner;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityOwner;
		private static int ___GetEntityOwner(int entityHandle)
		{
			int __retVal = __GetEntityOwner(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the owner of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose owner is to be set.</param>
		/// <param name="ownerHandle">The handle of the new owner entity.</param>
		internal static delegate*<int, int, void> SetEntityOwner = &___SetEntityOwner;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityOwner;
		private static void ___SetEntityOwner(int entityHandle, int ownerHandle)
		{
			__SetEntityOwner(entityHandle, ownerHandle);
		}

		/// <summary>
		/// Retrieves the parent of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose parent is to be retrieved.</param>
		/// <returns>The handle of the parent entity, or INVALID_EHANDLE_INDEX if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityParent = &___GetEntityParent;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityParent;
		private static int ___GetEntityParent(int entityHandle)
		{
			int __retVal = __GetEntityParent(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the parent of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose parent is to be set.</param>
		/// <param name="parentHandle">The handle of the new parent entity.</param>
		/// <param name="attachmentName">The name of the entity's attachment.</param>
		internal static delegate*<int, int, string, void> SetEntityParent = &___SetEntityParent;
		internal static delegate* unmanaged[Cdecl]<int, int, String192*, void> __SetEntityParent;
		private static void ___SetEntityParent(int entityHandle, int parentHandle, string attachmentName)
		{
			var __attachmentName = NativeMethods.ConstructString(attachmentName);
			try {
				__SetEntityParent(entityHandle, parentHandle, &__attachmentName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__attachmentName);
			}
		}

		/// <summary>
		/// Retrieves the absolute origin of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute origin is to be retrieved.</param>
		/// <returns>A vector where the absolute origin will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityAbsOrigin = &___GetEntityAbsOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityAbsOrigin;
		private static Vector3 ___GetEntityAbsOrigin(int entityHandle)
		{
			Vector3 __retVal = __GetEntityAbsOrigin(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute origin of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute origin is to be set.</param>
		/// <param name="origin">The new absolute origin to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityAbsOrigin = &___SetEntityAbsOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityAbsOrigin;
		private static void ___SetEntityAbsOrigin(int entityHandle, Vector3 origin)
		{
			__SetEntityAbsOrigin(entityHandle, &origin);
		}

		/// <summary>
		/// Retrieves the absolute scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute scale is to be retrieved.</param>
		/// <returns>A vector where the absolute scale will be stored.</returns>
		internal static delegate*<int, float> GetEntityAbsScale = &___GetEntityAbsScale;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityAbsScale;
		private static float ___GetEntityAbsScale(int entityHandle)
		{
			float __retVal = __GetEntityAbsScale(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute scale is to be set.</param>
		/// <param name="scale">The new absolute scale to set for the entity.</param>
		internal static delegate*<int, float, void> SetEntityAbsScale = &___SetEntityAbsScale;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetEntityAbsScale;
		private static void ___SetEntityAbsScale(int entityHandle, float scale)
		{
			__SetEntityAbsScale(entityHandle, scale);
		}

		/// <summary>
		/// Retrieves the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be retrieved.</param>
		/// <returns>A QAngle where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityAbsAngles = &___GetEntityAbsAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityAbsAngles;
		private static Vector3 ___GetEntityAbsAngles(int entityHandle)
		{
			Vector3 __retVal = __GetEntityAbsAngles(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be set.</param>
		/// <param name="angle">The new angular rotation to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityAbsAngles = &___SetEntityAbsAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityAbsAngles;
		private static void ___SetEntityAbsAngles(int entityHandle, Vector3 angle)
		{
			__SetEntityAbsAngles(entityHandle, &angle);
		}

		/// <summary>
		/// Retrieves the local origin of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local origin is to be retrieved.</param>
		/// <returns>A vector where the local origin will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityLocalOrigin = &___GetEntityLocalOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityLocalOrigin;
		private static Vector3 ___GetEntityLocalOrigin(int entityHandle)
		{
			Vector3 __retVal = __GetEntityLocalOrigin(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the local origin of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local origin is to be set.</param>
		/// <param name="origin">The new local origin to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityLocalOrigin = &___SetEntityLocalOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityLocalOrigin;
		private static void ___SetEntityLocalOrigin(int entityHandle, Vector3 origin)
		{
			__SetEntityLocalOrigin(entityHandle, &origin);
		}

		/// <summary>
		/// Retrieves the local scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local scale is to be retrieved.</param>
		/// <returns>A vector where the local scale will be stored.</returns>
		internal static delegate*<int, float> GetEntityLocalScale = &___GetEntityLocalScale;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityLocalScale;
		private static float ___GetEntityLocalScale(int entityHandle)
		{
			float __retVal = __GetEntityLocalScale(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the local scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local scale is to be set.</param>
		/// <param name="scale">The new local scale to set for the entity.</param>
		internal static delegate*<int, float, void> SetEntityLocalScale = &___SetEntityLocalScale;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetEntityLocalScale;
		private static void ___SetEntityLocalScale(int entityHandle, float scale)
		{
			__SetEntityLocalScale(entityHandle, scale);
		}

		/// <summary>
		/// Retrieves the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be retrieved.</param>
		/// <returns>A QAngle where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityLocalAngles = &___GetEntityLocalAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityLocalAngles;
		private static Vector3 ___GetEntityLocalAngles(int entityHandle)
		{
			Vector3 __retVal = __GetEntityLocalAngles(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be set.</param>
		/// <param name="angle">The new angular rotation to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityLocalAngles = &___SetEntityLocalAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityLocalAngles;
		private static void ___SetEntityLocalAngles(int entityHandle, Vector3 angle)
		{
			__SetEntityLocalAngles(entityHandle, &angle);
		}

		/// <summary>
		/// Retrieves the absolute velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute velocity is to be retrieved.</param>
		/// <returns>A vector where the absolute velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityAbsVelocity = &___GetEntityAbsVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityAbsVelocity;
		private static Vector3 ___GetEntityAbsVelocity(int entityHandle)
		{
			Vector3 __retVal = __GetEntityAbsVelocity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose absolute velocity is to be set.</param>
		/// <param name="velocity">The new absolute velocity to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityAbsVelocity = &___SetEntityAbsVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityAbsVelocity;
		private static void ___SetEntityAbsVelocity(int entityHandle, Vector3 velocity)
		{
			__SetEntityAbsVelocity(entityHandle, &velocity);
		}

		/// <summary>
		/// Retrieves the base velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose base velocity is to be retrieved.</param>
		/// <returns>A vector where the base velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityBaseVelocity = &___GetEntityBaseVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityBaseVelocity;
		private static Vector3 ___GetEntityBaseVelocity(int entityHandle)
		{
			Vector3 __retVal = __GetEntityBaseVelocity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the local angular velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local angular velocity is to be retrieved.</param>
		/// <returns>A vector where the local angular velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityLocalAngVelocity = &___GetEntityLocalAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityLocalAngVelocity;
		private static Vector3 ___GetEntityLocalAngVelocity(int entityHandle)
		{
			Vector3 __retVal = __GetEntityLocalAngVelocity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the angular velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular velocity is to be retrieved.</param>
		/// <returns>A vector where the angular velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityAngVelocity = &___GetEntityAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityAngVelocity;
		private static Vector3 ___GetEntityAngVelocity(int entityHandle)
		{
			Vector3 __retVal = __GetEntityAngVelocity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular velocity is to be set.</param>
		/// <param name="velocity">The new angular velocity to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityAngVelocity = &___SetEntityAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityAngVelocity;
		private static void ___SetEntityAngVelocity(int entityHandle, Vector3 velocity)
		{
			__SetEntityAngVelocity(entityHandle, &velocity);
		}

		/// <summary>
		/// Retrieves the local velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose local velocity is to be retrieved.</param>
		/// <returns>A vector where the local velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityLocalVelocity = &___GetEntityLocalVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityLocalVelocity;
		private static Vector3 ___GetEntityLocalVelocity(int entityHandle)
		{
			Vector3 __retVal = __GetEntityLocalVelocity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be retrieved.</param>
		/// <returns>A vector where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetEntityAngRotation = &___GetEntityAngRotation;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityAngRotation;
		private static Vector3 ___GetEntityAngRotation(int entityHandle)
		{
			Vector3 __retVal = __GetEntityAngRotation(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose angular rotation is to be set.</param>
		/// <param name="rotation">The new angular rotation to set for the entity.</param>
		internal static delegate*<int, Vector3, void> SetEntityAngRotation = &___SetEntityAngRotation;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityAngRotation;
		private static void ___SetEntityAngRotation(int entityHandle, Vector3 rotation)
		{
			__SetEntityAngRotation(entityHandle, &rotation);
		}

		/// <summary>
		/// Returns the input Vector transformed from entity to world space.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity</param>
		/// <param name="point">Point in entity local space to transform</param>
		/// <returns>The point transformed to world space coordinates</returns>
		internal static delegate*<int, Vector3, Vector3> TransformPointEntityToWorld = &___TransformPointEntityToWorld;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3> __TransformPointEntityToWorld;
		private static Vector3 ___TransformPointEntityToWorld(int entityHandle, Vector3 point)
		{
			Vector3 __retVal = __TransformPointEntityToWorld(entityHandle, &point);
			return __retVal;
		}

		/// <summary>
		/// Returns the input Vector transformed from world to entity space.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity</param>
		/// <param name="point">Point in world space to transform</param>
		/// <returns>The point transformed to entity local space coordinates</returns>
		internal static delegate*<int, Vector3, Vector3> TransformPointWorldToEntity = &___TransformPointWorldToEntity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3> __TransformPointWorldToEntity;
		private static Vector3 ___TransformPointWorldToEntity(int entityHandle, Vector3 point)
		{
			Vector3 __retVal = __TransformPointWorldToEntity(entityHandle, &point);
			return __retVal;
		}

		/// <summary>
		/// Get vector to eye position - absolute coords.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity</param>
		/// <returns>Eye position in absolute/world coordinates</returns>
		internal static delegate*<int, Vector3> GetEntityEyePosition = &___GetEntityEyePosition;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityEyePosition;
		private static Vector3 ___GetEntityEyePosition(int entityHandle)
		{
			Vector3 __retVal = __GetEntityEyePosition(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get the qangles that this entity is looking at.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity</param>
		/// <returns>Eye angles as a vector (pitch, yaw, roll)</returns>
		internal static delegate*<int, Vector3> GetEntityEyeAngles = &___GetEntityEyeAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityEyeAngles;
		private static Vector3 ___GetEntityEyeAngles(int entityHandle)
		{
			Vector3 __retVal = __GetEntityEyeAngles(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the forward velocity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose forward velocity is to be set.</param>
		/// <param name="forward"></param>
		internal static delegate*<int, Vector3, void> SetEntityForwardVector = &___SetEntityForwardVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetEntityForwardVector;
		private static void ___SetEntityForwardVector(int entityHandle, Vector3 forward)
		{
			__SetEntityForwardVector(entityHandle, &forward);
		}

		/// <summary>
		/// Get the forward vector of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Forward-facing direction vector of the entity</returns>
		internal static delegate*<int, Vector3> GetEntityForwardVector = &___GetEntityForwardVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityForwardVector;
		private static Vector3 ___GetEntityForwardVector(int entityHandle)
		{
			Vector3 __retVal = __GetEntityForwardVector(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get the left vector of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Left-facing direction vector of the entity (aligned with the y axis)</returns>
		internal static delegate*<int, Vector3> GetEntityLeftVector = &___GetEntityLeftVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityLeftVector;
		private static Vector3 ___GetEntityLeftVector(int entityHandle)
		{
			Vector3 __retVal = __GetEntityLeftVector(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get the right vector of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Right-facing direction vector of the entity</returns>
		internal static delegate*<int, Vector3> GetEntityRightVector = &___GetEntityRightVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityRightVector;
		private static Vector3 ___GetEntityRightVector(int entityHandle)
		{
			Vector3 __retVal = __GetEntityRightVector(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get the up vector of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Up-facing direction vector of the entity</returns>
		internal static delegate*<int, Vector3> GetEntityUpVector = &___GetEntityUpVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityUpVector;
		private static Vector3 ___GetEntityUpVector(int entityHandle)
		{
			Vector3 __retVal = __GetEntityUpVector(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get the entity-to-world transformation matrix.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>4x4 transformation matrix representing entity's position, rotation, and scale in world space</returns>
		internal static delegate*<int, Matrix4x4> GetEntityTransform = &___GetEntityTransform;
		internal static delegate* unmanaged[Cdecl]<int, Matrix4x4> __GetEntityTransform;
		private static Matrix4x4 ___GetEntityTransform(int entityHandle)
		{
			Matrix4x4 __retVal = __GetEntityTransform(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the model name of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose model name is to be retrieved.</param>
		/// <returns>A string where the model name will be stored.</returns>
		internal static delegate*<int, string> GetEntityModel = &___GetEntityModel;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetEntityModel;
		private static string ___GetEntityModel(int entityHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEntityModel(entityHandle);
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
		/// Sets the model name of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose model name is to be set.</param>
		/// <param name="model">The new model name to set for the entity.</param>
		internal static delegate*<int, string, void> SetEntityModel = &___SetEntityModel;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetEntityModel;
		private static void ___SetEntityModel(int entityHandle, string model)
		{
			var __model = NativeMethods.ConstructString(model);
			try {
				__SetEntityModel(entityHandle, &__model);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__model);
			}
		}

		/// <summary>
		/// Retrieves the water level of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose water level is to be retrieved.</param>
		/// <returns>The water level of the entity, or 0.0f if the entity is invalid.</returns>
		internal static delegate*<int, float> GetEntityWaterLevel = &___GetEntityWaterLevel;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityWaterLevel;
		private static float ___GetEntityWaterLevel(int entityHandle)
		{
			float __retVal = __GetEntityWaterLevel(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the ground entity of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose ground entity is to be retrieved.</param>
		/// <returns>The handle of the ground entity, or INVALID_EHANDLE_INDEX if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityGroundEntity = &___GetEntityGroundEntity;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityGroundEntity;
		private static int ___GetEntityGroundEntity(int entityHandle)
		{
			int __retVal = __GetEntityGroundEntity(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the effects of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose effects are to be retrieved.</param>
		/// <returns>The effect flags of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, int> GetEntityEffects = &___GetEntityEffects;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityEffects;
		private static int ___GetEntityEffects(int entityHandle)
		{
			int __retVal = __GetEntityEffects(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Adds the render effect flag to an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to modify</param>
		/// <param name="effects">Render effect flags to add</param>
		internal static delegate*<int, int, void> AddEntityEffects = &___AddEntityEffects;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __AddEntityEffects;
		private static void ___AddEntityEffects(int entityHandle, int effects)
		{
			__AddEntityEffects(entityHandle, effects);
		}

		/// <summary>
		/// Removes the render effect flag from an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to modify</param>
		/// <param name="effects">Render effect flags to remove</param>
		internal static delegate*<int, int, void> RemoveEntityEffects = &___RemoveEntityEffects;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __RemoveEntityEffects;
		private static void ___RemoveEntityEffects(int entityHandle, int effects)
		{
			__RemoveEntityEffects(entityHandle, effects);
		}

		/// <summary>
		/// Get a vector containing max bounds, centered on object.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Vector containing the maximum bounds of the entity's bounding box</returns>
		internal static delegate*<int, Vector3> GetEntityBoundingMaxs = &___GetEntityBoundingMaxs;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityBoundingMaxs;
		private static Vector3 ___GetEntityBoundingMaxs(int entityHandle)
		{
			Vector3 __retVal = __GetEntityBoundingMaxs(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get a vector containing min bounds, centered on object.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Vector containing the minimum bounds of the entity's bounding box</returns>
		internal static delegate*<int, Vector3> GetEntityBoundingMins = &___GetEntityBoundingMins;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityBoundingMins;
		private static Vector3 ___GetEntityBoundingMins(int entityHandle)
		{
			Vector3 __retVal = __GetEntityBoundingMins(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Get vector to center of object - absolute coords.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to query</param>
		/// <returns>Vector pointing to the center of the entity in absolute/world coordinates</returns>
		internal static delegate*<int, Vector3> GetEntityCenter = &___GetEntityCenter;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityCenter;
		private static Vector3 ___GetEntityCenter(int entityHandle)
		{
			Vector3 __retVal = __GetEntityCenter(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Teleports an entity to a specified location and orientation.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to teleport.</param>
		/// <param name="origin">A pointer to a Vector representing the new absolute position. Use nan vector to not set.</param>
		/// <param name="angles">A pointer to a QAngle representing the new orientation. Use nan vector to not set.</param>
		/// <param name="velocity">A pointer to a Vector representing the new velocity. Use nan vector to not set.</param>
		internal static delegate*<int, Vector3, Vector3, Vector3, void> TeleportEntity = &___TeleportEntity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3*, Vector3*, void> __TeleportEntity;
		private static void ___TeleportEntity(int entityHandle, Vector3 origin, Vector3 angles, Vector3 velocity)
		{
			__TeleportEntity(entityHandle, &origin, &angles, &velocity);
		}

		/// <summary>
		/// Apply an absolute velocity impulse to an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to apply impulse to</param>
		/// <param name="vecImpulse">Velocity impulse vector to apply</param>
		internal static delegate*<int, Vector3, void> ApplyAbsVelocityImpulseToEntity = &___ApplyAbsVelocityImpulseToEntity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __ApplyAbsVelocityImpulseToEntity;
		private static void ___ApplyAbsVelocityImpulseToEntity(int entityHandle, Vector3 vecImpulse)
		{
			__ApplyAbsVelocityImpulseToEntity(entityHandle, &vecImpulse);
		}

		/// <summary>
		/// Apply a local angular velocity impulse to an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to apply impulse to</param>
		/// <param name="angImpulse">Angular velocity impulse vector to apply</param>
		internal static delegate*<int, Vector3, void> ApplyLocalAngularVelocityImpulseToEntity = &___ApplyLocalAngularVelocityImpulseToEntity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __ApplyLocalAngularVelocityImpulseToEntity;
		private static void ___ApplyLocalAngularVelocityImpulseToEntity(int entityHandle, Vector3 angImpulse)
		{
			__ApplyLocalAngularVelocityImpulseToEntity(entityHandle, &angImpulse);
		}

		/// <summary>
		/// Invokes a named input method on a specified entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the target entity that will receive the input.</param>
		/// <param name="inputName">The name of the input action to invoke.</param>
		/// <param name="activatorHandle">The handle of the entity that initiated the sequence of actions.</param>
		/// <param name="callerHandle">The handle of the entity sending this event.</param>
		/// <param name="value">The value associated with the input action.</param>
		/// <param name="type">The type or classification of the value.</param>
		/// <param name="outputId">An identifier for tracking the output of this operation.</param>
		internal static delegate*<int, string, int, int, object, FieldType, int, void> AcceptEntityInput = &___AcceptEntityInput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, int, Variant256*, FieldType, int, void> __AcceptEntityInput;
		private static void ___AcceptEntityInput(int entityHandle, string inputName, int activatorHandle, int callerHandle, object value, FieldType type, int outputId)
		{
			var __inputName = NativeMethods.ConstructString(inputName);
			var __value = NativeMethods.ConstructVariant(value);
			try {
				__AcceptEntityInput(entityHandle, &__inputName, activatorHandle, callerHandle, &__value, type, outputId);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__inputName);
				NativeMethods.DestroyVariant(&__value);
			}
		}

		/// <summary>
		/// Connects a script function to an entity output.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="output">The name of the output to connect to.</param>
		/// <param name="functionName">The name of the script function to call.</param>
		internal static delegate*<int, string, string, void> ConnectEntityOutput = &___ConnectEntityOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __ConnectEntityOutput;
		private static void ___ConnectEntityOutput(int entityHandle, string output, string functionName)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__ConnectEntityOutput(entityHandle, &__output, &__functionName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Disconnects a script function from an entity output.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="output">The name of the output.</param>
		/// <param name="functionName">The name of the script function to disconnect.</param>
		internal static delegate*<int, string, string, void> DisconnectEntityOutput = &___DisconnectEntityOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __DisconnectEntityOutput;
		private static void ___DisconnectEntityOutput(int entityHandle, string output, string functionName)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__DisconnectEntityOutput(entityHandle, &__output, &__functionName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Disconnects a script function from an I/O event on a different entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the calling entity.</param>
		/// <param name="output">The name of the output.</param>
		/// <param name="functionName">The function name to disconnect.</param>
		/// <param name="targetHandle">The handle of the entity whose output is being disconnected.</param>
		internal static delegate*<int, string, string, int, void> DisconnectEntityRedirectedOutput = &___DisconnectEntityRedirectedOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, void> __DisconnectEntityRedirectedOutput;
		private static void ___DisconnectEntityRedirectedOutput(int entityHandle, string output, string functionName, int targetHandle)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__DisconnectEntityRedirectedOutput(entityHandle, &__output, &__functionName, targetHandle);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Fires an entity output.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity firing the output.</param>
		/// <param name="outputName">The name of the output to fire.</param>
		/// <param name="activatorHandle">The entity activating the output.</param>
		/// <param name="callerHandle">The entity that called the output.</param>
		/// <param name="value">The value associated with the input action.</param>
		/// <param name="type">The type or classification of the value.</param>
		/// <param name="delay">Delay in seconds before firing the output.</param>
		internal static delegate*<int, string, int, int, object, FieldType, float, void> FireEntityOutput = &___FireEntityOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, int, Variant256*, FieldType, float, void> __FireEntityOutput;
		private static void ___FireEntityOutput(int entityHandle, string outputName, int activatorHandle, int callerHandle, object value, FieldType type, float delay)
		{
			var __outputName = NativeMethods.ConstructString(outputName);
			var __value = NativeMethods.ConstructVariant(value);
			try {
				__FireEntityOutput(entityHandle, &__outputName, activatorHandle, callerHandle, &__value, type, delay);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__outputName);
				NativeMethods.DestroyVariant(&__value);
			}
		}

		/// <summary>
		/// Redirects an entity output to call a function on another entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose output is being redirected.</param>
		/// <param name="output">The name of the output to redirect.</param>
		/// <param name="functionName">The function name to call on the target entity.</param>
		/// <param name="targetHandle">The handle of the entity that will receive the output call.</param>
		internal static delegate*<int, string, string, int, void> RedirectEntityOutput = &___RedirectEntityOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, void> __RedirectEntityOutput;
		private static void ___RedirectEntityOutput(int entityHandle, string output, string functionName, int targetHandle)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__RedirectEntityOutput(entityHandle, &__output, &__functionName, targetHandle);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Makes an entity follow another entity with optional bone merging.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity that will follow</param>
		/// <param name="attachmentHandle">The handle of the entity to follow</param>
		/// <param name="boneMerge">If true, bones will be merged between entities</param>
		internal static delegate*<int, int, Bool8, void> FollowEntity = &___FollowEntity;
		internal static delegate* unmanaged[Cdecl]<int, int, Bool8, void> __FollowEntity;
		private static void ___FollowEntity(int entityHandle, int attachmentHandle, Bool8 boneMerge)
		{
			__FollowEntity(entityHandle, attachmentHandle, boneMerge);
		}

		/// <summary>
		/// Makes an entity follow another entity and merge with a specific bone or attachment.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity that will follow</param>
		/// <param name="attachmentHandle">The handle of the entity to follow</param>
		/// <param name="boneOrAttachName">Name of the bone or attachment point to merge with</param>
		internal static delegate*<int, int, string, void> FollowEntityMerge = &___FollowEntityMerge;
		internal static delegate* unmanaged[Cdecl]<int, int, String192*, void> __FollowEntityMerge;
		private static void ___FollowEntityMerge(int entityHandle, int attachmentHandle, string boneOrAttachName)
		{
			var __boneOrAttachName = NativeMethods.ConstructString(boneOrAttachName);
			try {
				__FollowEntityMerge(entityHandle, attachmentHandle, &__boneOrAttachName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__boneOrAttachName);
			}
		}

		/// <summary>
		/// Apply damage to an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity receiving damage</param>
		/// <param name="inflictorHandle">The handle of the entity inflicting damage (e.g., projectile)</param>
		/// <param name="attackerHandle">The handle of the attacking entity</param>
		/// <param name="force">Direction and magnitude of force to apply</param>
		/// <param name="hitPos">Position where the damage hit occurred</param>
		/// <param name="damage">Amount of damage to apply</param>
		/// <param name="damageTypes">Bitfield of damage type flags</param>
		/// <returns>Amount of damage actually applied to the entity</returns>
		internal static delegate*<int, int, int, Vector3, Vector3, float, DamageTypes, int> TakeEntityDamage = &___TakeEntityDamage;
		internal static delegate* unmanaged[Cdecl]<int, int, int, Vector3*, Vector3*, float, DamageTypes, int> __TakeEntityDamage;
		private static int ___TakeEntityDamage(int entityHandle, int inflictorHandle, int attackerHandle, Vector3 force, Vector3 hitPos, float damage, DamageTypes damageTypes)
		{
			int __retVal = __TakeEntityDamage(entityHandle, inflictorHandle, attackerHandle, &force, &hitPos, damage, damageTypes);
			return __retVal;
		}

		/// <summary>
		/// Retrieves a float attribute value from an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="defaultValue">The default value to return if the attribute does not exist.</param>
		/// <returns>The float value of the attribute, or the default value if missing or invalid.</returns>
		internal static delegate*<int, string, float, float> GetEntityAttributeFloatValue = &___GetEntityAttributeFloatValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, float, float> __GetEntityAttributeFloatValue;
		private static float ___GetEntityAttributeFloatValue(int entityHandle, string name, float defaultValue)
		{
			float __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetEntityAttributeFloatValue(entityHandle, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves an integer attribute value from an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="defaultValue">The default value to return if the attribute does not exist.</param>
		/// <returns>The integer value of the attribute, or the default value if missing or invalid.</returns>
		internal static delegate*<int, string, int, int> GetEntityAttributeIntValue = &___GetEntityAttributeIntValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, int> __GetEntityAttributeIntValue;
		private static int ___GetEntityAttributeIntValue(int entityHandle, string name, int defaultValue)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetEntityAttributeIntValue(entityHandle, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a float attribute value on an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The float value to assign to the attribute.</param>
		internal static delegate*<int, string, float, void> SetEntityAttributeFloatValue = &___SetEntityAttributeFloatValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, float, void> __SetEntityAttributeFloatValue;
		private static void ___SetEntityAttributeFloatValue(int entityHandle, string name, float value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__SetEntityAttributeFloatValue(entityHandle, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets an integer attribute value on an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The integer value to assign to the attribute.</param>
		internal static delegate*<int, string, int, void> SetEntityAttributeIntValue = &___SetEntityAttributeIntValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, void> __SetEntityAttributeIntValue;
		private static void ___SetEntityAttributeIntValue(int entityHandle, string name, int value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__SetEntityAttributeIntValue(entityHandle, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Deletes an attribute from an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute to delete.</param>
		internal static delegate*<int, string, void> DeleteEntityAttribute = &___DeleteEntityAttribute;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __DeleteEntityAttribute;
		private static void ___DeleteEntityAttribute(int entityHandle, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__DeleteEntityAttribute(entityHandle, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Checks if an entity has a specific attribute.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the attribute to check.</param>
		/// <returns>True if the attribute exists, false otherwise.</returns>
		internal static delegate*<int, string, Bool8> HasEntityAttribute = &___HasEntityAttribute;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Bool8> __HasEntityAttribute;
		private static Bool8 ___HasEntityAttribute(int entityHandle, string name)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __HasEntityAttribute(entityHandle, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
