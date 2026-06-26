using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: clients)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Retrieves the player slot from a given entity pointer.
		/// </summary>
		/// <param name="entity">A pointer to the entity (CBaseEntity*).</param>
		/// <returns>The player slot if valid, otherwise -1.</returns>
		internal static delegate*<nint, int> EntPointerToPlayerSlot = &___EntPointerToPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int> __EntPointerToPlayerSlot;
		private static int ___EntPointerToPlayerSlot(nint entity)
		{
			int __retVal = __EntPointerToPlayerSlot(entity);
			return __retVal;
		}

		/// <summary>
		/// Returns a pointer to the entity instance by player slot index.
		/// </summary>
		/// <param name="playerSlot">Index of the player slot.</param>
		/// <returns>Pointer to the entity instance, or nullptr if the slot is invalid.</returns>
		internal static delegate*<int, nint> PlayerSlotToEntPointer = &___PlayerSlotToEntPointer;
		internal static delegate* unmanaged[Cdecl]<int, nint> __PlayerSlotToEntPointer;
		private static nint ___PlayerSlotToEntPointer(int playerSlot)
		{
			nint __retVal = __PlayerSlotToEntPointer(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Returns the entity handle associated with a player slot index.
		/// </summary>
		/// <param name="playerSlot">Index of the player slot.</param>
		/// <returns>The index of the entity, or -1 if the handle is invalid.</returns>
		internal static delegate*<int, int> PlayerSlotToEntHandle = &___PlayerSlotToEntHandle;
		internal static delegate* unmanaged[Cdecl]<int, int> __PlayerSlotToEntHandle;
		private static int ___PlayerSlotToEntHandle(int playerSlot)
		{
			int __retVal = __PlayerSlotToEntHandle(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the client object from a given player slot.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot (0-based).</param>
		/// <returns>A pointer to the client object if found, otherwise nullptr.</returns>
		internal static delegate*<int, nint> PlayerSlotToClientPtr = &___PlayerSlotToClientPtr;
		internal static delegate* unmanaged[Cdecl]<int, nint> __PlayerSlotToClientPtr;
		private static nint ___PlayerSlotToClientPtr(int playerSlot)
		{
			nint __retVal = __PlayerSlotToClientPtr(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the index of a given client object.
		/// </summary>
		/// <param name="client">A pointer to the client object (CServerSideClient*).</param>
		/// <returns>The player slot if found, otherwise -1.</returns>
		internal static delegate*<nint, int> ClientPtrToPlayerSlot = &___ClientPtrToPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int> __ClientPtrToPlayerSlot;
		private static int ___ClientPtrToPlayerSlot(nint client)
		{
			int __retVal = __ClientPtrToPlayerSlot(client);
			return __retVal;
		}

		/// <summary>
		/// Returns the entity index for a given player slot.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The entity index if valid, otherwise 0.</returns>
		internal static delegate*<int, int> PlayerSlotToClientIndex = &___PlayerSlotToClientIndex;
		internal static delegate* unmanaged[Cdecl]<int, int> __PlayerSlotToClientIndex;
		private static int ___PlayerSlotToClientIndex(int playerSlot)
		{
			int __retVal = __PlayerSlotToClientIndex(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the player slot from a given client index.
		/// </summary>
		/// <param name="clientIndex">The index of the client.</param>
		/// <returns>The player slot if valid, otherwise -1.</returns>
		internal static delegate*<int, int> ClientIndexToPlayerSlot = &___ClientIndexToPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<int, int> __ClientIndexToPlayerSlot;
		private static int ___ClientIndexToPlayerSlot(int clientIndex)
		{
			int __retVal = __ClientIndexToPlayerSlot(clientIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the player slot from a given player service.
		/// </summary>
		/// <param name="service">The service pointer. Like CCSPlayer_ItemServices, CCSPlayer_WeaponServices ect.</param>
		/// <returns>The player slot if valid, otherwise -1.</returns>
		internal static delegate*<nint, int> PlayerServicesToPlayerSlot = &___PlayerServicesToPlayerSlot;
		internal static delegate* unmanaged[Cdecl]<nint, int> __PlayerServicesToPlayerSlot;
		private static int ___PlayerServicesToPlayerSlot(nint service)
		{
			int __retVal = __PlayerServicesToPlayerSlot(service);
			return __retVal;
		}

		/// <summary>
		/// Retrieves a client's authentication string (SteamID).
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose authentication string is being retrieved.</param>
		/// <returns>The authentication string.</returns>
		internal static delegate*<int, string> GetClientAuthId = &___GetClientAuthId;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientAuthId;
		private static string ___GetClientAuthId(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientAuthId(playerSlot);
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
		/// Returns the client's Steam account ID, a unique number identifying a given Steam account.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>uint32_t The client's steam account ID.</returns>
		internal static delegate*<int, uint> GetClientAccountId = &___GetClientAccountId;
		internal static delegate* unmanaged[Cdecl]<int, uint> __GetClientAccountId;
		private static uint ___GetClientAccountId(int playerSlot)
		{
			uint __retVal = __GetClientAccountId(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Returns the client's SteamID64 â€” a unique 64-bit identifier of a Steam account.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>uint64_t The client's SteamID64.</returns>
		internal static delegate*<int, ulong> GetClientSteamID64 = &___GetClientSteamID64;
		internal static delegate* unmanaged[Cdecl]<int, ulong> __GetClientSteamID64;
		private static ulong ___GetClientSteamID64(int playerSlot)
		{
			ulong __retVal = __GetClientSteamID64(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves a client's IP address.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The client's IP address.</returns>
		internal static delegate*<int, string> GetClientIp = &___GetClientIp;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientIp;
		private static string ___GetClientIp(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientIp(playerSlot);
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
		/// Retrieves a client's language.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The client's language.</returns>
		internal static delegate*<int, string> GetClientLanguage = &___GetClientLanguage;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientLanguage;
		private static string ___GetClientLanguage(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientLanguage(playerSlot);
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
		/// Retrieves a client's operating system.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The client's operating system.</returns>
		internal static delegate*<int, string> GetClientOS = &___GetClientOS;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientOS;
		private static string ___GetClientOS(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientOS(playerSlot);
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
		/// Returns the client's name.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The client's name.</returns>
		internal static delegate*<int, string> GetClientName = &___GetClientName;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientName;
		private static string ___GetClientName(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientName(playerSlot);
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
		/// Returns the client's connection time in seconds.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>float Connection time in seconds.</returns>
		internal static delegate*<int, float> GetClientTime = &___GetClientTime;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientTime;
		private static float ___GetClientTime(int playerSlot)
		{
			float __retVal = __GetClientTime(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Returns the client's current latency (RTT).
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>float Latency value.</returns>
		internal static delegate*<int, float> GetClientLatency = &___GetClientLatency;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientLatency;
		private static float ___GetClientLatency(int playerSlot)
		{
			float __retVal = __GetClientLatency(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Returns the client's access flags.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>uint64 Access flags as a bitmask.</returns>
		internal static delegate*<int, ulong> GetUserFlagBits = &___GetUserFlagBits;
		internal static delegate* unmanaged[Cdecl]<int, ulong> __GetUserFlagBits;
		private static ulong ___GetUserFlagBits(int playerSlot)
		{
			ulong __retVal = __GetUserFlagBits(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the access flags on a client using a bitmask.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="flags">Bitmask representing the flags to be set.</param>
		internal static delegate*<int, ulong, void> SetUserFlagBits = &___SetUserFlagBits;
		internal static delegate* unmanaged[Cdecl]<int, ulong, void> __SetUserFlagBits;
		private static void ___SetUserFlagBits(int playerSlot, ulong flags)
		{
			__SetUserFlagBits(playerSlot, flags);
		}

		/// <summary>
		/// Adds access flags to a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="flags">Bitmask representing the flags to be added.</param>
		internal static delegate*<int, ulong, void> AddUserFlags = &___AddUserFlags;
		internal static delegate* unmanaged[Cdecl]<int, ulong, void> __AddUserFlags;
		private static void ___AddUserFlags(int playerSlot, ulong flags)
		{
			__AddUserFlags(playerSlot, flags);
		}

		/// <summary>
		/// Removes access flags from a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="flags">Bitmask representing the flags to be removed.</param>
		internal static delegate*<int, ulong, void> RemoveUserFlags = &___RemoveUserFlags;
		internal static delegate* unmanaged[Cdecl]<int, ulong, void> __RemoveUserFlags;
		private static void ___RemoveUserFlags(int playerSlot, ulong flags)
		{
			__RemoveUserFlags(playerSlot, flags);
		}

		/// <summary>
		/// Checks if a certain player has been authenticated.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the player is authenticated, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsClientAuthorized = &___IsClientAuthorized;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsClientAuthorized;
		private static Bool8 ___IsClientAuthorized(int playerSlot)
		{
			Bool8 __retVal = __IsClientAuthorized(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if a certain player is connected.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the player is connected, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsClientConnected = &___IsClientConnected;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsClientConnected;
		private static Bool8 ___IsClientConnected(int playerSlot)
		{
			Bool8 __retVal = __IsClientConnected(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if a certain player has entered the game.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the player is in the game, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsClientInGame = &___IsClientInGame;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsClientInGame;
		private static Bool8 ___IsClientInGame(int playerSlot)
		{
			Bool8 __retVal = __IsClientInGame(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if a certain player is the SourceTV bot.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the client is the SourceTV bot, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsClientSourceTV = &___IsClientSourceTV;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsClientSourceTV;
		private static Bool8 ___IsClientSourceTV(int playerSlot)
		{
			Bool8 __retVal = __IsClientSourceTV(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if the client is alive or dead.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the client is alive, false if dead.</returns>
		internal static delegate*<int, Bool8> IsClientAlive = &___IsClientAlive;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsClientAlive;
		private static Bool8 ___IsClientAlive(int playerSlot)
		{
			Bool8 __retVal = __IsClientAlive(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if a certain player is a fake client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>true if the client is a fake client, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsFakeClient = &___IsFakeClient;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsFakeClient;
		private static Bool8 ___IsFakeClient(int playerSlot)
		{
			Bool8 __retVal = __IsFakeClient(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the movement type of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose movement type is to be retrieved.</param>
		/// <returns>The movement type of the entity, or 0 if the entity is invalid.</returns>
		internal static delegate*<int, MoveType> GetClientMoveType = &___GetClientMoveType;
		internal static delegate* unmanaged[Cdecl]<int, MoveType> __GetClientMoveType;
		private static MoveType ___GetClientMoveType(int playerSlot)
		{
			MoveType __retVal = __GetClientMoveType(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the movement type of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose movement type is to be set.</param>
		/// <param name="moveType">The movement type of the entity, or 0 if the entity is invalid.</param>
		internal static delegate*<int, MoveType, void> SetClientMoveType = &___SetClientMoveType;
		internal static delegate* unmanaged[Cdecl]<int, MoveType, void> __SetClientMoveType;
		private static void ___SetClientMoveType(int playerSlot, MoveType moveType)
		{
			__SetClientMoveType(playerSlot, moveType);
		}

		/// <summary>
		/// Retrieves the gravity scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose gravity scale is to be retrieved.</param>
		/// <returns>The gravity scale of the client, or 0.0f if the client is invalid.</returns>
		internal static delegate*<int, float> GetClientGravity = &___GetClientGravity;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientGravity;
		private static float ___GetClientGravity(int playerSlot)
		{
			float __retVal = __GetClientGravity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the gravity scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose gravity scale is to be set.</param>
		/// <param name="gravity">The new gravity scale to set for the client.</param>
		internal static delegate*<int, float, void> SetClientGravity = &___SetClientGravity;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetClientGravity;
		private static void ___SetClientGravity(int playerSlot, float gravity)
		{
			__SetClientGravity(playerSlot, gravity);
		}

		/// <summary>
		/// Retrieves the flags of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose flags are to be retrieved.</param>
		/// <returns>The flags of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientFlags = &___GetClientFlags;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientFlags;
		private static int ___GetClientFlags(int playerSlot)
		{
			int __retVal = __GetClientFlags(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the flags of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose flags are to be set.</param>
		/// <param name="flags">The new flags to set for the client.</param>
		internal static delegate*<int, int, void> SetClientFlags = &___SetClientFlags;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientFlags;
		private static void ___SetClientFlags(int playerSlot, int flags)
		{
			__SetClientFlags(playerSlot, flags);
		}

		/// <summary>
		/// Retrieves the render color of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose render color is to be retrieved.</param>
		/// <returns>The raw color value of the client's render color, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientRenderColor = &___GetClientRenderColor;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientRenderColor;
		private static int ___GetClientRenderColor(int playerSlot)
		{
			int __retVal = __GetClientRenderColor(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the render color of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose render color is to be set.</param>
		/// <param name="color">The new raw color value to set for the client's render color.</param>
		internal static delegate*<int, int, void> SetClientRenderColor = &___SetClientRenderColor;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientRenderColor;
		private static void ___SetClientRenderColor(int playerSlot, int color)
		{
			__SetClientRenderColor(playerSlot, color);
		}

		/// <summary>
		/// Retrieves the render mode of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose render mode is to be retrieved.</param>
		/// <returns>The render mode of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, RenderMode> GetClientRenderMode = &___GetClientRenderMode;
		internal static delegate* unmanaged[Cdecl]<int, RenderMode> __GetClientRenderMode;
		private static RenderMode ___GetClientRenderMode(int playerSlot)
		{
			RenderMode __retVal = __GetClientRenderMode(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the render mode of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose render mode is to be set.</param>
		/// <param name="renderMode">The new render mode to set for the client.</param>
		internal static delegate*<int, RenderMode, void> SetClientRenderMode = &___SetClientRenderMode;
		internal static delegate* unmanaged[Cdecl]<int, RenderMode, void> __SetClientRenderMode;
		private static void ___SetClientRenderMode(int playerSlot, RenderMode renderMode)
		{
			__SetClientRenderMode(playerSlot, renderMode);
		}

		/// <summary>
		/// Retrieves the mass of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose mass is to be retrieved.</param>
		/// <returns>The mass of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientMass = &___GetClientMass;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientMass;
		private static int ___GetClientMass(int playerSlot)
		{
			int __retVal = __GetClientMass(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the mass of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose mass is to be set.</param>
		/// <param name="mass">The new mass value to set for the client.</param>
		internal static delegate*<int, int, void> SetClientMass = &___SetClientMass;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientMass;
		private static void ___SetClientMass(int playerSlot, int mass)
		{
			__SetClientMass(playerSlot, mass);
		}

		/// <summary>
		/// Retrieves the friction of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose friction is to be retrieved.</param>
		/// <returns>The friction of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, float> GetClientFriction = &___GetClientFriction;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientFriction;
		private static float ___GetClientFriction(int playerSlot)
		{
			float __retVal = __GetClientFriction(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the friction of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose friction is to be set.</param>
		/// <param name="friction">The new friction value to set for the client.</param>
		internal static delegate*<int, float, void> SetClientFriction = &___SetClientFriction;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetClientFriction;
		private static void ___SetClientFriction(int playerSlot, float friction)
		{
			__SetClientFriction(playerSlot, friction);
		}

		/// <summary>
		/// Retrieves the health of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose health is to be retrieved.</param>
		/// <returns>The health of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientHealth = &___GetClientHealth;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientHealth;
		private static int ___GetClientHealth(int playerSlot)
		{
			int __retVal = __GetClientHealth(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the health of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose health is to be set.</param>
		/// <param name="health">The new health value to set for the client.</param>
		internal static delegate*<int, int, void> SetClientHealth = &___SetClientHealth;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientHealth;
		private static void ___SetClientHealth(int playerSlot, int health)
		{
			__SetClientHealth(playerSlot, health);
		}

		/// <summary>
		/// Retrieves the max health of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose max health is to be retrieved.</param>
		/// <returns>The max health of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientMaxHealth = &___GetClientMaxHealth;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientMaxHealth;
		private static int ___GetClientMaxHealth(int playerSlot)
		{
			int __retVal = __GetClientMaxHealth(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the max health of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose max health is to be set.</param>
		/// <param name="maxHealth">The new max health value to set for the client.</param>
		internal static delegate*<int, int, void> SetClientMaxHealth = &___SetClientMaxHealth;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientMaxHealth;
		private static void ___SetClientMaxHealth(int playerSlot, int maxHealth)
		{
			__SetClientMaxHealth(playerSlot, maxHealth);
		}

		/// <summary>
		/// Retrieves the team number of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose team number is to be retrieved.</param>
		/// <returns>The team number of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, CSTeam> GetClientTeam = &___GetClientTeam;
		internal static delegate* unmanaged[Cdecl]<int, CSTeam> __GetClientTeam;
		private static CSTeam ___GetClientTeam(int playerSlot)
		{
			CSTeam __retVal = __GetClientTeam(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the team number of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose team number is to be set.</param>
		/// <param name="team">The new team number to set for the client.</param>
		internal static delegate*<int, CSTeam, void> SetClientTeam = &___SetClientTeam;
		internal static delegate* unmanaged[Cdecl]<int, CSTeam, void> __SetClientTeam;
		private static void ___SetClientTeam(int playerSlot, CSTeam team)
		{
			__SetClientTeam(playerSlot, team);
		}

		/// <summary>
		/// Retrieves the absolute origin of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute origin is to be retrieved.</param>
		/// <returns>A vector where the absolute origin will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientAbsOrigin = &___GetClientAbsOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientAbsOrigin;
		private static Vector3 ___GetClientAbsOrigin(int playerSlot)
		{
			Vector3 __retVal = __GetClientAbsOrigin(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute origin of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute origin is to be set.</param>
		/// <param name="origin">The new absolute origin to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientAbsOrigin = &___SetClientAbsOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientAbsOrigin;
		private static void ___SetClientAbsOrigin(int playerSlot, Vector3 origin)
		{
			__SetClientAbsOrigin(playerSlot, &origin);
		}

		/// <summary>
		/// Retrieves the absolute scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute scale is to be retrieved.</param>
		/// <returns>A vector where the absolute scale will be stored.</returns>
		internal static delegate*<int, float> GetClientAbsScale = &___GetClientAbsScale;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientAbsScale;
		private static float ___GetClientAbsScale(int playerSlot)
		{
			float __retVal = __GetClientAbsScale(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute scale is to be set.</param>
		/// <param name="scale">The new absolute scale to set for the client.</param>
		internal static delegate*<int, float, void> SetClientAbsScale = &___SetClientAbsScale;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetClientAbsScale;
		private static void ___SetClientAbsScale(int playerSlot, float scale)
		{
			__SetClientAbsScale(playerSlot, scale);
		}

		/// <summary>
		/// Retrieves the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be retrieved.</param>
		/// <returns>A QAngle where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientAbsAngles = &___GetClientAbsAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientAbsAngles;
		private static Vector3 ___GetClientAbsAngles(int playerSlot)
		{
			Vector3 __retVal = __GetClientAbsAngles(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be set.</param>
		/// <param name="angle">The new angular rotation to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientAbsAngles = &___SetClientAbsAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientAbsAngles;
		private static void ___SetClientAbsAngles(int playerSlot, Vector3 angle)
		{
			__SetClientAbsAngles(playerSlot, &angle);
		}

		/// <summary>
		/// Retrieves the local origin of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local origin is to be retrieved.</param>
		/// <returns>A vector where the local origin will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientLocalOrigin = &___GetClientLocalOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientLocalOrigin;
		private static Vector3 ___GetClientLocalOrigin(int playerSlot)
		{
			Vector3 __retVal = __GetClientLocalOrigin(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the local origin of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local origin is to be set.</param>
		/// <param name="origin">The new local origin to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientLocalOrigin = &___SetClientLocalOrigin;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientLocalOrigin;
		private static void ___SetClientLocalOrigin(int playerSlot, Vector3 origin)
		{
			__SetClientLocalOrigin(playerSlot, &origin);
		}

		/// <summary>
		/// Retrieves the local scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local scale is to be retrieved.</param>
		/// <returns>A vector where the local scale will be stored.</returns>
		internal static delegate*<int, float> GetClientLocalScale = &___GetClientLocalScale;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientLocalScale;
		private static float ___GetClientLocalScale(int playerSlot)
		{
			float __retVal = __GetClientLocalScale(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the local scale of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local scale is to be set.</param>
		/// <param name="scale">The new local scale to set for the client.</param>
		internal static delegate*<int, float, void> SetClientLocalScale = &___SetClientLocalScale;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetClientLocalScale;
		private static void ___SetClientLocalScale(int playerSlot, float scale)
		{
			__SetClientLocalScale(playerSlot, scale);
		}

		/// <summary>
		/// Retrieves the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be retrieved.</param>
		/// <returns>A QAngle where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientLocalAngles = &___GetClientLocalAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientLocalAngles;
		private static Vector3 ___GetClientLocalAngles(int playerSlot)
		{
			Vector3 __retVal = __GetClientLocalAngles(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be set.</param>
		/// <param name="angle">The new angular rotation to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientLocalAngles = &___SetClientLocalAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientLocalAngles;
		private static void ___SetClientLocalAngles(int playerSlot, Vector3 angle)
		{
			__SetClientLocalAngles(playerSlot, &angle);
		}

		/// <summary>
		/// Retrieves the absolute velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute velocity is to be retrieved.</param>
		/// <returns>A vector where the absolute velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientAbsVelocity = &___GetClientAbsVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientAbsVelocity;
		private static Vector3 ___GetClientAbsVelocity(int playerSlot)
		{
			Vector3 __retVal = __GetClientAbsVelocity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the absolute velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose absolute velocity is to be set.</param>
		/// <param name="velocity">The new absolute velocity to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientAbsVelocity = &___SetClientAbsVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientAbsVelocity;
		private static void ___SetClientAbsVelocity(int playerSlot, Vector3 velocity)
		{
			__SetClientAbsVelocity(playerSlot, &velocity);
		}

		/// <summary>
		/// Retrieves the base velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose base velocity is to be retrieved.</param>
		/// <returns>A vector where the base velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientBaseVelocity = &___GetClientBaseVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientBaseVelocity;
		private static Vector3 ___GetClientBaseVelocity(int playerSlot)
		{
			Vector3 __retVal = __GetClientBaseVelocity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the local angular velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local angular velocity is to be retrieved.</param>
		/// <returns>A vector where the local angular velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientLocalAngVelocity = &___GetClientLocalAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientLocalAngVelocity;
		private static Vector3 ___GetClientLocalAngVelocity(int playerSlot)
		{
			Vector3 __retVal = __GetClientLocalAngVelocity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the angular velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular velocity is to be retrieved.</param>
		/// <returns>A vector where the angular velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientAngVelocity = &___GetClientAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientAngVelocity;
		private static Vector3 ___GetClientAngVelocity(int playerSlot)
		{
			Vector3 __retVal = __GetClientAngVelocity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular velocity is to be set.</param>
		/// <param name="velocity">The new angular velocity to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientAngVelocity = &___SetClientAngVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientAngVelocity;
		private static void ___SetClientAngVelocity(int playerSlot, Vector3 velocity)
		{
			__SetClientAngVelocity(playerSlot, &velocity);
		}

		/// <summary>
		/// Retrieves the local velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose local velocity is to be retrieved.</param>
		/// <returns>A vector where the local velocity will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientLocalVelocity = &___GetClientLocalVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientLocalVelocity;
		private static Vector3 ___GetClientLocalVelocity(int playerSlot)
		{
			Vector3 __retVal = __GetClientLocalVelocity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be retrieved.</param>
		/// <returns>A vector where the angular rotation will be stored.</returns>
		internal static delegate*<int, Vector3> GetClientAngRotation = &___GetClientAngRotation;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientAngRotation;
		private static Vector3 ___GetClientAngRotation(int playerSlot)
		{
			Vector3 __retVal = __GetClientAngRotation(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the angular rotation of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose angular rotation is to be set.</param>
		/// <param name="rotation">The new angular rotation to set for the client.</param>
		internal static delegate*<int, Vector3, void> SetClientAngRotation = &___SetClientAngRotation;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientAngRotation;
		private static void ___SetClientAngRotation(int playerSlot, Vector3 rotation)
		{
			__SetClientAngRotation(playerSlot, &rotation);
		}

		/// <summary>
		/// Returns the input Vector transformed from client to world space.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot</param>
		/// <param name="point">Point in client local space to transform</param>
		/// <returns>The point transformed to world space coordinates</returns>
		internal static delegate*<int, Vector3, Vector3> TransformPointClientToWorld = &___TransformPointClientToWorld;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3> __TransformPointClientToWorld;
		private static Vector3 ___TransformPointClientToWorld(int playerSlot, Vector3 point)
		{
			Vector3 __retVal = __TransformPointClientToWorld(playerSlot, &point);
			return __retVal;
		}

		/// <summary>
		/// Returns the input Vector transformed from world to client space.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot</param>
		/// <param name="point">Point in world space to transform</param>
		/// <returns>The point transformed to client local space coordinates</returns>
		internal static delegate*<int, Vector3, Vector3> TransformPointWorldToClient = &___TransformPointWorldToClient;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3> __TransformPointWorldToClient;
		private static Vector3 ___TransformPointWorldToClient(int playerSlot, Vector3 point)
		{
			Vector3 __retVal = __TransformPointWorldToClient(playerSlot, &point);
			return __retVal;
		}

		/// <summary>
		/// Get vector to eye position - absolute coords.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot</param>
		/// <returns>Eye position in absolute/world coordinates</returns>
		internal static delegate*<int, Vector3> GetClientEyePosition = &___GetClientEyePosition;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientEyePosition;
		private static Vector3 ___GetClientEyePosition(int playerSlot)
		{
			Vector3 __retVal = __GetClientEyePosition(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get the qangles that this client is looking at.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot</param>
		/// <returns>Eye angles as a vector (pitch, yaw, roll)</returns>
		internal static delegate*<int, Vector3> GetClientEyeAngles = &___GetClientEyeAngles;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientEyeAngles;
		private static Vector3 ___GetClientEyeAngles(int playerSlot)
		{
			Vector3 __retVal = __GetClientEyeAngles(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the forward velocity of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose forward velocity is to be set.</param>
		/// <param name="forward"></param>
		internal static delegate*<int, Vector3, void> SetClientForwardVector = &___SetClientForwardVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetClientForwardVector;
		private static void ___SetClientForwardVector(int playerSlot, Vector3 forward)
		{
			__SetClientForwardVector(playerSlot, &forward);
		}

		/// <summary>
		/// Get the forward vector of the client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Forward-facing direction vector of the client</returns>
		internal static delegate*<int, Vector3> GetClientForwardVector = &___GetClientForwardVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientForwardVector;
		private static Vector3 ___GetClientForwardVector(int playerSlot)
		{
			Vector3 __retVal = __GetClientForwardVector(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get the left vector of the client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Left-facing direction vector of the client (aligned with the y axis)</returns>
		internal static delegate*<int, Vector3> GetClientLeftVector = &___GetClientLeftVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientLeftVector;
		private static Vector3 ___GetClientLeftVector(int playerSlot)
		{
			Vector3 __retVal = __GetClientLeftVector(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get the right vector of the client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Right-facing direction vector of the client</returns>
		internal static delegate*<int, Vector3> GetClientRightVector = &___GetClientRightVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientRightVector;
		private static Vector3 ___GetClientRightVector(int playerSlot)
		{
			Vector3 __retVal = __GetClientRightVector(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get the up vector of the client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Up-facing direction vector of the client</returns>
		internal static delegate*<int, Vector3> GetClientUpVector = &___GetClientUpVector;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientUpVector;
		private static Vector3 ___GetClientUpVector(int playerSlot)
		{
			Vector3 __retVal = __GetClientUpVector(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get the client-to-world transformation matrix.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>4x4 transformation matrix representing client's position, rotation, and scale in world space</returns>
		internal static delegate*<int, Matrix4x4> GetClientTransform = &___GetClientTransform;
		internal static delegate* unmanaged[Cdecl]<int, Matrix4x4> __GetClientTransform;
		private static Matrix4x4 ___GetClientTransform(int playerSlot)
		{
			Matrix4x4 __retVal = __GetClientTransform(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the model name of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose model name is to be retrieved.</param>
		/// <returns>A string where the model name will be stored.</returns>
		internal static delegate*<int, string> GetClientModel = &___GetClientModel;
		internal static delegate* unmanaged[Cdecl]<int, String192> __GetClientModel;
		private static string ___GetClientModel(int playerSlot)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __GetClientModel(playerSlot);
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
		/// Sets the model name of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose model name is to be set.</param>
		/// <param name="model">The new model name to set for the client.</param>
		internal static delegate*<int, string, void> SetClientModel = &___SetClientModel;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetClientModel;
		private static void ___SetClientModel(int playerSlot, string model)
		{
			var __model = NativeMethods.ConstructString(model);
			try {
				__SetClientModel(playerSlot, &__model);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__model);
			}
		}

		/// <summary>
		/// Retrieves the water level of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose water level is to be retrieved.</param>
		/// <returns>The water level of the client, or 0.0f if the client is invalid.</returns>
		internal static delegate*<int, float> GetClientWaterLevel = &___GetClientWaterLevel;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientWaterLevel;
		private static float ___GetClientWaterLevel(int playerSlot)
		{
			float __retVal = __GetClientWaterLevel(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the ground client of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose ground client is to be retrieved.</param>
		/// <returns>The handle of the ground client, or INVALID_EHANDLE_INDEX if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientGroundEntity = &___GetClientGroundEntity;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientGroundEntity;
		private static int ___GetClientGroundEntity(int playerSlot)
		{
			int __retVal = __GetClientGroundEntity(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the effects of an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot whose effects are to be retrieved.</param>
		/// <returns>The effect flags of the client, or 0 if the client is invalid.</returns>
		internal static delegate*<int, int> GetClientEffects = &___GetClientEffects;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientEffects;
		private static int ___GetClientEffects(int playerSlot)
		{
			int __retVal = __GetClientEffects(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Adds the render effect flag to an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to modify</param>
		/// <param name="effects">Render effect flags to add</param>
		internal static delegate*<int, int, void> AddClientEffects = &___AddClientEffects;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __AddClientEffects;
		private static void ___AddClientEffects(int playerSlot, int effects)
		{
			__AddClientEffects(playerSlot, effects);
		}

		/// <summary>
		/// Removes the render effect flag from an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to modify</param>
		/// <param name="effects">Render effect flags to remove</param>
		internal static delegate*<int, int, void> RemoveClientEffects = &___RemoveClientEffects;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __RemoveClientEffects;
		private static void ___RemoveClientEffects(int playerSlot, int effects)
		{
			__RemoveClientEffects(playerSlot, effects);
		}

		/// <summary>
		/// Get a vector containing max bounds, centered on object.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Vector containing the maximum bounds of the client's bounding box</returns>
		internal static delegate*<int, Vector3> GetClientBoundingMaxs = &___GetClientBoundingMaxs;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientBoundingMaxs;
		private static Vector3 ___GetClientBoundingMaxs(int playerSlot)
		{
			Vector3 __retVal = __GetClientBoundingMaxs(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get a vector containing min bounds, centered on object.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Vector containing the minimum bounds of the client's bounding box</returns>
		internal static delegate*<int, Vector3> GetClientBoundingMins = &___GetClientBoundingMins;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientBoundingMins;
		private static Vector3 ___GetClientBoundingMins(int playerSlot)
		{
			Vector3 __retVal = __GetClientBoundingMins(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Get vector to center of object - absolute coords.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to query</param>
		/// <returns>Vector pointing to the center of the client in absolute/world coordinates</returns>
		internal static delegate*<int, Vector3> GetClientCenter = &___GetClientCenter;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetClientCenter;
		private static Vector3 ___GetClientCenter(int playerSlot)
		{
			Vector3 __retVal = __GetClientCenter(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Teleports an client to a specified location and orientation.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to teleport.</param>
		/// <param name="origin">A pointer to a Vector representing the new absolute position. Use nan vector to not set.</param>
		/// <param name="angles">A pointer to a QAngle representing the new orientation. Use nan vector to not set.</param>
		/// <param name="velocity">A pointer to a Vector representing the new velocity. Use nan vector to not set.</param>
		internal static delegate*<int, Vector3, Vector3, Vector3, void> TeleportClient = &___TeleportClient;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3*, Vector3*, void> __TeleportClient;
		private static void ___TeleportClient(int playerSlot, Vector3 origin, Vector3 angles, Vector3 velocity)
		{
			__TeleportClient(playerSlot, &origin, &angles, &velocity);
		}

		/// <summary>
		/// Apply an absolute velocity impulse to an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to apply impulse to</param>
		/// <param name="vecImpulse">Velocity impulse vector to apply</param>
		internal static delegate*<int, Vector3, void> ApplyAbsVelocityImpulseToClient = &___ApplyAbsVelocityImpulseToClient;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __ApplyAbsVelocityImpulseToClient;
		private static void ___ApplyAbsVelocityImpulseToClient(int playerSlot, Vector3 vecImpulse)
		{
			__ApplyAbsVelocityImpulseToClient(playerSlot, &vecImpulse);
		}

		/// <summary>
		/// Apply a local angular velocity impulse to an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to apply impulse to</param>
		/// <param name="angImpulse">Angular velocity impulse vector to apply</param>
		internal static delegate*<int, Vector3, void> ApplyLocalAngularVelocityImpulseToClient = &___ApplyLocalAngularVelocityImpulseToClient;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __ApplyLocalAngularVelocityImpulseToClient;
		private static void ___ApplyLocalAngularVelocityImpulseToClient(int playerSlot, Vector3 angImpulse)
		{
			__ApplyLocalAngularVelocityImpulseToClient(playerSlot, &angImpulse);
		}

		/// <summary>
		/// Invokes a named input method on a specified client.
		/// </summary>
		/// <param name="playerSlot">The handle of the target client that will receive the input.</param>
		/// <param name="inputName">The name of the input action to invoke.</param>
		/// <param name="activatorHandle">The index of the player's slot that initiated the sequence of actions.</param>
		/// <param name="callerHandle">The index of the player's slot sending this event. Use -1 to specify</param>
		/// <param name="value">The value associated with the input action.</param>
		/// <param name="type">The type or classification of the value.</param>
		/// <param name="outputId">An identifier for tracking the output of this operation.</param>
		internal static delegate*<int, string, int, int, object, FieldType, int, void> AcceptClientInput = &___AcceptClientInput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, int, Variant256*, FieldType, int, void> __AcceptClientInput;
		private static void ___AcceptClientInput(int playerSlot, string inputName, int activatorHandle, int callerHandle, object value, FieldType type, int outputId)
		{
			var __inputName = NativeMethods.ConstructString(inputName);
			var __value = NativeMethods.ConstructVariant(value);
			try {
				__AcceptClientInput(playerSlot, &__inputName, activatorHandle, callerHandle, &__value, type, outputId);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__inputName);
				NativeMethods.DestroyVariant(&__value);
			}
		}

		/// <summary>
		/// Connects a script function to an player output.
		/// </summary>
		/// <param name="playerSlot">The handle of the player.</param>
		/// <param name="output">The name of the output to connect to.</param>
		/// <param name="functionName">The name of the script function to call.</param>
		internal static delegate*<int, string, string, void> ConnectClientOutput = &___ConnectClientOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __ConnectClientOutput;
		private static void ___ConnectClientOutput(int playerSlot, string output, string functionName)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__ConnectClientOutput(playerSlot, &__output, &__functionName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Disconnects a script function from an player output.
		/// </summary>
		/// <param name="playerSlot">The handle of the player.</param>
		/// <param name="output">The name of the output.</param>
		/// <param name="functionName">The name of the script function to disconnect.</param>
		internal static delegate*<int, string, string, void> DisconnectClientOutput = &___DisconnectClientOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, void> __DisconnectClientOutput;
		private static void ___DisconnectClientOutput(int playerSlot, string output, string functionName)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__DisconnectClientOutput(playerSlot, &__output, &__functionName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Disconnects a script function from an I/O event on a different player.
		/// </summary>
		/// <param name="playerSlot">The handle of the calling player.</param>
		/// <param name="output">The name of the output.</param>
		/// <param name="functionName">The function name to disconnect.</param>
		/// <param name="targetHandle">The handle of the entity whose output is being disconnected.</param>
		internal static delegate*<int, string, string, int, void> DisconnectClientRedirectedOutput = &___DisconnectClientRedirectedOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, void> __DisconnectClientRedirectedOutput;
		private static void ___DisconnectClientRedirectedOutput(int playerSlot, string output, string functionName, int targetHandle)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__DisconnectClientRedirectedOutput(playerSlot, &__output, &__functionName, targetHandle);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Fires an player output.
		/// </summary>
		/// <param name="playerSlot">The handle of the player firing the output.</param>
		/// <param name="outputName">The name of the output to fire.</param>
		/// <param name="activatorHandle">The entity activating the output.</param>
		/// <param name="callerHandle">The entity that called the output.</param>
		/// <param name="value">The value associated with the input action.</param>
		/// <param name="type">The type or classification of the value.</param>
		/// <param name="delay">Delay in seconds before firing the output.</param>
		internal static delegate*<int, string, int, int, object, FieldType, float, void> FireClientOutput = &___FireClientOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, int, Variant256*, FieldType, float, void> __FireClientOutput;
		private static void ___FireClientOutput(int playerSlot, string outputName, int activatorHandle, int callerHandle, object value, FieldType type, float delay)
		{
			var __outputName = NativeMethods.ConstructString(outputName);
			var __value = NativeMethods.ConstructVariant(value);
			try {
				__FireClientOutput(playerSlot, &__outputName, activatorHandle, callerHandle, &__value, type, delay);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__outputName);
				NativeMethods.DestroyVariant(&__value);
			}
		}

		/// <summary>
		/// Redirects an player output to call a function on another player.
		/// </summary>
		/// <param name="playerSlot">The handle of the player whose output is being redirected.</param>
		/// <param name="output">The name of the output to redirect.</param>
		/// <param name="functionName">The function name to call on the target player.</param>
		/// <param name="targetHandle">The handle of the entity that will receive the output call.</param>
		internal static delegate*<int, string, string, int, void> RedirectClientOutput = &___RedirectClientOutput;
		internal static delegate* unmanaged[Cdecl]<int, String192*, String192*, int, void> __RedirectClientOutput;
		private static void ___RedirectClientOutput(int playerSlot, string output, string functionName, int targetHandle)
		{
			var __output = NativeMethods.ConstructString(output);
			var __functionName = NativeMethods.ConstructString(functionName);
			try {
				__RedirectClientOutput(playerSlot, &__output, &__functionName, targetHandle);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__output);
				NativeMethods.DestroyString(&__functionName);
			}
		}

		/// <summary>
		/// Makes an client follow another client with optional bone merging.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot that will follow</param>
		/// <param name="attachmentHandle">The index of the player's slot to follow</param>
		/// <param name="boneMerge">If true, bones will be merged between entities</param>
		internal static delegate*<int, int, Bool8, void> FollowClient = &___FollowClient;
		internal static delegate* unmanaged[Cdecl]<int, int, Bool8, void> __FollowClient;
		private static void ___FollowClient(int playerSlot, int attachmentHandle, Bool8 boneMerge)
		{
			__FollowClient(playerSlot, attachmentHandle, boneMerge);
		}

		/// <summary>
		/// Makes an client follow another client and merge with a specific bone or attachment.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot that will follow</param>
		/// <param name="attachmentHandle">The index of the player's slot to follow</param>
		/// <param name="boneOrAttachName">Name of the bone or attachment point to merge with</param>
		internal static delegate*<int, int, string, void> FollowClientMerge = &___FollowClientMerge;
		internal static delegate* unmanaged[Cdecl]<int, int, String192*, void> __FollowClientMerge;
		private static void ___FollowClientMerge(int playerSlot, int attachmentHandle, string boneOrAttachName)
		{
			var __boneOrAttachName = NativeMethods.ConstructString(boneOrAttachName);
			try {
				__FollowClientMerge(playerSlot, attachmentHandle, &__boneOrAttachName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__boneOrAttachName);
			}
		}

		/// <summary>
		/// Apply damage to an client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot receiving damage</param>
		/// <param name="inflictorSlot">The index of the player's slot inflicting damage (e.g., projectile)</param>
		/// <param name="attackerSlot">The index of the attacking client</param>
		/// <param name="force">Direction and magnitude of force to apply</param>
		/// <param name="hitPos">Position where the damage hit occurred</param>
		/// <param name="damage">Amount of damage to apply</param>
		/// <param name="damageTypes">Bitfield of damage type flags</param>
		/// <returns>Amount of damage actually applied to the client</returns>
		internal static delegate*<int, int, int, Vector3, Vector3, float, DamageTypes, int> TakeClientDamage = &___TakeClientDamage;
		internal static delegate* unmanaged[Cdecl]<int, int, int, Vector3*, Vector3*, float, DamageTypes, int> __TakeClientDamage;
		private static int ___TakeClientDamage(int playerSlot, int inflictorSlot, int attackerSlot, Vector3 force, Vector3 hitPos, float damage, DamageTypes damageTypes)
		{
			int __retVal = __TakeClientDamage(playerSlot, inflictorSlot, attackerSlot, &force, &hitPos, damage, damageTypes);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the pawn entity pointer associated with a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>A pointer to the client's pawn entity, or nullptr if the client or controller is invalid.</returns>
		internal static delegate*<int, nint> GetClientPawn = &___GetClientPawn;
		internal static delegate* unmanaged[Cdecl]<int, nint> __GetClientPawn;
		private static nint ___GetClientPawn(int playerSlot)
		{
			nint __retVal = __GetClientPawn(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Processes the target string to determine if one user can target another.
		/// </summary>
		/// <param name="caller">The index of the player's slot making the target request.</param>
		/// <param name="target">The target string specifying the player or players to be targeted.</param>
		/// <returns>A vector where the result of the targeting operation will be stored.</returns>
		internal static delegate*<int, string, int[]> ProcessTargetString = &___ProcessTargetString;
		internal static delegate* unmanaged[Cdecl]<int, String192*, Vector192> __ProcessTargetString;
		private static int[] ___ProcessTargetString(int caller, string target)
		{
			int[] __retVal;
			Vector192 __retVal_native;
			var __target = NativeMethods.ConstructString(target);
			try {
				__retVal_native = __ProcessTargetString(caller, &__target);
				// Unmarshal - Convert native data to managed data.
				__retVal = new int[NativeMethods.GetVectorSizeInt32(&__retVal_native)];
				NativeMethods.GetVectorDataInt32(&__retVal_native, __retVal);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorInt32(&__retVal_native);
				NativeMethods.DestroyString(&__target);
			}
			return __retVal;
		}

		/// <summary>
		/// Switches the player's team.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="team">The team index to switch the client to.</param>
		internal static delegate*<int, CSTeam, void> SwitchClientTeam = &___SwitchClientTeam;
		internal static delegate* unmanaged[Cdecl]<int, CSTeam, void> __SwitchClientTeam;
		private static void ___SwitchClientTeam(int playerSlot, CSTeam team)
		{
			__SwitchClientTeam(playerSlot, team);
		}

		/// <summary>
		/// Respawns a player.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to respawn.</param>
		internal static delegate*<int, void> RespawnClient = &___RespawnClient;
		internal static delegate* unmanaged[Cdecl]<int, void> __RespawnClient;
		private static void ___RespawnClient(int playerSlot)
		{
			__RespawnClient(playerSlot);
		}

		/// <summary>
		/// Forces a player to commit suicide.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="explode">If true, the client will explode upon death.</param>
		/// <param name="force">If true, the suicide will be forced.</param>
		internal static delegate*<int, Bool8, Bool8, void> ForcePlayerSuicide = &___ForcePlayerSuicide;
		internal static delegate* unmanaged[Cdecl]<int, Bool8, Bool8, void> __ForcePlayerSuicide;
		private static void ___ForcePlayerSuicide(int playerSlot, Bool8 explode, Bool8 force)
		{
			__ForcePlayerSuicide(playerSlot, explode, force);
		}

		/// <summary>
		/// Disconnects a client from the server as soon as the next frame starts.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to be kicked.</param>
		internal static delegate*<int, void> KickClient = &___KickClient;
		internal static delegate* unmanaged[Cdecl]<int, void> __KickClient;
		private static void ___KickClient(int playerSlot)
		{
			__KickClient(playerSlot);
		}

		/// <summary>
		/// Bans a client for a specified duration.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot to be banned.</param>
		/// <param name="duration">Duration of the ban in seconds.</param>
		/// <param name="kick">If true, the client will be kicked immediately after being banned.</param>
		internal static delegate*<int, float, Bool8, void> BanClient = &___BanClient;
		internal static delegate* unmanaged[Cdecl]<int, float, Bool8, void> __BanClient;
		private static void ___BanClient(int playerSlot, float duration, Bool8 kick)
		{
			__BanClient(playerSlot, duration, kick);
		}

		/// <summary>
		/// Bans an identity (either an IP address or a Steam authentication string).
		/// </summary>
		/// <param name="steamId">The Steam ID to ban.</param>
		/// <param name="duration">Duration of the ban in seconds.</param>
		/// <param name="kick">If true, the client will be kicked immediately after being banned.</param>
		internal static delegate*<ulong, float, Bool8, void> BanIdentity = &___BanIdentity;
		internal static delegate* unmanaged[Cdecl]<ulong, float, Bool8, void> __BanIdentity;
		private static void ___BanIdentity(ulong steamId, float duration, Bool8 kick)
		{
			__BanIdentity(steamId, duration, kick);
		}

		/// <summary>
		/// Retrieves the handle of the client's currently active weapon.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The entity handle of the active weapon, or INVALID_EHANDLE_INDEX if the client is invalid or has no active weapon.</returns>
		internal static delegate*<int, int> GetClientActiveWeapon = &___GetClientActiveWeapon;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientActiveWeapon;
		private static int ___GetClientActiveWeapon(int playerSlot)
		{
			int __retVal = __GetClientActiveWeapon(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Retrieves a list of weapon handles owned by the client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>A vector of entity handles for the client's weapons, or an empty vector if the client is invalid or has no weapons.</returns>
		internal static delegate*<int, int[]> GetClientWeapons = &___GetClientWeapons;
		internal static delegate* unmanaged[Cdecl]<int, Vector192> __GetClientWeapons;
		private static int[] ___GetClientWeapons(int playerSlot)
		{
			int[] __retVal;
			Vector192 __retVal_native;
			try {
				__retVal_native = __GetClientWeapons(playerSlot);
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
		/// Removes all weapons from a client, with an option to remove the suit as well.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="removeSuit">A boolean indicating whether to also remove the client's suit.</param>
		internal static delegate*<int, Bool8, void> RemoveWeapons = &___RemoveWeapons;
		internal static delegate* unmanaged[Cdecl]<int, Bool8, void> __RemoveWeapons;
		private static void ___RemoveWeapons(int playerSlot, Bool8 removeSuit)
		{
			__RemoveWeapons(playerSlot, removeSuit);
		}

		/// <summary>
		/// Forces a player to drop their weapon.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="weaponHandle">The handle of weapon to drop.</param>
		/// <param name="target">Target direction.</param>
		/// <param name="velocity">Velocity to toss weapon or zero to just drop weapon.</param>
		internal static delegate*<int, int, Vector3, Vector3, void> DropWeapon = &___DropWeapon;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3*, Vector3*, void> __DropWeapon;
		private static void ___DropWeapon(int playerSlot, int weaponHandle, Vector3 target, Vector3 velocity)
		{
			__DropWeapon(playerSlot, weaponHandle, &target, &velocity);
		}

		/// <summary>
		/// Selects a player's weapon.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="weaponHandle">The handle of weapon to bump.</param>
		internal static delegate*<int, int, void> SelectWeapon = &___SelectWeapon;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SelectWeapon;
		private static void ___SelectWeapon(int playerSlot, int weaponHandle)
		{
			__SelectWeapon(playerSlot, weaponHandle);
		}

		/// <summary>
		/// Switches a player's weapon.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="weaponHandle">The handle of weapon to switch.</param>
		internal static delegate*<int, int, void> SwitchWeapon = &___SwitchWeapon;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SwitchWeapon;
		private static void ___SwitchWeapon(int playerSlot, int weaponHandle)
		{
			__SwitchWeapon(playerSlot, weaponHandle);
		}

		/// <summary>
		/// Removes a player's weapon.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="weaponHandle">The handle of weapon to remove.</param>
		internal static delegate*<int, int, void> RemoveWeapon = &___RemoveWeapon;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __RemoveWeapon;
		private static void ___RemoveWeapon(int playerSlot, int weaponHandle)
		{
			__RemoveWeapon(playerSlot, weaponHandle);
		}

		/// <summary>
		/// Gives a named item (e.g., weapon) to a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="itemName">The name of the item to give.</param>
		/// <returns>The entity handle of the created item, or INVALID_EHANDLE_INDEX if the client or item is invalid.</returns>
		internal static delegate*<int, string, int> GiveNamedItem = &___GiveNamedItem;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __GiveNamedItem;
		private static int ___GiveNamedItem(int playerSlot, string itemName)
		{
			int __retVal;
			var __itemName = NativeMethods.ConstructString(itemName);
			try {
				__retVal = __GiveNamedItem(playerSlot, &__itemName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__itemName);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the state of a specific button for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="buttonIndex">The index of the button (0-2).</param>
		/// <returns>uint64_t The state of the specified button, or 0 if the client or button index is invalid.</returns>
		internal static delegate*<int, int, ulong> GetClientButtons = &___GetClientButtons;
		internal static delegate* unmanaged[Cdecl]<int, int, ulong> __GetClientButtons;
		private static ulong ___GetClientButtons(int playerSlot, int buttonIndex)
		{
			ulong __retVal = __GetClientButtons(playerSlot, buttonIndex);
			return __retVal;
		}

		/// <summary>
		/// Returns the client's armor value.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The armor value of the client.</returns>
		internal static delegate*<int, int> GetClientArmor = &___GetClientArmor;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientArmor;
		private static int ___GetClientArmor(int playerSlot)
		{
			int __retVal = __GetClientArmor(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the client's armor value.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="armor">The armor value to set.</param>
		internal static delegate*<int, int, void> SetClientArmor = &___SetClientArmor;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientArmor;
		private static void ___SetClientArmor(int playerSlot, int armor)
		{
			__SetClientArmor(playerSlot, armor);
		}

		/// <summary>
		/// Returns the client's speed value.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The speed value of the client.</returns>
		internal static delegate*<int, float> GetClientSpeed = &___GetClientSpeed;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetClientSpeed;
		private static float ___GetClientSpeed(int playerSlot)
		{
			float __retVal = __GetClientSpeed(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the client's speed value.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="speed">The speed value to set.</param>
		internal static delegate*<int, float, void> SetClientSpeed = &___SetClientSpeed;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetClientSpeed;
		private static void ___SetClientSpeed(int playerSlot, float speed)
		{
			__SetClientSpeed(playerSlot, speed);
		}

		/// <summary>
		/// Retrieves the amount of money a client has.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The amount of money the client has, or 0 if the player slot is invalid.</returns>
		internal static delegate*<int, int> GetClientMoney = &___GetClientMoney;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientMoney;
		private static int ___GetClientMoney(int playerSlot)
		{
			int __retVal = __GetClientMoney(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the amount of money for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="money">The amount of money to set.</param>
		internal static delegate*<int, int, void> SetClientMoney = &___SetClientMoney;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientMoney;
		private static void ___SetClientMoney(int playerSlot, int money)
		{
			__SetClientMoney(playerSlot, money);
		}

		/// <summary>
		/// Retrieves the number of kills for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The number of kills the client has, or 0 if the player slot is invalid.</returns>
		internal static delegate*<int, int> GetClientKills = &___GetClientKills;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientKills;
		private static int ___GetClientKills(int playerSlot)
		{
			int __retVal = __GetClientKills(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the number of kills for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="kills">The number of kills to set.</param>
		internal static delegate*<int, int, void> SetClientKills = &___SetClientKills;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientKills;
		private static void ___SetClientKills(int playerSlot, int kills)
		{
			__SetClientKills(playerSlot, kills);
		}

		/// <summary>
		/// Retrieves the number of deaths for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The number of deaths the client has, or 0 if the player slot is invalid.</returns>
		internal static delegate*<int, int> GetClientDeaths = &___GetClientDeaths;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientDeaths;
		private static int ___GetClientDeaths(int playerSlot)
		{
			int __retVal = __GetClientDeaths(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the number of deaths for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="deaths">The number of deaths to set.</param>
		internal static delegate*<int, int, void> SetClientDeaths = &___SetClientDeaths;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientDeaths;
		private static void ___SetClientDeaths(int playerSlot, int deaths)
		{
			__SetClientDeaths(playerSlot, deaths);
		}

		/// <summary>
		/// Retrieves the number of assists for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The number of assists the client has, or 0 if the player slot is invalid.</returns>
		internal static delegate*<int, int> GetClientAssists = &___GetClientAssists;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientAssists;
		private static int ___GetClientAssists(int playerSlot)
		{
			int __retVal = __GetClientAssists(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the number of assists for a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="assists">The number of assists to set.</param>
		internal static delegate*<int, int, void> SetClientAssists = &___SetClientAssists;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientAssists;
		private static void ___SetClientAssists(int playerSlot, int assists)
		{
			__SetClientAssists(playerSlot, assists);
		}

		/// <summary>
		/// Retrieves the total damage dealt by a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <returns>The total damage dealt by the client, or 0 if the player slot is invalid.</returns>
		internal static delegate*<int, int> GetClientDamage = &___GetClientDamage;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetClientDamage;
		private static int ___GetClientDamage(int playerSlot)
		{
			int __retVal = __GetClientDamage(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Sets the total damage dealt by a client.
		/// </summary>
		/// <param name="playerSlot">The index of the player's slot.</param>
		/// <param name="damage">The amount of damage to set.</param>
		internal static delegate*<int, int, void> SetClientDamage = &___SetClientDamage;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetClientDamage;
		private static void ___SetClientDamage(int playerSlot, int damage)
		{
			__SetClientDamage(playerSlot, damage);
		}

	}

#pragma warning restore CS0649
}
