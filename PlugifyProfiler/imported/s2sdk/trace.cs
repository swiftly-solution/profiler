using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: trace)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Performs a collideable trace using the VScript-compatible table call, exposing it through C++ exports.
		/// </summary>
		/// <param name="start">Trace start position (world space)</param>
		/// <param name="end">Trace end position (world space)</param>
		/// <param name="entityHandle">Entity handle of the collideable</param>
		/// <param name="outPos">Output: position of impact</param>
		/// <param name="outFraction">Output: fraction of trace completed</param>
		/// <param name="outHit">Output: whether a hit occurred</param>
		/// <param name="outStartSolid">Output: whether trace started inside solid</param>
		/// <param name="outNormal">Output: surface normal at impact</param>
		/// <returns>True if trace hit something, false otherwise</returns>
		internal static delegate*<Vector3, Vector3, int, ref Vector3, ref double, ref Bool8, ref Bool8, ref Vector3, Bool8> TraceCollideable = &___TraceCollideable;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, int, Vector3*, double*, Bool8*, Bool8*, Vector3*, Bool8> __TraceCollideable;
		private static Bool8 ___TraceCollideable(Vector3 start, Vector3 end, int entityHandle, ref Vector3 outPos, ref double outFraction, ref Bool8 outHit, ref Bool8 outStartSolid, ref Vector3 outNormal)
		{
			Bool8 __retVal;
			fixed(Vector3* __outPos = &outPos) {
			fixed(double* __outFraction = &outFraction) {
			fixed(Bool8* __outHit = &outHit) {
			fixed(Bool8* __outStartSolid = &outStartSolid) {
			fixed(Vector3* __outNormal = &outNormal) {
			__retVal = __TraceCollideable(&start, &end, entityHandle, __outPos, __outFraction, __outHit, __outStartSolid, __outNormal);
			}
			}
			}
			}
			}
			return __retVal;
		}

		/// <summary>
		/// Performs a collideable trace using the VScript-compatible table call, exposing it through C++ exports.
		/// </summary>
		/// <param name="start">Trace start position (world space)</param>
		/// <param name="end">Trace end position (world space)</param>
		/// <param name="entityHandle">Entity handle of the collideable</param>
		/// <param name="mins">Bounding box minimums</param>
		/// <param name="maxs">Bounding box maximums</param>
		/// <param name="outPos">Output: position of impact</param>
		/// <param name="outFraction">Output: fraction of trace completed</param>
		/// <param name="outHit">Output: whether a hit occurred</param>
		/// <param name="outStartSolid">Output: whether trace started inside solid</param>
		/// <param name="outNormal">Output: surface normal at impact</param>
		/// <returns>True if trace hit something, false otherwise</returns>
		internal static delegate*<Vector3, Vector3, int, nint, nint, ref Vector3, ref double, ref Bool8, ref Bool8, ref Vector3, Bool8> TraceCollideable2 = &___TraceCollideable2;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, int, nint, nint, Vector3*, double*, Bool8*, Bool8*, Vector3*, Bool8> __TraceCollideable2;
		private static Bool8 ___TraceCollideable2(Vector3 start, Vector3 end, int entityHandle, nint mins, nint maxs, ref Vector3 outPos, ref double outFraction, ref Bool8 outHit, ref Bool8 outStartSolid, ref Vector3 outNormal)
		{
			Bool8 __retVal;
			fixed(Vector3* __outPos = &outPos) {
			fixed(double* __outFraction = &outFraction) {
			fixed(Bool8* __outHit = &outHit) {
			fixed(Bool8* __outStartSolid = &outStartSolid) {
			fixed(Vector3* __outNormal = &outNormal) {
			__retVal = __TraceCollideable2(&start, &end, entityHandle, mins, maxs, __outPos, __outFraction, __outHit, __outStartSolid, __outNormal);
			}
			}
			}
			}
			}
			return __retVal;
		}

		/// <summary>
		/// Performs a hull trace with specified dimensions and mask.
		/// </summary>
		/// <param name="start">Trace start position</param>
		/// <param name="end">Trace end position</param>
		/// <param name="min">Local bounding box minimums</param>
		/// <param name="max">Local bounding box maximums</param>
		/// <param name="mask">Trace mask</param>
		/// <param name="ignoreHandle">Entity handle to ignore during trace</param>
		/// <param name="outPos">Output: position of impact</param>
		/// <param name="outFraction">Output: fraction of trace completed</param>
		/// <param name="outHit">Output: whether a hit occurred</param>
		/// <param name="outEntHit">Output: handle of entity hit</param>
		/// <param name="outStartSolid">Output: whether trace started inside solid</param>
		/// <returns>True if trace hit something, false otherwise</returns>
		internal static delegate*<Vector3, Vector3, Vector3, Vector3, int, int, ref Vector3, ref double, ref Bool8, ref int, ref Bool8, Bool8> TraceHull = &___TraceHull;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, Vector3*, int, int, Vector3*, double*, Bool8*, int*, Bool8*, Bool8> __TraceHull;
		private static Bool8 ___TraceHull(Vector3 start, Vector3 end, Vector3 min, Vector3 max, int mask, int ignoreHandle, ref Vector3 outPos, ref double outFraction, ref Bool8 outHit, ref int outEntHit, ref Bool8 outStartSolid)
		{
			Bool8 __retVal;
			fixed(Vector3* __outPos = &outPos) {
			fixed(double* __outFraction = &outFraction) {
			fixed(Bool8* __outHit = &outHit) {
			fixed(int* __outEntHit = &outEntHit) {
			fixed(Bool8* __outStartSolid = &outStartSolid) {
			__retVal = __TraceHull(&start, &end, &min, &max, mask, ignoreHandle, __outPos, __outFraction, __outHit, __outEntHit, __outStartSolid);
			}
			}
			}
			}
			}
			return __retVal;
		}

		/// <summary>
		/// Performs a line trace between two points.
		/// </summary>
		/// <param name="startPos">Trace start position</param>
		/// <param name="endPos">Trace end position</param>
		/// <param name="mask">Trace mask</param>
		/// <param name="ignoreHandle">Entity handle to ignore during trace</param>
		/// <param name="outPos">Output: position of impact</param>
		/// <param name="outFraction">Output: fraction of trace completed</param>
		/// <param name="outHit">Output: whether a hit occurred</param>
		/// <param name="outEntHit">Output: handle of entity hit</param>
		/// <param name="outStartSolid">Output: whether trace started inside solid</param>
		/// <returns>True if trace hit something, false otherwise</returns>
		internal static delegate*<Vector3, Vector3, int, int, ref Vector3, ref double, ref Bool8, ref int, ref Bool8, Bool8> TraceLine = &___TraceLine;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, int, int, Vector3*, double*, Bool8*, int*, Bool8*, Bool8> __TraceLine;
		private static Bool8 ___TraceLine(Vector3 startPos, Vector3 endPos, int mask, int ignoreHandle, ref Vector3 outPos, ref double outFraction, ref Bool8 outHit, ref int outEntHit, ref Bool8 outStartSolid)
		{
			Bool8 __retVal;
			fixed(Vector3* __outPos = &outPos) {
			fixed(double* __outFraction = &outFraction) {
			fixed(Bool8* __outHit = &outHit) {
			fixed(int* __outEntHit = &outEntHit) {
			fixed(Bool8* __outStartSolid = &outStartSolid) {
			__retVal = __TraceLine(&startPos, &endPos, mask, ignoreHandle, __outPos, __outFraction, __outHit, __outEntHit, __outStartSolid);
			}
			}
			}
			}
			}
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
