using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: debug)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Triggers a breakpoint in the debugger.
		/// </summary>
		internal static delegate*<void> DebugBreak = &___DebugBreak;
		internal static delegate* unmanaged[Cdecl]<void> __DebugBreak;
		private static void ___DebugBreak()
		{
			__DebugBreak();
		}

		/// <summary>
		/// Draws a debug overlay box.
		/// </summary>
		/// <param name="center">Center of the box in world space.</param>
		/// <param name="mins">Minimum bounds relative to the center.</param>
		/// <param name="maxs">Maximum bounds relative to the center.</param>
		/// <param name="r">Red color value.</param>
		/// <param name="g">Green color value.</param>
		/// <param name="b">Blue color value.</param>
		/// <param name="a">Alpha (transparency) value.</param>
		/// <param name="duration">Duration (in seconds) to display the box.</param>
		internal static delegate*<Vector3, Vector3, Vector3, int, int, int, int, float, void> DebugDrawBox = &___DebugDrawBox;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, int, int, int, int, float, void> __DebugDrawBox;
		private static void ___DebugDrawBox(Vector3 center, Vector3 mins, Vector3 maxs, int r, int g, int b, int a, float duration)
		{
			__DebugDrawBox(&center, &mins, &maxs, r, g, b, a, duration);
		}

		/// <summary>
		/// Draws a debug box oriented in the direction of a forward vector.
		/// </summary>
		/// <param name="center">Center of the box.</param>
		/// <param name="mins">Minimum bounds.</param>
		/// <param name="maxs">Maximum bounds.</param>
		/// <param name="forward">Forward direction vector.</param>
		/// <param name="color">RGB color vector.</param>
		/// <param name="alpha">Alpha transparency.</param>
		/// <param name="duration">Duration (in seconds) to display the box.</param>
		internal static delegate*<Vector3, Vector3, Vector3, Vector3, Vector3, float, float, void> DebugDrawBoxDirection = &___DebugDrawBoxDirection;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, Vector3*, Vector3*, float, float, void> __DebugDrawBoxDirection;
		private static void ___DebugDrawBoxDirection(Vector3 center, Vector3 mins, Vector3 maxs, Vector3 forward, Vector3 color, float alpha, float duration)
		{
			__DebugDrawBoxDirection(&center, &mins, &maxs, &forward, &color, alpha, duration);
		}

		/// <summary>
		/// Draws a debug circle.
		/// </summary>
		/// <param name="center">Center of the circle.</param>
		/// <param name="color">RGB color vector.</param>
		/// <param name="alpha">Alpha transparency.</param>
		/// <param name="radius">Circle radius.</param>
		/// <param name="zTest">Whether to perform depth testing.</param>
		/// <param name="duration">Duration (in seconds) to display the circle.</param>
		internal static delegate*<Vector3, Vector3, float, float, Bool8, float, void> DebugDrawCircle = &___DebugDrawCircle;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, float, float, Bool8, float, void> __DebugDrawCircle;
		private static void ___DebugDrawCircle(Vector3 center, Vector3 color, float alpha, float radius, Bool8 zTest, float duration)
		{
			__DebugDrawCircle(&center, &color, alpha, radius, zTest, duration);
		}

		/// <summary>
		/// Clears all debug overlays.
		/// </summary>
		internal static delegate*<void> DebugDrawClear = &___DebugDrawClear;
		internal static delegate* unmanaged[Cdecl]<void> __DebugDrawClear;
		private static void ___DebugDrawClear()
		{
			__DebugDrawClear();
		}

		/// <summary>
		/// Draws a debug overlay line.
		/// </summary>
		/// <param name="origin">Start point of the line.</param>
		/// <param name="target">End point of the line.</param>
		/// <param name="r">Red color value.</param>
		/// <param name="g">Green color value.</param>
		/// <param name="b">Blue color value.</param>
		/// <param name="zTest">Whether to perform depth testing.</param>
		/// <param name="duration">Duration (in seconds) to display the line.</param>
		internal static delegate*<Vector3, Vector3, int, int, int, Bool8, float, void> DebugDrawLine = &___DebugDrawLine;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, int, int, int, Bool8, float, void> __DebugDrawLine;
		private static void ___DebugDrawLine(Vector3 origin, Vector3 target, int r, int g, int b, Bool8 zTest, float duration)
		{
			__DebugDrawLine(&origin, &target, r, g, b, zTest, duration);
		}

		/// <summary>
		/// Draws a debug line using a color vector.
		/// </summary>
		/// <param name="start">Start point of the line.</param>
		/// <param name="end">End point of the line.</param>
		/// <param name="color">RGB color vector.</param>
		/// <param name="zTest">Whether to perform depth testing.</param>
		/// <param name="duration">Duration (in seconds) to display the line.</param>
		internal static delegate*<Vector3, Vector3, Vector3, Bool8, float, void> DebugDrawLine_vCol = &___DebugDrawLine_vCol;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, Bool8, float, void> __DebugDrawLine_vCol;
		private static void ___DebugDrawLine_vCol(Vector3 start, Vector3 end, Vector3 color, Bool8 zTest, float duration)
		{
			__DebugDrawLine_vCol(&start, &end, &color, zTest, duration);
		}

		/// <summary>
		/// Draws text at a specified screen position with line offset.
		/// </summary>
		/// <param name="x">X coordinate in screen space.</param>
		/// <param name="y">Y coordinate in screen space.</param>
		/// <param name="lineOffset">Line offset value.</param>
		/// <param name="text">The text string to display.</param>
		/// <param name="r">Red color value.</param>
		/// <param name="g">Green color value.</param>
		/// <param name="b">Blue color value.</param>
		/// <param name="a">Alpha transparency value.</param>
		/// <param name="duration">Duration (in seconds) to display the text.</param>
		internal static delegate*<float, float, int, string, int, int, int, int, float, void> DebugDrawScreenTextLine = &___DebugDrawScreenTextLine;
		internal static delegate* unmanaged[Cdecl]<float, float, int, String192*, int, int, int, int, float, void> __DebugDrawScreenTextLine;
		private static void ___DebugDrawScreenTextLine(float x, float y, int lineOffset, string text, int r, int g, int b, int a, float duration)
		{
			var __text = NativeMethods.ConstructString(text);
			try {
				__DebugDrawScreenTextLine(x, y, lineOffset, &__text, r, g, b, a, duration);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__text);
			}
		}

		/// <summary>
		/// Draws a debug sphere.
		/// </summary>
		/// <param name="center">Center of the sphere.</param>
		/// <param name="color">RGB color vector.</param>
		/// <param name="alpha">Alpha transparency.</param>
		/// <param name="radius">Radius of the sphere.</param>
		/// <param name="zTest">Whether to perform depth testing.</param>
		/// <param name="duration">Duration (in seconds) to display the sphere.</param>
		internal static delegate*<Vector3, Vector3, float, float, Bool8, float, void> DebugDrawSphere = &___DebugDrawSphere;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, float, float, Bool8, float, void> __DebugDrawSphere;
		private static void ___DebugDrawSphere(Vector3 center, Vector3 color, float alpha, float radius, Bool8 zTest, float duration)
		{
			__DebugDrawSphere(&center, &color, alpha, radius, zTest, duration);
		}

		/// <summary>
		/// Draws text in 3D space.
		/// </summary>
		/// <param name="origin">World-space position to draw the text at.</param>
		/// <param name="text">The text string to display.</param>
		/// <param name="viewCheck">If true, only draws when visible to camera.</param>
		/// <param name="duration">Duration (in seconds) to display the text.</param>
		internal static delegate*<Vector3, string, Bool8, float, void> DebugDrawText = &___DebugDrawText;
		internal static delegate* unmanaged[Cdecl]<Vector3*, String192*, Bool8, float, void> __DebugDrawText;
		private static void ___DebugDrawText(Vector3 origin, string text, Bool8 viewCheck, float duration)
		{
			var __text = NativeMethods.ConstructString(text);
			try {
				__DebugDrawText(&origin, &__text, viewCheck, duration);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__text);
			}
		}

		/// <summary>
		/// Draws styled debug text on screen.
		/// </summary>
		/// <param name="x">X coordinate.</param>
		/// <param name="y">Y coordinate.</param>
		/// <param name="lineOffset">Line offset value.</param>
		/// <param name="text">Text string.</param>
		/// <param name="r">Red color value.</param>
		/// <param name="g">Green color value.</param>
		/// <param name="b">Blue color value.</param>
		/// <param name="a">Alpha transparency.</param>
		/// <param name="duration">Duration (in seconds) to display the text.</param>
		/// <param name="font">Font name.</param>
		/// <param name="size">Font size.</param>
		/// <param name="bold">Whether text should be bold.</param>
		internal static delegate*<float, float, int, string, int, int, int, int, float, string, int, Bool8, void> DebugScreenTextPretty = &___DebugScreenTextPretty;
		internal static delegate* unmanaged[Cdecl]<float, float, int, String192*, int, int, int, int, float, String192*, int, Bool8, void> __DebugScreenTextPretty;
		private static void ___DebugScreenTextPretty(float x, float y, int lineOffset, string text, int r, int g, int b, int a, float duration, string font, int size, Bool8 bold)
		{
			var __text = NativeMethods.ConstructString(text);
			var __font = NativeMethods.ConstructString(font);
			try {
				__DebugScreenTextPretty(x, y, lineOffset, &__text, r, g, b, a, duration, &__font, size, bold);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__text);
				NativeMethods.DestroyString(&__font);
			}
		}

		/// <summary>
		/// Performs an assertion and logs a message if the assertion fails.
		/// </summary>
		/// <param name="assertion">Boolean value to test.</param>
		/// <param name="message">Message to display if the assertion fails.</param>
		internal static delegate*<Bool8, string, void> DebugScriptAssert = &___DebugScriptAssert;
		internal static delegate* unmanaged[Cdecl]<Bool8, String192*, void> __DebugScriptAssert;
		private static void ___DebugScriptAssert(Bool8 assertion, string message)
		{
			var __message = NativeMethods.ConstructString(message);
			try {
				__DebugScriptAssert(assertion, &__message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__message);
			}
		}

	}

#pragma warning restore CS0649
}
