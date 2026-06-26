using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: gamerules)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Retrieves the pointer to the current game rules proxy instance.
		/// </summary>
		/// <returns>A pointer to the game rules entity instance.</returns>
		internal static delegate*<nint> GetGameRulesProxy = &___GetGameRulesProxy;
		internal static delegate* unmanaged[Cdecl]<nint> __GetGameRulesProxy;
		private static nint ___GetGameRulesProxy()
		{
			nint __retVal = __GetGameRulesProxy();
			return __retVal;
		}

		/// <summary>
		/// Retrieves the pointer to the current game rules instance.
		/// </summary>
		/// <returns>A pointer to the game rules object.</returns>
		internal static delegate*<nint> GetGameRules = &___GetGameRules;
		internal static delegate* unmanaged[Cdecl]<nint> __GetGameRules;
		private static nint ___GetGameRules()
		{
			nint __retVal = __GetGameRules();
			return __retVal;
		}

		/// <summary>
		/// Retrieves the team manager instance for a specified team.
		/// </summary>
		/// <param name="team">The numeric identifier of the team.</param>
		/// <returns>A pointer to the corresponding CTeam instance, or nullptr if the team was not found.</returns>
		internal static delegate*<int, nint> GetGameTeamManager = &___GetGameTeamManager;
		internal static delegate* unmanaged[Cdecl]<int, nint> __GetGameTeamManager;
		private static nint ___GetGameTeamManager(int team)
		{
			nint __retVal = __GetGameTeamManager(team);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the current score of a specified team.
		/// </summary>
		/// <param name="team">The numeric identifier of the team.</param>
		/// <returns>The current score of the team, or -1 if the team could not be found.</returns>
		internal static delegate*<int, int> GetGameTeamScore = &___GetGameTeamScore;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetGameTeamScore;
		private static int ___GetGameTeamScore(int team)
		{
			int __retVal = __GetGameTeamScore(team);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the number of players on a specified team.
		/// </summary>
		/// <param name="team">The numeric identifier of the team (e.g., CS_TEAM_T, CS_TEAM_CT, CS_TEAM_SPECTATOR).</param>
		/// <returns>The number of players on the team, or -1 if game rules are unavailable.</returns>
		internal static delegate*<int, int> GetGamePlayerCount = &___GetGamePlayerCount;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetGamePlayerCount;
		private static int ___GetGamePlayerCount(int team)
		{
			int __retVal = __GetGamePlayerCount(team);
			return __retVal;
		}

		/// <summary>
		/// Returns the total number of rounds played in the current match.
		/// </summary>
		/// <returns>The total number of rounds played, or -1 if the game rules are unavailable.</returns>
		internal static delegate*<int> GetGameTotalRoundsPlayed = &___GetGameTotalRoundsPlayed;
		internal static delegate* unmanaged[Cdecl]<int> __GetGameTotalRoundsPlayed;
		private static int ___GetGameTotalRoundsPlayed()
		{
			int __retVal = __GetGameTotalRoundsPlayed();
			return __retVal;
		}

		/// <summary>
		/// Forces the round to end with a specified reason and delay.
		/// </summary>
		/// <param name="delay">Time (in seconds) to delay before the next round starts.</param>
		/// <param name="reason">The reason for ending the round, defined by the CSRoundEndReason enum.</param>
		internal static delegate*<float, CSRoundEndReason, void> TerminateRound = &___TerminateRound;
		internal static delegate* unmanaged[Cdecl]<float, CSRoundEndReason, void> __TerminateRound;
		private static void ___TerminateRound(float delay, CSRoundEndReason reason)
		{
			__TerminateRound(delay, reason);
		}

	}

#pragma warning restore CS0649
}
