using System;

// Generated from s2sdk.pplugin

namespace s2sdk {
#pragma warning disable CS0649

	/// <summary>
	/// Enum representing various movement types for entities.
	/// </summary>

	[Flags]	public enum MoveType : int
	{
		/// <summary>
		/// Never moves.
		/// </summary>
		None = 0,
		/// <summary>
		/// Previously isometric movement type.
		/// </summary>
		Isometric = 1,
		/// <summary>
		/// Player only - moving on the ground.
		/// </summary>
		Walk = 2,
		/// <summary>
		/// No gravity, but still collides with stuff.
		/// </summary>
		Fly = 3,
		/// <summary>
		/// Flies through the air and is affected by gravity.
		/// </summary>
		Flygravity = 4,
		/// <summary>
		/// Uses VPHYSICS for simulation.
		/// </summary>
		Vphysics = 5,
		/// <summary>
		/// No clip to world, push and crush.
		/// </summary>
		Push = 6,
		/// <summary>
		/// No gravity, no collisions, still has velocity/avelocity.
		/// </summary>
		Noclip = 7,
		/// <summary>
		/// Used by players only when going onto a ladder.
		/// </summary>
		Ladder = 8,
		/// <summary>
		/// Observer movement, depends on player's observer mode.
		/// </summary>
		Observer = 9,
		/// <summary>
		/// Allows the entity to describe its own physics.
		/// </summary>
		Custom = 10
	}

	/// <summary>
	/// Enum representing rendering modes for materials.
	/// </summary>

	[Flags]	public enum RenderMode : byte
	{
		/// <summary>
		/// Standard rendering mode (src).
		/// </summary>
		Normal = 0,
		/// <summary>
		/// Composite: c*a + dest*(1-a).
		/// </summary>
		TransColor = 1,
		/// <summary>
		/// Composite: src*a + dest*(1-a).
		/// </summary>
		TransTexture = 2,
		/// <summary>
		/// Composite: src*a + dest -- No Z buffer checks -- Fixed size in screen space.
		/// </summary>
		Glow = 3,
		/// <summary>
		/// Composite: src*srca + dest*(1-srca).
		/// </summary>
		TransAlpha = 4,
		/// <summary>
		/// Composite: src*a + dest.
		/// </summary>
		TransAdd = 5,
		/// <summary>
		/// Not drawn, used for environmental effects.
		/// </summary>
		Environmental = 6,
		/// <summary>
		/// Uses a fractional frame value to blend between animation frames.
		/// </summary>
		TransAddFrameBlend = 7,
		/// <summary>
		/// Composite: src + dest*(1-a).
		/// </summary>
		TransAlphaAdd = 8,
		/// <summary>
		/// Same as Glow but not fixed size in screen space.
		/// </summary>
		WorldGlow = 9,
		/// <summary>
		/// No rendering.
		/// </summary>
		None = 10,
		/// <summary>
		/// Developer visualizer rendering mode.
		/// </summary>
		DevVisualizer = 11
	}

	/// <summary>
	/// Enum representing the possible teams in Counter-Strike.
	/// </summary>

	[Flags]	public enum CSTeam : int
	{
		/// <summary>
		/// No team.
		/// </summary>
		None = 0,
		/// <summary>
		/// Spectator team.
		/// </summary>
		Spectator = 1,
		/// <summary>
		/// Terrorist team.
		/// </summary>
		T = 2,
		/// <summary>
		/// Counter-Terrorist team.
		/// </summary>
		CT = 3
	}

	/// <summary>
	/// Represents the possible types of data that can be passed as a value in input actions.
	/// </summary>

