using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: models)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Retrieves the attachment angles of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose attachment angles are to be retrieved.</param>
		/// <param name="attachmentIndex">The attachment index.</param>
		/// <returns>A vector representing the attachment angles (pitch, yaw, roll).</returns>
		internal static delegate*<int, int, Vector3> GetEntityAttachmentAngles = &___GetEntityAttachmentAngles;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3> __GetEntityAttachmentAngles;
		private static Vector3 ___GetEntityAttachmentAngles(int entityHandle, int attachmentIndex)
		{
			Vector3 __retVal = __GetEntityAttachmentAngles(entityHandle, attachmentIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the forward vector of an entity's attachment.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose attachment forward vector is to be retrieved.</param>
		/// <param name="attachmentIndex">The attachment index.</param>
		/// <returns>A vector representing the forward direction of the attachment.</returns>
		internal static delegate*<int, int, Vector3> GetEntityAttachmentForward = &___GetEntityAttachmentForward;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3> __GetEntityAttachmentForward;
		private static Vector3 ___GetEntityAttachmentForward(int entityHandle, int attachmentIndex)
		{
			Vector3 __retVal = __GetEntityAttachmentForward(entityHandle, attachmentIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the origin vector of an entity's attachment.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity whose attachment origin is to be retrieved.</param>
		/// <param name="attachmentIndex">The attachment index.</param>
		/// <returns>A vector representing the origin of the attachment.</returns>
		internal static delegate*<int, int, Vector3> GetEntityAttachmentOrigin = &___GetEntityAttachmentOrigin;
		internal static delegate* unmanaged[Cdecl]<int, int, Vector3> __GetEntityAttachmentOrigin;
		private static Vector3 ___GetEntityAttachmentOrigin(int entityHandle, int attachmentIndex)
		{
			Vector3 __retVal = __GetEntityAttachmentOrigin(entityHandle, attachmentIndex);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the material group hash of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>The material group hash.</returns>
		internal static delegate*<int, uint> GetEntityMaterialGroupHash = &___GetEntityMaterialGroupHash;
		internal static delegate* unmanaged[Cdecl]<int, uint> __GetEntityMaterialGroupHash;
		private static uint ___GetEntityMaterialGroupHash(int entityHandle)
		{
			uint __retVal = __GetEntityMaterialGroupHash(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the material group mask of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>The mesh group mask.</returns>
		internal static delegate*<int, ulong> GetEntityMaterialGroupMask = &___GetEntityMaterialGroupMask;
		internal static delegate* unmanaged[Cdecl]<int, ulong> __GetEntityMaterialGroupMask;
		private static ulong ___GetEntityMaterialGroupMask(int entityHandle)
		{
			ulong __retVal = __GetEntityMaterialGroupMask(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the model scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>The model scale factor.</returns>
		internal static delegate*<int, float> GetEntityModelScale = &___GetEntityModelScale;
		internal static delegate* unmanaged[Cdecl]<int, float> __GetEntityModelScale;
		private static float ___GetEntityModelScale(int entityHandle)
		{
			float __retVal = __GetEntityModelScale(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the render alpha of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>The alpha modulation value.</returns>
		internal static delegate*<int, int> GetEntityRenderAlpha = &___GetEntityRenderAlpha;
		internal static delegate* unmanaged[Cdecl]<int, int> __GetEntityRenderAlpha;
		private static int ___GetEntityRenderAlpha(int entityHandle)
		{
			int __retVal = __GetEntityRenderAlpha(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves the render color of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <returns>A vector representing the render color (R, G, B).</returns>
		internal static delegate*<int, Vector3> GetEntityRenderColor2 = &___GetEntityRenderColor2;
		internal static delegate* unmanaged[Cdecl]<int, Vector3> __GetEntityRenderColor2;
		private static Vector3 ___GetEntityRenderColor2(int entityHandle)
		{
			Vector3 __retVal = __GetEntityRenderColor2(entityHandle);
			return __retVal;
		}

		/// <summary>
		/// Retrieves an attachment index by name.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="attachmentName">The name of the attachment.</param>
		/// <returns>The attachment index, or -1 if not found.</returns>
		internal static delegate*<int, string, int> ScriptLookupAttachment = &___ScriptLookupAttachment;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int> __ScriptLookupAttachment;
		private static int ___ScriptLookupAttachment(int entityHandle, string attachmentName)
		{
			int __retVal;
			var __attachmentName = NativeMethods.ConstructString(attachmentName);
			try {
				__retVal = __ScriptLookupAttachment(entityHandle, &__attachmentName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__attachmentName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a bodygroup value by index.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="group">The bodygroup index.</param>
		/// <param name="value">The new value to set for the bodygroup.</param>
		internal static delegate*<int, int, int, void> SetEntityBodygroup = &___SetEntityBodygroup;
		internal static delegate* unmanaged[Cdecl]<int, int, int, void> __SetEntityBodygroup;
		private static void ___SetEntityBodygroup(int entityHandle, int group, int value)
		{
			__SetEntityBodygroup(entityHandle, group, value);
		}

		/// <summary>
		/// Sets a bodygroup value by name.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="name">The bodygroup name.</param>
		/// <param name="value">The new value to set for the bodygroup.</param>
		internal static delegate*<int, string, int, void> SetEntityBodygroupByName = &___SetEntityBodygroupByName;
		internal static delegate* unmanaged[Cdecl]<int, String192*, int, void> __SetEntityBodygroupByName;
		private static void ___SetEntityBodygroupByName(int entityHandle, string name, int value)
		{
			var __name = NativeMethods.ConstructString(name);
			try {
				__SetEntityBodygroupByName(entityHandle, &__name, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__name);
			}
		}

		/// <summary>
		/// Sets the light group of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="lightGroup">The light group name.</param>
		internal static delegate*<int, string, void> SetEntityLightGroup = &___SetEntityLightGroup;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetEntityLightGroup;
		private static void ___SetEntityLightGroup(int entityHandle, string lightGroup)
		{
			var __lightGroup = NativeMethods.ConstructString(lightGroup);
			try {
				__SetEntityLightGroup(entityHandle, &__lightGroup);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__lightGroup);
			}
		}

		/// <summary>
		/// Sets the material group of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="materialGroup">The material group name.</param>
		internal static delegate*<int, string, void> SetEntityMaterialGroup = &___SetEntityMaterialGroup;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetEntityMaterialGroup;
		private static void ___SetEntityMaterialGroup(int entityHandle, string materialGroup)
		{
			var __materialGroup = NativeMethods.ConstructString(materialGroup);
			try {
				__SetEntityMaterialGroup(entityHandle, &__materialGroup);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__materialGroup);
			}
		}

		/// <summary>
		/// Sets the material group hash of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="hash">The new material group hash to set.</param>
		internal static delegate*<int, uint, void> SetEntityMaterialGroupHash = &___SetEntityMaterialGroupHash;
		internal static delegate* unmanaged[Cdecl]<int, uint, void> __SetEntityMaterialGroupHash;
		private static void ___SetEntityMaterialGroupHash(int entityHandle, uint hash)
		{
			__SetEntityMaterialGroupHash(entityHandle, hash);
		}

		/// <summary>
		/// Sets the material group mask of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="mask">The new mesh group mask to set.</param>
		internal static delegate*<int, ulong, void> SetEntityMaterialGroupMask = &___SetEntityMaterialGroupMask;
		internal static delegate* unmanaged[Cdecl]<int, ulong, void> __SetEntityMaterialGroupMask;
		private static void ___SetEntityMaterialGroupMask(int entityHandle, ulong mask)
		{
			__SetEntityMaterialGroupMask(entityHandle, mask);
		}

		/// <summary>
		/// Sets the model scale of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="scale">The new scale factor.</param>
		internal static delegate*<int, float, void> SetEntityModelScale = &___SetEntityModelScale;
		internal static delegate* unmanaged[Cdecl]<int, float, void> __SetEntityModelScale;
		private static void ___SetEntityModelScale(int entityHandle, float scale)
		{
			__SetEntityModelScale(entityHandle, scale);
		}

		/// <summary>
		/// Sets the render alpha of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="alpha">The new alpha value (0â€“255).</param>
		internal static delegate*<int, int, void> SetEntityRenderAlpha = &___SetEntityRenderAlpha;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityRenderAlpha;
		private static void ___SetEntityRenderAlpha(int entityHandle, int alpha)
		{
			__SetEntityRenderAlpha(entityHandle, alpha);
		}

		/// <summary>
		/// Sets the render color of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="r">The red component (0â€“255).</param>
		/// <param name="g">The green component (0â€“255).</param>
		/// <param name="b">The blue component (0â€“255).</param>
		internal static delegate*<int, int, int, int, void> SetEntityRenderColor2 = &___SetEntityRenderColor2;
		internal static delegate* unmanaged[Cdecl]<int, int, int, int, void> __SetEntityRenderColor2;
		private static void ___SetEntityRenderColor2(int entityHandle, int r, int g, int b)
		{
			__SetEntityRenderColor2(entityHandle, r, g, b);
		}

		/// <summary>
		/// Sets the render mode of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="mode">The new render mode value.</param>
		internal static delegate*<int, int, void> SetEntityRenderMode2 = &___SetEntityRenderMode2;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntityRenderMode2;
		private static void ___SetEntityRenderMode2(int entityHandle, int mode)
		{
			__SetEntityRenderMode2(entityHandle, mode);
		}

		/// <summary>
		/// Sets a single mesh group for an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="meshGroupName">The name of the mesh group.</param>
		internal static delegate*<int, string, void> SetEntitySingleMeshGroup = &___SetEntitySingleMeshGroup;
		internal static delegate* unmanaged[Cdecl]<int, String192*, void> __SetEntitySingleMeshGroup;
		private static void ___SetEntitySingleMeshGroup(int entityHandle, string meshGroupName)
		{
			var __meshGroupName = NativeMethods.ConstructString(meshGroupName);
			try {
				__SetEntitySingleMeshGroup(entityHandle, &__meshGroupName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__meshGroupName);
			}
		}

		/// <summary>
		/// Sets the size (bounding box) of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="mins">The minimum bounding box vector.</param>
		/// <param name="maxs">The maximum bounding box vector.</param>
		internal static delegate*<int, Vector3, Vector3, void> SetEntitySize = &___SetEntitySize;
		internal static delegate* unmanaged[Cdecl]<int, Vector3*, Vector3*, void> __SetEntitySize;
		private static void ___SetEntitySize(int entityHandle, Vector3 mins, Vector3 maxs)
		{
			__SetEntitySize(entityHandle, &mins, &maxs);
		}

		/// <summary>
		/// Sets the skin of an entity.
		/// </summary>
		/// <param name="entityHandle">The handle of the entity.</param>
		/// <param name="skin">The new skin index.</param>
		internal static delegate*<int, int, void> SetEntitySkin = &___SetEntitySkin;
		internal static delegate* unmanaged[Cdecl]<int, int, void> __SetEntitySkin;
		private static void ___SetEntitySkin(int entityHandle, int skin)
		{
			__SetEntitySkin(entityHandle, skin);
		}

	}

#pragma warning restore CS0649
}
