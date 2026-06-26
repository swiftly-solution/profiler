using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: weapons)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Retrieves the weapon VData for a given weapon name.
		/// </summary>
		/// <param name="name">The name of the weapon.</param>
		/// <returns>A pointer to the `CCSWeaponBaseVData` if the entity handle is valid and represents a player weapon; otherwise, nullptr.</returns>
		internal static delegate*<string, nint> GetWeaponVDataFromKey = &___GetWeaponVDataFromKey;
		internal static delegate* unmanaged[Cdecl]<String192*, nint> __GetWeaponVDataFromKey;
		private static nint ___GetWeaponVDataFromKey(string name)
		{
			nint __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __GetWeaponVDataFromKey(&__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the weapon VData for a given weapon.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which to retrieve the weapon VData.</param>
		/// <returns>A pointer to the `CCSWeaponBaseVData` if the entity handle is valid and represents a player weapon; otherwise, nullptr.</returns>
		internal static delegate*<int, nint> GetWeaponVData = &___GetWeaponVData;
		internal static delegate* unmanaged[Cdecl]<int, nint> __GetWeaponVData;
		private static nint ___GetWeaponVData(int entityHandle)
		{
			nint __retVal = __GetWeaponVData(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the weapon type of a given entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity (weapon).</param>
		/// <returns>The type of the weapon, or WEAPONTYPE_UNKNOWN if the entity is invalid.</returns>
		internal static delegate*<int, CSWeaponType> GetWeaponType = &___GetWeaponType;
		internal static delegate* unmanaged[Cdecl]<int, CSWeaponType> __GetWeaponType;
		private static CSWeaponType ___GetWeaponType(int entityHandle)
		{
			CSWeaponType __retVal = __GetWeaponType(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the weapon category of a given entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity (weapon).</param>
		/// <returns>The category of the weapon, or WEAPONCATEGORY_OTHER if the entity is invalid.</returns>
		internal static delegate*<int, CSWeaponCategory> GetWeaponCategory = &___GetWeaponCategory;
		internal static delegate* unmanaged[Cdecl]<int, CSWeaponCategory> __GetWeaponCategory;
		private static CSWeaponCategory ___GetWeaponCategory(int entityHandle)
		{
			CSWeaponCategory __retVal = __GetWeaponCategory(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the gear slot of a given weapon entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity (weapon).</param>
		/// <returns>The gear slot of the weapon, or GEAR_SLOT_INVALID if the entity is invalid.</returns>
		internal static delegate*<int, GearSlot> GetWeaponGearSlot = &___GetWeaponGearSlot;
		internal static delegate* unmanaged[Cdecl]<int, GearSlot> __GetWeaponGearSlot;
		private static GearSlot ___GetWeaponGearSlot(int entityHandle)
		{
			GearSlot __retVal = __GetWeaponGearSlot(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the weapon definition index for a given entity handle.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity from which to retrieve the weapon def index.</param>
		/// <returns>The weapon definition index as a `uint16_t`, or 0 if the entity handle is invalid.</returns>
		internal static delegate*<int, WeaponDefIndex> GetWeaponItemDefinition = &___GetWeaponItemDefinition;
		internal static delegate* unmanaged[Cdecl]<int, WeaponDefIndex> __GetWeaponItemDefinition;
		private static WeaponDefIndex ___GetWeaponItemDefinition(int entityHandle)
		{
			WeaponDefIndex __retVal = __GetWeaponItemDefinition(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the item definition index associated with a given item name.
		/// </summary>
		/// <param name="itemName">The name of the item.</param>
		/// <returns>The weapon definition index as a `uint16_t`, or 0 if the entity handle is invalid.</returns>
		internal static delegate*<string, WeaponDefIndex> GetWeaponItemDefinitionByName = &___GetWeaponItemDefinitionByName;
		internal static delegate* unmanaged[Cdecl]<String192*, WeaponDefIndex> __GetWeaponItemDefinitionByName;
		private static WeaponDefIndex ___GetWeaponItemDefinitionByName(string itemName)
		{
			WeaponDefIndex __retVal;
			var __itemName = NativeMethods.ConstructString(itemName);
			try {
				__retVal = __GetWeaponItemDefinitionByName(&__itemName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__itemName);
			}
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