	[Flags]	public enum FieldType : int
	{
		/// <summary>
		/// Automatically detect the type of the value.
		/// </summary>
		Auto = 0,
		/// <summary>
		/// A 32-bit floating-point number.
		/// </summary>
		Float32 = 1,
		/// <summary>
		/// A 64-bit floating-point number.
		/// </summary>
		Float64 = 2,
		/// <summary>
		/// A 32-bit signed integer.
		/// </summary>
		Int32 = 3,
		/// <summary>
		/// A 32-bit unsigned integer.
		/// </summary>
		UInt32 = 4,
		/// <summary>
		/// A 64-bit signed integer.
		/// </summary>
		Int64 = 5,
		/// <summary>
		/// A 64-bit unsigned integer.
		/// </summary>
		UInt64 = 6,
		/// <summary>
		/// A boolean value (true or false).
		/// </summary>
		Boolean = 7,
		/// <summary>
		/// A single character.
		/// </summary>
		Character = 8,
		/// <summary>
		/// A managed string object.
		/// </summary>
		String = 9,
		/// <summary>
		/// A null-terminated C-style string.
		/// </summary>
		CString = 10,
		/// <summary>
		/// A script handle, typically for scripting integration.
		/// </summary>
		HScript = 11,
		/// <summary>
		/// An entity handle, used to reference an entity within the system.
		/// </summary>
		EHandle = 12,
		/// <summary>
		/// A resource handle, such as a file or asset reference.
		/// </summary>
		Resource = 13,
		/// <summary>
		/// A 3D vector, typically representing position or direction.
		/// </summary>
		Vector3d = 14,
		/// <summary>
		/// A 2D vector, for planar data or coordinates.
		/// </summary>
		Vector2d = 15,
		/// <summary>
		/// A 4D vector, often used for advanced mathematical representations.
		/// </summary>
		Vector4d = 16,
		/// <summary>
		/// A 32-bit color value (RGBA).
		/// </summary>
		Color32 = 17,
		/// <summary>
		/// A quaternion-based angle representation.
		/// </summary>
		QAngle = 18,
		/// <summary>
		/// A quaternion, used for rotation and orientation calculations.
		/// </summary>
		Quaternion = 19
	}

	/// <summary>
	/// Enum representing various damage types.
	/// </summary>

	[Flags]	public enum DamageTypes : int
	{
		/// <summary>
		/// Generic damage.
		/// </summary>
		DMG_GENERIC = 0,
		/// <summary>
		/// Crush damage.
		/// </summary>
		DMG_CRUSH = 1,
		/// <summary>
		/// Bullet damage.
		/// </summary>
		DMG_BULLET = 2,
		/// <summary>
		/// Slash damage.
		/// </summary>
		DMG_SLASH = 4,
		/// <summary>
		/// Burn damage.
		/// </summary>
		DMG_BURN = 8,
		/// <summary>
		/// Vehicle damage.
		/// </summary>
		DMG_VEHICLE = 16,
		/// <summary>
		/// Fall damage.
		/// </summary>
		DMG_FALL = 32,
		/// <summary>
		/// Blast damage.
		/// </summary>
		DMG_BLAST = 64,
		/// <summary>
		/// Club damage.
		/// </summary>
		DMG_CLUB = 128,
		/// <summary>
		/// Shock damage.
		/// </summary>
		DMG_SHOCK = 256,
		/// <summary>
		/// Sonic damage.
		/// </summary>
		DMG_SONIC = 512,
		/// <summary>
		/// Energy beam damage.
		/// </summary>
		DMG_ENERGYBEAM = 1024,
		/// <summary>
		/// Drowning damage.
		/// </summary>
		DMG_DROWN = 16384,
		/// <summary>
		/// Poison damage.
		/// </summary>
		DMG_POISON = 32768,
		/// <summary>
		/// Radiation damage.
		/// </summary>
		DMG_RADIATION = 65536,
		/// <summary>
		/// Recovering from drowning damage.
		/// </summary>
		DMG_DROWNRECOVER = 131072,
		/// <summary>
		/// Acid damage.
		/// </summary>
		DMG_ACID = 262144,
		/// <summary>
		/// Physgun damage.
		/// </summary>
		DMG_PHYSGUN = 1048576,
		/// <summary>
		/// Dissolve damage.
		/// </summary>
		DMG_DISSOLVE = 2097152,
		/// <summary>
		/// Surface blast damage.
		/// </summary>
		DMG_BLAST_SURFACE = 4194304,
		/// <summary>
		/// Buckshot damage.
		/// </summary>
		DMG_BUCKSHOT = 16777216,
		/// <summary>
		/// Last generic flag damage.
		/// </summary>
		DMG_LASTGENERICFLAG = 16777216,
		/// <summary>
		/// Headshot damage.
		/// </summary>
		DMG_HEADSHOT = 33554432,
		/// <summary>
		/// Danger zone damage.
		/// </summary>
		DMG_DANGERZONE = 67108864
	}

	/// <summary>
	/// Enum representing various flags for ConVars and ConCommands.
	/// </summary>

