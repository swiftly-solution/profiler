using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: timers)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Creates a new timer that executes a callback function at specified delays.
		/// </summary>
		/// <param name="delay">The time delay in seconds between each callback execution.</param>
		/// <param name="callback">The function to be called when the timer expires.</param>
		/// <param name="flags">Flags that modify the behavior of the timer (e.g., no-map change, repeating).</param>
		/// <param name="userData">An array intended to hold user-related data, allowing for elements of any type.</param>
		/// <returns>A id to the newly created Timer object, or -1 if the timer could not be created.</returns>
		internal static delegate*<double, TimerCallback, TimerFlag, object[], uint> CreateTimer = &___CreateTimer;
		internal static delegate* unmanaged[Cdecl]<double, nint, TimerFlag, Vector192*, uint> __CreateTimer;
		private static uint ___CreateTimer(double delay, TimerCallback callback, TimerFlag flags, object[] userData)
		{
			uint __retVal;
			var __userData = NativeMethods.ConstructVectorVariant(userData, userData.Length);
			try {
				__retVal = __CreateTimer(delay, Marshalling.GetFunctionPointerForDelegate(callback), flags, &__userData);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyVectorVariant(&__userData);
			}
			return __retVal;
		}

		/// <summary>
		/// Stops and removes an existing timer.
		/// </summary>
		/// <param name="timer">A id of the Timer object to be stopped and removed.</param>
		internal static delegate*<uint, void> KillsTimer = &___KillsTimer;
		internal static delegate* unmanaged[Cdecl]<uint, void> __KillsTimer;
		private static void ___KillsTimer(uint timer)
		{
			__KillsTimer(timer);
		}

		/// <summary>
		/// Reschedules an existing timer with a new delay.
		/// </summary>
		/// <param name="timer">A id of the Timer object to be stopped and removed.</param>
		/// <param name="newDaly">The new delay in seconds between each callback execution.</param>
		internal static delegate*<uint, double, void> RescheduleTimer = &___RescheduleTimer;
		internal static delegate* unmanaged[Cdecl]<uint, double, void> __RescheduleTimer;
		private static void ___RescheduleTimer(uint timer, double newDaly)
		{
			__RescheduleTimer(timer, newDaly);
		}

		/// <summary>
		/// Returns the number of seconds in between game server ticks.
		/// </summary>
		/// <returns>The tick interval value.</returns>
		internal static delegate*<double> GetTickInterval = &___GetTickInterval;
		internal static delegate* unmanaged[Cdecl]<double> __GetTickInterval;
		private static double ___GetTickInterval()
		{
			double __retVal = __GetTickInterval();
			return __retVal;
		}

		/// <summary>
		/// Returns the simulated game time.
		/// </summary>
		/// <returns>The ticked time value.</returns>
		internal static delegate*<double> GetTickedTime = &___GetTickedTime;
		internal static delegate* unmanaged[Cdecl]<double> __GetTickedTime;
		private static double ___GetTickedTime()
		{
			double __retVal = __GetTickedTime();
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
