using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: cvars)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a new console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value of the console variable.</param>
		/// <param name="description">A description of the console variable's purpose.</param>
		/// <param name="flags">Additional flags for the console variable.</param>
		/// <returns>A handle to the created console variable.</returns>
		internal static delegate*<string, object, string, ConVarFlag, ulong> CreateConVar = &___CreateConVar;
		internal static delegate* unmanaged[Cdecl]<String192*, Variant256*, String192*, ConVarFlag, ulong> __CreateConVar;
		private static ulong ___CreateConVar(string name, object defaultValue, string description, ConVarFlag flags)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __defaultValue = NativeMethods.ConstructVariant(defaultValue);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVar(&__name, &__defaultValue, &__description, flags);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyVariant(&__defaultValue);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new boolean console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, Bool8, string, ConVarFlag, Bool8, Bool8, Bool8, Bool8, ulong> CreateConVarBool = &___CreateConVarBool;
		internal static delegate* unmanaged[Cdecl]<String192*, Bool8, String192*, ConVarFlag, Bool8, Bool8, Bool8, Bool8, ulong> __CreateConVarBool;
		private static ulong ___CreateConVarBool(string name, Bool8 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Bool8 min, Bool8 hasMax, Bool8 max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarBool(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 16-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, short, string, ConVarFlag, Bool8, short, Bool8, short, ulong> CreateConVarInt16 = &___CreateConVarInt16;
		internal static delegate* unmanaged[Cdecl]<String192*, short, String192*, ConVarFlag, Bool8, short, Bool8, short, ulong> __CreateConVarInt16;
		private static ulong ___CreateConVarInt16(string name, short defaultValue, string description, ConVarFlag flags, Bool8 hasMin, short min, Bool8 hasMax, short max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarInt16(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 16-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, ushort, string, ConVarFlag, Bool8, ushort, Bool8, ushort, ulong> CreateConVarUInt16 = &___CreateConVarUInt16;
		internal static delegate* unmanaged[Cdecl]<String192*, ushort, String192*, ConVarFlag, Bool8, ushort, Bool8, ushort, ulong> __CreateConVarUInt16;
		private static ulong ___CreateConVarUInt16(string name, ushort defaultValue, string description, ConVarFlag flags, Bool8 hasMin, ushort min, Bool8 hasMax, ushort max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarUInt16(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 32-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, int, string, ConVarFlag, Bool8, int, Bool8, int, ulong> CreateConVarInt32 = &___CreateConVarInt32;
		internal static delegate* unmanaged[Cdecl]<String192*, int, String192*, ConVarFlag, Bool8, int, Bool8, int, ulong> __CreateConVarInt32;
		private static ulong ___CreateConVarInt32(string name, int defaultValue, string description, ConVarFlag flags, Bool8 hasMin, int min, Bool8 hasMax, int max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarInt32(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 32-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, uint, string, ConVarFlag, Bool8, uint, Bool8, uint, ulong> CreateConVarUInt32 = &___CreateConVarUInt32;
		internal static delegate* unmanaged[Cdecl]<String192*, uint, String192*, ConVarFlag, Bool8, uint, Bool8, uint, ulong> __CreateConVarUInt32;
		private static ulong ___CreateConVarUInt32(string name, uint defaultValue, string description, ConVarFlag flags, Bool8 hasMin, uint min, Bool8 hasMax, uint max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarUInt32(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 64-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, long, string, ConVarFlag, Bool8, long, Bool8, long, ulong> CreateConVarInt64 = &___CreateConVarInt64;
		internal static delegate* unmanaged[Cdecl]<String192*, long, String192*, ConVarFlag, Bool8, long, Bool8, long, ulong> __CreateConVarInt64;
		private static ulong ___CreateConVarInt64(string name, long defaultValue, string description, ConVarFlag flags, Bool8 hasMin, long min, Bool8 hasMax, long max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarInt64(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 64-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, ulong, string, ConVarFlag, Bool8, ulong, Bool8, ulong, ulong> CreateConVarUInt64 = &___CreateConVarUInt64;
		internal static delegate* unmanaged[Cdecl]<String192*, ulong, String192*, ConVarFlag, Bool8, ulong, Bool8, ulong, ulong> __CreateConVarUInt64;
		private static ulong ___CreateConVarUInt64(string name, ulong defaultValue, string description, ConVarFlag flags, Bool8 hasMin, ulong min, Bool8 hasMax, ulong max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarUInt64(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new floating-point console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, float, string, ConVarFlag, Bool8, float, Bool8, float, ulong> CreateConVarFloat = &___CreateConVarFloat;
		internal static delegate* unmanaged[Cdecl]<String192*, float, String192*, ConVarFlag, Bool8, float, Bool8, float, ulong> __CreateConVarFloat;
		private static ulong ___CreateConVarFloat(string name, float defaultValue, string description, ConVarFlag flags, Bool8 hasMin, float min, Bool8 hasMax, float max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarFloat(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new double-precision console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, double, string, ConVarFlag, Bool8, double, Bool8, double, ulong> CreateConVarDouble = &___CreateConVarDouble;
		internal static delegate* unmanaged[Cdecl]<String192*, double, String192*, ConVarFlag, Bool8, double, Bool8, double, ulong> __CreateConVarDouble;
		private static ulong ___CreateConVarDouble(string name, double defaultValue, string description, ConVarFlag flags, Bool8 hasMin, double min, Bool8 hasMax, double max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarDouble(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new color console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default color value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum color value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum color value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, int, string, ConVarFlag, Bool8, int, Bool8, int, ulong> CreateConVarColor = &___CreateConVarColor;
		internal static delegate* unmanaged[Cdecl]<String192*, int, String192*, ConVarFlag, Bool8, int, Bool8, int, ulong> __CreateConVarColor;
		private static ulong ___CreateConVarColor(string name, int defaultValue, string description, ConVarFlag flags, Bool8 hasMin, int min, Bool8 hasMax, int max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarColor(&__name, defaultValue, &__description, flags, hasMin, min, hasMax, max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 2D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, Vector2, string, ConVarFlag, Bool8, Vector2, Bool8, Vector2, ulong> CreateConVarVector2 = &___CreateConVarVector2;
		internal static delegate* unmanaged[Cdecl]<String192*, Vector2*, String192*, ConVarFlag, Bool8, Vector2*, Bool8, Vector2*, ulong> __CreateConVarVector2;
		private static ulong ___CreateConVarVector2(string name, Vector2 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector2 min, Bool8 hasMax, Vector2 max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarVector2(&__name, &defaultValue, &__description, flags, hasMin, &min, hasMax, &max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 3D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, Vector3, string, ConVarFlag, Bool8, Vector3, Bool8, Vector3, ulong> CreateConVarVector3 = &___CreateConVarVector3;
		internal static delegate* unmanaged[Cdecl]<String192*, Vector3*, String192*, ConVarFlag, Bool8, Vector3*, Bool8, Vector3*, ulong> __CreateConVarVector3;
		private static ulong ___CreateConVarVector3(string name, Vector3 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector3 min, Bool8 hasMax, Vector3 max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarVector3(&__name, &defaultValue, &__description, flags, hasMin, &min, hasMax, &max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new 4D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, Vector4, string, ConVarFlag, Bool8, Vector4, Bool8, Vector4, ulong> CreateConVarVector4 = &___CreateConVarVector4;
		internal static delegate* unmanaged[Cdecl]<String192*, Vector4*, String192*, ConVarFlag, Bool8, Vector4*, Bool8, Vector4*, ulong> __CreateConVarVector4;
		private static ulong ___CreateConVarVector4(string name, Vector4 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector4 min, Bool8 hasMax, Vector4 max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarVector4(&__name, &defaultValue, &__description, flags, hasMin, &min, hasMax, &max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new quaternion angle console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		/// <returns>A handle to the created console variable data.</returns>
		internal static delegate*<string, Vector3, string, ConVarFlag, Bool8, Vector3, Bool8, Vector3, ulong> CreateConVarQAngle = &___CreateConVarQAngle;
		internal static delegate* unmanaged[Cdecl]<String192*, Vector3*, String192*, ConVarFlag, Bool8, Vector3*, Bool8, Vector3*, ulong> __CreateConVarQAngle;
		private static ulong ___CreateConVarQAngle(string name, Vector3 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector3 min, Bool8 hasMax, Vector3 max)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarQAngle(&__name, &defaultValue, &__description, flags, hasMin, &min, hasMax, &max);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new string console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value of the console variable.</param>
		/// <param name="description">A description of the console variable's purpose.</param>
		/// <param name="flags">Additional flags for the console variable.</param>
		/// <returns>A handle to the created console variable.</returns>
		internal static delegate*<string, string, string, ConVarFlag, ulong> CreateConVarString = &___CreateConVarString;
		internal static delegate* unmanaged[Cdecl]<String192*, String192*, String192*, ConVarFlag, ulong> __CreateConVarString;
		private static ulong ___CreateConVarString(string name, string defaultValue, string description, ConVarFlag flags)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			var __defaultValue = NativeMethods.ConstructString(defaultValue);
			var __description = NativeMethods.ConstructString(description);
			try {
				__retVal = __CreateConVarString(&__name, &__defaultValue, &__description, flags);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__defaultValue);
				NativeMethods.DestroyString(&__description);
			}
			return __retVal;
		}

		/// <summary>
		/// Searches for a console variable.
		/// </summary>
		/// <param name="name">The name of the console variable to search for.</param>
		/// <returns>A handle to the console variable data if found; otherwise, nullptr.</returns>
		internal static delegate*<string, ulong> FindConVar = &___FindConVar;
		internal static delegate* unmanaged[Cdecl]<String192*, ulong> __FindConVar;
		private static ulong ___FindConVar(string name)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindConVar(&__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Searches for a console variable of a specific type.
		/// </summary>
		/// <param name="name">The name of the console variable to search for.</param>
		/// <param name="type">The type of the console variable to search for.</param>
		/// <returns>A handle to the console variable data if found; otherwise, nullptr.</returns>
		internal static delegate*<string, ConVarType, ulong> FindConVar2 = &___FindConVar2;
		internal static delegate* unmanaged[Cdecl]<String192*, ConVarType, ulong> __FindConVar2;
		private static ulong ___FindConVar2(string name, ConVarType type)
		{
			ulong __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __FindConVar2(&__name, type);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a hook for when a console variable's value is changed.
		/// </summary>
		/// <param name="conVarHandle">TThe handle to the console variable data.</param>
		/// <param name="callback">The callback function to be executed when the variable's value changes.</param>
		internal static delegate*<ulong, ChangeCallback, void> HookConVarChange = &___HookConVarChange;
		internal static delegate* unmanaged[Cdecl]<ulong, nint, void> __HookConVarChange;
		private static void ___HookConVarChange(ulong conVarHandle, ChangeCallback callback)
		{
			__HookConVarChange(conVarHandle, Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Removes a hook for when a console variable's value is changed.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="callback">The callback function to be removed.</param>
		internal static delegate*<ulong, ChangeCallback, void> UnhookConVarChange = &___UnhookConVarChange;
		internal static delegate* unmanaged[Cdecl]<ulong, nint, void> __UnhookConVarChange;
		private static void ___UnhookConVarChange(ulong conVarHandle, ChangeCallback callback)
		{
			__UnhookConVarChange(conVarHandle, Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Checks if a specific flag is set for a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="flag">The flag to check against the console variable.</param>
		/// <returns>True if the flag is set; otherwise, false.</returns>
		internal static delegate*<ulong, long, Bool8> IsConVarFlagSet = &___IsConVarFlagSet;
		internal static delegate* unmanaged[Cdecl]<ulong, long, Bool8> __IsConVarFlagSet;
		private static Bool8 ___IsConVarFlagSet(ulong conVarHandle, long flag)
		{
			Bool8 __retVal = __IsConVarFlagSet(conVarHandle, flag);
			return __retVal;
		}

		/// <summary>
		/// Adds flags to a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="flags">The flags to be added.</param>
		internal static delegate*<ulong, ConVarFlag, void> AddConVarFlags = &___AddConVarFlags;
		internal static delegate* unmanaged[Cdecl]<ulong, ConVarFlag, void> __AddConVarFlags;
		private static void ___AddConVarFlags(ulong conVarHandle, ConVarFlag flags)
		{
			__AddConVarFlags(conVarHandle, flags);
		}

		/// <summary>
		/// Removes flags from a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="flags">The flags to be removed.</param>
		internal static delegate*<ulong, ConVarFlag, void> RemoveConVarFlags = &___RemoveConVarFlags;
		internal static delegate* unmanaged[Cdecl]<ulong, ConVarFlag, void> __RemoveConVarFlags;
		private static void ___RemoveConVarFlags(ulong conVarHandle, ConVarFlag flags)
		{
			__RemoveConVarFlags(conVarHandle, flags);
		}

		/// <summary>
		/// Retrieves the current flags of a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current flags set on the console variable.</returns>
		internal static delegate*<ulong, ConVarFlag> GetConVarFlags = &___GetConVarFlags;
		internal static delegate* unmanaged[Cdecl]<ulong, ConVarFlag> __GetConVarFlags;
		private static ConVarFlag ___GetConVarFlags(ulong conVarHandle)
		{
			ConVarFlag __retVal = __GetConVarFlags(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Gets the specified bound (max or min) of a console variable and stores it in the output string.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="max">Indicates whether to get the maximum (true) or minimum (false) bound.</param>
		/// <returns>The bound value.</returns>
		internal static delegate*<ulong, Bool8, string> GetConVarBounds = &___GetConVarBounds;
		internal static delegate* unmanaged[Cdecl]<ulong, Bool8, String192> __GetConVarBounds;
		private static string ___GetConVarBounds(ulong conVarHandle, Bool8 max)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetConVarBounds(conVarHandle, max);
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
		/// Sets the specified bound (max or min) for a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="max">Indicates whether to set the maximum (true) or minimum (false) bound.</param>
		/// <param name="value">The value to set as the bound.</param>
		internal static delegate*<ulong, Bool8, string, void> SetConVarBounds = &___SetConVarBounds;
		internal static delegate* unmanaged[Cdecl]<ulong, Bool8, String192*, void> __SetConVarBounds;
		private static void ___SetConVarBounds(ulong conVarHandle, Bool8 max, string value)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetConVarBounds(conVarHandle, max, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Retrieves the default value of a console variable and stores it in the output string.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The output value in string format.</returns>
		internal static delegate*<ulong, string> GetConVarDefault = &___GetConVarDefault;
		internal static delegate* unmanaged[Cdecl]<ulong, String192> __GetConVarDefault;
		private static string ___GetConVarDefault(ulong conVarHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetConVarDefault(conVarHandle);
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
		/// Retrieves the current value of a console variable and stores it in the output string.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The output value in string format.</returns>
		internal static delegate*<ulong, string> GetConVarValue = &___GetConVarValue;
		internal static delegate* unmanaged[Cdecl]<ulong, String192> __GetConVarValue;
		private static string ___GetConVarValue(ulong conVarHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetConVarValue(conVarHandle);
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
		/// Retrieves the current value of a console variable and stores it in the output.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The output value.</returns>
		internal static delegate*<ulong, object> GetConVar = &___GetConVar;
		internal static delegate* unmanaged[Cdecl]<ulong, Variant256> __GetConVar;
		private static object ___GetConVar(ulong conVarHandle)
		{
			object __retVal;
			Variant256 __retVal_native;
			try {
				__retVal_native = __GetConVar(conVarHandle);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetVariantData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVariant(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a boolean console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current boolean value of the console variable.</returns>
		internal static delegate*<ulong, Bool8> GetConVarBool = &___GetConVarBool;
		internal static delegate* unmanaged[Cdecl]<ulong, Bool8> __GetConVarBool;
		private static Bool8 ___GetConVarBool(ulong conVarHandle)
		{
			Bool8 __retVal = __GetConVarBool(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a signed 16-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current int16_t value of the console variable.</returns>
		internal static delegate*<ulong, short> GetConVarInt16 = &___GetConVarInt16;
		internal static delegate* unmanaged[Cdecl]<ulong, short> __GetConVarInt16;
		private static short ___GetConVarInt16(ulong conVarHandle)
		{
			short __retVal = __GetConVarInt16(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 16-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current uint16_t value of the console variable.</returns>
		internal static delegate*<ulong, ushort> GetConVarUInt16 = &___GetConVarUInt16;
		internal static delegate* unmanaged[Cdecl]<ulong, ushort> __GetConVarUInt16;
		private static ushort ___GetConVarUInt16(ulong conVarHandle)
		{
			ushort __retVal = __GetConVarUInt16(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a signed 32-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current int32_t value of the console variable.</returns>
		internal static delegate*<ulong, int> GetConVarInt32 = &___GetConVarInt32;
		internal static delegate* unmanaged[Cdecl]<ulong, int> __GetConVarInt32;
		private static int ___GetConVarInt32(ulong conVarHandle)
		{
			int __retVal = __GetConVarInt32(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 32-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current uint32_t value of the console variable.</returns>
		internal static delegate*<ulong, uint> GetConVarUInt32 = &___GetConVarUInt32;
		internal static delegate* unmanaged[Cdecl]<ulong, uint> __GetConVarUInt32;
		private static uint ___GetConVarUInt32(ulong conVarHandle)
		{
			uint __retVal = __GetConVarUInt32(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a signed 64-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current int64_t value of the console variable.</returns>
		internal static delegate*<ulong, long> GetConVarInt64 = &___GetConVarInt64;
		internal static delegate* unmanaged[Cdecl]<ulong, long> __GetConVarInt64;
		private static long ___GetConVarInt64(ulong conVarHandle)
		{
			long __retVal = __GetConVarInt64(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 64-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current uint64_t value of the console variable.</returns>
		internal static delegate*<ulong, ulong> GetConVarUInt64 = &___GetConVarUInt64;
		internal static delegate* unmanaged[Cdecl]<ulong, ulong> __GetConVarUInt64;
		private static ulong ___GetConVarUInt64(ulong conVarHandle)
		{
			ulong __retVal = __GetConVarUInt64(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a float console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current float value of the console variable.</returns>
		internal static delegate*<ulong, float> GetConVarFloat = &___GetConVarFloat;
		internal static delegate* unmanaged[Cdecl]<ulong, float> __GetConVarFloat;
		private static float ___GetConVarFloat(ulong conVarHandle)
		{
			float __retVal = __GetConVarFloat(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a double console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current double value of the console variable.</returns>
		internal static delegate*<ulong, double> GetConVarDouble = &___GetConVarDouble;
		internal static delegate* unmanaged[Cdecl]<ulong, double> __GetConVarDouble;
		private static double ___GetConVarDouble(ulong conVarHandle)
		{
			double __retVal = __GetConVarDouble(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a string console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current string value of the console variable.</returns>
		internal static delegate*<ulong, string> GetConVarString = &___GetConVarString;
		internal static delegate* unmanaged[Cdecl]<ulong, String192> __GetConVarString;
		private static string ___GetConVarString(ulong conVarHandle)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetConVarString(conVarHandle);
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
		/// Retrieves the current value of a Color console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current Color value of the console variable.</returns>
		internal static delegate*<ulong, int> GetConVarColor = &___GetConVarColor;
		internal static delegate* unmanaged[Cdecl]<ulong, int> __GetConVarColor;
		private static int ___GetConVarColor(ulong conVarHandle)
		{
			int __retVal = __GetConVarColor(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a Vector2D console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current Vector2D value of the console variable.</returns>
		internal static delegate*<ulong, Vector2> GetConVarVector2 = &___GetConVarVector2;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector2> __GetConVarVector2;
		private static Vector2 ___GetConVarVector2(ulong conVarHandle)
		{
			Vector2 __retVal = __GetConVarVector2(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a Vector console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current Vector value of the console variable.</returns>
		internal static delegate*<ulong, Vector3> GetConVarVector = &___GetConVarVector;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector3> __GetConVarVector;
		private static Vector3 ___GetConVarVector(ulong conVarHandle)
		{
			Vector3 __retVal = __GetConVarVector(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a Vector4D console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current Vector4D value of the console variable.</returns>
		internal static delegate*<ulong, Vector4> GetConVarVector4 = &___GetConVarVector4;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector4> __GetConVarVector4;
		private static Vector4 ___GetConVarVector4(ulong conVarHandle)
		{
			Vector4 __retVal = __GetConVarVector4(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current value of a QAngle console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <returns>The current QAngle value of the console variable.</returns>
		internal static delegate*<ulong, Vector3> GetConVarQAngle = &___GetConVarQAngle;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector3> __GetConVarQAngle;
		private static Vector3 ___GetConVarQAngle(ulong conVarHandle)
		{
			Vector3 __retVal = __GetConVarQAngle(conVarHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets the value of a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The string value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, string, Bool8, Bool8, void> SetConVarValue = &___SetConVarValue;
		internal static delegate* unmanaged[Cdecl]<ulong, String192*, Bool8, Bool8, void> __SetConVarValue;
		private static void ___SetConVarValue(ulong conVarHandle, string value, Bool8 replicate, Bool8 notify)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetConVarValue(conVarHandle, &__value, replicate, notify);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Sets the value of a console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, object, Bool8, Bool8, void> SetConVar = &___SetConVar;
		internal static delegate* unmanaged[Cdecl]<ulong, Variant256*, Bool8, Bool8, void> __SetConVar;
		private static void ___SetConVar(ulong conVarHandle, object value, Bool8 replicate, Bool8 notify)
		{
			var __value = NativeMethods.ConstructVariant(value);
			try {
				__SetConVar(conVarHandle, &__value, replicate, notify);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVariant(&__value);
			}
		}

		/// <summary>
		/// Sets the value of a boolean console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, Bool8, Bool8, Bool8, void> SetConVarBool = &___SetConVarBool;
		internal static delegate* unmanaged[Cdecl]<ulong, Bool8, Bool8, Bool8, void> __SetConVarBool;
		private static void ___SetConVarBool(ulong conVarHandle, Bool8 value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarBool(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 16-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, short, Bool8, Bool8, void> SetConVarInt16 = &___SetConVarInt16;
		internal static delegate* unmanaged[Cdecl]<ulong, short, Bool8, Bool8, void> __SetConVarInt16;
		private static void ___SetConVarInt16(ulong conVarHandle, short value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarInt16(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 16-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, ushort, Bool8, Bool8, void> SetConVarUInt16 = &___SetConVarUInt16;
		internal static delegate* unmanaged[Cdecl]<ulong, ushort, Bool8, Bool8, void> __SetConVarUInt16;
		private static void ___SetConVarUInt16(ulong conVarHandle, ushort value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarUInt16(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 32-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, int, Bool8, Bool8, void> SetConVarInt32 = &___SetConVarInt32;
		internal static delegate* unmanaged[Cdecl]<ulong, int, Bool8, Bool8, void> __SetConVarInt32;
		private static void ___SetConVarInt32(ulong conVarHandle, int value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarInt32(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 32-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, uint, Bool8, Bool8, void> SetConVarUInt32 = &___SetConVarUInt32;
		internal static delegate* unmanaged[Cdecl]<ulong, uint, Bool8, Bool8, void> __SetConVarUInt32;
		private static void ___SetConVarUInt32(ulong conVarHandle, uint value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarUInt32(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 64-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, long, Bool8, Bool8, void> SetConVarInt64 = &___SetConVarInt64;
		internal static delegate* unmanaged[Cdecl]<ulong, long, Bool8, Bool8, void> __SetConVarInt64;
		private static void ___SetConVarInt64(ulong conVarHandle, long value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarInt64(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 64-bit integer console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, ulong, Bool8, Bool8, void> SetConVarUInt64 = &___SetConVarUInt64;
		internal static delegate* unmanaged[Cdecl]<ulong, ulong, Bool8, Bool8, void> __SetConVarUInt64;
		private static void ___SetConVarUInt64(ulong conVarHandle, ulong value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarUInt64(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a floating-point console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, float, Bool8, Bool8, void> SetConVarFloat = &___SetConVarFloat;
		internal static delegate* unmanaged[Cdecl]<ulong, float, Bool8, Bool8, void> __SetConVarFloat;
		private static void ___SetConVarFloat(ulong conVarHandle, float value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarFloat(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a double-precision floating-point console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, double, Bool8, Bool8, void> SetConVarDouble = &___SetConVarDouble;
		internal static delegate* unmanaged[Cdecl]<ulong, double, Bool8, Bool8, void> __SetConVarDouble;
		private static void ___SetConVarDouble(ulong conVarHandle, double value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarDouble(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a string console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, string, Bool8, Bool8, void> SetConVarString = &___SetConVarString;
		internal static delegate* unmanaged[Cdecl]<ulong, String192*, Bool8, Bool8, void> __SetConVarString;
		private static void ___SetConVarString(ulong conVarHandle, string value, Bool8 replicate, Bool8 notify)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SetConVarString(conVarHandle, &__value, replicate, notify);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Sets the value of a color console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, int, Bool8, Bool8, void> SetConVarColor = &___SetConVarColor;
		internal static delegate* unmanaged[Cdecl]<ulong, int, Bool8, Bool8, void> __SetConVarColor;
		private static void ___SetConVarColor(ulong conVarHandle, int value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarColor(conVarHandle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 2D vector console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, Vector2, Bool8, Bool8, void> SetConVarVector2 = &___SetConVarVector2;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector2*, Bool8, Bool8, void> __SetConVarVector2;
		private static void ___SetConVarVector2(ulong conVarHandle, Vector2 value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarVector2(conVarHandle, &value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 3D vector console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, Vector3, Bool8, Bool8, void> SetConVarVector3 = &___SetConVarVector3;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector3*, Bool8, Bool8, void> __SetConVarVector3;
		private static void ___SetConVarVector3(ulong conVarHandle, Vector3 value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarVector3(conVarHandle, &value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 4D vector console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, Vector4, Bool8, Bool8, void> SetConVarVector4 = &___SetConVarVector4;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector4*, Bool8, Bool8, void> __SetConVarVector4;
		private static void ___SetConVarVector4(ulong conVarHandle, Vector4 value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarVector4(conVarHandle, &value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a quaternion angle console variable.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		internal static delegate*<ulong, Vector3, Bool8, Bool8, void> SetConVarQAngle = &___SetConVarQAngle;
		internal static delegate* unmanaged[Cdecl]<ulong, Vector3*, Bool8, Bool8, void> __SetConVarQAngle;
		private static void ___SetConVarQAngle(ulong conVarHandle, Vector3 value, Bool8 replicate, Bool8 notify)
		{
			__SetConVarQAngle(conVarHandle, &value, replicate, notify);
		}

		/// <summary>
		/// Replicates a console variable value to a specific client. This does not change the actual console variable value.
		/// </summary>
		/// <param name="playerSlot">The index of the client to replicate the value to.</param>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="value">The value to send to the client.</param>
		internal static delegate*<int, ulong, string, void> SendConVarValue = &___SendConVarValue;
		internal static delegate* unmanaged[Cdecl]<int, ulong, String192*, void> __SendConVarValue;
		private static void ___SendConVarValue(int playerSlot, ulong conVarHandle, string value)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SendConVarValue(playerSlot, conVarHandle, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Replicates a console variable value to a specific client. This does not change the actual console variable value.
		/// </summary>
		/// <param name="conVarHandle">The handle to the console variable data.</param>
		/// <param name="playerSlot">The index of the client to replicate the value to.</param>
		/// <param name="value">The value to send to the client.</param>
		internal static delegate*<ulong, int, string, void> SendConVarValue2 = &___SendConVarValue2;
		internal static delegate* unmanaged[Cdecl]<ulong, int, String192*, void> __SendConVarValue2;
		private static void ___SendConVarValue2(ulong conVarHandle, int playerSlot, string value)
		{
			var __value = NativeMethods.ConstructString(value);
			try {
				__SendConVarValue2(conVarHandle, playerSlot, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Retrieves the value of a client's console variable and stores it in the output string.
		/// </summary>
		/// <param name="playerSlot">The index of the client whose console variable value is being retrieved.</param>
		/// <param name="convarName">The name of the console variable to retrieve.</param>
		/// <returns>The output string to store the client's console variable value.</returns>
		internal static delegate*<int, string, string> GetClientConVarValue = &___GetClientConVarValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192> __GetClientConVarValue;
		private static string ___GetClientConVarValue(int playerSlot, string convarName)
		{
			string __retVal;
			String192 __retVal_native;
			var __convarName = NativeMethods.ConstructString(convarName);
			try {
				__retVal_native = __GetClientConVarValue(playerSlot, &__convarName);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__convarName);
			}
			return __retVal;
		}

		/// <summary>
		/// Replicates a console variable value to a specific fake client. This does not change the actual console variable value.
		/// </summary>
		/// <param name="playerSlot">The index of the fake client to replicate the value to.</param>
		/// <param name="convarName">The name of the console variable.</param>
		/// <param name="convarValue">The value to set for the console variable.</param>
		internal static delegate*<int, string, string, void> SetFakeClientConVarValue = &___SetFakeClientConVarValue;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __SetFakeClientConVarValue;
		private static void ___SetFakeClientConVarValue(int playerSlot, string convarName, string convarValue)
		{
			var __convarName = NativeMethods.ConstructString(convarName);
			var __convarValue = NativeMethods.ConstructString(convarValue);
			try {
				__SetFakeClientConVarValue(playerSlot, &__convarName, &__convarValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__convarName);
				NativeMethods.DestroyString(&__convarValue);
			}
		}

		/// <summary>
		/// Starts a query to retrieve the value of a client's console variable.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query the value from.</param>
		/// <param name="convarName">The name of client convar to query.</param>
		/// <param name="callback">A function to use as a callback when the query has finished.</param>
		/// <param name="data">Optional values to pass to the callback function.</param>
		/// <returns>A cookie that uniquely identifies the query. Returns -1 on failure, such as when used on a bot.</returns>
		internal static delegate*<int, string, CvarValueCallback, object[], int> QueryClientConVar = &___QueryClientConVar;
		internal static delegate* unmanaged[Cdecl]<int, String192*, nint, Vector192*, int> __QueryClientConVar;
		private static int ___QueryClientConVar(int playerSlot, string convarName, CvarValueCallback callback, object[] data)
		{
			int __retVal;
			var __convarName = NativeMethods.ConstructString(convarName);
			var __data = NativeMethods.ConstructVectorVariant(data, data.Length);
			try {
				__retVal = __QueryClientConVar(playerSlot, &__convarName, Marshalling.GetFunctionPointerForDelegate(callback), &__data);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__convarName);
				NativeMethods.DestroyVectorVariant(&__data);
			}
			return __retVal;
		}

		/// <summary>
		///  Specifies that the given config file should be executed.
		/// </summary>
		/// <param name="conVarHandles">List of handles to the console variable data.</param>
		/// <param name="autoCreate">If true, and the config file does not exist, such a config file will be automatically created and populated with information from the plugin's registered cvars.</param>
		/// <param name="name">Name of the config file, excluding the .cfg extension. Cannot be empty.</param>
		/// <param name="folder">Folder under cfg/ to use. By default this is "plugify." Can be empty.</param>
		/// <returns>True on success, false otherwise.</returns>
		internal static delegate*<ulong[], Bool8, string, string, Bool8> AutoExecConfig = &___AutoExecConfig;
		internal static delegate* unmanaged[Cdecl]<Vector192*, Bool8, String192*, String192*, Bool8> __AutoExecConfig;
		private static Bool8 ___AutoExecConfig(ulong[] conVarHandles, Bool8 autoCreate, string name, string folder)
		{
			Bool8 __retVal;
			var __conVarHandles = NativeMethods.ConstructVectorUInt64(conVarHandles, conVarHandles.Length);
			var __name = NativeMethods.ConstructString(name);
			var __folder = NativeMethods.ConstructString(folder);
			try {
				__retVal = __AutoExecConfig(&__conVarHandles, autoCreate, &__name, &__folder);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorUInt64(&__conVarHandles);
				NativeMethods.DestroyString(&__name);
				NativeMethods.DestroyString(&__folder);
			}
			return __retVal;
		}

		/// <summary>
		/// Returns the current server language.
		/// </summary>
		/// <returns>The server language as a string.</returns>
		internal static delegate*<string> GetServerLanguage = &___GetServerLanguage;
		internal static delegate* unmanaged[Cdecl]<String192> __GetServerLanguage;
		private static string ___GetServerLanguage()
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetServerLanguage();
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for ConVar handle.
	/// </summary>
	internal sealed unsafe class ConVar
	{
		private ulong handle;

		/// <summary>
		/// Creates a new console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value of the console variable.</param>
		/// <param name="description">A description of the console variable's purpose.</param>
		/// <param name="flags">Additional flags for the console variable.</param>
		public ConVar(string name, object defaultValue, string description, ConVarFlag flags)
		{
			this.handle = s2sdk.CreateConVar(name, defaultValue, description, flags);
		}

		/// <summary>
		/// Creates a new boolean console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, Bool8 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Bool8 min, Bool8 hasMax, Bool8 max)
		{
			this.handle = s2sdk.CreateConVarBool(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 16-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, short defaultValue, string description, ConVarFlag flags, Bool8 hasMin, short min, Bool8 hasMax, short max)
		{
			this.handle = s2sdk.CreateConVarInt16(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 16-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, ushort defaultValue, string description, ConVarFlag flags, Bool8 hasMin, ushort min, Bool8 hasMax, ushort max)
		{
			this.handle = s2sdk.CreateConVarUInt16(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 32-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, int defaultValue, string description, ConVarFlag flags, Bool8 hasMin, int min, Bool8 hasMax, int max)
		{
			this.handle = s2sdk.CreateConVarInt32(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 32-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, uint defaultValue, string description, ConVarFlag flags, Bool8 hasMin, uint min, Bool8 hasMax, uint max)
		{
			this.handle = s2sdk.CreateConVarUInt32(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 64-bit signed integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, long defaultValue, string description, ConVarFlag flags, Bool8 hasMin, long min, Bool8 hasMax, long max)
		{
			this.handle = s2sdk.CreateConVarInt64(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 64-bit unsigned integer console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, ulong defaultValue, string description, ConVarFlag flags, Bool8 hasMin, ulong min, Bool8 hasMax, ulong max)
		{
			this.handle = s2sdk.CreateConVarUInt64(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new floating-point console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, float defaultValue, string description, ConVarFlag flags, Bool8 hasMin, float min, Bool8 hasMax, float max)
		{
			this.handle = s2sdk.CreateConVarFloat(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new double-precision console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, double defaultValue, string description, ConVarFlag flags, Bool8 hasMin, double min, Bool8 hasMax, double max)
		{
			this.handle = s2sdk.CreateConVarDouble(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 2D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, Vector2 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector2 min, Bool8 hasMax, Vector2 max)
		{
			this.handle = s2sdk.CreateConVarVector2(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 3D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, Vector3 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector3 min, Bool8 hasMax, Vector3 max)
		{
			this.handle = s2sdk.CreateConVarVector3(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new 4D vector console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value for the console variable.</param>
		/// <param name="description">A brief description of the console variable.</param>
		/// <param name="flags">Flags that define the behavior of the console variable.</param>
		/// <param name="hasMin">Indicates if a minimum value is provided.</param>
		/// <param name="min">The minimum value if hasMin is true.</param>
		/// <param name="hasMax">Indicates if a maximum value is provided.</param>
		/// <param name="max">The maximum value if hasMax is true.</param>
		public ConVar(string name, Vector4 defaultValue, string description, ConVarFlag flags, Bool8 hasMin, Vector4 min, Bool8 hasMax, Vector4 max)
		{
			this.handle = s2sdk.CreateConVarVector4(name, defaultValue, description, flags, hasMin, min, hasMax, max);
		}

		/// <summary>
		/// Creates a new string console variable.
		/// </summary>
		/// <param name="name">The name of the console variable.</param>
		/// <param name="defaultValue">The default value of the console variable.</param>
		/// <param name="description">A description of the console variable's purpose.</param>
		/// <param name="flags">Additional flags for the console variable.</param>
		public ConVar(string name, string defaultValue, string description, ConVarFlag flags)
		{
			this.handle = s2sdk.CreateConVarString(name, defaultValue, description, flags);
		}

		/// <summary>
		/// Internal constructor for creating ConVar from existing handle
		/// </summary>
		public ConVar(ulong handle, Ownership ownership = Ownership.Borrowed)
		{
			this.handle = handle;
		}

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public ulong Handle => handle;

		/// <summary>
		/// Checks if the handle is valid
		/// </summary>
		public bool IsValid => handle != 0;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public ulong Get() => handle;

		/// <summary>
		/// Releases ownership of the handle and returns it
		/// </summary>
		public ulong Release()
		{
			var h = handle;
			handle = 0;
			return h;
		}

		/// <summary>
		/// Resets the handle to invalid
		/// </summary>
		public void Reset()
		{
			handle = 0;
		}

		/// <summary>
		/// Searches for a console variable.
		/// </summary>
		/// <param name="name">The name of the console variable to search for.</param>
		/// <returns>A handle to the console variable data if found; otherwise, nullptr.</returns>
		public static ConVar Find(string name)
		{
			return new ConVar(s2sdk.FindConVar(name), Ownership.Borrowed);
		}

		/// <summary>
		/// Searches for a console variable of a specific type.
		/// </summary>
		/// <param name="name">The name of the console variable to search for.</param>
		/// <param name="type">The type of the console variable to search for.</param>
		/// <returns>A handle to the console variable data if found; otherwise, nullptr.</returns>
		public static ConVar Find2(string name, ConVarType type)
		{
			return new ConVar(s2sdk.FindConVar2(name, type), Ownership.Borrowed);
		}

		/// <summary>
		/// Creates a hook for when a console variable's value is changed.
		/// </summary>
		/// <param name="callback">The callback function to be executed when the variable's value changes.</param>
		public void HookChange(ChangeCallback callback)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.HookConVarChange(handle, callback);
		}

		/// <summary>
		/// Removes a hook for when a console variable's value is changed.
		/// </summary>
		/// <param name="callback">The callback function to be removed.</param>
		public void UnhookChange(ChangeCallback callback)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.UnhookConVarChange(handle, callback);
		}

		/// <summary>
		/// Checks if a specific flag is set for a console variable.
		/// </summary>
		/// <param name="flag">The flag to check against the console variable.</param>
		/// <returns>True if the flag is set; otherwise, false.</returns>
		public Bool8 IsFlagSet(long flag)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.IsConVarFlagSet(handle, flag);
		}

		/// <summary>
		/// Adds flags to a console variable.
		/// </summary>
		/// <param name="flags">The flags to be added.</param>
		public void AddFlags(ConVarFlag flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.AddConVarFlags(handle, flags);
		}

		/// <summary>
		/// Removes flags from a console variable.
		/// </summary>
		/// <param name="flags">The flags to be removed.</param>
		public void RemoveFlags(ConVarFlag flags)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.RemoveConVarFlags(handle, flags);
		}

		/// <summary>
		/// Retrieves the current flags of a console variable.
		/// </summary>
		/// <returns>The current flags set on the console variable.</returns>
		public ConVarFlag GetFlags()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarFlags(handle);
		}

		/// <summary>
		/// Gets the specified bound (max or min) of a console variable and stores it in the output string.
		/// </summary>
		/// <param name="max">Indicates whether to get the maximum (true) or minimum (false) bound.</param>
		/// <returns>The bound value.</returns>
		public string GetBounds(Bool8 max)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarBounds(handle, max);
		}

		/// <summary>
		/// Sets the specified bound (max or min) for a console variable.
		/// </summary>
		/// <param name="max">Indicates whether to set the maximum (true) or minimum (false) bound.</param>
		/// <param name="value">The value to set as the bound.</param>
		public void SetBounds(Bool8 max, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarBounds(handle, max, value);
		}

		/// <summary>
		/// Retrieves the default value of a console variable and stores it in the output string.
		/// </summary>
		/// <returns>The output value in string format.</returns>
		public string GetDefault()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarDefault(handle);
		}

		/// <summary>
		/// Retrieves the current value of a console variable and stores it in the output string.
		/// </summary>
		/// <returns>The output value in string format.</returns>
		public string GetValue()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarValue(handle);
		}

		/// <summary>
		/// Retrieves the current value of a console variable and stores it in the output.
		/// </summary>
		/// <returns>The output value.</returns>
		public object GetObject()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVar(handle);
		}

		/// <summary>
		/// Retrieves the current value of a boolean console variable.
		/// </summary>
		/// <returns>The current boolean value of the console variable.</returns>
		public Bool8 GetBool()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarBool(handle);
		}

		/// <summary>
		/// Retrieves the current value of a signed 16-bit integer console variable.
		/// </summary>
		/// <returns>The current int16_t value of the console variable.</returns>
		public short GetInt16()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarInt16(handle);
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 16-bit integer console variable.
		/// </summary>
		/// <returns>The current uint16_t value of the console variable.</returns>
		public ushort GetUInt16()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarUInt16(handle);
		}

		/// <summary>
		/// Retrieves the current value of a signed 32-bit integer console variable.
		/// </summary>
		/// <returns>The current int32_t value of the console variable.</returns>
		public int GetInt32()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarInt32(handle);
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 32-bit integer console variable.
		/// </summary>
		/// <returns>The current uint32_t value of the console variable.</returns>
		public uint GetUInt32()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarUInt32(handle);
		}

		/// <summary>
		/// Retrieves the current value of a signed 64-bit integer console variable.
		/// </summary>
		/// <returns>The current int64_t value of the console variable.</returns>
		public long GetInt64()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarInt64(handle);
		}

		/// <summary>
		/// Retrieves the current value of an unsigned 64-bit integer console variable.
		/// </summary>
		/// <returns>The current uint64_t value of the console variable.</returns>
		public ulong GetUInt64()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarUInt64(handle);
		}

		/// <summary>
		/// Retrieves the current value of a float console variable.
		/// </summary>
		/// <returns>The current float value of the console variable.</returns>
		public float GetFloat()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarFloat(handle);
		}

		/// <summary>
		/// Retrieves the current value of a double console variable.
		/// </summary>
		/// <returns>The current double value of the console variable.</returns>
		public double GetDouble()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarDouble(handle);
		}

		/// <summary>
		/// Retrieves the current value of a string console variable.
		/// </summary>
		/// <returns>The current string value of the console variable.</returns>
		public string GetString()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarString(handle);
		}

		/// <summary>
		/// Retrieves the current value of a Color console variable.
		/// </summary>
		/// <returns>The current Color value of the console variable.</returns>
		public int GetColor()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarColor(handle);
		}

		/// <summary>
		/// Retrieves the current value of a Vector2D console variable.
		/// </summary>
		/// <returns>The current Vector2D value of the console variable.</returns>
		public Vector2 GetVector2()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarVector2(handle);
		}

		/// <summary>
		/// Retrieves the current value of a Vector console variable.
		/// </summary>
		/// <returns>The current Vector value of the console variable.</returns>
		public Vector3 GetVector()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarVector(handle);
		}

		/// <summary>
		/// Retrieves the current value of a Vector4D console variable.
		/// </summary>
		/// <returns>The current Vector4D value of the console variable.</returns>
		public Vector4 GetVector4()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarVector4(handle);
		}

		/// <summary>
		/// Retrieves the current value of a QAngle console variable.
		/// </summary>
		/// <returns>The current QAngle value of the console variable.</returns>
		public Vector3 GetQAngle()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetConVarQAngle(handle);
		}

		/// <summary>
		/// Sets the value of a console variable.
		/// </summary>
		/// <param name="value">The string value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetValue(string value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarValue(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void Set(object value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVar(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a boolean console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetBool(Bool8 value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarBool(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 16-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetInt16(short value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarInt16(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 16-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetUInt16(ushort value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarUInt16(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 32-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetInt32(int value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarInt32(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 32-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetUInt32(uint value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarUInt32(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a signed 64-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetInt64(long value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarInt64(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of an unsigned 64-bit integer console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetUInt64(ulong value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarUInt64(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a floating-point console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetFloat(float value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarFloat(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a double-precision floating-point console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetDouble(double value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarDouble(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a string console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetString(string value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarString(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a color console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetColor(int value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarColor(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 2D vector console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetVector2(Vector2 value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarVector2(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 3D vector console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetVector3(Vector3 value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarVector3(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a 4D vector console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetVector4(Vector4 value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarVector4(handle, value, replicate, notify);
		}

		/// <summary>
		/// Sets the value of a quaternion angle console variable.
		/// </summary>
		/// <param name="value">The value to set for the console variable.</param>
		/// <param name="replicate">If set to true, the new convar value will be set on all clients. This will only work if the convar has the FCVAR_REPLICATED flag and actually exists on clients.</param>
		/// <param name="notify">If set to true, clients will be notified that the convar has changed. This will only work if the convar has the FCVAR_NOTIFY flag.</param>
		public void SetQAngle(Vector3 value, Bool8 replicate, Bool8 notify)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetConVarQAngle(handle, value, replicate, notify);
		}

		/// <summary>
		/// Replicates a console variable value to a specific client. This does not change the actual console variable value.
		/// </summary>
		/// <param name="playerSlot">The index of the client to replicate the value to.</param>
		/// <param name="value">The value to send to the client.</param>
		public void SendValue(int playerSlot, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SendConVarValue2(handle, playerSlot, value);
		}

		/// <summary>
		/// Retrieves the value of a client's console variable and stores it in the output string.
		/// </summary>
		/// <param name="playerSlot">The index of the client whose console variable value is being retrieved.</param>
		/// <param name="convarName">The name of the console variable to retrieve.</param>
		/// <returns>The output string to store the client's console variable value.</returns>
		public static string GetClientValue(int playerSlot, string convarName)
		{
			return s2sdk.GetClientConVarValue(playerSlot, convarName);
		}

		/// <summary>
		/// Replicates a console variable value to a specific fake client. This does not change the actual console variable value.
		/// </summary>
		/// <param name="playerSlot">The index of the fake client to replicate the value to.</param>
		/// <param name="convarName">The name of the console variable.</param>
		/// <param name="convarValue">The value to set for the console variable.</param>
		public static void SetFakeClientValue(int playerSlot, string convarName, string convarValue)
		{
			s2sdk.SetFakeClientConVarValue(playerSlot, convarName, convarValue);
		}

	}

#pragma warning restore CS0649
}
