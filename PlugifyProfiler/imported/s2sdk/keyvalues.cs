using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: keyvalues)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a new KeyValues instance
		/// </summary>
		/// <param name="setName">The name to assign to this KeyValues instance</param>
		/// <returns>Pointer to the newly created KeyValues object</returns>
		internal static delegate*<string, nint> Kv1Create = &___Kv1Create;
		internal static delegate* unmanaged[Cdecl]<String192*, nint> __Kv1Create;
		private static nint ___Kv1Create(string setName)
		{
			nint __retVal;
			var __setName = NativeMethods.ConstructString(setName);
			try {
				__retVal = __Kv1Create(&__setName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__setName);
			}
			return __retVal;
		}

		/// <summary>
		/// Destroys a KeyValues instance
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to destroy</param>
		internal static delegate*<nint, void> Kv1Destroy = &___Kv1Destroy;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv1Destroy;
		private static void ___Kv1Destroy(nint kv)
		{
			__Kv1Destroy(kv);
		}

		/// <summary>
		/// Gets the section name of a KeyValues instance
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <returns>The name of the KeyValues section</returns>
		internal static delegate*<nint, string> Kv1GetName = &___Kv1GetName;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __Kv1GetName;
		private static string ___Kv1GetName(nint kv)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __Kv1GetName(kv);
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
		/// Sets the section name of a KeyValues instance
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="name">The new name to assign to this KeyValues section</param>
		internal static delegate*<nint, string, void> Kv1SetName = &___Kv1SetName;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, void> __Kv1SetName;
		private static void ___Kv1SetName(nint kv, string name)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__Kv1SetName(kv, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Finds a key by name
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to search in</param>
		/// <param name="keyName">The name of the key to find</param>
		/// <returns>Pointer to the found KeyValues subkey, or NULL if not found</returns>
		internal static delegate*<nint, string, nint> Kv1FindKey = &___Kv1FindKey;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __Kv1FindKey;
		private static nint ___Kv1FindKey(nint kv, string keyName)
		{
			nint __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1FindKey(kv, &__keyName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Finds a key by name or creates it if it doesn't exist
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to search in</param>
		/// <param name="keyName">The name of the key to find or create</param>
		/// <returns>Pointer to the found or newly created KeyValues subkey (never NULL)</returns>
		internal static delegate*<nint, string, nint> Kv1FindOrCreateKey = &___Kv1FindOrCreateKey;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __Kv1FindOrCreateKey;
		private static nint ___Kv1FindOrCreateKey(nint kv, string keyName)
		{
			nint __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1FindOrCreateKey(kv, &__keyName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new subkey with the specified name
		/// </summary>
		/// <param name="kv">Pointer to the parent KeyValues object</param>
		/// <param name="keyName">The name for the new key</param>
		/// <returns>Pointer to the newly created KeyValues subkey</returns>
		internal static delegate*<nint, string, nint> Kv1CreateKey = &___Kv1CreateKey;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint> __Kv1CreateKey;
		private static nint ___Kv1CreateKey(nint kv, string keyName)
		{
			nint __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1CreateKey(kv, &__keyName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a new subkey with an autogenerated name
		/// </summary>
		/// <param name="kv">Pointer to the parent KeyValues object</param>
		/// <returns>Pointer to the newly created KeyValues subkey</returns>
		internal static delegate*<nint, nint> Kv1CreateNewKey = &___Kv1CreateNewKey;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv1CreateNewKey;
		private static nint ___Kv1CreateNewKey(nint kv)
		{
			nint __retVal = __Kv1CreateNewKey(kv);
			return __retVal;
		}

		/// <summary>
		/// Adds a subkey to this KeyValues instance
		/// </summary>
		/// <param name="kv">Pointer to the parent KeyValues object</param>
		/// <param name="subKey">Pointer to the KeyValues object to add as a child</param>
		internal static delegate*<nint, nint, void> Kv1AddSubKey = &___Kv1AddSubKey;
		internal static delegate* unmanaged[Cdecl]<nint, nint, void> __Kv1AddSubKey;
		private static void ___Kv1AddSubKey(nint kv, nint subKey)
		{
			__Kv1AddSubKey(kv, subKey);
		}

		/// <summary>
		/// Gets the first subkey in the list
		/// </summary>
		/// <param name="kv">Pointer to the parent KeyValues object</param>
		/// <returns>Pointer to the first subkey, or NULL if there are no children</returns>
		internal static delegate*<nint, nint> Kv1GetFirstSubKey = &___Kv1GetFirstSubKey;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv1GetFirstSubKey;
		private static nint ___Kv1GetFirstSubKey(nint kv)
		{
			nint __retVal = __Kv1GetFirstSubKey(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets the next sibling key in the list
		/// </summary>
		/// <param name="kv">Pointer to the current KeyValues object</param>
		/// <returns>Pointer to the next sibling key, or NULL if this is the last sibling</returns>
		internal static delegate*<nint, nint> Kv1GetNextKey = &___Kv1GetNextKey;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv1GetNextKey;
		private static nint ___Kv1GetNextKey(nint kv)
		{
			nint __retVal = __Kv1GetNextKey(kv);
			return __retVal;
		}

		/// <summary>
		/// Gets a color value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the color from</param>
		/// <param name="defaultValue">The default color value to return if the key is not found</param>
		/// <returns>The color value as a 32-bit integer (RGBA)</returns>
		internal static delegate*<nint, string, int, int> Kv1GetColor = &___Kv1GetColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __Kv1GetColor;
		private static int ___Kv1GetColor(nint kv, string keyName, int defaultValue)
		{
			int __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1GetColor(kv, &__keyName, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a color value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the color for</param>
		/// <param name="value">The color value as a 32-bit integer (RGBA)</param>
		internal static delegate*<nint, string, int, void> Kv1SetColor = &___Kv1SetColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __Kv1SetColor;
		private static void ___Kv1SetColor(nint kv, string keyName, int value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__Kv1SetColor(kv, &__keyName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
		}

		/// <summary>
		/// Gets an integer value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the integer from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The integer value associated with the key, or defaultValue if not found</returns>
		internal static delegate*<nint, string, int, int> Kv1GetInt = &___Kv1GetInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __Kv1GetInt;
		private static int ___Kv1GetInt(nint kv, string keyName, int defaultValue)
		{
			int __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1GetInt(kv, &__keyName, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an integer value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the integer for</param>
		/// <param name="value">The integer value to set</param>
		internal static delegate*<nint, string, int, void> Kv1SetInt = &___Kv1SetInt;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, void> __Kv1SetInt;
		private static void ___Kv1SetInt(nint kv, string keyName, int value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__Kv1SetInt(kv, &__keyName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
		}

		/// <summary>
		/// Gets a float value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the float from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The float value associated with the key, or defaultValue if not found</returns>
		internal static delegate*<nint, string, float, float> Kv1GetFloat = &___Kv1GetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, float> __Kv1GetFloat;
		private static float ___Kv1GetFloat(nint kv, string keyName, float defaultValue)
		{
			float __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1GetFloat(kv, &__keyName, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a float value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the float for</param>
		/// <param name="value">The float value to set</param>
		internal static delegate*<nint, string, float, void> Kv1SetFloat = &___Kv1SetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, void> __Kv1SetFloat;
		private static void ___Kv1SetFloat(nint kv, string keyName, float value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__Kv1SetFloat(kv, &__keyName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
		}

		/// <summary>
		/// Gets a string value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the string from</param>
		/// <param name="defaultValue">The default string to return if the key is not found</param>
		/// <returns>The string value associated with the key, or defaultValue if not found</returns>
		internal static delegate*<nint, string, string, string> Kv1GetString = &___Kv1GetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, String192> __Kv1GetString;
		private static string ___Kv1GetString(nint kv, string keyName, string defaultValue)
		{
			string __retVal;
			String192 __retVal_native;
			var __keyName = NativeMethods.ConstructString(keyName);
			var __defaultValue = NativeMethods.ConstructString(defaultValue);
			try {
				__retVal_native = __Kv1GetString(kv, &__keyName, &__defaultValue);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__keyName);
				NativeMethods.DestroyString(&__defaultValue);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a string value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the string for</param>
		/// <param name="value">The string value to set</param>
		internal static delegate*<nint, string, string, void> Kv1SetString = &___Kv1SetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, void> __Kv1SetString;
		private static void ___Kv1SetString(nint kv, string keyName, string value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__Kv1SetString(kv, &__keyName, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
				NativeMethods.DestroyString(&__value);
			}
		}

		/// <summary>
		/// Gets a pointer value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the pointer from</param>
		/// <param name="defaultValue">The default pointer to return if the key is not found</param>
		/// <returns>The pointer value associated with the key, or defaultValue if not found</returns>
		internal static delegate*<nint, string, nint, nint> Kv1GetPtr = &___Kv1GetPtr;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, nint> __Kv1GetPtr;
		private static nint ___Kv1GetPtr(nint kv, string keyName, nint defaultValue)
		{
			nint __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1GetPtr(kv, &__keyName, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a pointer value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the pointer for</param>
		/// <param name="value">The pointer value to set</param>
		internal static delegate*<nint, string, nint, void> Kv1SetPtr = &___Kv1SetPtr;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, void> __Kv1SetPtr;
		private static void ___Kv1SetPtr(nint kv, string keyName, nint value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__Kv1SetPtr(kv, &__keyName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
		}

		/// <summary>
		/// Gets a boolean value from a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to retrieve the boolean from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The boolean value associated with the key, or defaultValue if not found</returns>
		internal static delegate*<nint, string, Bool8, Bool8> Kv1GetBool = &___Kv1GetBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, Bool8> __Kv1GetBool;
		private static Bool8 ___Kv1GetBool(nint kv, string keyName, Bool8 defaultValue)
		{
			Bool8 __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1GetBool(kv, &__keyName, defaultValue);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a boolean value for a key
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to set the boolean for</param>
		/// <param name="value">The boolean value to set</param>
		internal static delegate*<nint, string, Bool8, void> Kv1SetBool = &___Kv1SetBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, void> __Kv1SetBool;
		private static void ___Kv1SetBool(nint kv, string keyName, Bool8 value)
		{
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__Kv1SetBool(kv, &__keyName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
		}

		/// <summary>
		/// Makes a deep copy of a KeyValues tree
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to copy</param>
		/// <returns>Pointer to the newly allocated copy of the KeyValues tree</returns>
		internal static delegate*<nint, nint> Kv1MakeCopy = &___Kv1MakeCopy;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __Kv1MakeCopy;
		private static nint ___Kv1MakeCopy(nint kv)
		{
			nint __retVal = __Kv1MakeCopy(kv);
			return __retVal;
		}

		/// <summary>
		/// Clears all subkeys and the current value
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to clear</param>
		internal static delegate*<nint, void> Kv1Clear = &___Kv1Clear;
		internal static delegate* unmanaged[Cdecl]<nint, void> __Kv1Clear;
		private static void ___Kv1Clear(nint kv)
		{
			__Kv1Clear(kv);
		}

		/// <summary>
		/// Checks if a key exists and has no value or subkeys
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object</param>
		/// <param name="keyName">The name of the key to check</param>
		/// <returns>true if the key exists and is empty, false otherwise</returns>
		internal static delegate*<nint, string, Bool8> Kv1IsEmpty = &___Kv1IsEmpty;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8> __Kv1IsEmpty;
		private static Bool8 ___Kv1IsEmpty(nint kv, string keyName)
		{
			Bool8 __retVal;
			var __keyName = NativeMethods.ConstructString(keyName);
			try {
				__retVal = __Kv1IsEmpty(kv, &__keyName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__keyName);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for KeyValues pointer.
	/// </summary>
	internal sealed unsafe class KeyValues1 : SafeHandle
	{
		/// <summary>
		/// Creates a new KeyValues instance
		/// </summary>
		/// <param name="setName">The name to assign to this KeyValues instance</param>
		public KeyValues1(string setName) : this(s2sdk.Kv1Create(setName), Ownership.Owned)
		{
		}

		/// <summary>
		/// Makes a deep copy of a KeyValues tree
		/// </summary>
		/// <param name="kv">Pointer to the KeyValues object to copy</param>
		public KeyValues1(nint kv) : this(s2sdk.Kv1MakeCopy(kv), Ownership.Owned)
		{
		}

		/// <summary>
		/// Internal constructor for creating KeyValues1 from existing handle
		/// </summary>
		public KeyValues1(nint handle, Ownership ownership) : base((nint)handle, ownsHandle: ownership == Ownership.Owned)
		{
		}

		/// <summary>
		/// Releases the handle (called automatically by SafeHandle)
		/// </summary>
		protected override bool ReleaseHandle()
		{
			s2sdk.Kv1Destroy((nint)handle);
			return true;
		}

		/// <summary>
		/// Checks if the KeyValues1 has a valid handle
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
		/// Gets the section name of a KeyValues instance
		/// </summary>
		/// <returns>The name of the KeyValues section</returns>
		public string GetName()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetName(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the section name of a KeyValues instance
		/// </summary>
		/// <param name="name">The new name to assign to this KeyValues section</param>
		public void SetName(string name)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetName(Handle, name);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Finds a key by name
		/// </summary>
		/// <param name="keyName">The name of the key to find</param>
		/// <returns>Pointer to the found KeyValues subkey, or NULL if not found</returns>
		public KeyValues1 FindKey(string keyName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1FindKey(Handle, keyName), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Finds a key by name or creates it if it doesn't exist
		/// </summary>
		/// <param name="keyName">The name of the key to find or create</param>
		/// <returns>Pointer to the found or newly created KeyValues subkey (never NULL)</returns>
		public KeyValues1 FindOrCreateKey(string keyName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1FindOrCreateKey(Handle, keyName), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Creates a new subkey with the specified name
		/// </summary>
		/// <param name="keyName">The name for the new key</param>
		/// <returns>Pointer to the newly created KeyValues subkey</returns>
		public KeyValues1 CreateKey(string keyName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1CreateKey(Handle, keyName), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Creates a new subkey with an autogenerated name
		/// </summary>
		/// <returns>Pointer to the newly created KeyValues subkey</returns>
		public KeyValues1 CreateNewKey()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1CreateNewKey(Handle), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a subkey to this KeyValues instance
		/// </summary>
		/// <param name="subKey">Pointer to the KeyValues object to add as a child</param>
		public void AddSubKey(KeyValues1 subKey)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1AddSubKey(Handle, subKey.Get());
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the first subkey in the list
		/// </summary>
		/// <returns>Pointer to the first subkey, or NULL if there are no children</returns>
		public KeyValues1 GetFirstSubKey()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1GetFirstSubKey(Handle), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the next sibling key in the list
		/// </summary>
		/// <returns>Pointer to the next sibling key, or NULL if this is the last sibling</returns>
		public KeyValues1 GetNextKey()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return new KeyValues1(s2sdk.Kv1GetNextKey(Handle), Ownership.Borrowed);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a color value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the color from</param>
		/// <param name="defaultValue">The default color value to return if the key is not found</param>
		/// <returns>The color value as a 32-bit integer (RGBA)</returns>
		public int GetColor(string keyName, int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetColor(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a color value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the color for</param>
		/// <param name="value">The color value as a 32-bit integer (RGBA)</param>
		public void SetColor(string keyName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetColor(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an integer value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the integer from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The integer value associated with the key, or defaultValue if not found</returns>
		public int GetInt(string keyName, int defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetInt(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets an integer value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the integer for</param>
		/// <param name="value">The integer value to set</param>
		public void SetInt(string keyName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetInt(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a float value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the float from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The float value associated with the key, or defaultValue if not found</returns>
		public float GetFloat(string keyName, float defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetFloat(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a float value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the float for</param>
		/// <param name="value">The float value to set</param>
		public void SetFloat(string keyName, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetFloat(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a string value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the string from</param>
		/// <param name="defaultValue">The default string to return if the key is not found</param>
		/// <returns>The string value associated with the key, or defaultValue if not found</returns>
		public string GetString(string keyName, string defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetString(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a string value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the string for</param>
		/// <param name="value">The string value to set</param>
		public void SetString(string keyName, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetString(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a pointer value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the pointer from</param>
		/// <param name="defaultValue">The default pointer to return if the key is not found</param>
		/// <returns>The pointer value associated with the key, or defaultValue if not found</returns>
		public nint GetPtr(string keyName, nint defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetPtr(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a pointer value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the pointer for</param>
		/// <param name="value">The pointer value to set</param>
		public void SetPtr(string keyName, nint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetPtr(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a boolean value from a key
		/// </summary>
		/// <param name="keyName">The name of the key to retrieve the boolean from</param>
		/// <param name="defaultValue">The default value to return if the key is not found</param>
		/// <returns>The boolean value associated with the key, or defaultValue if not found</returns>
		public Bool8 GetBool(string keyName, Bool8 defaultValue)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1GetBool(Handle, keyName, defaultValue);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a boolean value for a key
		/// </summary>
		/// <param name="keyName">The name of the key to set the boolean for</param>
		/// <param name="value">The boolean value to set</param>
		public void SetBool(string keyName, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1SetBool(Handle, keyName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Clears all subkeys and the current value
		/// </summary>
		public void Clear()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.Kv1Clear(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if a key exists and has no value or subkeys
		/// </summary>
		/// <param name="keyName">The name of the key to check</param>
		/// <returns>true if the key exists and is empty, false otherwise</returns>
		public Bool8 IsEmpty(string keyName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.Kv1IsEmpty(Handle, keyName);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

	}

#pragma warning restore CS0649
}
