using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: keyvalues3)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a new KeyValues3 object with specified type and subtype
		/// </summary>
		/// <param name="type">The KV3 type enumeration value</param>
		/// <param name="subtype">The KV3 subtype enumeration value</param>
		/// <returns>Pointer to the newly created KeyValues3 object</returns>
		internal static delegate*<int, int, nint> Kv3Create = &___Kv3Create;
		internal static delegate* unmanaged[Cdecl]<int, int, nint> __Kv3Create;
		private static nint ___Kv3Create(int type, int subtype)
		{
			nint __retVal = __Kv3Create(type, subtype);
			return __retVal;
		}

		/// <summary>
		/// Creates a new KeyValues3 object with cluster element, type, and subtype
		/// </summary>
		/// <param name="cluster_elem">The cluster element index</param>
		/// <param name="type">The KV3 type enumeration value</param>
		/// <param name="subtype">The KV3 subtype enumeration value</param>
		/// <returns>Pointer to the newly created KeyValues3 object</returns>
		internal static delegate*<int, int, int, nint> Kv3CreateWithCluster = &___Kv3CreateWithCluster;
		internal static delegate* unmanaged[Cdecl]<int, int, int, nint> __Kv3CreateWithCluster;
		private static nint ___Kv3CreateWithCluster(int cluster_elem, int type, int subtype)
		{
			nint __retVal = __Kv3CreateWithCluster(cluster_elem, type, subtype);
			return __retVal;
		}

		/// <summary>
		/// Creates a copy of an existing KeyValues3 object
		/// </summary>
		/// <param name="other">Pointer to the KeyValues3 object to copy</param>
		/// <returns>Pointer to the newly created copy, or nullptr if other is null</returns>
		internal static delegate*<nint, nint> Kv3CreateCopy = &___Kv3CreateCopy;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv3CreateCopy;
		private static nint ___Kv3CreateCopy(nint other)
		{
			nint __retVal = __Kv3CreateCopy(other);
			return __retVal;
		}

		/// <summary>
		/// Destroys a KeyValues3 object and frees its memory
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object to destroy</param>
		internal static delegate*<nint, void> Kv3Destroy = &___Kv3Destroy;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv3Destroy;
		private static void ___Kv3Destroy(nint kv)
		{
			__Kv3Destroy(kv);
		}

		/// <summary>
		/// Copies data from another KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the destination KeyValues3 object</param>
		/// <param name="other">Pointer to the source KeyValues3 object</param>
		internal static delegate*<nint, nint, void> Kv3CopyFrom = &___Kv3CopyFrom;
		internal static delegate* unmanaged[Cdecl]<nint, nint, void> __Kv3CopyFrom;
		private static void ___Kv3CopyFrom(nint kv, nint other)
		{
			__Kv3CopyFrom(kv, other);
		}

		/// <summary>
		/// Overlays keys from another KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the destination KeyValues3 object</param>
		/// <param name="other">Pointer to the source KeyValues3 object</param>
		/// <param name="depth">Whether to perform a deep overlay</param>
		internal static delegate*<nint, nint, Bool8, void> Kv3OverlayKeysFrom = &___Kv3OverlayKeysFrom;
		internal static delegate* unmanaged[Cdecl]<nint, nint, Bool8, void> __Kv3OverlayKeysFrom;
		private static void ___Kv3OverlayKeysFrom(nint kv, nint other, Bool8 depth)
		{
			__Kv3OverlayKeysFrom(kv, other, depth);
		}

		/// <summary>
		/// Gets the context associated with a KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Pointer to the CKeyValues3Context, or nullptr if kv is null</returns>
		internal static delegate*<nint, nint> Kv3GetContext = &___Kv3GetContext;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv3GetContext;
		private static nint ___Kv3GetContext(nint kv)
		{
			nint __retVal = __Kv3GetContext(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets the metadata associated with a KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="ppCtx">Pointer to store the context pointer</param>
		/// <returns>Pointer to the KV3MetaData_t structure, or nullptr if kv is null</returns>
		internal static delegate*<nint, nint, nint> Kv3GetMetaData = &___Kv3GetMetaData;
		internal static delegate* unmanaged[Cdecl]<nint, nint, nint> __Kv3GetMetaData;
		private static nint ___Kv3GetMetaData(nint kv, nint ppCtx)
		{
			nint __retVal = __Kv3GetMetaData(kv, ppCtx);
			return __retVal;
		}

		/// <summary>
		/// Checks if a specific flag is set
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="flag">The flag to check</param>
		/// <returns>true if the flag is set, false otherwise</returns>
		internal static delegate*<nint, byte, Bool8> Kv3HasFlag = &___Kv3HasFlag;
		internal static delegate* unmanaged[Cdecl]<nint, byte, Bool8> __Kv3HasFlag;
		private static Bool8 ___Kv3HasFlag(nint kv, byte flag)
		{
			Bool8 __retVal = __Kv3HasFlag(kv, flag);
			return __retVal;
		}

		/// <summary>
		/// Checks if any flags are set
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if any flags are set, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3HasAnyFlags = &___Kv3HasAnyFlags;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3HasAnyFlags;
		private static Bool8 ___Kv3HasAnyFlags(nint kv)
		{
			Bool8 __retVal = __Kv3HasAnyFlags(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets all flags as a bitmask
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Bitmask of all flags, or 0 if kv is null</returns>
		internal static delegate*<nint, byte> Kv3GetAllFlags = &___Kv3GetAllFlags;
		internal static delegate* unmanaged[Cdecl]<nint, byte> __Kv3GetAllFlags;
		private static byte ___Kv3GetAllFlags(nint kv)
		{
			byte __retVal = __Kv3GetAllFlags(kv);
			return __retVal;
		}

		/// <summary>
		/// Sets all flags from a bitmask
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="flags">Bitmask of flags to set</param>
		internal static delegate*<nint, byte, void> Kv3SetAllFlags = &___Kv3SetAllFlags;
		internal static delegate* unmanaged[Cdecl]<nint, byte, void> __Kv3SetAllFlags;
		private static void ___Kv3SetAllFlags(nint kv, byte flags)
		{
			__Kv3SetAllFlags(kv, flags);
		}

		/// <summary>
		/// Sets or clears a specific flag
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="flag">The flag to modify</param>
		/// <param name="state">true to set the flag, false to clear it</param>
		internal static delegate*<nint, byte, Bool8, void> Kv3SetFlag = &___Kv3SetFlag;
		internal static delegate* unmanaged[Cdecl]<nint, byte, Bool8, void> __Kv3SetFlag;
		private static void ___Kv3SetFlag(nint kv, byte flag, Bool8 state)
		{
			__Kv3SetFlag(kv, flag, state);
		}

		/// <summary>
		/// Gets the basic type of the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>The type enumeration value, or 0 if kv is null</returns>
		internal static delegate*<nint, byte> Kv3GetType = &___Kv3GetType;
		internal static delegate* unmanaged[Cdecl]<nint, byte> __Kv3GetType;
		private static byte ___Kv3GetType(nint kv)
		{
			byte __retVal = __Kv3GetType(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets the extended type of the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>The extended type enumeration value, or 0 if kv is null</returns>
		internal static delegate*<nint, byte> Kv3GetTypeEx = &___Kv3GetTypeEx;
		internal static delegate* unmanaged[Cdecl]<nint, byte> __Kv3GetTypeEx;
		private static byte ___Kv3GetTypeEx(nint kv)
		{
			byte __retVal = __Kv3GetTypeEx(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets the subtype of the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>The subtype enumeration value, or 0 if kv is null</returns>
		internal static delegate*<nint, byte> Kv3GetSubType = &___Kv3GetSubType;
		internal static delegate* unmanaged[Cdecl]<nint, byte> __Kv3GetSubType;
		private static byte ___Kv3GetSubType(nint kv)
		{
			byte __retVal = __Kv3GetSubType(kv);
			return __retVal;
		}

		/// <summary>
		/// Checks if the object has invalid member names
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if invalid member names exist, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3HasInvalidMemberNames = &___Kv3HasInvalidMemberNames;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3HasInvalidMemberNames;
		private static Bool8 ___Kv3HasInvalidMemberNames(nint kv)
		{
			Bool8 __retVal = __Kv3HasInvalidMemberNames(kv);
			return __retVal;
		}

		/// <summary>
		/// Sets the invalid member names flag
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="bValue">true to mark as having invalid member names, false otherwise</param>
		internal static delegate*<nint, Bool8, void> Kv3SetHasInvalidMemberNames = &___Kv3SetHasInvalidMemberNames;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, void> __Kv3SetHasInvalidMemberNames;
		private static void ___Kv3SetHasInvalidMemberNames(nint kv, Bool8 bValue)
		{
			__Kv3SetHasInvalidMemberNames(kv, bValue);
		}

		/// <summary>
		/// Gets the type as a string representation
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>String representation of the type, or empty string if kv is null</returns>
		internal static delegate*<nint, string> Kv3GetTypeAsString = &___Kv3GetTypeAsString;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __Kv3GetTypeAsString;
		private static string ___Kv3GetTypeAsString(nint kv)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __Kv3GetTypeAsString(kv);
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
		/// Gets the subtype as a string representation
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>String representation of the subtype, or empty string if kv is null</returns>
		internal static delegate*<nint, string> Kv3GetSubTypeAsString = &___Kv3GetSubTypeAsString;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __Kv3GetSubTypeAsString;
		private static string ___Kv3GetSubTypeAsString(nint kv)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __Kv3GetSubTypeAsString(kv);
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
		/// Converts the KeyValues3 object to a string representation
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="flags">Formatting flags for the string conversion</param>
		/// <returns>String representation of the object, or empty string if kv is null</returns>
		internal static delegate*<nint, uint, string> Kv3ToString = &___Kv3ToString;
		internal static delegate* unmanaged[Cdecl]<nint, uint, String192> __Kv3ToString;
		private static string ___Kv3ToString(nint kv, uint flags)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __Kv3ToString(kv, flags);
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
		/// Checks if the KeyValues3 object is null
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if the object is null or the pointer is null, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3IsNull = &___Kv3IsNull;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3IsNull;
		private static Bool8 ___Kv3IsNull(nint kv)
		{
			Bool8 __retVal = __Kv3IsNull(kv);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to null
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		internal static delegate*<nint, void> Kv3SetToNull = &___Kv3SetToNull;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv3SetToNull;
		private static void ___Kv3SetToNull(nint kv)
		{
			__Kv3SetToNull(kv);
		}

		/// <summary>
		/// Checks if the KeyValues3 object is an array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if the object is an array, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3IsArray = &___Kv3IsArray;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3IsArray;
		private static Bool8 ___Kv3IsArray(nint kv)
		{
			Bool8 __retVal = __Kv3IsArray(kv);
			return __retVal;
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a KV3 array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if the object is a KV3 array, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3IsKV3Array = &___Kv3IsKV3Array;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3IsKV3Array;
		private static Bool8 ___Kv3IsKV3Array(nint kv)
		{
			Bool8 __retVal = __Kv3IsKV3Array(kv);
			return __retVal;
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a table
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if the object is a table, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3IsTable = &___Kv3IsTable;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3IsTable;
		private static Bool8 ___Kv3IsTable(nint kv)
		{
			Bool8 __retVal = __Kv3IsTable(kv);
			return __retVal;
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>true if the object is a string, false otherwise</returns>
		internal static delegate*<nint, Bool8> Kv3IsString = &___Kv3IsString;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __Kv3IsString;
		private static Bool8 ___Kv3IsString(nint kv)
		{
			Bool8 __retVal = __Kv3IsString(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets the boolean value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Boolean value or defaultValue</returns>
		internal static delegate*<nint, Bool8, Bool8> Kv3GetBool = &___Kv3GetBool;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, Bool8> __Kv3GetBool;
		private static Bool8 ___Kv3GetBool(nint kv, Bool8 defaultValue)
		{
			Bool8 __retVal = __Kv3GetBool(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the char value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Char value or defaultValue</returns>
		internal static delegate*<nint, Char8, Char8> Kv3GetChar = &___Kv3GetChar;
		internal static delegate* unmanaged[Cdecl]<nint, Char8, Char8> __Kv3GetChar;
		private static Char8 ___Kv3GetChar(nint kv, Char8 defaultValue)
		{
			Char8 __retVal = __Kv3GetChar(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the 32-bit Unicode character value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>32-bit Unicode character value or defaultValue</returns>
		internal static delegate*<nint, uint, uint> Kv3GetUChar32 = &___Kv3GetUChar32;
		internal static delegate* unmanaged[Cdecl]<nint, uint, uint> __Kv3GetUChar32;
		private static uint ___Kv3GetUChar32(nint kv, uint defaultValue)
		{
			uint __retVal = __Kv3GetUChar32(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the signed 8-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int8_t value or defaultValue</returns>
		internal static delegate*<nint, sbyte, sbyte> Kv3GetInt8 = &___Kv3GetInt8;
		internal static delegate* unmanaged[Cdecl]<nint, sbyte, sbyte> __Kv3GetInt8;
		private static sbyte ___Kv3GetInt8(nint kv, sbyte defaultValue)
		{
			sbyte __retVal = __Kv3GetInt8(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the unsigned 8-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint8_t value or defaultValue</returns>
		internal static delegate*<nint, byte, byte> Kv3GetUInt8 = &___Kv3GetUInt8;
		internal static delegate* unmanaged[Cdecl]<nint, byte, byte> __Kv3GetUInt8;
		private static byte ___Kv3GetUInt8(nint kv, byte defaultValue)
		{
			byte __retVal = __Kv3GetUInt8(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the signed 16-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int16_t value or defaultValue</returns>
		internal static delegate*<nint, short, short> Kv3GetShort = &___Kv3GetShort;
		internal static delegate* unmanaged[Cdecl]<nint, short, short> __Kv3GetShort;
		private static short ___Kv3GetShort(nint kv, short defaultValue)
		{
			short __retVal = __Kv3GetShort(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the unsigned 16-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint16_t value or defaultValue</returns>
		internal static delegate*<nint, ushort, ushort> Kv3GetUShort = &___Kv3GetUShort;
		internal static delegate* unmanaged[Cdecl]<nint, ushort, ushort> __Kv3GetUShort;
		private static ushort ___Kv3GetUShort(nint kv, ushort defaultValue)
		{
			ushort __retVal = __Kv3GetUShort(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the signed 32-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int32_t value or defaultValue</returns>
		internal static delegate*<nint, int, int> Kv3GetInt = &___Kv3GetInt;
		internal static delegate* unmanaged[Cdecl]<nint, int, int> __Kv3GetInt;
		private static int ___Kv3GetInt(nint kv, int defaultValue)
		{
			int __retVal = __Kv3GetInt(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the unsigned 32-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint32_t value or defaultValue</returns>
		internal static delegate*<nint, uint, uint> Kv3GetUInt = &___Kv3GetUInt;
		internal static delegate* unmanaged[Cdecl]<nint, uint, uint> __Kv3GetUInt;
		private static uint ___Kv3GetUInt(nint kv, uint defaultValue)
		{
			uint __retVal = __Kv3GetUInt(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the signed 64-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int64_t value or defaultValue</returns>
		internal static delegate*<nint, long, long> Kv3GetInt64 = &___Kv3GetInt64;
		internal static delegate* unmanaged[Cdecl]<nint, long, long> __Kv3GetInt64;
		private static long ___Kv3GetInt64(nint kv, long defaultValue)
		{
			long __retVal = __Kv3GetInt64(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the unsigned 64-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint64_t value or defaultValue</returns>
		internal static delegate*<nint, ulong, ulong> Kv3GetUInt64 = &___Kv3GetUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, ulong, ulong> __Kv3GetUInt64;
		private static ulong ___Kv3GetUInt64(nint kv, ulong defaultValue)
		{
			ulong __retVal = __Kv3GetUInt64(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the float value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Float value or defaultValue</returns>
		internal static delegate*<nint, float, float> Kv3GetFloat = &___Kv3GetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, float, float> __Kv3GetFloat;
		private static float ___Kv3GetFloat(nint kv, float defaultValue)
		{
			float __retVal = __Kv3GetFloat(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the double value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Double value or defaultValue</returns>
		internal static delegate*<nint, double, double> Kv3GetDouble = &___Kv3GetDouble;
		internal static delegate* unmanaged[Cdecl]<nint, double, double> __Kv3GetDouble;
		private static double ___Kv3GetDouble(nint kv, double defaultValue)
		{
			double __retVal = __Kv3GetDouble(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a boolean value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">Boolean value to set</param>
		internal static delegate*<nint, Bool8, void> Kv3SetBool = &___Kv3SetBool;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, void> __Kv3SetBool;
		private static void ___Kv3SetBool(nint kv, Bool8 value)
		{
			__Kv3SetBool(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a char value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">Char value to set</param>
		internal static delegate*<nint, Char8, void> Kv3SetChar = &___Kv3SetChar;
		internal static delegate* unmanaged[Cdecl]<nint, Char8, void> __Kv3SetChar;
		private static void ___Kv3SetChar(nint kv, Char8 value)
		{
			__Kv3SetChar(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 32-bit Unicode character value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">32-bit Unicode character value to set</param>
		internal static delegate*<nint, uint, void> Kv3SetUChar32 = &___Kv3SetUChar32;
		internal static delegate* unmanaged[Cdecl]<nint, uint, void> __Kv3SetUChar32;
		private static void ___Kv3SetUChar32(nint kv, uint value)
		{
			__Kv3SetUChar32(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 8-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">int8_t value to set</param>
		internal static delegate*<nint, sbyte, void> Kv3SetInt8 = &___Kv3SetInt8;
		internal static delegate* unmanaged[Cdecl]<nint, sbyte, void> __Kv3SetInt8;
		private static void ___Kv3SetInt8(nint kv, sbyte value)
		{
			__Kv3SetInt8(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 8-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">uint8_t value to set</param>
		internal static delegate*<nint, byte, void> Kv3SetUInt8 = &___Kv3SetUInt8;
		internal static delegate* unmanaged[Cdecl]<nint, byte, void> __Kv3SetUInt8;
		private static void ___Kv3SetUInt8(nint kv, byte value)
		{
			__Kv3SetUInt8(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 16-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">int16_t value to set</param>
		internal static delegate*<nint, short, void> Kv3SetShort = &___Kv3SetShort;
		internal static delegate* unmanaged[Cdecl]<nint, short, void> __Kv3SetShort;
		private static void ___Kv3SetShort(nint kv, short value)
		{
			__Kv3SetShort(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 16-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">uint16_t value to set</param>
		internal static delegate*<nint, ushort, void> Kv3SetUShort = &___Kv3SetUShort;
		internal static delegate* unmanaged[Cdecl]<nint, ushort, void> __Kv3SetUShort;
		private static void ___Kv3SetUShort(nint kv, ushort value)
		{
			__Kv3SetUShort(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 32-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">int32_t value to set</param>
		internal static delegate*<nint, int, void> Kv3SetInt = &___Kv3SetInt;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __Kv3SetInt;
		private static void ___Kv3SetInt(nint kv, int value)
		{
			__Kv3SetInt(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 32-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">uint32_t value to set</param>
		internal static delegate*<nint, uint, void> Kv3SetUInt = &___Kv3SetUInt;
		internal static delegate* unmanaged[Cdecl]<nint, uint, void> __Kv3SetUInt;
		private static void ___Kv3SetUInt(nint kv, uint value)
		{
			__Kv3SetUInt(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 64-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">int64_t value to set</param>
		internal static delegate*<nint, long, void> Kv3SetInt64 = &___Kv3SetInt64;
		internal static delegate* unmanaged[Cdecl]<nint, long, void> __Kv3SetInt64;
		private static void ___Kv3SetInt64(nint kv, long value)
		{
			__Kv3SetInt64(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 64-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">uint64_t value to set</param>
		internal static delegate*<nint, ulong, void> Kv3SetUInt64 = &___Kv3SetUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, ulong, void> __Kv3SetUInt64;
		private static void ___Kv3SetUInt64(nint kv, ulong value)
		{
			__Kv3SetUInt64(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a float value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">Float value to set</param>
		internal static delegate*<nint, float, void> Kv3SetFloat = &___Kv3SetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, float, void> __Kv3SetFloat;
		private static void ___Kv3SetFloat(nint kv, float value)
		{
			__Kv3SetFloat(kv, value);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a double value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="value">Double value to set</param>
		internal static delegate*<nint, double, void> Kv3SetDouble = &___Kv3SetDouble;
		internal static delegate* unmanaged[Cdecl]<nint, double, void> __Kv3SetDouble;
		private static void ___Kv3SetDouble(nint kv, double value)
		{
			__Kv3SetDouble(kv, value);
		}

		/// <summary>
		/// Gets the pointer value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default value to return if kv is null</param>
		/// <returns>Pointer value as uintptr_t or defaultValue</returns>
		internal static delegate*<nint, nint, nint> Kv3GetPointer = &___Kv3GetPointer;
		internal static delegate* unmanaged[Cdecl]<nint, nint, nint> __Kv3GetPointer;
		private static nint ___Kv3GetPointer(nint kv, nint defaultValue)
		{
			nint __retVal = __Kv3GetPointer(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a pointer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="ptr">Pointer value as uintptr_t to set</param>
		internal static delegate*<nint, nint, void> Kv3SetPointer = &___Kv3SetPointer;
		internal static delegate* unmanaged[Cdecl]<nint, nint, void> __Kv3SetPointer;
		private static void ___Kv3SetPointer(nint kv, nint ptr)
		{
			__Kv3SetPointer(kv, ptr);
		}

		/// <summary>
		/// Gets the string token value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default token value to return if kv is null</param>
		/// <returns>String token hash code or defaultValue</returns>
		internal static delegate*<nint, uint, uint> Kv3GetStringToken = &___Kv3GetStringToken;
		internal static delegate* unmanaged[Cdecl]<nint, uint, uint> __Kv3GetStringToken;
		private static uint ___Kv3GetStringToken(nint kv, uint defaultValue)
		{
			uint __retVal = __Kv3GetStringToken(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a string token value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="token">String token hash code to set</param>
		internal static delegate*<nint, uint, void> Kv3SetStringToken = &___Kv3SetStringToken;
		internal static delegate* unmanaged[Cdecl]<nint, uint, void> __Kv3SetStringToken;
		private static void ___Kv3SetStringToken(nint kv, uint token)
		{
			__Kv3SetStringToken(kv, token);
		}

		/// <summary>
		/// Gets the entity handle value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default entity handle value to return if kv is null</param>
		/// <returns>Entity handle as int32_t or defaultValue</returns>
		internal static delegate*<nint, int, int> Kv3GetEHandle = &___Kv3GetEHandle;
		internal static delegate* unmanaged[Cdecl]<nint, int, int> __Kv3GetEHandle;
		private static int ___Kv3GetEHandle(nint kv, int defaultValue)
		{
			int __retVal = __Kv3GetEHandle(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to an entity handle value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="ehandle">Entity handle value to set</param>
		internal static delegate*<nint, int, void> Kv3SetEHandle = &___Kv3SetEHandle;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __Kv3SetEHandle;
		private static void ___Kv3SetEHandle(nint kv, int ehandle)
		{
			__Kv3SetEHandle(kv, ehandle);
		}

		/// <summary>
		/// Gets the string value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default string to return if kv is null or value is empty</param>
		/// <returns>String value or defaultValue</returns>
		internal static delegate*<nint, string, string> Kv3GetString = &___Kv3GetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192> __Kv3GetString;
		private static string ___Kv3GetString(nint kv, string defaultValue)
		{
			string __retVal;
			String192 __retVal_native;
			var __defaultValue = NativeMethods.ConstructString(defaultValue);
			try {
				__retVal_native = __Kv3GetString(kv, &__defaultValue);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__defaultValue);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a string value (copies the string)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="str">String value to set</param>
		/// <param name="subtype">String subtype enumeration value</param>
		internal static delegate*<nint, string, byte, void> Kv3SetString = &___Kv3SetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, byte, void> __Kv3SetString;
		private static void ___Kv3SetString(nint kv, string str, byte subtype)
		{
			var __str = NativeMethods.ConstructString(str);
			try {
				__Kv3SetString(kv, &__str, subtype);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__str);
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an external string value (does not copy)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="str">External string value to reference</param>
		/// <param name="subtype">String subtype enumeration value</param>
		internal static delegate*<nint, string, byte, void> Kv3SetStringExternal = &___Kv3SetStringExternal;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, byte, void> __Kv3SetStringExternal;
		private static void ___Kv3SetStringExternal(nint kv, string str, byte subtype)
		{
			var __str = NativeMethods.ConstructString(str);
			try {
				__Kv3SetStringExternal(kv, &__str, subtype);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__str);
			}
		}

		/// <summary>
		/// Gets the binary blob from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Vector containing the binary blob data, or empty vector if kv is null</returns>
		internal static delegate*<nint, byte[]> Kv3GetBinaryBlob = &___Kv3GetBinaryBlob;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192> __Kv3GetBinaryBlob;
		private static byte[] ___Kv3GetBinaryBlob(nint kv)
		{
			byte[] __retVal;
			Vector192 __retVal_native;
			try {
				__retVal_native = __Kv3GetBinaryBlob(kv);
				// Unmarshal - Convert native data to managed data.
				__retVal = new byte[NativeMethods.GetVectorSizeUInt8(&__retVal_native)];
				NativeMethods.GetVectorDataUInt8(&__retVal_native, __retVal);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorUInt8(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the size of the binary blob in the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Size of the binary blob in bytes, or 0 if kv is null</returns>
		internal static delegate*<nint, int> Kv3GetBinaryBlobSize = &___Kv3GetBinaryBlobSize;
		internal static delegate* unmanaged[Cdecl]<nint, int> __Kv3GetBinaryBlobSize;
		private static int ___Kv3GetBinaryBlobSize(nint kv)
		{
			int __retVal = __Kv3GetBinaryBlobSize(kv);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a binary blob (copies the data)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="blob">Vector containing the binary blob data</param>
		internal static delegate*<nint, byte[], void> Kv3SetToBinaryBlob = &___Kv3SetToBinaryBlob;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192*, void> __Kv3SetToBinaryBlob;
		private static void ___Kv3SetToBinaryBlob(nint kv, byte[] blob)
		{
			var __blob = NativeMethods.ConstructVectorUInt8(blob, blob.Length);
			try {
				__Kv3SetToBinaryBlob(kv, &__blob);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorUInt8(&__blob);
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an external binary blob (does not copy)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="blob">Vector containing the external binary blob data</param>
		/// <param name="free_mem">Whether to free the memory when the object is destroyed</param>
		internal static delegate*<nint, byte[], Bool8, void> Kv3SetToBinaryBlobExternal = &___Kv3SetToBinaryBlobExternal;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192*, Bool8, void> __Kv3SetToBinaryBlobExternal;
		private static void ___Kv3SetToBinaryBlobExternal(nint kv, byte[] blob, Bool8 free_mem)
		{
			var __blob = NativeMethods.ConstructVectorUInt8(blob, blob.Length);
			try {
				__Kv3SetToBinaryBlobExternal(kv, &__blob, free_mem);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorUInt8(&__blob);
			}
		}

		/// <summary>
		/// Gets the color value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default color value to return if kv is null</param>
		/// <returns>Color value as int32_t or defaultValue</returns>
		internal static delegate*<nint, int, int> Kv3GetColor = &___Kv3GetColor;
		internal static delegate* unmanaged[Cdecl]<nint, int, int> __Kv3GetColor;
		private static int ___Kv3GetColor(nint kv, int defaultValue)
		{
			int __retVal = __Kv3GetColor(kv, defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a color value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="color">Color value as int32_t to set</param>
		internal static delegate*<nint, int, void> Kv3SetColor = &___Kv3SetColor;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __Kv3SetColor;
		private static void ___Kv3SetColor(nint kv, int color)
		{
			__Kv3SetColor(kv, color);
		}

		/// <summary>
		/// Gets the 3D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default vector to return if kv is null</param>
		/// <returns>3D vector or defaultValue</returns>
		internal static delegate*<nint, Vector3, Vector3> Kv3GetVector = &___Kv3GetVector;
		internal static delegate* unmanaged[Cdecl]<nint, Vector3*, Vector3> __Kv3GetVector;
		private static Vector3 ___Kv3GetVector(nint kv, Vector3 defaultValue)
		{
			Vector3 __retVal = __Kv3GetVector(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the 2D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default 2D vector to return if kv is null</param>
		/// <returns>2D vector or defaultValue</returns>
		internal static delegate*<nint, Vector2, Vector2> Kv3GetVector2D = &___Kv3GetVector2D;
		internal static delegate* unmanaged[Cdecl]<nint, Vector2*, Vector2> __Kv3GetVector2D;
		private static Vector2 ___Kv3GetVector2D(nint kv, Vector2 defaultValue)
		{
			Vector2 __retVal = __Kv3GetVector2D(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the 4D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default 4D vector to return if kv is null</param>
		/// <returns>4D vector or defaultValue</returns>
		internal static delegate*<nint, Vector4, Vector4> Kv3GetVector4D = &___Kv3GetVector4D;
		internal static delegate* unmanaged[Cdecl]<nint, Vector4*, Vector4> __Kv3GetVector4D;
		private static Vector4 ___Kv3GetVector4D(nint kv, Vector4 defaultValue)
		{
			Vector4 __retVal = __Kv3GetVector4D(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the quaternion value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default quaternion to return if kv is null</param>
		/// <returns>Quaternion as vec4 or defaultValue</returns>
		internal static delegate*<nint, Vector4, Vector4> Kv3GetQuaternion = &___Kv3GetQuaternion;
		internal static delegate* unmanaged[Cdecl]<nint, Vector4*, Vector4> __Kv3GetQuaternion;
		private static Vector4 ___Kv3GetQuaternion(nint kv, Vector4 defaultValue)
		{
			Vector4 __retVal = __Kv3GetQuaternion(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the angle (QAngle) value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default angle to return if kv is null</param>
		/// <returns>QAngle as vec3 or defaultValue</returns>
		internal static delegate*<nint, Vector3, Vector3> Kv3GetQAngle = &___Kv3GetQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, Vector3*, Vector3> __Kv3GetQAngle;
		private static Vector3 ___Kv3GetQAngle(nint kv, Vector3 defaultValue)
		{
			Vector3 __retVal = __Kv3GetQAngle(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Gets the 3x4 matrix value from the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="defaultValue">Default matrix to return if kv is null</param>
		/// <returns>3x4 matrix as mat4x4 or defaultValue</returns>
		internal static delegate*<nint, Matrix4x4, Matrix4x4> Kv3GetMatrix3x4 = &___Kv3GetMatrix3x4;
		internal static delegate* unmanaged[Cdecl]<nint, Matrix4x4*, Matrix4x4> __Kv3GetMatrix3x4;
		private static Matrix4x4 ___Kv3GetMatrix3x4(nint kv, Matrix4x4 defaultValue)
		{
			Matrix4x4 __retVal = __Kv3GetMatrix3x4(kv, &defaultValue);
			return __retVal;
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 3D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="vec">3D vector to set</param>
		internal static delegate*<nint, Vector3, void> Kv3SetVector = &___Kv3SetVector;
		internal static delegate* unmanaged[Cdecl]<nint, Vector3*, void> __Kv3SetVector;
		private static void ___Kv3SetVector(nint kv, Vector3 vec)
		{
			__Kv3SetVector(kv, &vec);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 2D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="vec2d">2D vector to set</param>
		internal static delegate*<nint, Vector2, void> Kv3SetVector2D = &___Kv3SetVector2D;
		internal static delegate* unmanaged[Cdecl]<nint, Vector2*, void> __Kv3SetVector2D;
		private static void ___Kv3SetVector2D(nint kv, Vector2 vec2d)
		{
			__Kv3SetVector2D(kv, &vec2d);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 4D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="vec4d">4D vector to set</param>
		internal static delegate*<nint, Vector4, void> Kv3SetVector4D = &___Kv3SetVector4D;
		internal static delegate* unmanaged[Cdecl]<nint, Vector4*, void> __Kv3SetVector4D;
		private static void ___Kv3SetVector4D(nint kv, Vector4 vec4d)
		{
			__Kv3SetVector4D(kv, &vec4d);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a quaternion value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="quat">Quaternion to set (as vec4)</param>
		internal static delegate*<nint, Vector4, void> Kv3SetQuaternion = &___Kv3SetQuaternion;
		internal static delegate* unmanaged[Cdecl]<nint, Vector4*, void> __Kv3SetQuaternion;
		private static void ___Kv3SetQuaternion(nint kv, Vector4 quat)
		{
			__Kv3SetQuaternion(kv, &quat);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an angle (QAngle) value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="ang">QAngle to set (as vec3)</param>
		internal static delegate*<nint, Vector3, void> Kv3SetQAngle = &___Kv3SetQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, Vector3*, void> __Kv3SetQAngle;
		private static void ___Kv3SetQAngle(nint kv, Vector3 ang)
		{
			__Kv3SetQAngle(kv, &ang);
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 3x4 matrix value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="matrix">3x4 matrix to set (as mat4x4)</param>
		internal static delegate*<nint, Matrix4x4, void> Kv3SetMatrix3x4 = &___Kv3SetMatrix3x4;
		internal static delegate* unmanaged[Cdecl]<nint, Matrix4x4*, void> __Kv3SetMatrix3x4;
		private static void ___Kv3SetMatrix3x4(nint kv, Matrix4x4 matrix)
		{
			__Kv3SetMatrix3x4(kv, &matrix);
		}

		/// <summary>
		/// Gets the number of elements in the array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Number of array elements, or 0 if kv is null or not an array</returns>
		internal static delegate*<nint, int> Kv3GetArrayElementCount = &___Kv3GetArrayElementCount;
		internal static delegate* unmanaged[Cdecl]<nint, int> __Kv3GetArrayElementCount;
		private static int ___Kv3GetArrayElementCount(nint kv)
		{
			int __retVal = __Kv3GetArrayElementCount(kv);
			return __retVal;
		}

		/// <summary>
		/// Sets the number of elements in the array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="count">Number of elements to set</param>
		/// <param name="type">Type of array elements</param>
		/// <param name="subtype">Subtype of array elements</param>
		internal static delegate*<nint, int, byte, byte, void> Kv3SetArrayElementCount = &___Kv3SetArrayElementCount;
		internal static delegate* unmanaged[Cdecl]<nint, int, byte, byte, void> __Kv3SetArrayElementCount;
		private static void ___Kv3SetArrayElementCount(nint kv, int count, byte type, byte subtype)
		{
			__Kv3SetArrayElementCount(kv, count, type, subtype);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an empty KV3 array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		internal static delegate*<nint, void> Kv3SetToEmptyKV3Array = &___Kv3SetToEmptyKV3Array;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv3SetToEmptyKV3Array;
		private static void ___Kv3SetToEmptyKV3Array(nint kv)
		{
			__Kv3SetToEmptyKV3Array(kv);
		}

		/// <summary>
		/// Gets an array element at the specified index
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="elem">Index of the element to get</param>
		/// <returns>Pointer to the element KeyValues3 object, or nullptr if invalid</returns>
		internal static delegate*<nint, int, nint> Kv3GetArrayElement = &___Kv3GetArrayElement;
		internal static delegate* unmanaged[Cdecl]<nint, int, nint> __Kv3GetArrayElement;
		private static nint ___Kv3GetArrayElement(nint kv, int elem)
		{
			nint __retVal = __Kv3GetArrayElement(kv, elem);
			return __retVal;
		}

		/// <summary>
		/// Inserts a new element before the specified index
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="elem">Index before which to insert</param>
		/// <returns>Pointer to the newly inserted element, or nullptr if invalid</returns>
		internal static delegate*<nint, int, nint> Kv3ArrayInsertElementBefore = &___Kv3ArrayInsertElementBefore;
		internal static delegate* unmanaged[Cdecl]<nint, int, nint> __Kv3ArrayInsertElementBefore;
		private static nint ___Kv3ArrayInsertElementBefore(nint kv, int elem)
		{
			nint __retVal = __Kv3ArrayInsertElementBefore(kv, elem);
			return __retVal;
		}

		/// <summary>
		/// Inserts a new element after the specified index
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="elem">Index after which to insert</param>
		/// <returns>Pointer to the newly inserted element, or nullptr if invalid</returns>
		internal static delegate*<nint, int, nint> Kv3ArrayInsertElementAfter = &___Kv3ArrayInsertElementAfter;
		internal static delegate* unmanaged[Cdecl]<nint, int, nint> __Kv3ArrayInsertElementAfter;
		private static nint ___Kv3ArrayInsertElementAfter(nint kv, int elem)
		{
			nint __retVal = __Kv3ArrayInsertElementAfter(kv, elem);
			return __retVal;
		}

		/// <summary>
		/// Adds a new element to the end of the array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Pointer to the newly added element, or nullptr if invalid</returns>
		internal static delegate*<nint, nint> Kv3ArrayAddElementToTail = &___Kv3ArrayAddElementToTail;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv3ArrayAddElementToTail;
		private static nint ___Kv3ArrayAddElementToTail(nint kv)
		{
			nint __retVal = __Kv3ArrayAddElementToTail(kv);
			return __retVal;
		}

		/// <summary>
		/// Swaps two array elements
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="idx1">Index of the first element</param>
		/// <param name="idx2">Index of the second element</param>
		internal static delegate*<nint, int, int, void> Kv3ArraySwapItems = &___Kv3ArraySwapItems;
		internal static delegate* unmanaged[Cdecl]<nint, int, int, void> __Kv3ArraySwapItems;
		private static void ___Kv3ArraySwapItems(nint kv, int idx1, int idx2)
		{
			__Kv3ArraySwapItems(kv, idx1, idx2);
		}

		/// <summary>
		/// Removes an element from the array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="elem">Index of the element to remove</param>
		internal static delegate*<nint, int, void> Kv3ArrayRemoveElement = &___Kv3ArrayRemoveElement;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __Kv3ArrayRemoveElement;
		private static void ___Kv3ArrayRemoveElement(nint kv, int elem)
		{
			__Kv3ArrayRemoveElement(kv, elem);
		}

		/// <summary>
		/// Sets the KeyValues3 object to an empty table
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		internal static delegate*<nint, void> Kv3SetToEmptyTable = &___Kv3SetToEmptyTable;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv3SetToEmptyTable;
		private static void ___Kv3SetToEmptyTable(nint kv)
		{
			__Kv3SetToEmptyTable(kv);
		}

		/// <summary>
		/// Gets the number of members in the table
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <returns>Number of table members, or 0 if kv is null or not a table</returns>
		internal static delegate*<nint, int> Kv3GetMemberCount = &___Kv3GetMemberCount;
		internal static delegate* unmanaged[Cdecl]<nint, int> __Kv3GetMemberCount;
		private static int ___Kv3GetMemberCount(nint kv)
		{
			int __retVal = __Kv3GetMemberCount(kv);
			return __retVal;
		}

		/// <summary>
		/// Checks if a member with the specified name exists
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member to check</param>
		/// <returns>true if the member exists, false otherwise</returns>
		internal static delegate*<nint, string, Bool8> Kv3HasMember = &___Kv3HasMember;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8> __Kv3HasMember;
		private static Bool8 ___Kv3HasMember(nint kv, string name)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3HasMember(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds a member by name
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member to find</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if not found</returns>
		internal static delegate*<nint, string, nint> Kv3FindMember = &___Kv3FindMember;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __Kv3FindMember;
		private static nint ___Kv3FindMember(nint kv, string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3FindMember(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds a member by name, or creates it if it doesn't exist
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member to find or create</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if kv is null</returns>
		internal static delegate*<nint, string, nint> Kv3FindOrCreateMember = &___Kv3FindOrCreateMember;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __Kv3FindOrCreateMember;
		private static nint ___Kv3FindOrCreateMember(nint kv, string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3FindOrCreateMember(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a member from the table
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member to remove</param>
		/// <returns>true if the member was removed, false otherwise</returns>
		internal static delegate*<nint, string, Bool8> Kv3RemoveMember = &___Kv3RemoveMember;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8> __Kv3RemoveMember;
		private static Bool8 ___Kv3RemoveMember(nint kv, string name)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3RemoveMember(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the name of a member at the specified index
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="index">Index of the member</param>
		/// <returns>Name of the member, or empty string if invalid</returns>
		internal static delegate*<nint, int, string> Kv3GetMemberName = &___Kv3GetMemberName;
		internal static delegate* unmanaged[Cdecl]<nint, int, String192> __Kv3GetMemberName;
		private static string ___Kv3GetMemberName(nint kv, int index)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __Kv3GetMemberName(kv, index);
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
		/// Gets a member by index
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="index">Index of the member to get</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if invalid</returns>
		internal static delegate*<nint, int, nint> Kv3GetMemberByIndex = &___Kv3GetMemberByIndex;
		internal static delegate* unmanaged[Cdecl]<nint, int, nint> __Kv3GetMemberByIndex;
		private static nint ___Kv3GetMemberByIndex(nint kv, int index)
		{
			nint __retVal = __Kv3GetMemberByIndex(kv, index);
			return __retVal;
		}

		/// <summary>
		/// Gets a boolean value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Boolean value or defaultValue</returns>
		internal static delegate*<nint, string, Bool8, Bool8> Kv3GetMemberBool = &___Kv3GetMemberBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, Bool8> __Kv3GetMemberBool;
		private static Bool8 ___Kv3GetMemberBool(nint kv, string name, Bool8 defaultValue)
		{
			Bool8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberBool(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a char value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Char value or defaultValue</returns>
		internal static delegate*<nint, string, Char8, Char8> Kv3GetMemberChar = &___Kv3GetMemberChar;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Char8, Char8> __Kv3GetMemberChar;
		private static Char8 ___Kv3GetMemberChar(nint kv, string name, Char8 defaultValue)
		{
			Char8 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberChar(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 32-bit Unicode character value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>32-bit Unicode character value or defaultValue</returns>
		internal static delegate*<nint, string, uint, uint> Kv3GetMemberUChar32 = &___Kv3GetMemberUChar32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, uint> __Kv3GetMemberUChar32;
		private static uint ___Kv3GetMemberUChar32(nint kv, string name, uint defaultValue)
		{
			uint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberUChar32(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a signed 8-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int8_t value or defaultValue</returns>
		internal static delegate*<nint, string, sbyte, sbyte> Kv3GetMemberInt8 = &___Kv3GetMemberInt8;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, sbyte, sbyte> __Kv3GetMemberInt8;
		private static sbyte ___Kv3GetMemberInt8(nint kv, string name, sbyte defaultValue)
		{
			sbyte __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberInt8(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 8-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint8_t value or defaultValue</returns>
		internal static delegate*<nint, string, byte, byte> Kv3GetMemberUInt8 = &___Kv3GetMemberUInt8;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, byte, byte> __Kv3GetMemberUInt8;
		private static byte ___Kv3GetMemberUInt8(nint kv, string name, byte defaultValue)
		{
			byte __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberUInt8(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a signed 16-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int16_t value or defaultValue</returns>
		internal static delegate*<nint, string, short, short> Kv3GetMemberShort = &___Kv3GetMemberShort;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, short, short> __Kv3GetMemberShort;
		private static short ___Kv3GetMemberShort(nint kv, string name, short defaultValue)
		{
			short __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberShort(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 16-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint16_t value or defaultValue</returns>
		internal static delegate*<nint, string, ushort, ushort> Kv3GetMemberUShort = &___Kv3GetMemberUShort;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ushort, ushort> __Kv3GetMemberUShort;
		private static ushort ___Kv3GetMemberUShort(nint kv, string name, ushort defaultValue)
		{
			ushort __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberUShort(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a signed 32-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int32_t value or defaultValue</returns>
		internal static delegate*<nint, string, int, int> Kv3GetMemberInt = &___Kv3GetMemberInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __Kv3GetMemberInt;
		private static int ___Kv3GetMemberInt(nint kv, string name, int defaultValue)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberInt(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 32-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint32_t value or defaultValue</returns>
		internal static delegate*<nint, string, uint, uint> Kv3GetMemberUInt = &___Kv3GetMemberUInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, uint> __Kv3GetMemberUInt;
		private static uint ___Kv3GetMemberUInt(nint kv, string name, uint defaultValue)
		{
			uint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberUInt(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a signed 64-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int64_t value or defaultValue</returns>
		internal static delegate*<nint, string, long, long> Kv3GetMemberInt64 = &___Kv3GetMemberInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, long, long> __Kv3GetMemberInt64;
		private static long ___Kv3GetMemberInt64(nint kv, string name, long defaultValue)
		{
			long __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberInt64(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 64-bit integer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint64_t value or defaultValue</returns>
		internal static delegate*<nint, string, ulong, ulong> Kv3GetMemberUInt64 = &___Kv3GetMemberUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong, ulong> __Kv3GetMemberUInt64;
		private static ulong ___Kv3GetMemberUInt64(nint kv, string name, ulong defaultValue)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberUInt64(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a float value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Float value or defaultValue</returns>
		internal static delegate*<nint, string, float, float> Kv3GetMemberFloat = &___Kv3GetMemberFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, float> __Kv3GetMemberFloat;
		private static float ___Kv3GetMemberFloat(nint kv, string name, float defaultValue)
		{
			float __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberFloat(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a double value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Double value or defaultValue</returns>
		internal static delegate*<nint, string, double, double> Kv3GetMemberDouble = &___Kv3GetMemberDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, double, double> __Kv3GetMemberDouble;
		private static double ___Kv3GetMemberDouble(nint kv, string name, double defaultValue)
		{
			double __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberDouble(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a pointer value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Pointer value as uintptr_t or defaultValue</returns>
		internal static delegate*<nint, string, nint, nint> Kv3GetMemberPointer = &___Kv3GetMemberPointer;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, nint> __Kv3GetMemberPointer;
		private static nint ___Kv3GetMemberPointer(nint kv, string name, nint defaultValue)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberPointer(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a string token value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default token value to return if member not found</param>
		/// <returns>String token hash code or defaultValue</returns>
		internal static delegate*<nint, string, uint, uint> Kv3GetMemberStringToken = &___Kv3GetMemberStringToken;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, uint> __Kv3GetMemberStringToken;
		private static uint ___Kv3GetMemberStringToken(nint kv, string name, uint defaultValue)
		{
			uint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberStringToken(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an entity handle value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default entity handle value to return if member not found</param>
		/// <returns>Entity handle as int32_t or defaultValue</returns>
		internal static delegate*<nint, string, int, int> Kv3GetMemberEHandle = &___Kv3GetMemberEHandle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __Kv3GetMemberEHandle;
		private static int ___Kv3GetMemberEHandle(nint kv, string name, int defaultValue)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberEHandle(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a string value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default string to return if member not found</param>
		/// <returns>String value or defaultValue</returns>
		internal static delegate*<nint, string, string, string> Kv3GetMemberString = &___Kv3GetMemberString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192> __Kv3GetMemberString;
		private static string ___Kv3GetMemberString(nint kv, string name, string defaultValue)
		{
			string __retVal;
			String192 __retVal_native;
			var __name = NativeMethods.ConstructString(name);
			var __defaultValue = NativeMethods.ConstructString(defaultValue);
			try {
				__retVal_native = __Kv3GetMemberString(kv, &__name, &__defaultValue);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__defaultValue);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a color value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default color value to return if member not found</param>
		/// <returns>Color value as int32_t or defaultValue</returns>
		internal static delegate*<nint, string, int, int> Kv3GetMemberColor = &___Kv3GetMemberColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __Kv3GetMemberColor;
		private static int ___Kv3GetMemberColor(nint kv, string name, int defaultValue)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberColor(kv, &__name, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 3D vector value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default vector to return if member not found</param>
		/// <returns>3D vector or defaultValue</returns>
		internal static delegate*<nint, string, Vector3, Vector3> Kv3GetMemberVector = &___Kv3GetMemberVector;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Vector3> __Kv3GetMemberVector;
		private static Vector3 ___Kv3GetMemberVector(nint kv, string name, Vector3 defaultValue)
		{
			Vector3 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberVector(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 2D vector value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default 2D vector to return if member not found</param>
		/// <returns>2D vector or defaultValue</returns>
		internal static delegate*<nint, string, Vector2, Vector2> Kv3GetMemberVector2D = &___Kv3GetMemberVector2D;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector2*, Vector2> __Kv3GetMemberVector2D;
		private static Vector2 ___Kv3GetMemberVector2D(nint kv, string name, Vector2 defaultValue)
		{
			Vector2 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberVector2D(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 4D vector value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default 4D vector to return if member not found</param>
		/// <returns>4D vector or defaultValue</returns>
		internal static delegate*<nint, string, Vector4, Vector4> Kv3GetMemberVector4D = &___Kv3GetMemberVector4D;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector4*, Vector4> __Kv3GetMemberVector4D;
		private static Vector4 ___Kv3GetMemberVector4D(nint kv, string name, Vector4 defaultValue)
		{
			Vector4 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberVector4D(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a quaternion value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default quaternion to return if member not found</param>
		/// <returns>Quaternion as vec4 or defaultValue</returns>
		internal static delegate*<nint, string, Vector4, Vector4> Kv3GetMemberQuaternion = &___Kv3GetMemberQuaternion;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector4*, Vector4> __Kv3GetMemberQuaternion;
		private static Vector4 ___Kv3GetMemberQuaternion(nint kv, string name, Vector4 defaultValue)
		{
			Vector4 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberQuaternion(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an angle (QAngle) value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default angle to return if member not found</param>
		/// <returns>QAngle as vec3 or defaultValue</returns>
		internal static delegate*<nint, string, Vector3, Vector3> Kv3GetMemberQAngle = &___Kv3GetMemberQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Vector3> __Kv3GetMemberQAngle;
		private static Vector3 ___Kv3GetMemberQAngle(nint kv, string name, Vector3 defaultValue)
		{
			Vector3 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberQAngle(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 3x4 matrix value from a table member
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default matrix to return if member not found</param>
		/// <returns>3x4 matrix as mat4x4 or defaultValue</returns>
		internal static delegate*<nint, string, Matrix4x4, Matrix4x4> Kv3GetMemberMatrix3x4 = &___Kv3GetMemberMatrix3x4;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Matrix4x4*, Matrix4x4> __Kv3GetMemberMatrix3x4;
		private static Matrix4x4 ___Kv3GetMemberMatrix3x4(nint kv, string name, Matrix4x4 defaultValue)
		{
			Matrix4x4 __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __Kv3GetMemberMatrix3x4(kv, &__name, &defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a table member to null
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		internal static delegate*<nint, string, void> Kv3SetMemberToNull = &___Kv3SetMemberToNull;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, void> __Kv3SetMemberToNull;
		private static void ___Kv3SetMemberToNull(nint kv, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberToNull(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an empty array
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		internal static delegate*<nint, string, void> Kv3SetMemberToEmptyArray = &___Kv3SetMemberToEmptyArray;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, void> __Kv3SetMemberToEmptyArray;
		private static void ___Kv3SetMemberToEmptyArray(nint kv, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberToEmptyArray(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an empty table
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		internal static delegate*<nint, string, void> Kv3SetMemberToEmptyTable = &___Kv3SetMemberToEmptyTable;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, void> __Kv3SetMemberToEmptyTable;
		private static void ___Kv3SetMemberToEmptyTable(nint kv, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberToEmptyTable(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a binary blob (copies the data)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="blob">Vector containing the binary blob data</param>
		internal static delegate*<nint, string, byte[], void> Kv3SetMemberToBinaryBlob = &___Kv3SetMemberToBinaryBlob;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, void> __Kv3SetMemberToBinaryBlob;
		private static void ___Kv3SetMemberToBinaryBlob(nint kv, string name, byte[] blob)
		{
			var __name = NativeMethods.ConstructString(name);
			var __blob = NativeMethods.ConstructVectorUInt8(blob, blob.Length);
			try {
				__Kv3SetMemberToBinaryBlob(kv, &__name, &__blob);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyVectorUInt8(&__blob);
			}
		}

		/// <summary>
		/// Sets a table member to an external binary blob (does not copy)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="blob">Vector containing the external binary blob data</param>
		/// <param name="free_mem">Whether to free the memory when the object is destroyed</param>
		internal static delegate*<nint, string, byte[], Bool8, void> Kv3SetMemberToBinaryBlobExternal = &___Kv3SetMemberToBinaryBlobExternal;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, Bool8, void> __Kv3SetMemberToBinaryBlobExternal;
		private static void ___Kv3SetMemberToBinaryBlobExternal(nint kv, string name, byte[] blob, Bool8 free_mem)
		{
			var __name = NativeMethods.ConstructString(name);
			var __blob = NativeMethods.ConstructVectorUInt8(blob, blob.Length);
			try {
				__Kv3SetMemberToBinaryBlobExternal(kv, &__name, &__blob, free_mem);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyVectorUInt8(&__blob);
			}
		}

		/// <summary>
		/// Sets a table member to a copy of another KeyValues3 value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="other">Pointer to the KeyValues3 object to copy</param>
		internal static delegate*<nint, string, nint, void> Kv3SetMemberToCopyOfValue = &___Kv3SetMemberToCopyOfValue;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __Kv3SetMemberToCopyOfValue;
		private static void ___Kv3SetMemberToCopyOfValue(nint kv, string name, nint other)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberToCopyOfValue(kv, &__name, other);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a boolean value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Boolean value to set</param>
		internal static delegate*<nint, string, Bool8, void> Kv3SetMemberBool = &___Kv3SetMemberBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, void> __Kv3SetMemberBool;
		private static void ___Kv3SetMemberBool(nint kv, string name, Bool8 value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberBool(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a char value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Char value to set</param>
		internal static delegate*<nint, string, Char8, void> Kv3SetMemberChar = &___Kv3SetMemberChar;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Char8, void> __Kv3SetMemberChar;
		private static void ___Kv3SetMemberChar(nint kv, string name, Char8 value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberChar(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a 32-bit Unicode character value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">32-bit Unicode character value to set</param>
		internal static delegate*<nint, string, uint, void> Kv3SetMemberUChar32 = &___Kv3SetMemberUChar32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, void> __Kv3SetMemberUChar32;
		private static void ___Kv3SetMemberUChar32(nint kv, string name, uint value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberUChar32(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a signed 8-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int8_t value to set</param>
		internal static delegate*<nint, string, sbyte, void> Kv3SetMemberInt8 = &___Kv3SetMemberInt8;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, sbyte, void> __Kv3SetMemberInt8;
		private static void ___Kv3SetMemberInt8(nint kv, string name, sbyte value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberInt8(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 8-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint8_t value to set</param>
		internal static delegate*<nint, string, byte, void> Kv3SetMemberUInt8 = &___Kv3SetMemberUInt8;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, byte, void> __Kv3SetMemberUInt8;
		private static void ___Kv3SetMemberUInt8(nint kv, string name, byte value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberUInt8(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a signed 16-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int16_t value to set</param>
		internal static delegate*<nint, string, short, void> Kv3SetMemberShort = &___Kv3SetMemberShort;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, short, void> __Kv3SetMemberShort;
		private static void ___Kv3SetMemberShort(nint kv, string name, short value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberShort(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 16-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint16_t value to set</param>
		internal static delegate*<nint, string, ushort, void> Kv3SetMemberUShort = &___Kv3SetMemberUShort;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ushort, void> __Kv3SetMemberUShort;
		private static void ___Kv3SetMemberUShort(nint kv, string name, ushort value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberUShort(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a signed 32-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int32_t value to set</param>
		internal static delegate*<nint, string, int, void> Kv3SetMemberInt = &___Kv3SetMemberInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __Kv3SetMemberInt;
		private static void ___Kv3SetMemberInt(nint kv, string name, int value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberInt(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 32-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint32_t value to set</param>
		internal static delegate*<nint, string, uint, void> Kv3SetMemberUInt = &___Kv3SetMemberUInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, void> __Kv3SetMemberUInt;
		private static void ___Kv3SetMemberUInt(nint kv, string name, uint value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberUInt(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a signed 64-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int64_t value to set</param>
		internal static delegate*<nint, string, long, void> Kv3SetMemberInt64 = &___Kv3SetMemberInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, long, void> __Kv3SetMemberInt64;
		private static void ___Kv3SetMemberInt64(nint kv, string name, long value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberInt64(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 64-bit integer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint64_t value to set</param>
		internal static delegate*<nint, string, ulong, void> Kv3SetMemberUInt64 = &___Kv3SetMemberUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong, void> __Kv3SetMemberUInt64;
		private static void ___Kv3SetMemberUInt64(nint kv, string name, ulong value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberUInt64(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a float value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Float value to set</param>
		internal static delegate*<nint, string, float, void> Kv3SetMemberFloat = &___Kv3SetMemberFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, void> __Kv3SetMemberFloat;
		private static void ___Kv3SetMemberFloat(nint kv, string name, float value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberFloat(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a double value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Double value to set</param>
		internal static delegate*<nint, string, double, void> Kv3SetMemberDouble = &___Kv3SetMemberDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, double, void> __Kv3SetMemberDouble;
		private static void ___Kv3SetMemberDouble(nint kv, string name, double value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberDouble(kv, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a pointer value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="ptr">Pointer value as uintptr_t to set</param>
		internal static delegate*<nint, string, nint, void> Kv3SetMemberPointer = &___Kv3SetMemberPointer;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __Kv3SetMemberPointer;
		private static void ___Kv3SetMemberPointer(nint kv, string name, nint ptr)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberPointer(kv, &__name, ptr);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a string token value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="token">String token hash code to set</param>
		internal static delegate*<nint, string, uint, void> Kv3SetMemberStringToken = &___Kv3SetMemberStringToken;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, void> __Kv3SetMemberStringToken;
		private static void ___Kv3SetMemberStringToken(nint kv, string name, uint token)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberStringToken(kv, &__name, token);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an entity handle value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="ehandle">Entity handle value to set</param>
		internal static delegate*<nint, string, int, void> Kv3SetMemberEHandle = &___Kv3SetMemberEHandle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __Kv3SetMemberEHandle;
		private static void ___Kv3SetMemberEHandle(nint kv, string name, int ehandle)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberEHandle(kv, &__name, ehandle);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a string value (copies the string)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="str">String value to set</param>
		/// <param name="subtype">String subtype enumeration value</param>
		internal static delegate*<nint, string, string, byte, void> Kv3SetMemberString = &___Kv3SetMemberString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, byte, void> __Kv3SetMemberString;
		private static void ___Kv3SetMemberString(nint kv, string name, string str, byte subtype)
		{
			var __name = NativeMethods.ConstructString(name);
			var __str = NativeMethods.ConstructString(str);
			try {
				__Kv3SetMemberString(kv, &__name, &__str, subtype);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__str);
			}
		}

		/// <summary>
		/// Sets a table member to an external string value (does not copy)
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="str">External string value to reference</param>
		/// <param name="subtype">String subtype enumeration value</param>
		internal static delegate*<nint, string, string, byte, void> Kv3SetMemberStringExternal = &___Kv3SetMemberStringExternal;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, byte, void> __Kv3SetMemberStringExternal;
		private static void ___Kv3SetMemberStringExternal(nint kv, string name, string str, byte subtype)
		{
			var __name = NativeMethods.ConstructString(name);
			var __str = NativeMethods.ConstructString(str);
			try {
				__Kv3SetMemberStringExternal(kv, &__name, &__str, subtype);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__str);
			}
		}

		/// <summary>
		/// Sets a table member to a color value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="color">Color value as int32_t to set</param>
		internal static delegate*<nint, string, int, void> Kv3SetMemberColor = &___Kv3SetMemberColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __Kv3SetMemberColor;
		private static void ___Kv3SetMemberColor(nint kv, string name, int color)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberColor(kv, &__name, color);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a 3D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="vec">3D vector to set</param>
		internal static delegate*<nint, string, Vector3, void> Kv3SetMemberVector = &___Kv3SetMemberVector;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, void> __Kv3SetMemberVector;
		private static void ___Kv3SetMemberVector(nint kv, string name, Vector3 vec)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberVector(kv, &__name, &vec);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a 2D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="vec2d">2D vector to set</param>
		internal static delegate*<nint, string, Vector2, void> Kv3SetMemberVector2D = &___Kv3SetMemberVector2D;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector2*, void> __Kv3SetMemberVector2D;
		private static void ___Kv3SetMemberVector2D(nint kv, string name, Vector2 vec2d)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberVector2D(kv, &__name, &vec2d);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a 4D vector value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="vec4d">4D vector to set</param>
		internal static delegate*<nint, string, Vector4, void> Kv3SetMemberVector4D = &___Kv3SetMemberVector4D;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector4*, void> __Kv3SetMemberVector4D;
		private static void ___Kv3SetMemberVector4D(nint kv, string name, Vector4 vec4d)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberVector4D(kv, &__name, &vec4d);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a quaternion value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="quat">Quaternion to set (as vec4)</param>
		internal static delegate*<nint, string, Vector4, void> Kv3SetMemberQuaternion = &___Kv3SetMemberQuaternion;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector4*, void> __Kv3SetMemberQuaternion;
		private static void ___Kv3SetMemberQuaternion(nint kv, string name, Vector4 quat)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberQuaternion(kv, &__name, &quat);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to an angle (QAngle) value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="ang">QAngle to set (as vec3)</param>
		internal static delegate*<nint, string, Vector3, void> Kv3SetMemberQAngle = &___Kv3SetMemberQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, void> __Kv3SetMemberQAngle;
		private static void ___Kv3SetMemberQAngle(nint kv, string name, Vector3 ang)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberQAngle(kv, &__name, &ang);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets a table member to a 3x4 matrix value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="name">Name of the member</param>
		/// <param name="matrix">3x4 matrix to set (as mat4x4)</param>
		internal static delegate*<nint, string, Matrix4x4, void> Kv3SetMemberMatrix3x4 = &___Kv3SetMemberMatrix3x4;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Matrix4x4*, void> __Kv3SetMemberMatrix3x4;
		private static void ___Kv3SetMemberMatrix3x4(nint kv, string name, Matrix4x4 matrix)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv3SetMemberMatrix3x4(kv, &__name, &matrix);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Prints debug information about the KeyValues3 object
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		internal static delegate*<nint, void> Kv3DebugPrint = &___Kv3DebugPrint;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv3DebugPrint;
		private static void ___Kv3DebugPrint(nint kv)
		{
			__Kv3DebugPrint(kv);
		}

		/// <summary>
		/// Loads KeyValues3 data from a buffer into a context
		/// </summary>
		/// <param name="context">Pointer to the KeyValues3 context</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, byte[], string, uint, Bool8> Kv3LoadFromBuffer = &___Kv3LoadFromBuffer;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, String192*, uint, Bool8> __Kv3LoadFromBuffer;
		private static Bool8 ___Kv3LoadFromBuffer(nint context, ref string error, byte[] input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructVectorUInt8(input, input.Length);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromBuffer(context, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, byte[], string, uint, Bool8> Kv3Load = &___Kv3Load;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, String192*, uint, Bool8> __Kv3Load;
		private static Bool8 ___Kv3Load(nint kv, ref string error, byte[] input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructVectorUInt8(input, input.Length);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3Load(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a text string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Text string containing KV3 data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadFromText = &___Kv3LoadFromText;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadFromText;
		private static Bool8 ___Kv3LoadFromText(nint kv, ref string error, string input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructString(input);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromText(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a file into a context
		/// </summary>
		/// <param name="context">Pointer to the KeyValues3 context</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="path">Path to the file</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadFromFileToContext = &___Kv3LoadFromFileToContext;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadFromFileToContext;
		private static Bool8 ___Kv3LoadFromFileToContext(nint context, ref string error, string filename, string path, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __filename = NativeMethods.ConstructString(filename);
			var __path = NativeMethods.ConstructString(path);
			try {
				__retVal = __Kv3LoadFromFileToContext(context, &__error, &__filename, &__path, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__filename);
				NativeMethods.DestroyString(&__path);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a file
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="path">Path to the file</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadFromFile = &___Kv3LoadFromFile;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadFromFile;
		private static Bool8 ___Kv3LoadFromFile(nint kv, ref string error, string filename, string path, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __filename = NativeMethods.ConstructString(filename);
			var __path = NativeMethods.ConstructString(path);
			try {
				__retVal = __Kv3LoadFromFile(kv, &__error, &__filename, &__path, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__filename);
				NativeMethods.DestroyString(&__path);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a JSON string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">JSON string</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadFromJSON = &___Kv3LoadFromJSON;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadFromJSON;
		private static Bool8 ___Kv3LoadFromJSON(nint kv, ref string error, string input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructString(input);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromJSON(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a JSON file
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadFromJSONFile = &___Kv3LoadFromJSONFile;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadFromJSONFile;
		private static Bool8 ___Kv3LoadFromJSONFile(nint kv, ref string error, string path, string filename, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __path = NativeMethods.ConstructString(path);
			var __filename = NativeMethods.ConstructString(filename);
			try {
				__retVal = __Kv3LoadFromJSONFile(kv, &__error, &__path, &__filename, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__path);
				NativeMethods.DestroyString(&__filename);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 file
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, byte, uint, Bool8> Kv3LoadFromKV1File = &___Kv3LoadFromKV1File;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, byte, uint, Bool8> __Kv3LoadFromKV1File;
		private static Bool8 ___Kv3LoadFromKV1File(nint kv, ref string error, string path, string filename, byte esc_behavior, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __path = NativeMethods.ConstructString(path);
			var __filename = NativeMethods.ConstructString(filename);
			try {
				__retVal = __Kv3LoadFromKV1File(kv, &__error, &__path, &__filename, esc_behavior, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__path);
				NativeMethods.DestroyString(&__filename);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 text string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">KV1 text string</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="unk">Unknown boolean parameter</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, byte, string, Bool8, uint, Bool8> Kv3LoadFromKV1Text = &___Kv3LoadFromKV1Text;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, byte, String192*, Bool8, uint, Bool8> __Kv3LoadFromKV1Text;
		private static Bool8 ___Kv3LoadFromKV1Text(nint kv, ref string error, string input, byte esc_behavior, string kv_name, Bool8 unk, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructString(input);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromKV1Text(kv, &__error, &__input, esc_behavior, &__kv_name, unk, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 text string with translation
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">KV1 text string</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="translation">Pointer to translation table</param>
		/// <param name="unk1">Unknown integer parameter</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="unk2">Unknown boolean parameter</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, byte, nint, int, string, Bool8, uint, Bool8> Kv3LoadFromKV1TextTranslated = &___Kv3LoadFromKV1TextTranslated;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, byte, nint, int, String192*, Bool8, uint, Bool8> __Kv3LoadFromKV1TextTranslated;
		private static Bool8 ___Kv3LoadFromKV1TextTranslated(nint kv, ref string error, string input, byte esc_behavior, nint translation, int unk1, string kv_name, Bool8 unk2, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructString(input);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromKV1TextTranslated(kv, &__error, &__input, esc_behavior, translation, unk1, &__kv_name, unk2, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads data from a buffer that may be KV3 or KV1 format
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, byte[], string, uint, Bool8> Kv3LoadFromKV3OrKV1 = &___Kv3LoadFromKV3OrKV1;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, String192*, uint, Bool8> __Kv3LoadFromKV3OrKV1;
		private static Bool8 ___Kv3LoadFromKV3OrKV1(nint kv, ref string error, byte[] input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructVectorUInt8(input, input.Length);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromKV3OrKV1(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 data from old schema text format
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, byte[], string, uint, Bool8> Kv3LoadFromOldSchemaText = &___Kv3LoadFromOldSchemaText;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, String192*, uint, Bool8> __Kv3LoadFromOldSchemaText;
		private static Bool8 ___Kv3LoadFromOldSchemaText(nint kv, ref string error, byte[] input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructVectorUInt8(input, input.Length);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadFromOldSchemaText(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Loads KeyValues3 text without a header
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Text string containing KV3 data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3LoadTextNoHeader = &___Kv3LoadTextNoHeader;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3LoadTextNoHeader;
		private static Bool8 ___Kv3LoadTextNoHeader(nint kv, ref string error, string input, string kv_name, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __input = NativeMethods.ConstructString(input);
			var __kv_name = NativeMethods.ConstructString(kv_name);
			try {
				__retVal = __Kv3LoadTextNoHeader(kv, &__error, &__input, &__kv_name, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__input);
				NativeMethods.DestroyString(&__kv_name);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data to a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output buffer data</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref byte[], uint, Bool8> Kv3Save = &___Kv3Save;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, uint, Bool8> __Kv3Save;
		private static Bool8 ___Kv3Save(nint kv, ref string error, ref byte[] output, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructVectorUInt8(output, output.Length);
			try {
				__retVal = __Kv3Save(kv, &__error, &__output, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				Array.Resize(ref output, NativeMethods.GetVectorSizeUInt8(&__output));
				NativeMethods.GetVectorDataUInt8(&__output, output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data as JSON to a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output JSON data</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref byte[], Bool8> Kv3SaveAsJSON = &___Kv3SaveAsJSON;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, Bool8> __Kv3SaveAsJSON;
		private static Bool8 ___Kv3SaveAsJSON(nint kv, ref string error, ref byte[] output)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructVectorUInt8(output, output.Length);
			try {
				__retVal = __Kv3SaveAsJSON(kv, &__error, &__output);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				Array.Resize(ref output, NativeMethods.GetVectorSizeUInt8(&__output));
				NativeMethods.GetVectorDataUInt8(&__output, output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data as a JSON string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the JSON output</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref string, Bool8> Kv3SaveAsJSONString = &___Kv3SaveAsJSONString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Bool8> __Kv3SaveAsJSONString;
		private static Bool8 ___Kv3SaveAsJSONString(nint kv, ref string error, ref string output)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructString(output);
			try {
				__retVal = __Kv3SaveAsJSONString(kv, &__error, &__output);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				output = NativeMethods.GetStringData(&__output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data as KeyValues1 text to a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output KV1 text data</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref byte[], byte, Bool8> Kv3SaveAsKV1Text = &___Kv3SaveAsKV1Text;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, byte, Bool8> __Kv3SaveAsKV1Text;
		private static Bool8 ___Kv3SaveAsKV1Text(nint kv, ref string error, ref byte[] output, byte esc_behavior)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructVectorUInt8(output, output.Length);
			try {
				__retVal = __Kv3SaveAsKV1Text(kv, &__error, &__output, esc_behavior);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				Array.Resize(ref output, NativeMethods.GetVectorSizeUInt8(&__output));
				NativeMethods.GetVectorDataUInt8(&__output, output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data as KeyValues1 text with translation to a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output KV1 text data</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="translation">Pointer to translation table</param>
		/// <param name="unk">Unknown integer parameter</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref byte[], byte, nint, int, Bool8> Kv3SaveAsKV1TextTranslated = &___Kv3SaveAsKV1TextTranslated;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, byte, nint, int, Bool8> __Kv3SaveAsKV1TextTranslated;
		private static Bool8 ___Kv3SaveAsKV1TextTranslated(nint kv, ref string error, ref byte[] output, byte esc_behavior, nint translation, int unk)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructVectorUInt8(output, output.Length);
			try {
				__retVal = __Kv3SaveAsKV1TextTranslated(kv, &__error, &__output, esc_behavior, translation, unk);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				Array.Resize(ref output, NativeMethods.GetVectorSizeUInt8(&__output));
				NativeMethods.GetVectorDataUInt8(&__output, output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 text without a header to a buffer
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output text data</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref byte[], uint, Bool8> Kv3SaveTextNoHeaderToBuffer = &___Kv3SaveTextNoHeaderToBuffer;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector192*, uint, Bool8> __Kv3SaveTextNoHeaderToBuffer;
		private static Bool8 ___Kv3SaveTextNoHeaderToBuffer(nint kv, ref string error, ref byte[] output, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructVectorUInt8(output, output.Length);
			try {
				__retVal = __Kv3SaveTextNoHeaderToBuffer(kv, &__error, &__output, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				Array.Resize(ref output, NativeMethods.GetVectorSizeUInt8(&__output));
				NativeMethods.GetVectorDataUInt8(&__output, output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyVectorUInt8(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 text without a header to a string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the text output</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref string, uint, Bool8> Kv3SaveTextNoHeader = &___Kv3SaveTextNoHeader;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, uint, Bool8> __Kv3SaveTextNoHeader;
		private static Bool8 ___Kv3SaveTextNoHeader(nint kv, ref string error, ref string output, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructString(output);
			try {
				__retVal = __Kv3SaveTextNoHeader(kv, &__error, &__output, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				output = NativeMethods.GetStringData(&__output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 text to a string
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the text output</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, ref string, uint, Bool8> Kv3SaveTextToString = &___Kv3SaveTextToString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, uint, Bool8> __Kv3SaveTextToString;
		private static Bool8 ___Kv3SaveTextToString(nint kv, ref string error, ref string output, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __output = NativeMethods.ConstructString(output);
			try {
				__retVal = __Kv3SaveTextToString(kv, &__error, &__output, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
				output = NativeMethods.GetStringData(&__output);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__output);
			}
			return __retVal;
		}

		/// <summary>
		/// Saves KeyValues3 data to a file
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues3 object</param>
		/// <param name="error">Output string for error messages</param>
		/// <param name="filename">Name of the file to save</param>
		/// <param name="path">Path to save the file</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		internal static delegate*<nint, ref string, string, string, uint, Bool8> Kv3SaveToFile = &___Kv3SaveToFile;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192*, uint, Bool8> __Kv3SaveToFile;
		private static Bool8 ___Kv3SaveToFile(nint kv, ref string error, string filename, string path, uint flags)
		{
			Bool8 __retVal;
			var __error = NativeMethods.ConstructString(error);
			var __filename = NativeMethods.ConstructString(filename);
			var __path = NativeMethods.ConstructString(path);
			try {
				__retVal = __Kv3SaveToFile(kv, &__error, &__filename, &__path, flags);
				// Unmarshal - Convert native data to managed data.
				error = NativeMethods.GetStringData(&__error);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__error);
				NativeMethods.DestroyString(&__filename);
				NativeMethods.DestroyString(&__path);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for KeyValues3 handle.
	/// </summary>
	internal sealed unsafe class KeyValues3 : SafeHandle
	{
		/// <summary>
		/// Creates a new KeyValues3 object with specified type and subtype
		/// </summary>
		/// <param name="type">The KV3 type enumeration value</param>
		/// <param name="subtype">The KV3 subtype enumeration value</param>
		public KeyValues3(int type, int subtype) : this(s2sdk.Kv3Create(type, subtype), Ownership.Owned)
		{
		}

		/// <summary>
		/// Creates a new KeyValues3 object with cluster element, type, and subtype
		/// </summary>
		/// <param name="cluster_elem">The cluster element index</param>
		/// <param name="type">The KV3 type enumeration value</param>
		/// <param name="subtype">The KV3 subtype enumeration value</param>
		public KeyValues3(int cluster_elem, int type, int subtype) : this(s2sdk.Kv3CreateWithCluster(cluster_elem, type, subtype), Ownership.Owned)
		{
		}

		/// <summary>
		/// Creates a copy of an existing KeyValues3 object
		/// </summary>
		/// <param name="other">Pointer to the KeyValues3 object to copy</param>
		public KeyValues3(nint other) : this(s2sdk.Kv3CreateCopy(other), Ownership.Owned)
		{
		}

		/// <summary>
		/// Internal constructor for creating KeyValues3 from existing handle
		/// </summary>
		public KeyValues3(nint handle, Ownership ownership) : base((nint)handle, ownsHandle: ownership == Ownership.Owned)
		{
		}

		/// <summary>
		/// Releases the handle (called automatically by SafeHandle)
		/// </summary>
		protected override bool ReleaseHandle()
		{
			s2sdk.Kv3Destroy((nint)handle);
			return true;
		}

		/// <summary>
		/// Checks if the KeyValues3 has a valid handle
		/// </summary>
		public override bool IsInvalid => handle == nint.Zero;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Handle => (nint)handle;

		/// <summary>
		/// Checks if the handle is valid
		/// </summary>
		public bool IsValid => handle != nint.Zero;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Get() => (nint)handle;

		/// <summary>
		/// Releases ownership of the handle and returns it
		/// </summary>
		public nint Release()
		{
			var h = handle;
			SetHandleAsInvalid();
			return (nint)h;
		}

		/// <summary>
		/// Disposes the handle
		/// </summary>
		public void Reset()
		{
			Dispose();
		}

		/// <summary>
		/// Copies data from another KeyValues3 object
		/// </summary>
		/// <param name="other">Pointer to the source KeyValues3 object</param>
		public void CopyFrom(KeyValues3 other)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3CopyFrom(Handle, other.Get());
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Overlays keys from another KeyValues3 object
		/// </summary>
		/// <param name="other">Pointer to the source KeyValues3 object</param>
		/// <param name="depth">Whether to perform a deep overlay</param>
		public void OverlayKeysFrom(KeyValues3 other, Bool8 depth)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3OverlayKeysFrom(Handle, other.Get(), depth);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the context associated with a KeyValues3 object
		/// </summary>
		/// <returns>Pointer to the CKeyValues3Context, or nullptr if kv is null</returns>
		public nint GetContext()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetContext(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the metadata associated with a KeyValues3 object
		/// </summary>
		/// <param name="ppCtx">Pointer to store the context pointer</param>
		/// <returns>Pointer to the KV3MetaData_t structure, or nullptr if kv is null</returns>
		public nint GetMetaData(nint ppCtx)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMetaData(Handle, ppCtx);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if a specific flag is set
		/// </summary>
		/// <param name="flag">The flag to check</param>
		/// <returns>true if the flag is set, false otherwise</returns>
		public Bool8 HasFlag(byte flag)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3HasFlag(Handle, flag);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if any flags are set
		/// </summary>
		/// <returns>true if any flags are set, false otherwise</returns>
		public Bool8 HasAnyFlags()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3HasAnyFlags(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets all flags as a bitmask
		/// </summary>
		/// <returns>Bitmask of all flags, or 0 if kv is null</returns>
		public byte GetAllFlags()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetAllFlags(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets all flags from a bitmask
		/// </summary>
		/// <param name="flags">Bitmask of flags to set</param>
		public void SetAllFlags(byte flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetAllFlags(Handle, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets or clears a specific flag
		/// </summary>
		/// <param name="flag">The flag to modify</param>
		/// <param name="state">true to set the flag, false to clear it</param>
		public void SetFlag(byte flag, Bool8 state)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetFlag(Handle, flag, state);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the basic type of the KeyValues3 object
		/// </summary>
		/// <returns>The type enumeration value, or 0 if kv is null</returns>
		public byte GetType()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetType(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the extended type of the KeyValues3 object
		/// </summary>
		/// <returns>The extended type enumeration value, or 0 if kv is null</returns>
		public byte GetTypeEx()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetTypeEx(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the subtype of the KeyValues3 object
		/// </summary>
		/// <returns>The subtype enumeration value, or 0 if kv is null</returns>
		public byte GetSubType()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetSubType(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the object has invalid member names
		/// </summary>
		/// <returns>true if invalid member names exist, false otherwise</returns>
		public Bool8 HasInvalidMemberNames()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3HasInvalidMemberNames(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the invalid member names flag
		/// </summary>
		/// <param name="bValue">true to mark as having invalid member names, false otherwise</param>
		public void SetHasInvalidMemberNames(Bool8 bValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetHasInvalidMemberNames(Handle, bValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the type as a string representation
		/// </summary>
		/// <returns>String representation of the type, or empty string if kv is null</returns>
		public string GetTypeAsString()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetTypeAsString(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the subtype as a string representation
		/// </summary>
		/// <returns>String representation of the subtype, or empty string if kv is null</returns>
		public string GetSubTypeAsString()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetSubTypeAsString(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Converts the KeyValues3 object to a string representation
		/// </summary>
		/// <param name="flags">Formatting flags for the string conversion</param>
		/// <returns>String representation of the object, or empty string if kv is null</returns>
		public string ToString(uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3ToString(Handle, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the KeyValues3 object is null
		/// </summary>
		/// <returns>true if the object is null or the pointer is null, false otherwise</returns>
		public Bool8 IsNull()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3IsNull(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to null
		/// </summary>
		public void SetToNull()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetToNull(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the KeyValues3 object is an array
		/// </summary>
		/// <returns>true if the object is an array, false otherwise</returns>
		public Bool8 IsArray()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3IsArray(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a KV3 array
		/// </summary>
		/// <returns>true if the object is a KV3 array, false otherwise</returns>
		public Bool8 IsKV3Array()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3IsKV3Array(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a table
		/// </summary>
		/// <returns>true if the object is a table, false otherwise</returns>
		public Bool8 IsTable()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3IsTable(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the KeyValues3 object is a string
		/// </summary>
		/// <returns>true if the object is a string, false otherwise</returns>
		public Bool8 IsString()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3IsString(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the boolean value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Boolean value or defaultValue</returns>
		public Bool8 GetBool(Bool8 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetBool(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the char value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Char value or defaultValue</returns>
		public Char8 GetChar(Char8 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetChar(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the 32-bit Unicode character value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>32-bit Unicode character value or defaultValue</returns>
		public uint GetUChar32(uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetUChar32(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the signed 8-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int8_t value or defaultValue</returns>
		public sbyte GetInt8(sbyte defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetInt8(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the unsigned 8-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint8_t value or defaultValue</returns>
		public byte GetUInt8(byte defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetUInt8(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the signed 16-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int16_t value or defaultValue</returns>
		public short GetShort(short defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetShort(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the unsigned 16-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint16_t value or defaultValue</returns>
		public ushort GetUShort(ushort defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetUShort(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the signed 32-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int32_t value or defaultValue</returns>
		public int GetInt(int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetInt(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the unsigned 32-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint32_t value or defaultValue</returns>
		public uint GetUInt(uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetUInt(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the signed 64-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>int64_t value or defaultValue</returns>
		public long GetInt64(long defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetInt64(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the unsigned 64-bit integer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>uint64_t value or defaultValue</returns>
		public ulong GetUInt64(ulong defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetUInt64(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the float value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Float value or defaultValue</returns>
		public float GetFloat(float defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetFloat(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the double value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null or conversion fails</param>
		/// <returns>Double value or defaultValue</returns>
		public double GetDouble(double defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetDouble(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a boolean value
		/// </summary>
		/// <param name="value">Boolean value to set</param>
		public void SetBool(Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetBool(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a char value
		/// </summary>
		/// <param name="value">Char value to set</param>
		public void SetChar(Char8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetChar(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 32-bit Unicode character value
		/// </summary>
		/// <param name="value">32-bit Unicode character value to set</param>
		public void SetUChar32(uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetUChar32(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 8-bit integer value
		/// </summary>
		/// <param name="value">int8_t value to set</param>
		public void SetInt8(sbyte value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetInt8(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 8-bit integer value
		/// </summary>
		/// <param name="value">uint8_t value to set</param>
		public void SetUInt8(byte value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetUInt8(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 16-bit integer value
		/// </summary>
		/// <param name="value">int16_t value to set</param>
		public void SetShort(short value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetShort(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 16-bit integer value
		/// </summary>
		/// <param name="value">uint16_t value to set</param>
		public void SetUShort(ushort value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetUShort(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 32-bit integer value
		/// </summary>
		/// <param name="value">int32_t value to set</param>
		public void SetInt(int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetInt(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 32-bit integer value
		/// </summary>
		/// <param name="value">uint32_t value to set</param>
		public void SetUInt(uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetUInt(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a signed 64-bit integer value
		/// </summary>
		/// <param name="value">int64_t value to set</param>
		public void SetInt64(long value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetInt64(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an unsigned 64-bit integer value
		/// </summary>
		/// <param name="value">uint64_t value to set</param>
		public void SetUInt64(ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetUInt64(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a float value
		/// </summary>
		/// <param name="value">Float value to set</param>
		public void SetFloat(float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetFloat(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a double value
		/// </summary>
		/// <param name="value">Double value to set</param>
		public void SetDouble(double value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetDouble(Handle, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the pointer value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default value to return if kv is null</param>
		/// <returns>Pointer value as uintptr_t or defaultValue</returns>
		public nint GetPointer(nint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetPointer(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a pointer value
		/// </summary>
		/// <param name="ptr">Pointer value as uintptr_t to set</param>
		public void SetPointer(nint ptr)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetPointer(Handle, ptr);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the string token value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default token value to return if kv is null</param>
		/// <returns>String token hash code or defaultValue</returns>
		public uint GetStringToken(uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetStringToken(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a string token value
		/// </summary>
		/// <param name="token">String token hash code to set</param>
		public void SetStringToken(uint token)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetStringToken(Handle, token);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the entity handle value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default entity handle value to return if kv is null</param>
		/// <returns>Entity handle as int32_t or defaultValue</returns>
		public int GetEHandle(int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetEHandle(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an entity handle value
		/// </summary>
		/// <param name="ehandle">Entity handle value to set</param>
		public void SetEHandle(int ehandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetEHandle(Handle, ehandle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the string value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default string to return if kv is null or value is empty</param>
		/// <returns>String value or defaultValue</returns>
		public string GetString(string defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetString(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a string value (copies the string)
		/// </summary>
		/// <param name="str">String value to set</param>
		/// <param name="subtype">String subtype enumeration value</param>
		public void SetString(string str, byte subtype)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetString(Handle, str, subtype);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an external string value (does not copy)
		/// </summary>
		/// <param name="str">External string value to reference</param>
		/// <param name="subtype">String subtype enumeration value</param>
		public void SetStringExternal(string str, byte subtype)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetStringExternal(Handle, str, subtype);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the binary blob from the KeyValues3 object
		/// </summary>
		/// <returns>Vector containing the binary blob data, or empty vector if kv is null</returns>
		public byte[] GetBinaryBlob()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetBinaryBlob(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the size of the binary blob in the KeyValues3 object
		/// </summary>
		/// <returns>Size of the binary blob in bytes, or 0 if kv is null</returns>
		public int GetBinaryBlobSize()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetBinaryBlobSize(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a binary blob (copies the data)
		/// </summary>
		/// <param name="blob">Vector containing the binary blob data</param>
		public void SetToBinaryBlob(byte[] blob)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetToBinaryBlob(Handle, blob);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an external binary blob (does not copy)
		/// </summary>
		/// <param name="blob">Vector containing the external binary blob data</param>
		/// <param name="free_mem">Whether to free the memory when the object is destroyed</param>
		public void SetToBinaryBlobExternal(byte[] blob, Bool8 free_mem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetToBinaryBlobExternal(Handle, blob, free_mem);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the color value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default color value to return if kv is null</param>
		/// <returns>Color value as int32_t or defaultValue</returns>
		public int GetColor(int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetColor(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a color value
		/// </summary>
		/// <param name="color">Color value as int32_t to set</param>
		public void SetColor(int color)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetColor(Handle, color);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the 3D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default vector to return if kv is null</param>
		/// <returns>3D vector or defaultValue</returns>
		public Vector3 GetVector(Vector3 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetVector(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the 2D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default 2D vector to return if kv is null</param>
		/// <returns>2D vector or defaultValue</returns>
		public Vector2 GetVector2D(Vector2 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetVector2D(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the 4D vector value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default 4D vector to return if kv is null</param>
		/// <returns>4D vector or defaultValue</returns>
		public Vector4 GetVector4D(Vector4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetVector4D(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the quaternion value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default quaternion to return if kv is null</param>
		/// <returns>Quaternion as vec4 or defaultValue</returns>
		public Vector4 GetQuaternion(Vector4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetQuaternion(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the angle (QAngle) value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default angle to return if kv is null</param>
		/// <returns>QAngle as vec3 or defaultValue</returns>
		public Vector3 GetQAngle(Vector3 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetQAngle(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the 3x4 matrix value from the KeyValues3 object
		/// </summary>
		/// <param name="defaultValue">Default matrix to return if kv is null</param>
		/// <returns>3x4 matrix as mat4x4 or defaultValue</returns>
		public Matrix4x4 GetMatrix3x4(Matrix4x4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMatrix3x4(Handle, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 3D vector value
		/// </summary>
		/// <param name="vec">3D vector to set</param>
		public void SetVector(Vector3 vec)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetVector(Handle, vec);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 2D vector value
		/// </summary>
		/// <param name="vec2d">2D vector to set</param>
		public void SetVector2D(Vector2 vec2d)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetVector2D(Handle, vec2d);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 4D vector value
		/// </summary>
		/// <param name="vec4d">4D vector to set</param>
		public void SetVector4D(Vector4 vec4d)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetVector4D(Handle, vec4d);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a quaternion value
		/// </summary>
		/// <param name="quat">Quaternion to set (as vec4)</param>
		public void SetQuaternion(Vector4 quat)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetQuaternion(Handle, quat);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an angle (QAngle) value
		/// </summary>
		/// <param name="ang">QAngle to set (as vec3)</param>
		public void SetQAngle(Vector3 ang)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetQAngle(Handle, ang);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to a 3x4 matrix value
		/// </summary>
		/// <param name="matrix">3x4 matrix to set (as mat4x4)</param>
		public void SetMatrix3x4(Matrix4x4 matrix)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMatrix3x4(Handle, matrix);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the number of elements in the array
		/// </summary>
		/// <returns>Number of array elements, or 0 if kv is null or not an array</returns>
		public int GetArrayElementCount()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetArrayElementCount(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the number of elements in the array
		/// </summary>
		/// <param name="count">Number of elements to set</param>
		/// <param name="type">Type of array elements</param>
		/// <param name="subtype">Subtype of array elements</param>
		public void SetArrayElementCount(int count, byte type, byte subtype)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetArrayElementCount(Handle, count, type, subtype);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an empty KV3 array
		/// </summary>
		public void SetToEmptyKV3Array()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetToEmptyKV3Array(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an array element at the specified index
		/// </summary>
		/// <param name="elem">Index of the element to get</param>
		/// <returns>Pointer to the element KeyValues3 object, or nullptr if invalid</returns>
		public KeyValues3 GetArrayElement(int elem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3GetArrayElement(Handle, elem), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Inserts a new element before the specified index
		/// </summary>
		/// <param name="elem">Index before which to insert</param>
		/// <returns>Pointer to the newly inserted element, or nullptr if invalid</returns>
		public KeyValues3 ArrayInsertElementBefore(int elem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3ArrayInsertElementBefore(Handle, elem), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Inserts a new element after the specified index
		/// </summary>
		/// <param name="elem">Index after which to insert</param>
		/// <returns>Pointer to the newly inserted element, or nullptr if invalid</returns>
		public KeyValues3 ArrayInsertElementAfter(int elem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3ArrayInsertElementAfter(Handle, elem), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a new element to the end of the array
		/// </summary>
		/// <returns>Pointer to the newly added element, or nullptr if invalid</returns>
		public KeyValues3 ArrayAddElementToTail()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3ArrayAddElementToTail(Handle), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Swaps two array elements
		/// </summary>
		/// <param name="idx1">Index of the first element</param>
		/// <param name="idx2">Index of the second element</param>
		public void ArraySwapItems(int idx1, int idx2)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3ArraySwapItems(Handle, idx1, idx2);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Removes an element from the array
		/// </summary>
		/// <param name="elem">Index of the element to remove</param>
		public void ArrayRemoveElement(int elem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3ArrayRemoveElement(Handle, elem);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the KeyValues3 object to an empty table
		/// </summary>
		public void SetToEmptyTable()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetToEmptyTable(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the number of members in the table
		/// </summary>
		/// <returns>Number of table members, or 0 if kv is null or not a table</returns>
		public int GetMemberCount()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberCount(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if a member with the specified name exists
		/// </summary>
		/// <param name="name">Name of the member to check</param>
		/// <returns>true if the member exists, false otherwise</returns>
		public Bool8 HasMember(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3HasMember(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Finds a member by name
		/// </summary>
		/// <param name="name">Name of the member to find</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if not found</returns>
		public KeyValues3 FindMember(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3FindMember(Handle, name), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Finds a member by name, or creates it if it doesn't exist
		/// </summary>
		/// <param name="name">Name of the member to find or create</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if kv is null</returns>
		public KeyValues3 FindOrCreateMember(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3FindOrCreateMember(Handle, name), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Removes a member from the table
		/// </summary>
		/// <param name="name">Name of the member to remove</param>
		/// <returns>true if the member was removed, false otherwise</returns>
		public Bool8 RemoveMember(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3RemoveMember(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the name of a member at the specified index
		/// </summary>
		/// <param name="index">Index of the member</param>
		/// <returns>Name of the member, or empty string if invalid</returns>
		public string GetMemberName(int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberName(Handle, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a member by index
		/// </summary>
		/// <param name="index">Index of the member to get</param>
		/// <returns>Pointer to the member KeyValues3 object, or nullptr if invalid</returns>
		public KeyValues3 GetMemberByIndex(int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues3(s2sdk.Kv3GetMemberByIndex(Handle, index), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a boolean value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Boolean value or defaultValue</returns>
		public Bool8 GetMemberBool(string name, Bool8 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberBool(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a char value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Char value or defaultValue</returns>
		public Char8 GetMemberChar(string name, Char8 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberChar(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 32-bit Unicode character value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>32-bit Unicode character value or defaultValue</returns>
		public uint GetMemberUChar32(string name, uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberUChar32(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a signed 8-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int8_t value or defaultValue</returns>
		public sbyte GetMemberInt8(string name, sbyte defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberInt8(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 8-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint8_t value or defaultValue</returns>
		public byte GetMemberUInt8(string name, byte defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberUInt8(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a signed 16-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int16_t value or defaultValue</returns>
		public short GetMemberShort(string name, short defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberShort(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 16-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint16_t value or defaultValue</returns>
		public ushort GetMemberUShort(string name, ushort defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberUShort(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a signed 32-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int32_t value or defaultValue</returns>
		public int GetMemberInt(string name, int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberInt(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 32-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint32_t value or defaultValue</returns>
		public uint GetMemberUInt(string name, uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberUInt(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a signed 64-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>int64_t value or defaultValue</returns>
		public long GetMemberInt64(string name, long defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberInt64(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 64-bit integer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>uint64_t value or defaultValue</returns>
		public ulong GetMemberUInt64(string name, ulong defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberUInt64(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a float value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Float value or defaultValue</returns>
		public float GetMemberFloat(string name, float defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberFloat(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a double value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Double value or defaultValue</returns>
		public double GetMemberDouble(string name, double defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberDouble(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a pointer value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default value to return if member not found</param>
		/// <returns>Pointer value as uintptr_t or defaultValue</returns>
		public nint GetMemberPointer(string name, nint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberPointer(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a string token value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default token value to return if member not found</param>
		/// <returns>String token hash code or defaultValue</returns>
		public uint GetMemberStringToken(string name, uint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberStringToken(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an entity handle value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default entity handle value to return if member not found</param>
		/// <returns>Entity handle as int32_t or defaultValue</returns>
		public int GetMemberEHandle(string name, int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberEHandle(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a string value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default string to return if member not found</param>
		/// <returns>String value or defaultValue</returns>
		public string GetMemberString(string name, string defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberString(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a color value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default color value to return if member not found</param>
		/// <returns>Color value as int32_t or defaultValue</returns>
		public int GetMemberColor(string name, int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberColor(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 3D vector value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default vector to return if member not found</param>
		/// <returns>3D vector or defaultValue</returns>
		public Vector3 GetMemberVector(string name, Vector3 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberVector(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 2D vector value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default 2D vector to return if member not found</param>
		/// <returns>2D vector or defaultValue</returns>
		public Vector2 GetMemberVector2D(string name, Vector2 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberVector2D(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 4D vector value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default 4D vector to return if member not found</param>
		/// <returns>4D vector or defaultValue</returns>
		public Vector4 GetMemberVector4D(string name, Vector4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberVector4D(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a quaternion value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default quaternion to return if member not found</param>
		/// <returns>Quaternion as vec4 or defaultValue</returns>
		public Vector4 GetMemberQuaternion(string name, Vector4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberQuaternion(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an angle (QAngle) value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default angle to return if member not found</param>
		/// <returns>QAngle as vec3 or defaultValue</returns>
		public Vector3 GetMemberQAngle(string name, Vector3 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberQAngle(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 3x4 matrix value from a table member
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="defaultValue">Default matrix to return if member not found</param>
		/// <returns>3x4 matrix as mat4x4 or defaultValue</returns>
		public Matrix4x4 GetMemberMatrix3x4(string name, Matrix4x4 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3GetMemberMatrix3x4(Handle, name, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to null
		/// </summary>
		/// <param name="name">Name of the member</param>
		public void SetMemberToNull(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToNull(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an empty array
		/// </summary>
		/// <param name="name">Name of the member</param>
		public void SetMemberToEmptyArray(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToEmptyArray(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an empty table
		/// </summary>
		/// <param name="name">Name of the member</param>
		public void SetMemberToEmptyTable(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToEmptyTable(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a binary blob (copies the data)
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="blob">Vector containing the binary blob data</param>
		public void SetMemberToBinaryBlob(string name, byte[] blob)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToBinaryBlob(Handle, name, blob);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an external binary blob (does not copy)
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="blob">Vector containing the external binary blob data</param>
		/// <param name="free_mem">Whether to free the memory when the object is destroyed</param>
		public void SetMemberToBinaryBlobExternal(string name, byte[] blob, Bool8 free_mem)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToBinaryBlobExternal(Handle, name, blob, free_mem);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a copy of another KeyValues3 value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="other">Pointer to the KeyValues3 object to copy</param>
		public void SetMemberToCopyOfValue(string name, nint other)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberToCopyOfValue(Handle, name, other);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a boolean value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Boolean value to set</param>
		public void SetMemberBool(string name, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberBool(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a char value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Char value to set</param>
		public void SetMemberChar(string name, Char8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberChar(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a 32-bit Unicode character value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">32-bit Unicode character value to set</param>
		public void SetMemberUChar32(string name, uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberUChar32(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a signed 8-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int8_t value to set</param>
		public void SetMemberInt8(string name, sbyte value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberInt8(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 8-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint8_t value to set</param>
		public void SetMemberUInt8(string name, byte value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberUInt8(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a signed 16-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int16_t value to set</param>
		public void SetMemberShort(string name, short value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberShort(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 16-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint16_t value to set</param>
		public void SetMemberUShort(string name, ushort value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberUShort(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a signed 32-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int32_t value to set</param>
		public void SetMemberInt(string name, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberInt(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 32-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint32_t value to set</param>
		public void SetMemberUInt(string name, uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberUInt(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a signed 64-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">int64_t value to set</param>
		public void SetMemberInt64(string name, long value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberInt64(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an unsigned 64-bit integer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">uint64_t value to set</param>
		public void SetMemberUInt64(string name, ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberUInt64(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a float value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Float value to set</param>
		public void SetMemberFloat(string name, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberFloat(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a double value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="value">Double value to set</param>
		public void SetMemberDouble(string name, double value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberDouble(Handle, name, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a pointer value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="ptr">Pointer value as uintptr_t to set</param>
		public void SetMemberPointer(string name, nint ptr)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberPointer(Handle, name, ptr);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a string token value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="token">String token hash code to set</param>
		public void SetMemberStringToken(string name, uint token)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberStringToken(Handle, name, token);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an entity handle value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="ehandle">Entity handle value to set</param>
		public void SetMemberEHandle(string name, int ehandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberEHandle(Handle, name, ehandle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a string value (copies the string)
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="str">String value to set</param>
		/// <param name="subtype">String subtype enumeration value</param>
		public void SetMemberString(string name, string str, byte subtype)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberString(Handle, name, str, subtype);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an external string value (does not copy)
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="str">External string value to reference</param>
		/// <param name="subtype">String subtype enumeration value</param>
		public void SetMemberStringExternal(string name, string str, byte subtype)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberStringExternal(Handle, name, str, subtype);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a color value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="color">Color value as int32_t to set</param>
		public void SetMemberColor(string name, int color)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberColor(Handle, name, color);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a 3D vector value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="vec">3D vector to set</param>
		public void SetMemberVector(string name, Vector3 vec)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberVector(Handle, name, vec);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a 2D vector value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="vec2d">2D vector to set</param>
		public void SetMemberVector2D(string name, Vector2 vec2d)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberVector2D(Handle, name, vec2d);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a 4D vector value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="vec4d">4D vector to set</param>
		public void SetMemberVector4D(string name, Vector4 vec4d)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberVector4D(Handle, name, vec4d);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a quaternion value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="quat">Quaternion to set (as vec4)</param>
		public void SetMemberQuaternion(string name, Vector4 quat)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberQuaternion(Handle, name, quat);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to an angle (QAngle) value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="ang">QAngle to set (as vec3)</param>
		public void SetMemberQAngle(string name, Vector3 ang)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberQAngle(Handle, name, ang);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a table member to a 3x4 matrix value
		/// </summary>
		/// <param name="name">Name of the member</param>
		/// <param name="matrix">3x4 matrix to set (as mat4x4)</param>
		public void SetMemberMatrix3x4(string name, Matrix4x4 matrix)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3SetMemberMatrix3x4(Handle, name, matrix);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Prints debug information about the KeyValues3 object
		/// </summary>
		public void DebugPrint()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv3DebugPrint(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 Load(ref string error, byte[] input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3Load(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a text string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Text string containing KV3 data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromText(ref string error, string input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromText(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a file
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="path">Path to the file</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromFile(ref string error, string filename, string path, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromFile(Handle, ref error, filename, path, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a JSON string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">JSON string</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromJSON(ref string error, string input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromJSON(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a JSON file
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromJSONFile(ref string error, string path, string filename, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromJSONFile(Handle, ref error, path, filename, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 file
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="path">Path to the file</param>
		/// <param name="filename">Name of the file to load</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromKV1File(ref string error, string path, string filename, byte esc_behavior, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromKV1File(Handle, ref error, path, filename, esc_behavior, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 text string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">KV1 text string</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="unk">Unknown boolean parameter</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromKV1Text(ref string error, string input, byte esc_behavior, string kv_name, Bool8 unk, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromKV1Text(Handle, ref error, input, esc_behavior, kv_name, unk, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from a KeyValues1 text string with translation
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">KV1 text string</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="translation">Pointer to translation table</param>
		/// <param name="unk1">Unknown integer parameter</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="unk2">Unknown boolean parameter</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromKV1TextTranslated(ref string error, string input, byte esc_behavior, nint translation, int unk1, string kv_name, Bool8 unk2, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromKV1TextTranslated(Handle, ref error, input, esc_behavior, translation, unk1, kv_name, unk2, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads data from a buffer that may be KV3 or KV1 format
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromKV3OrKV1(ref string error, byte[] input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromKV3OrKV1(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 data from old schema text format
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Vector containing the input buffer data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadFromOldSchemaText(ref string error, byte[] input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadFromOldSchemaText(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Loads KeyValues3 text without a header
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="input">Text string containing KV3 data</param>
		/// <param name="kv_name">Name for the KeyValues3 object</param>
		/// <param name="flags">Loading flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 LoadTextNoHeader(ref string error, string input, string kv_name, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3LoadTextNoHeader(Handle, ref error, input, kv_name, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data to a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output buffer data</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 Save(ref string error, ref byte[] output, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3Save(Handle, ref error, ref output, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data as JSON to a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output JSON data</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveAsJSON(ref string error, ref byte[] output)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveAsJSON(Handle, ref error, ref output);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data as a JSON string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the JSON output</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveAsJSONString(ref string error, ref string output)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveAsJSONString(Handle, ref error, ref output);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data as KeyValues1 text to a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output KV1 text data</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveAsKV1Text(ref string error, ref byte[] output, byte esc_behavior)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveAsKV1Text(Handle, ref error, ref output, esc_behavior);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data as KeyValues1 text with translation to a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output KV1 text data</param>
		/// <param name="esc_behavior">Escape sequence behavior for KV1 text</param>
		/// <param name="translation">Pointer to translation table</param>
		/// <param name="unk">Unknown integer parameter</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveAsKV1TextTranslated(ref string error, ref byte[] output, byte esc_behavior, nint translation, int unk)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveAsKV1TextTranslated(Handle, ref error, ref output, esc_behavior, translation, unk);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 text without a header to a buffer
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">Vector to store the output text data</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveTextNoHeaderToBuffer(ref string error, ref byte[] output, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveTextNoHeaderToBuffer(Handle, ref error, ref output, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 text without a header to a string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the text output</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveTextNoHeader(ref string error, ref string output, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveTextNoHeader(Handle, ref error, ref output, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 text to a string
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="output">String to store the text output</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveTextToString(ref string error, ref string output, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveTextToString(Handle, ref error, ref output, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Saves KeyValues3 data to a file
		/// </summary>
		/// <param name="error">Output string for error messages</param>
		/// <param name="filename">Name of the file to save</param>
		/// <param name="path">Path to save the file</param>
		/// <param name="flags">Saving flags</param>
		/// <returns>true if successful, false otherwise</returns>
		public Bool8 SaveToFile(ref string error, string filename, string path, uint flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv3SaveToFile(Handle, ref error, filename, path, flags);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

	}

#pragma warning restore CS0649
}
