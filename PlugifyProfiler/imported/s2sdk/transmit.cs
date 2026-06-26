using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: transmit)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Sets a bit in the TransmitEntity bitvec, marking an entity as transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to mark as transmittable.</param>
		internal static delegate*<nint, int, void> SetTransmitInfoEntity = &___SetTransmitInfoEntity;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __SetTransmitInfoEntity;
		private static void ___SetTransmitInfoEntity(nint info, int entityHandle)
		{
			__SetTransmitInfoEntity(info, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitEntity bitvec, marking an entity as not transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to mark as not transmittable.</param>
		internal static delegate*<nint, int, void> ClearTransmitInfoEntity = &___ClearTransmitInfoEntity;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __ClearTransmitInfoEntity;
		private static void ___ClearTransmitInfoEntity(nint info, int entityHandle)
		{
			__ClearTransmitInfoEntity(info, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitEntity bitvec.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to check.</param>
		/// <returns>True if the entity is marked as transmittable, false otherwise.</returns>
		internal static delegate*<nint, int, Bool8> IsTransmitInfoEntitySet = &___IsTransmitInfoEntitySet;
		internal static delegate* unmanaged[Cdecl]<nint, int, Bool8> __IsTransmitInfoEntitySet;
		private static Bool8 ___IsTransmitInfoEntitySet(nint info, int entityHandle)
		{
			Bool8 __retVal = __IsTransmitInfoEntitySet(info, entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets all bits in the TransmitEntity bitvec, marking all entities as transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> SetTransmitInfoEntityAll = &___SetTransmitInfoEntityAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __SetTransmitInfoEntityAll;
		private static void ___SetTransmitInfoEntityAll(nint info)
		{
			__SetTransmitInfoEntityAll(info);
		}

		/// <summary>
		/// Clears all bits in the TransmitEntity bitvec, marking all entities as not transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> ClearTransmitInfoEntityAll = &___ClearTransmitInfoEntityAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __ClearTransmitInfoEntityAll;
		private static void ___ClearTransmitInfoEntityAll(nint info)
		{
			__ClearTransmitInfoEntityAll(info);
		}

		/// <summary>
		/// Sets a bit in the TransmitNonPlayers bitvec, marking a non-player entity as transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The index of the non-player entity to mark as transmittable.</param>
		internal static delegate*<nint, int, void> SetTransmitInfoNonPlayer = &___SetTransmitInfoNonPlayer;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __SetTransmitInfoNonPlayer;
		private static void ___SetTransmitInfoNonPlayer(nint info, int entityHandle)
		{
			__SetTransmitInfoNonPlayer(info, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitNonPlayers bitvec, marking a non-player entity as not transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The index of the non-player entity to mark as not transmittable.</param>
		internal static delegate*<nint, int, void> ClearTransmitInfoNonPlayer = &___ClearTransmitInfoNonPlayer;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __ClearTransmitInfoNonPlayer;
		private static void ___ClearTransmitInfoNonPlayer(nint info, int entityHandle)
		{
			__ClearTransmitInfoNonPlayer(info, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitNonPlayers bitvec.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The index of the non-player entity to check.</param>
		/// <returns>True if the entity is marked as transmittable, false otherwise.</returns>
		internal static delegate*<nint, int, Bool8> IsTransmitInfoNonPlayerSet = &___IsTransmitInfoNonPlayerSet;
		internal static delegate* unmanaged[Cdecl]<nint, int, Bool8> __IsTransmitInfoNonPlayerSet;
		private static Bool8 ___IsTransmitInfoNonPlayerSet(nint info, int entityHandle)
		{
			Bool8 __retVal = __IsTransmitInfoNonPlayerSet(info, entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets all bits in the TransmitNonPlayers bitvec, marking all non-player entities as transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> SetTransmitInfoNonPlayerAll = &___SetTransmitInfoNonPlayerAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __SetTransmitInfoNonPlayerAll;
		private static void ___SetTransmitInfoNonPlayerAll(nint info)
		{
			__SetTransmitInfoNonPlayerAll(info);
		}

		/// <summary>
		/// Clears all bits in the TransmitNonPlayers bitvec, marking all non-player entities as not transmittable.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> ClearTransmitInfoNonPlayerAll = &___ClearTransmitInfoNonPlayerAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __ClearTransmitInfoNonPlayerAll;
		private static void ___ClearTransmitInfoNonPlayerAll(nint info)
		{
			__ClearTransmitInfoNonPlayerAll(info);
		}

		/// <summary>
		/// Sets a bit in the TransmitAlways bitvec, marking an entity to always transmit.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to mark as always transmittable.</param>
		internal static delegate*<nint, int, void> SetTransmitInfoAlways = &___SetTransmitInfoAlways;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __SetTransmitInfoAlways;
		private static void ___SetTransmitInfoAlways(nint info, int entityHandle)
		{
			__SetTransmitInfoAlways(info, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitAlways bitvec, unmarking an entity from always transmit.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to unmark from always transmit.</param>
		internal static delegate*<nint, int, void> ClearTransmitInfoAlways = &___ClearTransmitInfoAlways;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __ClearTransmitInfoAlways;
		private static void ___ClearTransmitInfoAlways(nint info, int entityHandle)
		{
			__ClearTransmitInfoAlways(info, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitAlways bitvec.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="entityHandle">The handle of the entity to check.</param>
		/// <returns>True if the entity is marked to always transmit, false otherwise.</returns>
		internal static delegate*<nint, int, Bool8> IsTransmitInfoAlwaysSet = &___IsTransmitInfoAlwaysSet;
		internal static delegate* unmanaged[Cdecl]<nint, int, Bool8> __IsTransmitInfoAlwaysSet;
		private static Bool8 ___IsTransmitInfoAlwaysSet(nint info, int entityHandle)
		{
			Bool8 __retVal = __IsTransmitInfoAlwaysSet(info, entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Sets all bits in the TransmitAlways bitvec, marking all entities to always transmit.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> SetTransmitInfoAlwaysAll = &___SetTransmitInfoAlwaysAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __SetTransmitInfoAlwaysAll;
		private static void ___SetTransmitInfoAlwaysAll(nint info)
		{
			__SetTransmitInfoAlwaysAll(info);
		}

		/// <summary>
		/// Clears all bits in the TransmitAlways bitvec, unmarking all entities from always transmit.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> ClearTransmitInfoAlwaysAll = &___ClearTransmitInfoAlwaysAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __ClearTransmitInfoAlwaysAll;
		private static void ___ClearTransmitInfoAlwaysAll(nint info)
		{
			__ClearTransmitInfoAlwaysAll(info);
		}

		/// <summary>
		/// Gets the count of target player slots.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <returns>The number of target player slots, or 0 if the info pointer is null.</returns>
		internal static delegate*<nint, int> GetTransmitInfoTargetSlotsCount = &___GetTransmitInfoTargetSlotsCount;
		internal static delegate* unmanaged[Cdecl]<nint, int> __GetTransmitInfoTargetSlotsCount;
		private static int ___GetTransmitInfoTargetSlotsCount(nint info)
		{
			int __retVal = __GetTransmitInfoTargetSlotsCount(info);
			return __retVal;
		}

		/// <summary>
		/// Gets a player slot value at a specific index in the target slots vector.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="index">The index in the target slots vector.</param>
		/// <returns>The player slot value, or -1 if the index is invalid or info is null.</returns>
		internal static delegate*<nint, int, int> GetTransmitInfoTargetSlot = &___GetTransmitInfoTargetSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int, int> __GetTransmitInfoTargetSlot;
		private static int ___GetTransmitInfoTargetSlot(nint info, int index)
		{
			int __retVal = __GetTransmitInfoTargetSlot(info, index);
			return __retVal;
		}

		/// <summary>
		/// Adds a player slot to the target slots vector.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="playerSlot">The player slot value to add.</param>
		internal static delegate*<nint, int, void> AddTransmitInfoTargetSlot = &___AddTransmitInfoTargetSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __AddTransmitInfoTargetSlot;
		private static void ___AddTransmitInfoTargetSlot(nint info, int playerSlot)
		{
			__AddTransmitInfoTargetSlot(info, playerSlot);
		}

		/// <summary>
		/// Removes a player slot from the target slots vector.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="index">Index within the target slots vector to remove.</param>
		internal static delegate*<nint, int, void> RemoveTransmitInfoTargetSlot = &___RemoveTransmitInfoTargetSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __RemoveTransmitInfoTargetSlot;
		private static void ___RemoveTransmitInfoTargetSlot(nint info, int index)
		{
			__RemoveTransmitInfoTargetSlot(info, index);
		}

		/// <summary>
		/// Gets the target slots vector.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <returns>The player slots array.</returns>
		internal static delegate*<nint, int[]> GetTransmitInfoTargetSlotsAll = &___GetTransmitInfoTargetSlotsAll;
		internal static delegate* unmanaged[Cdecl]<nint, Vector192> __GetTransmitInfoTargetSlotsAll;
		private static int[] ___GetTransmitInfoTargetSlotsAll(nint info)
		{
			int[] __retVal;
			Vector192 __retVal_native;
			try {
				__retVal_native = __GetTransmitInfoTargetSlotsAll(info);
				// Unmarshal - Convert native data to managed data.
				__retVal = new int[NativeMethods.GetVectorSizeInt32(&__retVal_native)];
				NativeMethods.GetVectorDataInt32(&__retVal_native, __retVal);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorInt32(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Clears all target player slots from the vector.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		internal static delegate*<nint, void> RemoveTransmitInfoTargetSlotsAll = &___RemoveTransmitInfoTargetSlotsAll;
		internal static delegate* unmanaged[Cdecl]<nint, void> __RemoveTransmitInfoTargetSlotsAll;
		private static void ___RemoveTransmitInfoTargetSlotsAll(nint info)
		{
			__RemoveTransmitInfoTargetSlotsAll(info);
		}

		/// <summary>
		/// Gets the player slot value from the CCheckTransmitInfo.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <returns>The player slot value, or -1 if info is null.</returns>
		internal static delegate*<nint, int> GetTransmitInfoPlayerSlot = &___GetTransmitInfoPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int> __GetTransmitInfoPlayerSlot;
		private static int ___GetTransmitInfoPlayerSlot(nint info)
		{
			int __retVal = __GetTransmitInfoPlayerSlot(info);
			return __retVal;
		}

		/// <summary>
		/// Sets the player slot value in the CCheckTransmitInfo.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="playerSlot">The player slot value to set.</param>
		internal static delegate*<nint, int, void> SetTransmitInfoPlayerSlot = &___SetTransmitInfoPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __SetTransmitInfoPlayerSlot;
		private static void ___SetTransmitInfoPlayerSlot(nint info, int playerSlot)
		{
			__SetTransmitInfoPlayerSlot(info, playerSlot);
		}

		/// <summary>
		/// Gets the full update flag from the CCheckTransmitInfo.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <returns>True if full update is enabled, false otherwise.</returns>
		internal static delegate*<nint, Bool8> GetTransmitInfoFullUpdate = &___GetTransmitInfoFullUpdate;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8> __GetTransmitInfoFullUpdate;
		private static Bool8 ___GetTransmitInfoFullUpdate(nint info)
		{
			Bool8 __retVal = __GetTransmitInfoFullUpdate(info);
			return __retVal;
		}

		/// <summary>
		/// Sets the full update flag in the CCheckTransmitInfo.
		/// </summary>
		/// <param name="info">Pointer to the CCheckTransmitInfo structure.</param>
		/// <param name="fullUpdate">The full update flag value to set.</param>
		internal static delegate*<nint, Bool8, void> SetTransmitInfoFullUpdate = &___SetTransmitInfoFullUpdate;
		internal static delegate* unmanaged[Cdecl]<nint, Bool8, void> __SetTransmitInfoFullUpdate;
		private static void ___SetTransmitInfoFullUpdate(nint info, Bool8 fullUpdate)
		{
			__SetTransmitInfoFullUpdate(info, fullUpdate);
		}

	}

	/// <summary>
	/// RAII wrapper for CheckTransmitInfo pointer.
	/// </summary>
	internal sealed unsafe class CheckTransmitInfo
	{
		private nint handle;

		/// <summary>
		/// Internal constructor for creating CheckTransmitInfo from existing handle
		/// </summary>
		public CheckTransmitInfo(nint handle)
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
		/// Sets a bit in the TransmitEntity bitvec, marking an entity as transmittable.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to mark as transmittable.</param>
		public void SetEntity(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoEntity(handle, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitEntity bitvec, marking an entity as not transmittable.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to mark as not transmittable.</param>
		public void ClearEntity(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoEntity(handle, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitEntity bitvec.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to check.</param>
		/// <returns>True if the entity is marked as transmittable, false otherwise.</returns>
		public Bool8 IsEntitySet(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.IsTransmitInfoEntitySet(handle, entityHandle);
		}

		/// <summary>
		/// Sets all bits in the TransmitEntity bitvec, marking all entities as transmittable.
		/// </summary>
		public void SetEntityAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoEntityAll(handle);
		}

		/// <summary>
		/// Clears all bits in the TransmitEntity bitvec, marking all entities as not transmittable.
		/// </summary>
		public void ClearEntityAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoEntityAll(handle);
		}

		/// <summary>
		/// Sets a bit in the TransmitNonPlayers bitvec, marking a non-player entity as transmittable.
		/// </summary>
		/// <param name="entityHandle">The index of the non-player entity to mark as transmittable.</param>
		public void SetNonPlayer(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoNonPlayer(handle, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitNonPlayers bitvec, marking a non-player entity as not transmittable.
		/// </summary>
		/// <param name="entityHandle">The index of the non-player entity to mark as not transmittable.</param>
		public void ClearNonPlayer(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoNonPlayer(handle, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitNonPlayers bitvec.
		/// </summary>
		/// <param name="entityHandle">The index of the non-player entity to check.</param>
		/// <returns>True if the entity is marked as transmittable, false otherwise.</returns>
		public Bool8 IsNonPlayerSet(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.IsTransmitInfoNonPlayerSet(handle, entityHandle);
		}

		/// <summary>
		/// Sets all bits in the TransmitNonPlayers bitvec, marking all non-player entities as transmittable.
		/// </summary>
		public void SetNonPlayerAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoNonPlayerAll(handle);
		}

		/// <summary>
		/// Clears all bits in the TransmitNonPlayers bitvec, marking all non-player entities as not transmittable.
		/// </summary>
		public void ClearNonPlayerAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoNonPlayerAll(handle);
		}

		/// <summary>
		/// Sets a bit in the TransmitAlways bitvec, marking an entity to always transmit.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to mark as always transmittable.</param>
		public void SetAlways(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoAlways(handle, entityHandle);
		}

		/// <summary>
		/// Clears a bit in the TransmitAlways bitvec, unmarking an entity from always transmit.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to unmark from always transmit.</param>
		public void ClearAlways(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoAlways(handle, entityHandle);
		}

		/// <summary>
		/// Checks if a bit is set in the TransmitAlways bitvec.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity to check.</param>
		/// <returns>True if the entity is marked to always transmit, false otherwise.</returns>
		public Bool8 IsAlwaysSet(int entityHandle)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.IsTransmitInfoAlwaysSet(handle, entityHandle);
		}

		/// <summary>
		/// Sets all bits in the TransmitAlways bitvec, marking all entities to always transmit.
		/// </summary>
		public void SetAlwaysAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoAlwaysAll(handle);
		}

		/// <summary>
		/// Clears all bits in the TransmitAlways bitvec, unmarking all entities from always transmit.
		/// </summary>
		public void ClearAlwaysAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.ClearTransmitInfoAlwaysAll(handle);
		}

		/// <summary>
		/// Gets the count of target player slots.
		/// </summary>
		/// <returns>The number of target player slots, or 0 if the info pointer is null.</returns>
		public int GetTargetSlotsCount()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetTransmitInfoTargetSlotsCount(handle);
		}

		/// <summary>
		/// Gets a player slot value at a specific index in the target slots vector.
		/// </summary>
		/// <param name="index">The index in the target slots vector.</param>
		/// <returns>The player slot value, or -1 if the index is invalid or info is null.</returns>
		public int GetTargetSlot(int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetTransmitInfoTargetSlot(handle, index);
		}

		/// <summary>
		/// Adds a player slot to the target slots vector.
		/// </summary>
		/// <param name="playerSlot">The player slot value to add.</param>
		public void AddTargetSlot(int playerSlot)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.AddTransmitInfoTargetSlot(handle, playerSlot);
		}

		/// <summary>
		/// Removes a player slot from the target slots vector.
		/// </summary>
		/// <param name="index">Index within the target slots vector to remove.</param>
		public void RemoveTargetSlot(int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.RemoveTransmitInfoTargetSlot(handle, index);
		}

		/// <summary>
		/// Gets the target slots vector.
		/// </summary>
		/// <returns>The player slots array.</returns>
		public int[] GetTargetSlotsAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetTransmitInfoTargetSlotsAll(handle);
		}

		/// <summary>
		/// Clears all target player slots from the vector.
		/// </summary>
		public void RemoveTargetSlotsAll()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.RemoveTransmitInfoTargetSlotsAll(handle);
		}

		/// <summary>
		/// Gets the player slot value from the CCheckTransmitInfo.
		/// </summary>
		/// <returns>The player slot value, or -1 if info is null.</returns>
		public int GetPlayerSlot()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetTransmitInfoPlayerSlot(handle);
		}

		/// <summary>
		/// Sets the player slot value in the CCheckTransmitInfo.
		/// </summary>
		/// <param name="playerSlot">The player slot value to set.</param>
		public void SetPlayerSlot(int playerSlot)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoPlayerSlot(handle, playerSlot);
		}

		/// <summary>
		/// Gets the full update flag from the CCheckTransmitInfo.
		/// </summary>
		/// <returns>True if full update is enabled, false otherwise.</returns>
		public Bool8 GetFullUpdate()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			return s2sdk.GetTransmitInfoFullUpdate(handle);
		}

		/// <summary>
		/// Sets the full update flag in the CCheckTransmitInfo.
		/// </summary>
		/// <param name="fullUpdate">The full update flag value to set.</param>
		public void SetFullUpdate(Bool8 fullUpdate)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			s2sdk.SetTransmitInfoFullUpdate(handle, fullUpdate);
		}

	}

#pragma warning restore CS0649
}