	[Flags]	public enum ConVarFlag : long
	{
		/// <summary>
		/// The default, no flags at all.
		/// </summary>
		None = 0,
		/// <summary>
		/// Linked to a ConCommand.
		/// </summary>
		LinkedConcommand = 1,
		/// <summary>
		/// Hidden in released products. Automatically removed if ALLOW_DEVELOPMENT_CVARS is defined.
		/// </summary>
		DevelopmentOnly = 2,
		/// <summary>
		/// Defined by the game DLL.
		/// </summary>
		GameDll = 4,
		/// <summary>
		/// Defined by the client DLL.
		/// </summary>
		ClientDll = 8,
		/// <summary>
		/// Hidden. Doesn't appear in find or auto-complete. Like DEVELOPMENTONLY but cannot be compiled out.
		/// </summary>
		Hidden = 16,
		/// <summary>
		/// Server cvar; data is not sent since it's sensitive (e.g., passwords).
		/// </summary>
		Protected = 32,
		/// <summary>
		/// This cvar cannot be changed by clients connected to a multiplayer server.
		/// </summary>
		SpOnly = 64,
		/// <summary>
		/// Saved to vars.rc.
		/// </summary>
		Archive = 128,
		/// <summary>
		/// Notifies players when changed.
		/// </summary>
		Notify = 256,
		/// <summary>
		/// Changes the client's info string.
		/// </summary>
		UserInfo = 512,
		/// <summary>
		/// Hides the cvar from lookups.
		/// </summary>
		Missing0 = 1024,
		/// <summary>
		/// If this is a server cvar, changes are not logged to the file or console.
		/// </summary>
		Unlogged = 2048,
		/// <summary>
		/// Hides the cvar from lookups.
		/// </summary>
		Missing1 = 4096,
		/// <summary>
		/// Server-enforced setting on clients.
		/// </summary>
		Replicated = 8192,
		/// <summary>
		/// Only usable in singleplayer/debug or multiplayer with sv_cheats.
		/// </summary>
		Cheat = 16384,
		/// <summary>
		/// Causes auto-generated varnameN for splitscreen slots.
		/// </summary>
		PerUser = 32768,
		/// <summary>
		/// Records this cvar when starting a demo file.
		/// </summary>
		Demo = 65536,
		/// <summary>
		/// Excluded from demo files.
		/// </summary>
		DontRecord = 131072,
		/// <summary>
		/// Reserved for future use.
		/// </summary>
		Missing2 = 262144,
		/// <summary>
		/// Cvars tagged with this are available to customers.
		/// </summary>
		Release = 524288,
		/// <summary>
		/// Marks the cvar as a menu bar item.
		/// </summary>
		MenuBarItem = 1048576,
		/// <summary>
		/// Reserved for future use.
		/// </summary>
		Missing3 = 2097152,
		/// <summary>
		/// Cannot be changed by a client connected to a server.
		/// </summary>
		NotConnected = 4194304,
		/// <summary>
		/// Enables fuzzy matching for vconsole.
		/// </summary>
		VconsoleFuzzyMatching = 8388608,
		/// <summary>
		/// The server can execute this command on clients.
		/// </summary>
		ServerCanExecute = 16777216,
		/// <summary>
		/// Allows clients to execute this command.
		/// </summary>
		ClientCanExecute = 33554432,
		/// <summary>
		/// The server cannot query this cvar's value.
		/// </summary>
		ServerCannotQuery = 67108864,
		/// <summary>
		/// Sets focus in the vconsole.
		/// </summary>
		VconsoleSetFocus = 134217728,
		/// <summary>
		/// IVEngineClient::ClientCmd can execute this command.
		/// </summary>
		ClientCmdCanExecute = 268435456,
		/// <summary>
		/// Executes the cvar every tick.
		/// </summary>
		ExecutePerTick = 536870912
	}

	/// <summary>
	/// Enum representing the possible results of an operation.
	/// </summary>

	[Flags]	public enum ResultType : int
	{
		/// <summary>
		/// The action continues to be processed without interruption.
		/// </summary>
		Continue = 0,
		/// <summary>
		/// Indicates that the action has altered the state or behavior during execution.
		/// </summary>
		Changed = 1,
		/// <summary>
		/// The action has been successfully handled, and no further action is required.
		/// </summary>
		Handled = 2,
		/// <summary>
		/// The action processing is halted, and no further steps will be executed.
		/// </summary>
		Stop = 3
	}

	/// <summary>
	/// The command execution context.
	/// </summary>

