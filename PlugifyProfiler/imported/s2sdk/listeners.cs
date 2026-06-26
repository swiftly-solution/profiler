using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: listeners)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnectCallback, void> OnClientConnect_Register = &___OnClientConnect_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnect_Register;
		private static void ___OnClientConnect_Register(OnClientConnectCallback callback)
		{
			__OnClientConnect_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnectCallback, void> OnClientConnect_Unregister = &___OnClientConnect_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnect_Unregister;
		private static void ___OnClientConnect_Unregister(OnClientConnectCallback callback)
		{
			__OnClientConnect_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnect_PostCallback, void> OnClientConnect_Post_Register = &___OnClientConnect_Post_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnect_Post_Register;
		private static void ___OnClientConnect_Post_Register(OnClientConnect_PostCallback callback)
		{
			__OnClientConnect_Post_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnect_PostCallback, void> OnClientConnect_Post_Unregister = &___OnClientConnect_Post_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnect_Post_Unregister;
		private static void ___OnClientConnect_Post_Unregister(OnClientConnect_PostCallback callback)
		{
			__OnClientConnect_Post_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnectedCallback, void> OnClientConnected_Register = &___OnClientConnected_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnected_Register;
		private static void ___OnClientConnected_Register(OnClientConnectedCallback callback)
		{
			__OnClientConnected_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientConnectedCallback, void> OnClientConnected_Unregister = &___OnClientConnected_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientConnected_Unregister;
		private static void ___OnClientConnected_Unregister(OnClientConnectedCallback callback)
		{
			__OnClientConnected_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientPutInServerCallback, void> OnClientPutInServer_Register = &___OnClientPutInServer_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientPutInServer_Register;
		private static void ___OnClientPutInServer_Register(OnClientPutInServerCallback callback)
		{
			__OnClientPutInServer_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientPutInServerCallback, void> OnClientPutInServer_Unregister = &___OnClientPutInServer_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientPutInServer_Unregister;
		private static void ___OnClientPutInServer_Unregister(OnClientPutInServerCallback callback)
		{
			__OnClientPutInServer_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientDisconnectCallback, void> OnClientDisconnect_Register = &___OnClientDisconnect_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientDisconnect_Register;
		private static void ___OnClientDisconnect_Register(OnClientDisconnectCallback callback)
		{
			__OnClientDisconnect_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientDisconnectCallback, void> OnClientDisconnect_Unregister = &___OnClientDisconnect_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientDisconnect_Unregister;
		private static void ___OnClientDisconnect_Unregister(OnClientDisconnectCallback callback)
		{
			__OnClientDisconnect_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientDisconnect_PostCallback, void> OnClientDisconnect_Post_Register = &___OnClientDisconnect_Post_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientDisconnect_Post_Register;
		private static void ___OnClientDisconnect_Post_Register(OnClientDisconnect_PostCallback callback)
		{
			__OnClientDisconnect_Post_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientDisconnect_PostCallback, void> OnClientDisconnect_Post_Unregister = &___OnClientDisconnect_Post_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientDisconnect_Post_Unregister;
		private static void ___OnClientDisconnect_Post_Unregister(OnClientDisconnect_PostCallback callback)
		{
			__OnClientDisconnect_Post_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientActiveCallback, void> OnClientActive_Register = &___OnClientActive_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientActive_Register;
		private static void ___OnClientActive_Register(OnClientActiveCallback callback)
		{
			__OnClientActive_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientActiveCallback, void> OnClientActive_Unregister = &___OnClientActive_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientActive_Unregister;
		private static void ___OnClientActive_Unregister(OnClientActiveCallback callback)
		{
			__OnClientActive_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientFullyConnectCallback, void> OnClientFullyConnect_Register = &___OnClientFullyConnect_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientFullyConnect_Register;
		private static void ___OnClientFullyConnect_Register(OnClientFullyConnectCallback callback)
		{
			__OnClientFullyConnect_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientFullyConnectCallback, void> OnClientFullyConnect_Unregister = &___OnClientFullyConnect_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientFullyConnect_Unregister;
		private static void ___OnClientFullyConnect_Unregister(OnClientFullyConnectCallback callback)
		{
			__OnClientFullyConnect_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientSettingsChangedCallback, void> OnClientSettingsChanged_Register = &___OnClientSettingsChanged_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientSettingsChanged_Register;
		private static void ___OnClientSettingsChanged_Register(OnClientSettingsChangedCallback callback)
		{
			__OnClientSettingsChanged_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientSettingsChangedCallback, void> OnClientSettingsChanged_Unregister = &___OnClientSettingsChanged_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientSettingsChanged_Unregister;
		private static void ___OnClientSettingsChanged_Unregister(OnClientSettingsChangedCallback callback)
		{
			__OnClientSettingsChanged_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientAuthenticatedCallback, void> OnClientAuthenticated_Register = &___OnClientAuthenticated_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientAuthenticated_Register;
		private static void ___OnClientAuthenticated_Register(OnClientAuthenticatedCallback callback)
		{
			__OnClientAuthenticated_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnClientAuthenticatedCallback, void> OnClientAuthenticated_Unregister = &___OnClientAuthenticated_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnClientAuthenticated_Unregister;
		private static void ___OnClientAuthenticated_Unregister(OnClientAuthenticatedCallback callback)
		{
			__OnClientAuthenticated_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnRoundTerminatedCallback, void> OnRoundTerminated_Register = &___OnRoundTerminated_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnRoundTerminated_Register;
		private static void ___OnRoundTerminated_Register(OnRoundTerminatedCallback callback)
		{
			__OnRoundTerminated_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnRoundTerminatedCallback, void> OnRoundTerminated_Unregister = &___OnRoundTerminated_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnRoundTerminated_Unregister;
		private static void ___OnRoundTerminated_Unregister(OnRoundTerminatedCallback callback)
		{
			__OnRoundTerminated_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityCreatedCallback, void> OnEntityCreated_Register = &___OnEntityCreated_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityCreated_Register;
		private static void ___OnEntityCreated_Register(OnEntityCreatedCallback callback)
		{
			__OnEntityCreated_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityCreatedCallback, void> OnEntityCreated_Unregister = &___OnEntityCreated_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityCreated_Unregister;
		private static void ___OnEntityCreated_Unregister(OnEntityCreatedCallback callback)
		{
			__OnEntityCreated_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityDeletedCallback, void> OnEntityDeleted_Register = &___OnEntityDeleted_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityDeleted_Register;
		private static void ___OnEntityDeleted_Register(OnEntityDeletedCallback callback)
		{
			__OnEntityDeleted_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityDeletedCallback, void> OnEntityDeleted_Unregister = &___OnEntityDeleted_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityDeleted_Unregister;
		private static void ___OnEntityDeleted_Unregister(OnEntityDeletedCallback callback)
		{
			__OnEntityDeleted_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityParentChangedCallback, void> OnEntityParentChanged_Register = &___OnEntityParentChanged_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityParentChanged_Register;
		private static void ___OnEntityParentChanged_Register(OnEntityParentChangedCallback callback)
		{
			__OnEntityParentChanged_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnEntityParentChangedCallback, void> OnEntityParentChanged_Unregister = &___OnEntityParentChanged_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnEntityParentChanged_Unregister;
		private static void ___OnEntityParentChanged_Unregister(OnEntityParentChangedCallback callback)
		{
			__OnEntityParentChanged_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerCheckTransmitCallback, void> OnServerCheckTransmit_Register = &___OnServerCheckTransmit_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerCheckTransmit_Register;
		private static void ___OnServerCheckTransmit_Register(OnServerCheckTransmitCallback callback)
		{
			__OnServerCheckTransmit_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerCheckTransmitCallback, void> OnServerCheckTransmit_Unregister = &___OnServerCheckTransmit_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerCheckTransmit_Unregister;
		private static void ___OnServerCheckTransmit_Unregister(OnServerCheckTransmitCallback callback)
		{
			__OnServerCheckTransmit_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerStartupCallback, void> OnServerStartup_Register = &___OnServerStartup_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerStartup_Register;
		private static void ___OnServerStartup_Register(OnServerStartupCallback callback)
		{
			__OnServerStartup_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerStartupCallback, void> OnServerStartup_Unregister = &___OnServerStartup_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerStartup_Unregister;
		private static void ___OnServerStartup_Unregister(OnServerStartupCallback callback)
		{
			__OnServerStartup_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerActivateCallback, void> OnServerActivate_Register = &___OnServerActivate_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerActivate_Register;
		private static void ___OnServerActivate_Register(OnServerActivateCallback callback)
		{
			__OnServerActivate_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerActivateCallback, void> OnServerActivate_Unregister = &___OnServerActivate_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerActivate_Unregister;
		private static void ___OnServerActivate_Unregister(OnServerActivateCallback callback)
		{
			__OnServerActivate_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerSpawnCallback, void> OnServerSpawn_Register = &___OnServerSpawn_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerSpawn_Register;
		private static void ___OnServerSpawn_Register(OnServerSpawnCallback callback)
		{
			__OnServerSpawn_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerSpawnCallback, void> OnServerSpawn_Unregister = &___OnServerSpawn_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerSpawn_Unregister;
		private static void ___OnServerSpawn_Unregister(OnServerSpawnCallback callback)
		{
			__OnServerSpawn_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerStartedCallback, void> OnServerStarted_Register = &___OnServerStarted_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerStarted_Register;
		private static void ___OnServerStarted_Register(OnServerStartedCallback callback)
		{
			__OnServerStarted_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnServerStartedCallback, void> OnServerStarted_Unregister = &___OnServerStarted_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnServerStarted_Unregister;
		private static void ___OnServerStarted_Unregister(OnServerStartedCallback callback)
		{
			__OnServerStarted_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnMapStartCallback, void> OnMapStart_Register = &___OnMapStart_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnMapStart_Register;
		private static void ___OnMapStart_Register(OnMapStartCallback callback)
		{
			__OnMapStart_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnMapStartCallback, void> OnMapStart_Unregister = &___OnMapStart_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnMapStart_Unregister;
		private static void ___OnMapStart_Unregister(OnMapStartCallback callback)
		{
			__OnMapStart_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnMapEndCallback, void> OnMapEnd_Register = &___OnMapEnd_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnMapEnd_Register;
		private static void ___OnMapEnd_Register(OnMapEndCallback callback)
		{
			__OnMapEnd_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnMapEndCallback, void> OnMapEnd_Unregister = &___OnMapEnd_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnMapEnd_Unregister;
		private static void ___OnMapEnd_Unregister(OnMapEndCallback callback)
		{
			__OnMapEnd_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnGameFrameCallback, void> OnGameFrame_Register = &___OnGameFrame_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnGameFrame_Register;
		private static void ___OnGameFrame_Register(OnGameFrameCallback callback)
		{
			__OnGameFrame_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnGameFrameCallback, void> OnGameFrame_Unregister = &___OnGameFrame_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnGameFrame_Unregister;
		private static void ___OnGameFrame_Unregister(OnGameFrameCallback callback)
		{
			__OnGameFrame_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnUpdateWhenNotInGameCallback, void> OnUpdateWhenNotInGame_Register = &___OnUpdateWhenNotInGame_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnUpdateWhenNotInGame_Register;
		private static void ___OnUpdateWhenNotInGame_Register(OnUpdateWhenNotInGameCallback callback)
		{
			__OnUpdateWhenNotInGame_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnUpdateWhenNotInGameCallback, void> OnUpdateWhenNotInGame_Unregister = &___OnUpdateWhenNotInGame_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnUpdateWhenNotInGame_Unregister;
		private static void ___OnUpdateWhenNotInGame_Unregister(OnUpdateWhenNotInGameCallback callback)
		{
			__OnUpdateWhenNotInGame_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Register callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnPreWorldUpdateCallback, void> OnPreWorldUpdate_Register = &___OnPreWorldUpdate_Register;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnPreWorldUpdate_Register;
		private static void ___OnPreWorldUpdate_Register(OnPreWorldUpdateCallback callback)
		{
			__OnPreWorldUpdate_Register(Marshalling.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Unregister callback to event.
		/// </summary>
		/// <param name="callback">Function callback.</param>
		internal static delegate*<OnPreWorldUpdateCallback, void> OnPreWorldUpdate_Unregister = &___OnPreWorldUpdate_Unregister;
		internal static delegate* unmanaged[Cdecl]<nint, void> __OnPreWorldUpdate_Unregister;
		private static void ___OnPreWorldUpdate_Unregister(OnPreWorldUpdateCallback callback)
		{
			__OnPreWorldUpdate_Unregister(Marshalling.GetFunctionPointerForDelegate(callback));
		}

	}

#pragma warning restore CS0649
}
