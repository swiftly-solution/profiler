using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: bodies)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Applies an impulse to an entity at a specific world position.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="position">The world position where the impulse will be applied.</param>
		/// <param name="impulse">The impulse vector to apply.</param>
		internal static delegate*<int, Vector3, Vector3, void> AddBodyImpulseAtPosition = &___AddBodyImpulseAtPosition;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3*, void> __AddBodyImpulseAtPosition;
		private static void ___AddBodyImpulseAtPosition(int entityHandle, Vector3 position, Vector3 impulse)
		{
			__AddBodyImpulseAtPosition(entityHandle, &position, &impulse);
		}

		/// <summary>
		/// Adds linear and angular velocity to the entity's physics object.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="linearVelocity">The linear velocity vector to add.</param>
		/// <param name="angularVelocity">The angular velocity vector to add.</param>
		internal static delegate*<int, Vector3, Vector3, void> AddBodyVelocity = &___AddBodyVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3*, void> __AddBodyVelocity;
		private static void ___AddBodyVelocity(int entityHandle, Vector3 linearVelocity, Vector3 angularVelocity)
		{
			__AddBodyVelocity(entityHandle, &linearVelocity, &angularVelocity);
		}

		/// <summary>
		/// Detaches the entity from its parent.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		internal static delegate*<int, void> DetachBodyFromParent = &___DetachBodyFromParent;
		internal static delegate* unmanaged[Cdecl]<int, void> __DetachBodyFromParent;
		private static void ___DetachBodyFromParent(int entityHandle)
		{
			__DetachBodyFromParent(entityHandle);
		}

		/// <summary>
		/// Retrieves the currently active sequence of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>The sequence ID of the active sequence, or -1 if invalid.</returns>
		internal static delegate*<int, int> GetBodySequence = &___GetBodySequence;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetBodySequence;
		private static int ___GetBodySequence(int entityHandle)
		{
			int __retVal = __GetBodySequence(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Checks whether the entity is attached to a parent.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>True if attached to a parent, false otherwise.</returns>
		internal static delegate*<int, Bool8> IsBodyAttachedToParent = &___IsBodyAttachedToParent;
		internal static delegate* unmanaged[Cdecl]<int, Bool8> __IsBodyAttachedToParent;
		private static Bool8 ___IsBodyAttachedToParent(int entityHandle)
		{
			Bool8 __retVal = __IsBodyAttachedToParent(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Looks up a sequence ID by its name.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The name of the sequence.</param>
		/// <returns>The sequence ID, or -1 if not found.</returns>
		internal static delegate*<int, string, int> LookupBodySequence = &___LookupBodySequence;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __LookupBodySequence;
		private static int ___LookupBodySequence(int entityHandle, string name)
		{
			int __retVal;
			var __name = NativeMethods.ConstructString(name);
			try {
				__retVal = __LookupBodySequence(entityHandle, &__name);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
			return __retVal;
		}

		/// <summary>
		/// Retrieves the duration of a specified sequence.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="sequenceName">The name of the sequence.</param>
		/// <returns>The duration of the sequence in seconds, or 0 if invalid.</returns>
		internal static delegate*<int, string, float> SetBodySequenceDuration = &___SetBodySequenceDuration;
		internal static delegate* unmanaged[Cdecl]<int, String192*, float> __SetBodySequenceDuration;
		private static float ___SetBodySequenceDuration(int entityHandle, string sequenceName)
		{
			float __retVal;
			var __sequenceName = NativeMethods.ConstructString(sequenceName);
			try {
				__retVal = __SetBodySequenceDuration(entityHandle, &__sequenceName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__sequenceName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets the angular velocity of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="angVelocity">The new angular velocity vector.</param>
		internal static delegate*<int, Vector3, void> SetBodyAngularVelocity = &___SetBodyAngularVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetBodyAngularVelocity;
		private static void ___SetBodyAngularVelocity(int entityHandle, Vector3 angVelocity)
		{
			__SetBodyAngularVelocity(entityHandle, &angVelocity);
		}

		/// <summary>
		/// Sets the material group of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="materialGroup">The material group token to assign.</param>
		internal static delegate*<int, string, void> SetBodyMaterialGroup = &___SetBodyMaterialGroup;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetBodyMaterialGroup;
		private static void ___SetBodyMaterialGroup(int entityHandle, string materialGroup)
		{
			var __materialGroup = NativeMethods.ConstructString(materialGroup);
			try {
				__SetBodyMaterialGroup(entityHandle, &__materialGroup);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__materialGroup);
			}
		}

		/// <summary>
		/// Sets the linear velocity of the entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="velocity">The new velocity vector.</param>
		internal static delegate*<int, Vector3, void> SetBodyVelocity = &___SetBodyVelocity;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, void> __SetBodyVelocity;
		private static void ___SetBodyVelocity(int entityHandle, Vector3 velocity)
		{
			__SetBodyVelocity(entityHandle, &velocity);
		}

	}

#pragma warning restore CS0649
}