	[Flags]	public enum CommandCallingContext : int
	{
		/// <summary>
		/// The command execute from the client's console.
		/// </summary>
		Console = 0,
		/// <summary>
		/// The command execute from the client's chat.
		/// </summary>
		Chat = 1
	}

	/// <summary>
	/// Enum representing the type of callback.
	/// </summary>

	[Flags]	public enum HookMode : byte
	{
		/// <summary>
		/// Callback will be executed before the original function
		/// </summary>
		Pre = 0,
		/// <summary>
		/// Callback will be executed after the original function
		/// </summary>
		Post = 1
	}


	[Flags]	public enum ConVarType : short
	{
		/// <summary>
		/// Invalid type
		/// </summary>
		Invalid = -1,
		/// <summary>
		/// Boolean type
		/// </summary>
		Bool = 0,
		/// <summary>
		/// 16-bit signed integer
		/// </summary>
		Int16 = 1,
		/// <summary>
		/// 16-bit unsigned integer
		/// </summary>
		UInt16 = 2,
		/// <summary>
		/// 32-bit signed integer
		/// </summary>
		Int32 = 3,
		/// <summary>
		/// 32-bit unsigned integer
		/// </summary>
		UInt32 = 4,
		/// <summary>
		/// 64-bit signed integer
		/// </summary>
		Int64 = 5,
		/// <summary>
		/// 64-bit unsigned integer
		/// </summary>
		UInt64 = 6,
		/// <summary>
		/// 32-bit floating point
		/// </summary>
		Float32 = 7,
		/// <summary>
		/// 64-bit floating point (double)
		/// </summary>
		Float64 = 8,
		/// <summary>
		/// String type
		/// </summary>
		String = 9,
		/// <summary>
		/// Color type
		/// </summary>
		Color = 10,
		/// <summary>
		/// 2D vector
		/// </summary>
		Vector2 = 11,
		/// <summary>
		/// 3D vector
		/// </summary>
		Vector3 = 12,
		/// <summary>
		/// 4D vector
		/// </summary>
		Vector4 = 13,
		/// <summary>
		/// Quaternion angle
		/// </summary>
		Qangle = 14,
		/// <summary>
		/// Maximum value (used for bounds checking)
		/// </summary>
		Max = 15
	}

	/// <summary>
	/// Enum representing various flags for ConVars and ConCommands.
	/// </summary>

	[Flags]	public enum CvarValueStatus : int
	{
		/// <summary>
		/// It got the value fine.
		/// </summary>
		ValueIntact = 0,
		/// <summary>
		/// It did not found the value.
		/// </summary>
		CvarNotFound = 1,
		/// <summary>
		/// There's a ConCommand, but it's not a ConVar.
		/// </summary>
		NotACvar = 2,
		/// <summary>
		/// The cvar was marked with FCVAR_SERVER_CAN_NOT_QUERY, so the server is not allowed to have its value.
		/// </summary>
		CvarProtected = 3
	}

	/// <summary>
	/// Enum representing the type of callback.
	/// </summary>

	[Flags]	public enum EventHookError : int
	{
		/// <summary>
		/// Indicates that the event hook was successfully created.
		/// </summary>
		Okay = 0,
		/// <summary>
		/// Indicates that the event name provided is invalid or does not exist.
		/// </summary>
		InvalidEvent = 1,
		/// <summary>
		/// Indicates that the event system is not currently active or initialized.
		/// </summary>
		NotActive = 2,
		/// <summary>
		/// Indicates that the callback function provided is invalid or not compatible with the event system.
		/// </summary>
		InvalidCallback = 3
	}

	/// <summary>
	/// Enum representing the possible verbosity of a logger.
	/// </summary>

	[Flags]	public enum LoggingVerbosity : int
	{
		/// <summary>
		/// Turns off all spew.
		/// </summary>
		Off = 0,
		/// <summary>
		/// Turns on vital logs.
		/// </summary>
		Essential = 1,
		/// <summary>
		/// Turns on most messages.
		/// </summary>
		Default = 2,
		/// <summary>
		/// Allows for walls of text that are usually useful.
		/// </summary>
		Detailed = 3,
		/// <summary>
		/// Allows everything.
		/// </summary>
		Max = 4
	}

	/// <summary>
	/// Enum representing the possible verbosity of a logger.
	/// </summary>

