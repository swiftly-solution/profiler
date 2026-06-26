using System;
using System.Numerics;

using Plugify;

// Generated from s2sdk.pplugin

namespace s2sdk {
#pragma warning disable CS0649

	/// <summary>
	/// Handles the execution of a command triggered by a caller. This function processes the command, interprets its context, and handles any provided arguments.
	/// </summary>
	public delegate ResultType CommandCallback(int caller, CommandCallingContext context, string[] arguments);

	/// <summary>
	/// Handles changes to a console variable's value. This function is called whenever the value of a specific console variable is modified.
	/// </summary>
	public delegate void ChangeCallback(ulong conVarHandle, string newValue, string oldValue);

	/// <summary>
	/// Handles changes to a console variable's value. This function is called whenever the value of a specific console variable is modified.
	/// </summary>
	public delegate void CvarValueCallback(int playerSlot, int cookie, CvarValueStatus code, string name, string value, object[] data);

	/// <summary>
	/// Defines a QueueTask Callback.
	/// </summary>
	public delegate void TaskCallback(object[] userData);

	/// <summary>
	/// This function is a callback handler for entity output events. It is triggered when a specific output event is activated, and it handles the process by passing the activator, the caller, and a delay parameter for the output.
	/// </summary>
	public delegate ResultType HookEntityOutputCallback(int activatorHandle, int callerHandle, float flDelay);

	/// <summary>
	/// Handles events triggered by the game event system. This function processes the event data, determines the necessary action, and optionally prevents event broadcasting.
	/// </summary>
	public delegate ResultType EventCallback(string name, nint event_, Bool8 dontBroadcast);

	/// <summary>
	/// Handles the final result of a Yes/No vote. This function is called when a vote concludes, and is responsible for determining whether the vote passed based on the number of 'yes' and 'no' votes. Also receives context about the clients who participated in the vote.
	/// </summary>
	public delegate Bool8 YesNoVoteResult(int numVotes, int yesVotes, int noVotes, int numClients, int[] clientInfoSlot, int[] clientInfoItem);

	public delegate void YesNoVoteHandler(VoteAction action, int clientSlot, int choice);

	/// <summary>
	/// This function is invoked when a timer event occurs. It handles the timer-related logic and performs necessary actions based on the event.
	/// </summary>
	public delegate void TimerCallback(uint timer, object[] userData);

	/// <summary>
	/// Called on client connection. If you return true, the client will be allowed in the server. If you return false (or return nothing), the client will be rejected. If the client is rejected by this forward or any other, OnClientDisconnect will not be called.<br>Note: Do not write to rejectmsg if you plan on returning true. If multiple plugins write to the string buffer, it is not defined which plugin's string will be shown to the client, but it is guaranteed one of them will.
	/// </summary>
	public delegate Bool8 OnClientConnectCallback(int playerSlot, string name, string networkId);

	/// <summary>
	/// Called on client connection.
	/// </summary>
	public delegate void OnClientConnect_PostCallback(int playerSlot);

	/// <summary>
	/// Called once a client successfully connects. This callback is paired with OnClientDisconnect.
	/// </summary>
	public delegate void OnClientConnectedCallback(int playerSlot);

	/// <summary>
	/// Called when a client is entering the game.
	/// </summary>
	public delegate void OnClientPutInServerCallback(int playerSlot);

	/// <summary>
	/// Called when a client is disconnecting from the server.
	/// </summary>
	public delegate void OnClientDisconnectCallback(int playerSlot);

	/// <summary>
	/// Called when a client is disconnected from the server.
	/// </summary>
	public delegate void OnClientDisconnect_PostCallback(int playerSlot, int reason);

	/// <summary>
	/// Called when a client is activated by the game.
	/// </summary>
	public delegate void OnClientActiveCallback(int playerSlot, Bool8 isActive);

	/// <summary>
	/// Called when a client is fully connected to the game.
	/// </summary>
	public delegate void OnClientFullyConnectCallback(int playerSlot);

	/// <summary>
	/// Called whenever the client's settings are changed.
	/// </summary>
	public delegate void OnClientSettingsChangedCallback(int playerSlot);

	/// <summary>
	/// Called when a client is fully connected to the game.
	/// </summary>
	public delegate void OnClientAuthenticatedCallback(int playerSlot, ulong steamID);

	/// <summary>
	/// Called right before a round terminates.
	/// </summary>
	public delegate void OnRoundTerminatedCallback(float delay, CSRoundEndReason reason);

	/// <summary>
	/// Called when an entity is created.
	/// </summary>
	public delegate void OnEntityCreatedCallback(int entityHandle);

	/// <summary>
	/// Called when when an entity is destroyed.
	/// </summary>
	public delegate void OnEntityDeletedCallback(int entityHandle);

	/// <summary>
	/// When an entity is reparented to another entity.
	/// </summary>
	public delegate void OnEntityParentChangedCallback(int entityHandle, int parentHandle);

	/// <summary>
	/// When entities is transmitted to another entities.
	/// </summary>
	public delegate void OnServerCheckTransmitCallback(nint[] checkTransmitInfoList);

	/// <summary>
	/// Called on every server startup.
	/// </summary>
	public delegate void OnServerStartupCallback();

	/// <summary>
	/// Called on every server activate.
	/// </summary>
	public delegate void OnServerActivateCallback();

	/// <summary>
	/// Called on every server spawn.
	/// </summary>
	public delegate void OnServerSpawnCallback();

	/// <summary>
	/// Called on every server started only once.
	/// </summary>
	public delegate void OnServerStartedCallback();

	/// <summary>
	/// Called on every map start.
	/// </summary>
	public delegate void OnMapStartCallback();

	/// <summary>
	/// Called on every map end.
	/// </summary>
	public delegate void OnMapEndCallback();

	/// <summary>
	/// Called before every server frame. Note that you should avoid doing expensive computations or declaring large local arrays.
	/// </summary>
	public delegate void OnGameFrameCallback(Bool8 simulating, Bool8 firstTick, Bool8 lastTick);

	/// <summary>
	/// Called when the server is not in game.
	/// </summary>
	public delegate void OnUpdateWhenNotInGameCallback(float deltaTime);

	/// <summary>
	/// Called before every server frame, before entities are updated.
	/// </summary>
	public delegate void OnPreWorldUpdateCallback(Bool8 simulating);

	/// <summary>
	/// Callback function for user messages.
	/// </summary>
	public delegate ResultType UserMessageCallback(nint userMessage);

#pragma warning restore CS0649
}
