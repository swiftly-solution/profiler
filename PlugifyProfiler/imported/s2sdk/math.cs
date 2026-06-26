using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: math)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Returns angular difference in degrees
		/// </summary>
		/// <param name="angle1">First angle in degrees</param>
		/// <param name="angle2">Second angle in degrees</param>
		/// <returns>Angular difference in degrees</returns>
		internal static delegate*<float, float, float> AnglesDiff = &___AnglesDiff;
		internal static delegate* unmanaged[Cdecl]<float, float, float> __AnglesDiff;
		private static float ___AnglesDiff(float angle1, float angle2)
		{
			float __retVal = __AnglesDiff(angle1, angle2);
			return __retVal;
		}

		/// <summary>
		/// Converts QAngle to directional Vector
		/// </summary>
		/// <param name="angles">The QAngle to convert</param>
		/// <returns>Directional vector</returns>
		internal static delegate*<Vector3, Vector3> AnglesToVector = &___AnglesToVector;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3> __AnglesToVector;
		private static Vector3 ___AnglesToVector(Vector3 angles)
		{
			Vector3 __retVal = __AnglesToVector(&angles);
			return __retVal;
		}

		/// <summary>
		/// Converts axis-angle representation to quaternion
		/// </summary>
		/// <param name="axis">Rotation axis (should be normalized)</param>
		/// <param name="angle">Rotation angle in radians</param>
		/// <returns>Resulting quaternion</returns>
		internal static delegate*<Vector3, float, Vector4> AxisAngleToQuaternion = &___AxisAngleToQuaternion;
		internal static delegate* unmanaged[Cdecl]<Vector3*, float, Vector4> __AxisAngleToQuaternion;
		private static Vector4 ___AxisAngleToQuaternion(Vector3 axis, float angle)
		{
			Vector4 __retVal = __AxisAngleToQuaternion(&axis, angle);
			return __retVal;
		}

		/// <summary>
		/// Computes closest point on an entity's oriented bounding box (OBB)
		/// </summary>
		/// <param name="entityHandle">Handle of the entity</param>
		/// <param name="position">Position to find closest point from</param>
		/// <returns>Closest point on the entity's OBB, or vec3_origin if entity is invalid</returns>
		internal static delegate*<int, Vector3, Vector3> CalcClosestPointOnEntityOBB = &___CalcClosestPointOnEntityOBB;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3> __CalcClosestPointOnEntityOBB;
		private static Vector3 ___CalcClosestPointOnEntityOBB(int entityHandle, Vector3 position)
		{
			Vector3 __retVal = __CalcClosestPointOnEntityOBB(entityHandle, &position);
			return __retVal;
		}

		/// <summary>
		/// Computes distance between two entities' oriented bounding boxes (OBBs)
		/// </summary>
		/// <param name="entityHandle1">Handle of the first entity</param>
		/// <param name="entityHandle2">Handle of the second entity</param>
		/// <returns>Distance between OBBs, or -1.0f if either entity is invalid</returns>
		internal static delegate*<int, int, float> CalcDistanceBetweenEntityOBB = &___CalcDistanceBetweenEntityOBB;
		internal static delegate* unmanaged[Cdecl]<int, int, float> __CalcDistanceBetweenEntityOBB;
		private static float ___CalcDistanceBetweenEntityOBB(int entityHandle1, int entityHandle2)
		{
			float __retVal = __CalcDistanceBetweenEntityOBB(entityHandle1, entityHandle2);
			return __retVal;
		}

		/// <summary>
		/// Computes shortest 2D distance from a point to a line segment
		/// </summary>
		/// <param name="p">The point</param>
		/// <param name="vLineA">First endpoint of the line segment</param>
		/// <param name="vLineB">Second endpoint of the line segment</param>
		/// <returns>Shortest 2D distance</returns>
		internal static delegate*<Vector3, Vector3, Vector3, float> CalcDistanceToLineSegment2D = &___CalcDistanceToLineSegment2D;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, float> __CalcDistanceToLineSegment2D;
		private static float ___CalcDistanceToLineSegment2D(Vector3 p, Vector3 vLineA, Vector3 vLineB)
		{
			float __retVal = __CalcDistanceToLineSegment2D(&p, &vLineA, &vLineB);
			return __retVal;
		}

		/// <summary>
		/// Computes cross product of two vectors
		/// </summary>
		/// <param name="v1">First vector</param>
		/// <param name="v2">Second vector</param>
		/// <returns>Cross product vector (v1 × v2)</returns>
		internal static delegate*<Vector3, Vector3, Vector3> CrossVectors = &___CrossVectors;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3> __CrossVectors;
		private static Vector3 ___CrossVectors(Vector3 v1, Vector3 v2)
		{
			Vector3 __retVal = __CrossVectors(&v1, &v2);
			return __retVal;
		}

		/// <summary>
		/// Smooth exponential decay function
		/// </summary>
		/// <param name="decayTo">Target value to decay towards</param>
		/// <param name="decayTime">Time constant for decay</param>
		/// <param name="dt">Delta time</param>
		/// <returns>Decay factor</returns>
		internal static delegate*<float, float, float, float> ExponentDecay = &___ExponentDecay;
		internal static delegate* unmanaged[Cdecl]<float, float, float, float> __ExponentDecay;
		private static float ___ExponentDecay(float decayTo, float decayTime, float dt)
		{
			float __retVal = __ExponentDecay(decayTo, decayTime, dt);
			return __retVal;
		}

		/// <summary>
		/// Linear interpolation between two vectors
		/// </summary>
		/// <param name="start">Starting vector</param>
		/// <param name="end">Ending vector</param>
		/// <param name="factor">Interpolation factor (0.0 to 1.0)</param>
		/// <returns>Interpolated vector</returns>
		internal static delegate*<Vector3, Vector3, float, Vector3> LerpVectors = &___LerpVectors;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, float, Vector3> __LerpVectors;
		private static Vector3 ___LerpVectors(Vector3 start, Vector3 end, float factor)
		{
			Vector3 __retVal = __LerpVectors(&start, &end, factor);
			return __retVal;
		}

		/// <summary>
		/// Quaternion spherical linear interpolation for angles
		/// </summary>
		/// <param name="fromAngle">Starting angle</param>
		/// <param name="toAngle">Ending angle</param>
		/// <param name="time">Interpolation time (0.0 to 1.0)</param>
		/// <returns>Interpolated angle</returns>
		internal static delegate*<Vector3, Vector3, float, Vector3> QSlerp = &___QSlerp;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, float, Vector3> __QSlerp;
		private static Vector3 ___QSlerp(Vector3 fromAngle, Vector3 toAngle, float time)
		{
			Vector3 __retVal = __QSlerp(&fromAngle, &toAngle, time);
			return __retVal;
		}

		/// <summary>
		/// Rotate one QAngle by another
		/// </summary>
		/// <param name="a1">Base orientation</param>
		/// <param name="a2">Rotation to apply</param>
		/// <returns>Rotated orientation</returns>
		internal static delegate*<Vector3, Vector3, Vector3> RotateOrientation = &___RotateOrientation;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3> __RotateOrientation;
		private static Vector3 ___RotateOrientation(Vector3 a1, Vector3 a2)
		{
			Vector3 __retVal = __RotateOrientation(&a1, &a2);
			return __retVal;
		}

		/// <summary>
		/// Rotate a vector around a point by specified angle
		/// </summary>
		/// <param name="rotationOrigin">Origin point of rotation</param>
		/// <param name="rotationAngle">Angle to rotate by</param>
		/// <param name="vectorToRotate">Vector to be rotated</param>
		/// <returns>Rotated vector</returns>
		internal static delegate*<Vector3, Vector3, Vector3, Vector3> RotatePosition = &___RotatePosition;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3*, Vector3> __RotatePosition;
		private static Vector3 ___RotatePosition(Vector3 rotationOrigin, Vector3 rotationAngle, Vector3 vectorToRotate)
		{
			Vector3 __retVal = __RotatePosition(&rotationOrigin, &rotationAngle, &vectorToRotate);
			return __retVal;
		}

		/// <summary>
		/// Rotates quaternion by axis-angle representation
		/// </summary>
		/// <param name="q">Quaternion to rotate</param>
		/// <param name="axis">Rotation axis</param>
		/// <param name="angle">Rotation angle in radians</param>
		/// <returns>Rotated quaternion</returns>
		internal static delegate*<Vector4, Vector3, float, Vector4> RotateQuaternionByAxisAngle = &___RotateQuaternionByAxisAngle;
		internal static delegate* unmanaged[Cdecl]<Vector4*, Vector3*, float, Vector4> __RotateQuaternionByAxisAngle;
		private static Vector4 ___RotateQuaternionByAxisAngle(Vector4 q, Vector3 axis, float angle)
		{
			Vector4 __retVal = __RotateQuaternionByAxisAngle(&q, &axis, angle);
			return __retVal;
		}

		/// <summary>
		/// Finds angular delta between two QAngles
		/// </summary>
		/// <param name="src">Source angle</param>
		/// <param name="dest">Destination angle</param>
		/// <returns>Delta angle from src to dest</returns>
		internal static delegate*<Vector3, Vector3, Vector3> RotationDelta = &___RotationDelta;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3> __RotationDelta;
		private static Vector3 ___RotationDelta(Vector3 src, Vector3 dest)
		{
			Vector3 __retVal = __RotationDelta(&src, &dest);
			return __retVal;
		}

		/// <summary>
		/// Converts delta QAngle to angular velocity vector
		/// </summary>
		/// <param name="a1">First angle</param>
		/// <param name="a2">Second angle</param>
		/// <returns>Angular velocity vector</returns>
		internal static delegate*<Vector3, Vector3, Vector3> RotationDeltaAsAngularVelocity = &___RotationDeltaAsAngularVelocity;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, Vector3> __RotationDeltaAsAngularVelocity;
		private static Vector3 ___RotationDeltaAsAngularVelocity(Vector3 a1, Vector3 a2)
		{
			Vector3 __retVal = __RotationDeltaAsAngularVelocity(&a1, &a2);
			return __retVal;
		}

		/// <summary>
		/// Interpolates between two quaternions using spline
		/// </summary>
		/// <param name="q0">Starting quaternion</param>
		/// <param name="q1">Ending quaternion</param>
		/// <param name="t">Interpolation parameter (0.0 to 1.0)</param>
		/// <returns>Interpolated quaternion</returns>
		internal static delegate*<Vector4, Vector4, float, Vector4> SplineQuaternions = &___SplineQuaternions;
		internal static delegate* unmanaged[Cdecl]<Vector4*, Vector4*, float, Vector4> __SplineQuaternions;
		private static Vector4 ___SplineQuaternions(Vector4 q0, Vector4 q1, float t)
		{
			Vector4 __retVal = __SplineQuaternions(&q0, &q1, t);
			return __retVal;
		}

		/// <summary>
		/// Interpolates between two vectors using spline
		/// </summary>
		/// <param name="v0">Starting vector</param>
		/// <param name="v1">Ending vector</param>
		/// <param name="t">Interpolation parameter (0.0 to 1.0)</param>
		/// <returns>Interpolated vector</returns>
		internal static delegate*<Vector3, Vector3, float, Vector3> SplineVectors = &___SplineVectors;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3*, float, Vector3> __SplineVectors;
		private static Vector3 ___SplineVectors(Vector3 v0, Vector3 v1, float t)
		{
			Vector3 __retVal = __SplineVectors(&v0, &v1, t);
			return __retVal;
		}

		/// <summary>
		/// Converts directional vector to QAngle (no roll)
		/// </summary>
		/// <param name="input">Direction vector</param>
		/// <returns>Angle representation with pitch and yaw (roll is 0)</returns>
		internal static delegate*<Vector3, Vector3> VectorToAngles = &___VectorToAngles;
		internal static delegate* unmanaged[Cdecl]<Vector3*, Vector3> __VectorToAngles;
		private static Vector3 ___VectorToAngles(Vector3 input)
		{
			Vector3 __retVal = __VectorToAngles(&input);
			return __retVal;
		}

		/// <summary>
		/// Returns random float between min and max
		/// </summary>
		/// <param name="min">Minimum value (inclusive)</param>
		/// <param name="max">Maximum value (inclusive)</param>
		/// <returns>Random float in range [min, max]</returns>
		internal static delegate*<float, float, float> RandomFlt = &___RandomFlt;
		internal static delegate* unmanaged[Cdecl]<float, float, float> __RandomFlt;
		private static float ___RandomFlt(float min, float max)
		{
			float __retVal = __RandomFlt(min, max);
			return __retVal;
		}

		/// <summary>
		/// Returns random integer between min and max (inclusive)
		/// </summary>
		/// <param name="min">Minimum value (inclusive)</param>
		/// <param name="max">Maximum value (inclusive)</param>
		/// <returns>Random integer in range [min, max]</returns>
		internal static delegate*<int, int, int> RandomInt = &___RandomInt;
		internal static delegate* unmanaged[Cdecl]<int, int, int> __RandomInt;
		private static int ___RandomInt(int min, int max)
		{
			int __retVal = __RandomInt(min, max);
			return __retVal;
		}

	}

#pragma warning restore CS0649
}