	[Flags]	public enum LoggingSeverity : int
	{
		/// <summary>
		/// Turns off all spew.
		/// </summary>
		Off = 0,
		/// <summary>
		/// A debug message.
		/// </summary>
		Detailed = 1,
		/// <summary>
		/// An informative logging message.
		/// </summary>
		Message = 2,
		/// <summary>
		/// A warning, typically non-fatal.
		/// </summary>
		Warning = 3,
		/// <summary>
		/// A message caused by an Assert**() operation.
		/// </summary>
		Assert = 4,
		/// <summary>
		/// An error, typically fatal/unrecoverable.
		/// </summary>
		Error = 5
	}

	/// <summary>
	/// Logging channel behavior flags, set on channel creation.
	/// </summary>

	[Flags]	public enum LoggingChannelFlags : int
	{
		/// <summary>
		/// Indicates that the spew is only relevant to interactive consoles.
		/// </summary>
		ConsoleOnly = 1,
		/// <summary>
		/// Indicates that spew should not be echoed to any output devices.
		/// </summary>
		DoNotEcho = 2
	}

	/// <summary>
	/// Enum representing the possible reasons a vote creation or processing has failed.
	/// </summary>

	[Flags]	public enum VoteCreateFailed : int
	{
		/// <summary>
		/// Generic vote failure.
		/// </summary>
		Generic = 0,
		/// <summary>
		/// Vote failed due to players transitioning.
		/// </summary>
		TransitioningPlayers = 1,
		/// <summary>
		/// Vote failed because vote rate limit was exceeded.
		/// </summary>
		RateExceeded = 2,
		/// <summary>
		/// Vote failed because Yes votes must exceed No votes.
		/// </summary>
		YesMustExceedNo = 3,
		/// <summary>
		/// Vote failed due to quorum not being met.
		/// </summary>
		QuorumFailure = 4,
		/// <summary>
		/// Vote failed because the issue is disabled.
		/// </summary>
		IssueDisabled = 5,
		/// <summary>
		/// Vote failed because the map was not found.
		/// </summary>
		MapNotFound = 6,
		/// <summary>
		/// Vote failed because map name is required.
		/// </summary>
		MapNameRequired = 7,
		/// <summary>
		/// Vote failed because a similar vote failed recently.
		/// </summary>
		FailedRecently = 8,
		/// <summary>
		/// Vote to kick failed recently.
		/// </summary>
		FailedRecentKick = 9,
		/// <summary>
		/// Vote to change map failed recently.
		/// </summary>
		FailedRecentChangeMap = 10,
		/// <summary>
		/// Vote to swap teams failed recently.
		/// </summary>
		FailedRecentSwapTeams = 11,
		/// <summary>
		/// Vote to scramble teams failed recently.
		/// </summary>
		FailedRecentScrambleTeams = 12,
		/// <summary>
		/// Vote to restart failed recently.
		/// </summary>
		FailedRecentRestart = 13,
		/// <summary>
		/// Team is not allowed to call vote.
		/// </summary>
		TeamCantCall = 14,
		/// <summary>
		/// Vote failed because game is waiting for players.
		/// </summary>
		WaitingForPlayers = 15,
		/// <summary>
		/// Target player was not found.
		/// </summary>
		PlayerNotFound = 16,
		/// <summary>
		/// Cannot kick an admin.
		/// </summary>
		CannotKickAdmin = 17,
		/// <summary>
		/// Scramble is currently in progress.
		/// </summary>
		ScrambleInProgress = 18,
		/// <summary>
		/// Swap is currently in progress.
		/// </summary>
		SwapInProgress = 19,
		/// <summary>
		/// Spectators are not allowed to vote.
		/// </summary>
		Spectator = 20,
		/// <summary>
		/// Voting is disabled.
		/// </summary>
		Disabled = 21,
		/// <summary>
		/// Next level is already set.
		/// </summary>
		NextLevelSet = 22,
		/// <summary>
		/// Rematch vote failed.
		/// </summary>
		Rematch = 23,
		/// <summary>
		/// Vote to surrender failed due to being too early.
		/// </summary>
		TooEarlySurrender = 24,
		/// <summary>
		/// Vote to continue failed.
		/// </summary>
		Continue = 25,
		/// <summary>
		/// Vote failed because match is already paused.
		/// </summary>
		MatchPaused = 26,
		/// <summary>
		/// Vote failed because match is not paused.
		/// </summary>
		MatchNotPaused = 27,
		/// <summary>
		/// Vote failed because game is not in warmup.
		/// </summary>
		NotInWarmup = 28,
		/// <summary>
		/// Vote failed because there are not 10 players.
		/// </summary>
		Not10Players = 29,
		/// <summary>
		/// Vote failed due to an active timeout.
		/// </summary>
		TimeoutActive = 30,
		/// <summary>
		/// Vote failed because timeout is inactive.
		/// </summary>
		TimeoutInactive = 31,
		/// <summary>
		/// Vote failed because timeout has been exhausted.
		/// </summary>
		TimeoutExhausted = 32,
		/// <summary>
		/// Vote failed because the round can't end now.
		/// </summary>
		CantRoundEnd = 33,
		/// <summary>
		/// Sentinel value. Not a real failure reason.
		/// </summary>
		Max = 34
	}

