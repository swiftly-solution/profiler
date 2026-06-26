using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: panorama)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Start a new Yes/No vote
		/// </summary>
		/// <param name="duration">Maximum time to leave vote active for</param>
		/// <param name="caller">Player slot of the vote caller. Use VOTE_CALLER_SERVER for 'Server'.</param>
		/// <param name="voteTitle">Translation string to use as the vote message. (Only '#SFUI_vote' or '#Panorama_vote' strings)</param>
		/// <param name="detailStr">Extra string used in some vote translation strings.</param>
		/// <param name="votePassTitle">Translation string to use as the vote message. (Only '#SFUI_vote' or '#Panorama_vote' strings)</param>
		/// <param name="detailPassStr">Extra string used in some vote translation strings when the vote passes.</param>
		/// <param name="failReason">Reason for the vote to fail, used in some translation strings.</param>
		/// <param name="filter">Recipient filter with all the clients who are allowed to participate in the vote.</param>
		/// <param name="result">Called when a menu action is completed.</param>
		/// <param name="handler">Called when the vote has finished.</param>
		internal static delegate*<double, int, string, string, string, string, VoteCreateFailed, ulong, YesNoVoteResult, YesNoVoteHandler, Bool8> PanoramaSendYesNoVote = &___PanoramaSendYesNoVote;
		internal static delegate* unmanaged[Cdecl]<double, int, String192*, String192*, String192*, String192*, VoteCreateFailed, ulong, nint, nint, Bool8> __PanoramaSendYesNoVote;
		private static Bool8 ___PanoramaSendYesNoVote(double duration, int caller, string voteTitle, string detailStr, string votePassTitle, string detailPassStr, VoteCreateFailed failReason, ulong filter, YesNoVoteResult result, YesNoVoteHandler handler)
		{
			Bool8 __retVal;
			var __voteTitle = NativeMethods.ConstructString(voteTitle);
			var __detailStr = NativeMethods.ConstructString(detailStr);
			var __votePassTitle = NativeMethods.ConstructString(votePassTitle);
			var __detailPassStr = NativeMethods.ConstructString(detailPassStr);
			try {
				__retVal = __PanoramaSendYesNoVote(duration, caller, &__voteTitle, &__detailStr, &__votePassTitle, &__detailPassStr, failReason, filter, Marshalling.GetFunctionPointerForDelegate(result), Marshalling.GetFunctionPointerForDelegate(handler));
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__voteTitle);
				NativeMethods.DestroyString(&__detailStr);
				NativeMethods.DestroyString(&__votePassTitle);
				NativeMethods.DestroyString(&__detailPassStr);
			}
			return __retVal;
		}

		/// <summary>
		/// Start a new Yes/No vote with all players included
		/// </summary>
		/// <param name="duration">Maximum time to leave vote active for</param>
		/// <param name="caller">Player slot of the vote caller. Use VOTE_CALLER_SERVER for 'Server'.</param>
		/// <param name="voteTitle">Translation string to use as the vote message. (Only '#SFUI_vote' or '#Panorama_vote' strings)</param>
		/// <param name="detailStr">Extra string used in some vote translation strings.</param>
		/// <param name="votePassTitle">Translation string to use as the vote message. (Only '#SFUI_vote' or '#Panorama_vote' strings)</param>
		/// <param name="detailPassStr">Extra string used in some vote translation strings when the vote passes.</param>
		/// <param name="failReason">Reason for the vote to fail, used in some translation strings.</param>
		/// <param name="result">Called when a menu action is completed.</param>
		/// <param name="handler">Called when the vote has finished.</param>
		internal static delegate*<double, int, string, string, string, string, VoteCreateFailed, YesNoVoteResult, YesNoVoteHandler, Bool8> PanoramaSendYesNoVoteToAll = &___PanoramaSendYesNoVoteToAll;
		internal static delegate* unmanaged[Cdecl]<double, int, String192*, String192*, String192*, String192*, VoteCreateFailed, nint, nint, Bool8> __PanoramaSendYesNoVoteToAll;
		private static Bool8 ___PanoramaSendYesNoVoteToAll(double duration, int caller, string voteTitle, string detailStr, string votePassTitle, string detailPassStr, VoteCreateFailed failReason, YesNoVoteResult result, YesNoVoteHandler handler)
		{
			Bool8 __retVal;
			var __voteTitle = NativeMethods.ConstructString(voteTitle);
			var __detailStr = NativeMethods.ConstructString(detailStr);
			var __votePassTitle = NativeMethods.ConstructString(votePassTitle);
			var __detailPassStr = NativeMethods.ConstructString(detailPassStr);
			try {
				__retVal = __PanoramaSendYesNoVoteToAll(duration, caller, &__voteTitle, &__detailStr, &__votePassTitle, &__detailPassStr, failReason, Marshalling.GetFunctionPointerForDelegate(result), Marshalling.GetFunctionPointerForDelegate(handler));
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__voteTitle);
				NativeMethods.DestroyString(&__detailStr);
				NativeMethods.DestroyString(&__votePassTitle);
				NativeMethods.DestroyString(&__detailPassStr);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a player from the current vote.
		/// </summary>
		/// <param name="playerSlot">The slot/index of the player to remove from the vote.</param>
		internal static delegate*<int, void> PanoramaRemovePlayerFromVote = &___PanoramaRemovePlayerFromVote;
		internal static delegate* unmanaged[Cdecl]<int, void> __PanoramaRemovePlayerFromVote;
		private static void ___PanoramaRemovePlayerFromVote(int playerSlot)
		{
			__PanoramaRemovePlayerFromVote(playerSlot);
		}

		/// <summary>
		/// Checks if a player is in the vote pool.
		/// </summary>
		/// <param name="playerSlot">The slot/index of the player to check.</param>
		/// <returns>true if the player is in the vote pool, false otherwise.</returns>
		internal static delegate*<int, Bool8> PanoramaIsPlayerInVotePool = &___PanoramaIsPlayerInVotePool;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __PanoramaIsPlayerInVotePool;
		private static Bool8 ___PanoramaIsPlayerInVotePool(int playerSlot)
		{
			Bool8 __retVal = __PanoramaIsPlayerInVotePool(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Redraws the vote UI to a specific player client.
		/// </summary>
		/// <param name="playerSlot">The slot/index of the player to update.</param>
		/// <returns>true if the vote UI was successfully redrawn, false otherwise.</returns>
		internal static delegate*<int, Bool8> PanoramaRedrawVoteToClient = &___PanoramaRedrawVoteToClient;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __PanoramaRedrawVoteToClient;
		private static Bool8 ___PanoramaRedrawVoteToClient(int playerSlot)
		{
			Bool8 __retVal = __PanoramaRedrawVoteToClient(playerSlot);
			return __retVal;
		}

		/// <summary>
		/// Checks if a vote is currently in progress.
		/// </summary>
		/// <returns>true if a vote is active, false otherwise.</returns>
		internal static delegate*<Bool8> PanoramaIsVoteInProgress = &___PanoramaIsVoteInProgress;
		internal static delegate* unmanaged[Cdecl]<Bool8> __PanoramaIsVoteInProgress;
		private static Bool8 ___PanoramaIsVoteInProgress()
		{
			Bool8 __retVal = __PanoramaIsVoteInProgress();
			return __retVal;
		}

		/// <summary>
		/// Ends the current vote with a specified reason.
		/// </summary>
		/// <param name="reason">The reason for ending the vote.</param>
		internal static delegate*<VoteEndReason, void> PanoramaEndVote = &___PanoramaEndVote;
		internal static delegate* unmanaged[Cdecl]<VoteEndReason, void> __PanoramaEndVote;
		private static void ___PanoramaEndVote(VoteEndReason reason)
		{
			__PanoramaEndVote(reason);
		}

	}

#pragma warning restore CS0649
}
