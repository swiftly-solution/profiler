using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: schema)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Get the offset of a member in a given schema class.
		/// </summary>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the member whose offset is to be retrieved.</param>
		/// <returns>The offset of the member in the class.</returns>
		internal static delegate*<string, string, int> GetSchemaOffset = &___GetSchemaOffset;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, int> __GetSchemaOffset;
		private static int ___GetSchemaOffset(string className, string memberName)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetSchemaOffset(&__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Get the offset of a chain in a given schema class.
		/// </summary>
		/// <param name="className">The name of the class.</param>
		/// <returns>The offset of the chain entity in the class (-1 for non-entity classes).</returns>
		internal static delegate*<string, int> GetSchemaChainOffset = &___GetSchemaChainOffset;
		internal static delegate* unmanaged[Cdecl]<String192*, int> __GetSchemaChainOffset;
		private static int ___GetSchemaChainOffset(string className)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			try {
				__retVal = __GetSchemaChainOffset(&__className);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
			}
			return __retVal;
		}

		/// <summary>
		/// Check if a schema field is networked.
		/// </summary>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the member to check.</param>
		/// <returns>True if the member is networked, false otherwise.</returns>
		internal static delegate*<string, string, Bool8> IsSchemaFieldNetworked = &___IsSchemaFieldNetworked;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, Bool8> __IsSchemaFieldNetworked;
		private static Bool8 ___IsSchemaFieldNetworked(string className, string memberName)
		{
			Bool8 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __IsSchemaFieldNetworked(&__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Get the size of a schema class.
		/// </summary>
		/// <param name="className">The name of the class.</param>
		/// <returns>The size of the class in bytes, or -1 if the class is not found.</returns>
		internal static delegate*<string, int> GetSchemaClassSize = &___GetSchemaClassSize;
		internal static delegate* unmanaged[Cdecl]<String192*, int> __GetSchemaClassSize;
		private static int ___GetSchemaClassSize(string className)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			try {
				__retVal = __GetSchemaClassSize(&__className);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
			}
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the integer value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <returns>The integer value at the given memory location.</returns>
		internal static delegate*<nint, int, int, long> GetEntData2 = &___GetEntData2;
		internal static delegate* unmanaged[Cdecl]<nint, int, int, long> __GetEntData2;
		private static long ___GetEntData2(nint entity, int offset, int size)
		{
			long __retVal = __GetEntData2(entity, offset, size);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the integer value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The integer value to set.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, long, int, Bool8, int, void> SetEntData2 = &___SetEntData2;
		internal static delegate* unmanaged[Cdecl]<nint, int, long, int, Bool8, int, void> __SetEntData2;
		private static void ___SetEntData2(nint entity, int offset, long value, int size, Bool8 changeState, int chainOffset)
		{
			__SetEntData2(entity, offset, value, size, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the float value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <returns>The float value at the given memory location.</returns>
		internal static delegate*<nint, int, int, double> GetEntDataFloat2 = &___GetEntDataFloat2;
		internal static delegate* unmanaged[Cdecl]<nint, int, int, double> __GetEntDataFloat2;
		private static double ___GetEntDataFloat2(nint entity, int offset, int size)
		{
			double __retVal = __GetEntDataFloat2(entity, offset, size);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the float value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The float value to set.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, double, int, Bool8, int, void> SetEntDataFloat2 = &___SetEntDataFloat2;
		internal static delegate* unmanaged[Cdecl]<nint, int, double, int, Bool8, int, void> __SetEntDataFloat2;
		private static void ___SetEntDataFloat2(nint entity, int offset, double value, int size, Bool8 changeState, int chainOffset)
		{
			__SetEntDataFloat2(entity, offset, value, size, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the string value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The string value at the given memory location.</returns>
		internal static delegate*<nint, int, string> GetEntDataString2 = &___GetEntDataString2;
		internal static delegate* unmanaged[Cdecl]<nint, int, String192> __GetEntDataString2;
		private static string ___GetEntDataString2(nint entity, int offset)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEntDataString2(entity, offset);
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
		/// Peeks into an entity's object data and sets the string at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The string value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, string, Bool8, int, void> SetEntDataString2 = &___SetEntDataString2;
		internal static delegate* unmanaged[Cdecl]<nint, int, String192*, Bool8, int, void> __SetEntDataString2;
		private static void ___SetEntDataString2(nint entity, int offset, string value, Bool8 changeState, int chainOffset)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetEntDataString2(entity, offset, &__value, changeState, chainOffset);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the vector value at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The vector value at the given memory location.</returns>
		internal static delegate*<nint, int, Vector3> GetEntDataVector2 = &___GetEntDataVector2;
		internal static delegate* unmanaged[Cdecl]<nint, int, Vector3> __GetEntDataVector2;
		private static Vector3 ___GetEntDataVector2(nint entity, int offset)
		{
			Vector3 __retVal = __GetEntDataVector2(entity, offset);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the vector at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, Vector3, Bool8, int, void> SetEntDataVector2 = &___SetEntDataVector2;
		internal static delegate* unmanaged[Cdecl]<nint, int, Vector3*, Bool8, int, void> __SetEntDataVector2;
		private static void ___SetEntDataVector2(nint entity, int offset, Vector3 value, Bool8 changeState, int chainOffset)
		{
			__SetEntDataVector2(entity, offset, &value, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object data and retrieves the entity handle at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The entity handle at the given memory location.</returns>
		internal static delegate*<nint, int, int> GetEntDataEnt2 = &___GetEntDataEnt2;
		internal static delegate* unmanaged[Cdecl]<nint, int, int> __GetEntDataEnt2;
		private static int ___GetEntDataEnt2(nint entity, int offset)
		{
			int __retVal = __GetEntDataEnt2(entity, offset);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the entity handle at the given offset.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The entity handle to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, int, Bool8, int, void> SetEntDataEnt2 = &___SetEntDataEnt2;
		internal static delegate* unmanaged[Cdecl]<nint, int, int, Bool8, int, void> __SetEntDataEnt2;
		private static void ___SetEntDataEnt2(nint entity, int offset, int value, Bool8 changeState, int chainOffset)
		{
			__SetEntDataEnt2(entity, offset, value, changeState, chainOffset);
		}

		/// <summary>
		/// Updates the networked state of a schema field for a given entity pointer.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<nint, int, int, void> ChangeEntityState2 = &___ChangeEntityState2;
		internal static delegate* unmanaged[Cdecl]<nint, int, int, void> __ChangeEntityState2;
		private static void ___ChangeEntityState2(nint entity, int offset, int chainOffset)
		{
			__ChangeEntityState2(entity, offset, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the integer value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <returns>The integer value at the given memory location.</returns>
		internal static delegate*<int, int, int, long> GetEntData = &___GetEntData;
		internal static delegate* unmanaged[Cdecl]<int, int, int, long> __GetEntData;
		private static long ___GetEntData(int entityHandle, int offset, int size)
		{
			long __retVal = __GetEntData(entityHandle, offset, size);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the integer value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The integer value to set.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, long, int, Bool8, int, void> SetEntData = &___SetEntData;
		internal static delegate* unmanaged[Cdecl]<int, int, long, int, Bool8, int, void> __SetEntData;
		private static void ___SetEntData(int entityHandle, int offset, long value, int size, Bool8 changeState, int chainOffset)
		{
			__SetEntData(entityHandle, offset, value, size, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the float value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <returns>The float value at the given memory location.</returns>
		internal static delegate*<int, int, int, double> GetEntDataFloat = &___GetEntDataFloat;
		internal static delegate* unmanaged[Cdecl]<int, int, int, double> __GetEntDataFloat;
		private static double ___GetEntDataFloat(int entityHandle, int offset, int size)
		{
			double __retVal = __GetEntDataFloat(entityHandle, offset, size);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the float value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The float value to set.</param>
		/// <param name="size">Number of bytes to write (valid values are 1, 2, 4 or 8).</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, double, int, Bool8, int, void> SetEntDataFloat = &___SetEntDataFloat;
		internal static delegate* unmanaged[Cdecl]<int, int, double, int, Bool8, int, void> __SetEntDataFloat;
		private static void ___SetEntDataFloat(int entityHandle, int offset, double value, int size, Bool8 changeState, int chainOffset)
		{
			__SetEntDataFloat(entityHandle, offset, value, size, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the string value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The string value at the given memory location.</returns>
		internal static delegate*<int, int, string> GetEntDataString = &___GetEntDataString;
		internal static delegate* unmanaged[Cdecl]<int, int, String192> __GetEntDataString;
		private static string ___GetEntDataString(int entityHandle, int offset)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetEntDataString(entityHandle, offset);
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
		/// Peeks into an entity's object data and sets the string at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The string value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, string, Bool8, int, void> SetEntDataString = &___SetEntDataString;
		internal static delegate* unmanaged[Cdecl]<int, int, String192*, Bool8, int, void> __SetEntDataString;
		private static void ___SetEntDataString(int entityHandle, int offset, string value, Bool8 changeState, int chainOffset)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetEntDataString(entityHandle, offset, &__value, changeState, chainOffset);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Peeks into an entity's object schema and retrieves the vector value at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The vector value at the given memory location.</returns>
		internal static delegate*<int, int, Vector3> GetEntDataVector = &___GetEntDataVector;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3> __GetEntDataVector;
		private static Vector3 ___GetEntDataVector(int entityHandle, int offset)
		{
			Vector3 __retVal = __GetEntDataVector(entityHandle, offset);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the vector at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, Vector3, Bool8, int, void> SetEntDataVector = &___SetEntDataVector;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3*, Bool8, int, void> __SetEntDataVector;
		private static void ___SetEntDataVector(int entityHandle, int offset, Vector3 value, Bool8 changeState, int chainOffset)
		{
			__SetEntDataVector(entityHandle, offset, &value, changeState, chainOffset);
		}

		/// <summary>
		/// Peeks into an entity's object data and retrieves the entity handle at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <returns>The entity handle at the given memory location.</returns>
		internal static delegate*<int, int, int> GetEntDataEnt = &___GetEntDataEnt;
		internal static delegate* unmanaged[Cdecl]<int, int, int> __GetEntDataEnt;
		private static int ___GetEntDataEnt(int entityHandle, int offset)
		{
			int __retVal = __GetEntDataEnt(entityHandle, offset);
			return __retVal;
		}

		/// <summary>
		/// Peeks into an entity's object data and sets the entity handle at the given offset.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="value">The entity handle to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, int, Bool8, int, void> SetEntDataEnt = &___SetEntDataEnt;
		internal static delegate* unmanaged[Cdecl]<int, int, int, Bool8, int, void> __SetEntDataEnt;
		private static void ___SetEntDataEnt(int entityHandle, int offset, int value, Bool8 changeState, int chainOffset)
		{
			__SetEntDataEnt(entityHandle, offset, value, changeState, chainOffset);
		}

		/// <summary>
		/// Updates the networked state of a schema field for a given entity handle.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="offset">The offset of the schema to use.</param>
		/// <param name="chainOffset">The offset of the chain entity in the class (-1 for non-entity classes).</param>
		internal static delegate*<int, int, int, void> ChangeEntityState = &___ChangeEntityState;
		internal static delegate* unmanaged[Cdecl]<int, int, int, void> __ChangeEntityState;
		private static void ___ChangeEntityState(int entityHandle, int offset, int chainOffset)
		{
			__ChangeEntityState(entityHandle, offset, chainOffset);
		}

		/// <summary>
		/// Retrieves the count of values that an entity schema's array can store.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <returns>Size of array (in elements) or 0 if schema is not an array.</returns>
		internal static delegate*<nint, string, string, int> GetEntSchemaArraySize2 = &___GetEntSchemaArraySize2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int> __GetEntSchemaArraySize2;
		private static int ___GetEntSchemaArraySize2(nint entity, string className, string memberName)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaArraySize2(entity, &__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves an integer value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>An integer value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, long> GetEntSchema2 = &___GetEntSchema2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, long> __GetEntSchema2;
		private static long ___GetEntSchema2(nint entity, string className, string memberName, int element)
		{
			long __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchema2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an integer value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The integer value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, long, Bool8, int, void> SetEntSchema2 = &___SetEntSchema2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, long, Bool8, int, void> __SetEntSchema2;
		private static void ___SetEntSchema2(nint entity, string className, string memberName, long value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchema2(entity, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a float value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A float value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, double> GetEntSchemaFloat2 = &___GetEntSchemaFloat2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, double> __GetEntSchemaFloat2;
		private static double ___GetEntSchemaFloat2(nint entity, string className, string memberName, int element)
		{
			double __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaFloat2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a float value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The float value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, double, Bool8, int, void> SetEntSchemaFloat2 = &___SetEntSchemaFloat2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, double, Bool8, int, void> __SetEntSchemaFloat2;
		private static void ___SetEntSchemaFloat2(nint entity, string className, string memberName, double value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaFloat2(entity, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a string value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, string> GetEntSchemaString2 = &___GetEntSchemaString2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, String192> __GetEntSchemaString2;
		private static string ___GetEntSchemaString2(nint entity, string className, string memberName, int element)
		{
			string __retVal;
			String192 __retVal_native;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal_native = __GetEntSchemaString2(entity, &__className, &__memberName, element);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a string value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The string value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, string, Bool8, int, void> SetEntSchemaString2 = &___SetEntSchemaString2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, Bool8, int, void> __SetEntSchemaString2;
		private static void ___SetEntSchemaString2(nint entity, string className, string memberName, string value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetEntSchemaString2(entity, &__className, &__memberName, &__value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A vector value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, Vector3> GetEntSchemaVector3D2 = &___GetEntSchemaVector3D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, Vector3> __GetEntSchemaVector3D2;
		private static Vector3 ___GetEntSchemaVector3D2(nint entity, string className, string memberName, int element)
		{
			Vector3 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector3D2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, Vector3, Bool8, int, void> SetEntSchemaVector3D2 = &___SetEntSchemaVector3D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Vector3*, Bool8, int, void> __SetEntSchemaVector3D2;
		private static void ___SetEntSchemaVector3D2(nint entity, string className, string memberName, Vector3 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector3D2(entity, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A vector value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, Vector2> GetEntSchemaVector2D2 = &___GetEntSchemaVector2D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, Vector2> __GetEntSchemaVector2D2;
		private static Vector2 ___GetEntSchemaVector2D2(nint entity, string className, string memberName, int element)
		{
			Vector2 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector2D2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, Vector2, Bool8, int, void> SetEntSchemaVector2D2 = &___SetEntSchemaVector2D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Vector2*, Bool8, int, void> __SetEntSchemaVector2D2;
		private static void ___SetEntSchemaVector2D2(nint entity, string className, string memberName, Vector2 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector2D2(entity, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A vector value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, Vector4> GetEntSchemaVector4D2 = &___GetEntSchemaVector4D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, Vector4> __GetEntSchemaVector4D2;
		private static Vector4 ___GetEntSchemaVector4D2(nint entity, string className, string memberName, int element)
		{
			Vector4 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector4D2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, Vector4, Bool8, int, void> SetEntSchemaVector4D2 = &___SetEntSchemaVector4D2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Vector4*, Bool8, int, void> __SetEntSchemaVector4D2;
		private static void ___SetEntSchemaVector4D2(nint entity, string className, string memberName, Vector4 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector4D2(entity, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves an entity handle from an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<nint, string, string, int, int> GetEntSchemaEnt2 = &___GetEntSchemaEnt2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, int> __GetEntSchemaEnt2;
		private static int ___GetEntSchemaEnt2(nint entity, string className, string memberName, int element)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaEnt2(entity, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an entity handle in an entity's schema.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The entity handle to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<nint, string, string, int, Bool8, int, void> SetEntSchemaEnt2 = &___SetEntSchemaEnt2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, int, Bool8, int, void> __SetEntSchemaEnt2;
		private static void ___SetEntSchemaEnt2(nint entity, string className, string memberName, int value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaEnt2(entity, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Updates the networked state of a schema field for a given entity pointer.
		/// </summary>
		/// <param name="entity">Pointer to the instance of the class where the value is to be set.</param>
		/// <param name="className">The name of the class that contains the member.</param>
		/// <param name="memberName">The name of the member to be set.</param>
		internal static delegate*<nint, string, string, void> NetworkStateChanged2 = &___NetworkStateChanged2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, void> __NetworkStateChanged2;
		private static void ___NetworkStateChanged2(nint entity, string className, string memberName)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__NetworkStateChanged2(entity, &__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves the count of values that an entity schema's array can store.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <returns>Size of array (in elements) or 0 if schema is not an array.</returns>
		internal static delegate*<int, string, string, int> GetEntSchemaArraySize = &___GetEntSchemaArraySize;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int> __GetEntSchemaArraySize;
		private static int ___GetEntSchemaArraySize(int entityHandle, string className, string memberName)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaArraySize(entityHandle, &__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves an integer value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>An integer value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, long> GetEntSchema = &___GetEntSchema;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, long> __GetEntSchema;
		private static long ___GetEntSchema(int entityHandle, string className, string memberName, int element)
		{
			long __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchema(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an integer value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The integer value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, long, Bool8, int, void> SetEntSchema = &___SetEntSchema;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, long, Bool8, int, void> __SetEntSchema;
		private static void ___SetEntSchema(int entityHandle, string className, string memberName, long value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchema(entityHandle, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a float value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A float value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, double> GetEntSchemaFloat = &___GetEntSchemaFloat;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, double> __GetEntSchemaFloat;
		private static double ___GetEntSchemaFloat(int entityHandle, string className, string memberName, int element)
		{
			double __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaFloat(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a float value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The float value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, double, Bool8, int, void> SetEntSchemaFloat = &___SetEntSchemaFloat;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, double, Bool8, int, void> __SetEntSchemaFloat;
		private static void ___SetEntSchemaFloat(int entityHandle, string className, string memberName, double value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaFloat(entityHandle, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a string value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, string> GetEntSchemaString = &___GetEntSchemaString;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, String192> __GetEntSchemaString;
		private static string ___GetEntSchemaString(int entityHandle, string className, string memberName, int element)
		{
			string __retVal;
			String192 __retVal_native;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal_native = __GetEntSchemaString(entityHandle, &__className, &__memberName, element);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a string value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The string value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, string, Bool8, int, void> SetEntSchemaString = &___SetEntSchemaString;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, String192*, Bool8, int, void> __SetEntSchemaString;
		private static void ___SetEntSchemaString(int entityHandle, string className, string memberName, string value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetEntSchemaString(entityHandle, &__className, &__memberName, &__value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, Vector3> GetEntSchemaVector3D = &___GetEntSchemaVector3D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, Vector3> __GetEntSchemaVector3D;
		private static Vector3 ___GetEntSchemaVector3D(int entityHandle, string className, string memberName, int element)
		{
			Vector3 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector3D(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, Vector3, Bool8, int, void> SetEntSchemaVector3D = &___SetEntSchemaVector3D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, Vector3*, Bool8, int, void> __SetEntSchemaVector3D;
		private static void ___SetEntSchemaVector3D(int entityHandle, string className, string memberName, Vector3 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector3D(entityHandle, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, Vector2> GetEntSchemaVector2D = &___GetEntSchemaVector2D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, Vector2> __GetEntSchemaVector2D;
		private static Vector2 ___GetEntSchemaVector2D(int entityHandle, string className, string memberName, int element)
		{
			Vector2 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector2D(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, Vector2, Bool8, int, void> SetEntSchemaVector2D = &___SetEntSchemaVector2D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, Vector2*, Bool8, int, void> __SetEntSchemaVector2D;
		private static void ___SetEntSchemaVector2D(int entityHandle, string className, string memberName, Vector2 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector2D(entityHandle, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves a vector value from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, Vector4> GetEntSchemaVector4D = &___GetEntSchemaVector4D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, Vector4> __GetEntSchemaVector4D;
		private static Vector4 ___GetEntSchemaVector4D(int entityHandle, string className, string memberName, int element)
		{
			Vector4 __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaVector4D(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a vector value in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The vector value to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, Vector4, Bool8, int, void> SetEntSchemaVector4D = &___SetEntSchemaVector4D;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, Vector4*, Bool8, int, void> __SetEntSchemaVector4D;
		private static void ___SetEntSchemaVector4D(int entityHandle, string className, string memberName, Vector4 value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaVector4D(entityHandle, &__className, &__memberName, &value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Retrieves an entity handle from an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		/// <returns>A string value at the given schema offset.</returns>
		internal static delegate*<int, string, string, int, int> GetEntSchemaEnt = &___GetEntSchemaEnt;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, int> __GetEntSchemaEnt;
		private static int ___GetEntSchemaEnt(int entityHandle, string className, string memberName, int element)
		{
			int __retVal;
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__retVal = __GetEntSchemaEnt(entityHandle, &__className, &__memberName, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an entity handle in an entity's schema.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class.</param>
		/// <param name="memberName">The name of the schema member.</param>
		/// <param name="value">The entity handle to set.</param>
		/// <param name="changeState">If true, change will be sent over the network.</param>
		/// <param name="element">Element # (starting from 0) if schema is an array.</param>
		internal static delegate*<int, string, string, int, Bool8, int, void> SetEntSchemaEnt = &___SetEntSchemaEnt;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, Bool8, int, void> __SetEntSchemaEnt;
		private static void ___SetEntSchemaEnt(int entityHandle, string className, string memberName, int value, Bool8 changeState, int element)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__SetEntSchemaEnt(entityHandle, &__className, &__memberName, value, changeState, element);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

		/// <summary>
		/// Updates the networked state of a schema field for a given entity handle.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which the value is to be retrieved.</param>
		/// <param name="className">The name of the class that contains the member.</param>
		/// <param name="memberName">The name of the member to be set.</param>
		internal static delegate*<int, string, string, void> NetworkStateChanged = &___NetworkStateChanged;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __NetworkStateChanged;
		private static void ___NetworkStateChanged(int entityHandle, string className, string memberName)
		{
			var __className = NativeMethods.ConstructString(className);
			var __memberName = NativeMethods.ConstructString(memberName);
			try {
				__NetworkStateChanged(entityHandle, &__className, &__memberName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__className);
				NativeMethods.DestroyString(&__memberName);
			}
		}

	}

#pragma warning restore CS0649
}