	/// <summary>
	/// Enum representing the possible types of a vote actions.
	/// </summary>

	[Flags]	public enum VoteAction : int
	{
		/// <summary>
		/// Triggered when the vote begins. No additional parameters are used.
		/// </summary>
		Start = 0,
		/// <summary>
		/// Triggered when a player casts a vote. 'clientSlot' holds the voter's slot and 'choice' is the selected option (e.g., VOTE_OPTION1 for yes, VOTE_OPTION2 for no).
		/// </summary>
		Vote = 1,
		/// <summary>
		/// Triggered when the vote concludes. 'clientSlot' is typically -1. 'choice' contains the reason the vote ended (from YesNoVoteEndReason).
		/// </summary>
		End = 2
	}

	/// <summary>
	/// Enum representing the possible types of a vote.
	/// </summary>

	[Flags]	public enum VoteEndReason : int
	{
		/// <summary>
		/// All possible votes were cast.
		/// </summary>
		AllVotes = 0,
		/// <summary>
		/// Time ran out.
		/// </summary>
		TimeUp = 1,
		/// <summary>
		/// The vote got cancelled.
		/// </summary>
		Cancelled = 2
	}

	/// <summary>
	/// Enum representing the possible flags of a timer.
	/// </summary>

	[Flags]	public enum TimerFlag : int
	{
		/// <summary>
		/// Timer with no unique properties.
		/// </summary>
		Default = 0,
		/// <summary>
		/// Timer will repeat until stopped.
		/// </summary>
		Repeat = 1,
		/// <summary>
		/// Timer will not carry over mapchanges.
		/// </summary>
		NoMapChange = 2
	}

	/// <summary>
	/// Enum representing the possible reasons for a round ending in Counter-Strike.
	/// </summary>

	[Flags]	public enum CSRoundEndReason : int
	{
		/// <summary>
		/// Target successfully bombed.
		/// </summary>
		TargetBombed = 1,
		/// <summary>
		/// The VIP has escaped (not present in CS:GO).
		/// </summary>
		VIPEscaped = 2,
		/// <summary>
		/// VIP has been assassinated (not present in CS:GO).
		/// </summary>
		VIPKilled = 3,
		/// <summary>
		/// The terrorists have escaped.
		/// </summary>
		TerroristsEscaped = 4,
		/// <summary>
		/// The CTs have prevented most of the terrorists from escaping.
		/// </summary>
		CTStoppedEscape = 5,
		/// <summary>
		/// Escaping terrorists have all been neutralized.
		/// </summary>
		TerroristsStopped = 6,
		/// <summary>
		/// The bomb has been defused.
		/// </summary>
		BombDefused = 7,
		/// <summary>
		/// Counter-Terrorists win.
		/// </summary>
		CTWin = 8,
		/// <summary>
		/// Terrorists win.
		/// </summary>
		TerroristWin = 9,
		/// <summary>
		/// Round draw.
		/// </summary>
		Draw = 10,
		/// <summary>
		/// All hostages have been rescued.
		/// </summary>
		HostagesRescued = 11,
		/// <summary>
		/// Target has been saved.
		/// </summary>
		TargetSaved = 12,
		/// <summary>
		/// Hostages have not been rescued.
		/// </summary>
		HostagesNotRescued = 13,
		/// <summary>
		/// Terrorists have not escaped.
		/// </summary>
		TerroristsNotEscaped = 14,
		/// <summary>
		/// VIP has not escaped (not present in CS:GO).
		/// </summary>
		VIPNotEscaped = 15,
		/// <summary>
		/// Game commencing.
		/// </summary>
		GameStart = 16,
		/// <summary>
		/// Terrorists surrender.
		/// </summary>
		TerroristsSurrender = 17,
		/// <summary>
		/// CTs surrender.
		/// </summary>
		CTSurrender = 18,
		/// <summary>
		/// Terrorists planted the bomb.
		/// </summary>
		TerroristsPlanted = 19,
		/// <summary>
		/// CTs reached the hostage.
		/// </summary>
		CTsReachedHostage = 20,
		/// <summary>
		/// Survival mode win.
		/// </summary>
		SurvivalWin = 21,
		/// <summary>
		/// Survival mode draw.
		/// </summary>
		SurvivalDraw = 22
	}

	/// <summary>
	/// Enum representing different weapon types.
	/// </summary>

	[Flags]	public enum CSWeaponType : uint
	{
		Knife = 0,
		Pistol = 1,
		SubmachineGun = 2,
		Rifle = 3,
		Shotgun = 4,
		SniperRifle = 5,
		MachineGun = 6,
		C4 = 7,
		Taser = 8,
		Grenade = 9,
		Equipment = 10,
		StackableItem = 11,
		Unknown = 12
	}

	/// <summary>
	/// Enum representing different weapon categories.
	/// </summary>

	[Flags]	public enum CSWeaponCategory : uint
	{
		Other = 0,
		Melee = 1,
		Secondary = 2,
		SMG = 3,
		Rifle = 4,
		Heavy = 5,
		Count = 6
	}

	/// <summary>
	/// Enum representing different gear slots.
	/// </summary>

	[Flags]	public enum GearSlot : uint
	{
		Invalid = 4294967295,
		Rifle = 0,
		Pistol = 1,
		Knife = 2,
		Grenades = 3,
		C4 = 4,
		ReservedSlot6 = 5,
		ReservedSlot7 = 6,
		ReservedSlot8 = 7,
		ReservedSlot9 = 8,
		ReservedSlot10 = 9,
		ReservedSlot11 = 10,
		Boosts = 11,
		Utility = 12,
		Count = 13,
		First = 0,
		Last = 12
	}

	/// <summary>
	/// Enum representing different weapon definition indices.
	/// </summary>

	[Flags]	public enum WeaponDefIndex : ushort
	{
		Invalid = 0,
		Deagle = 1,
		Elite = 2,
		FiveSeven = 3,
		Glock = 4,
		AK47 = 7,
		AUG = 8,
		AWP = 9,
		FAMAS = 10,
		G3SG1 = 11,
		GalilAR = 13,
		M249 = 14,
		M4A1 = 16,
		MAC10 = 17,
		P90 = 19,
		MP5SD = 23,
		UMP45 = 24,
		XM1014 = 25,
		Bizon = 26,
		MAG7 = 27,
		Negev = 28,
		SawedOff = 29,
		Tec9 = 30,
		Taser = 31,
		HKP2000 = 32,
		MP7 = 33,
		MP9 = 34,
		Nova = 35,
		P250 = 36,
		SCAR20 = 38,
		SG556 = 39,
		SSG08 = 40,
		KnifeGG = 41,
		Knife = 42,
		Flashbang = 43,
		HEGrenade = 44,
		SmokeGrenade = 45,
		Molotov = 46,
		Decoy = 47,
		IncGrenade = 48,
		C4 = 49,
		Kevlar = 50,
		AssaultSuit = 51,
		HeavyAssaultSuit = 52,
		Defuser = 55,
		KnifeT = 59,
		M4A1Silencer = 60,
		USPSilencer = 61,
		CZ75A = 63,
		Revolver = 64,
		Bayonet = 500,
		KnifeCSS = 503,
		KnifeFlip = 505,
		KnifeGut = 506,
		KnifeKarambit = 507,
		KnifeM9Bayonet = 508,
		KnifeTactical = 509,
		KnifeFalchion = 512,
		KnifeBowie = 514,
		KnifeButterfly = 515,
		KnifePush = 516,
		KnifeCord = 517,
		KnifeCanis = 518,
		KnifeUrsus = 519,
		KnifeGypsyJackknife = 520,
		KnifeOutdoor = 521,
		KnifeStiletto = 522,
		KnifeWidowmaker = 523,
		KnifeSkeleton = 525,
		KnifeKukri = 526
	}


	/// <summary>
	/// Ownership type for RAII wrappers
	/// </summary>
	internal enum Ownership { Borrowed, Owned }

#pragma warning restore CS0649
}
