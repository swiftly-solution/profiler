using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plugify;

// Generated from s2sdk.pplugin (group: protobuf)

namespace s2sdk {
#pragma warning disable CS0649

	internal static unsafe partial class s2sdk {

		/// <summary>
		/// Hooks a user message with a callback.
		/// </summary>
		/// <param name="messageId">The ID of the message to hook.</param>
		/// <param name="callback">The callback function to invoke when the message is received.</param>
		/// <param name="mode">Whether to hook the message in the post mode (after processing) or pre mode (before processing).</param>
		/// <returns>True if the hook was successfully added, false otherwise.</returns>
		internal static delegate*<short, UserMessageCallback, HookMode, Bool8> HookUserMessage = &___HookUserMessage;
		internal static delegate* unmanaged[Cdecl]<short, nint, HookMode, Bool8> __HookUserMessage;
		private static Bool8 ___HookUserMessage(short messageId, UserMessageCallback callback, HookMode mode)
		{
			Bool8 __retVal = __HookUserMessage(messageId, Marshalling.GetFunctionPointerForDelegate(callback), mode);
			return __retVal;
		}

		/// <summary>
		/// Unhooks a previously hooked user message.
		/// </summary>
		/// <param name="messageId">The ID of the message to unhook.</param>
		/// <param name="callback">The callback function to remove.</param>
		/// <param name="mode">Whether the hook was in post mode (after processing) or pre mode (before processing).</param>
		/// <returns>True if the hook was successfully removed, false otherwise.</returns>
		internal static delegate*<short, UserMessageCallback, HookMode, Bool8> UnhookUserMessage = &___UnhookUserMessage;
		internal static delegate* unmanaged[Cdecl]<short, nint, HookMode, Bool8> __UnhookUserMessage;
		private static Bool8 ___UnhookUserMessage(short messageId, UserMessageCallback callback, HookMode mode)
		{
			Bool8 __retVal = __UnhookUserMessage(messageId, Marshalling.GetFunctionPointerForDelegate(callback), mode);
			return __retVal;
		}

		/// <summary>
		/// Creates a UserMessage from a serializable message.
		/// </summary>
		/// <param name="msgSerializable">The serializable message.</param>
		/// <param name="message">The network message.</param>
		/// <param name="recipientMask">The recipient mask.</param>
		/// <returns>A pointer to the newly created UserMessage.</returns>
		internal static delegate*<nint, nint, ulong, nint> UserMessageCreateFromSerializable = &___UserMessageCreateFromSerializable;
		internal static delegate* unmanaged[Cdecl]<nint, nint, ulong, nint> __UserMessageCreateFromSerializable;
		private static nint ___UserMessageCreateFromSerializable(nint msgSerializable, nint message, ulong recipientMask)
		{
			nint __retVal = __UserMessageCreateFromSerializable(msgSerializable, message, recipientMask);
			return __retVal;
		}

		/// <summary>
		/// Creates a UserMessage from a message name.
		/// </summary>
		/// <param name="messageName">The name of the message.</param>
		/// <returns>A pointer to the newly created UserMessage.</returns>
		internal static delegate*<string, nint> UserMessageCreateFromName = &___UserMessageCreateFromName;
		internal static delegate* unmanaged[Cdecl]<String192*, nint> __UserMessageCreateFromName;
		private static nint ___UserMessageCreateFromName(string messageName)
		{
			nint __retVal;
			var __messageName = NativeMethods.ConstructString(messageName);
			try {
				__retVal = __UserMessageCreateFromName(&__messageName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__messageName);
			}
			return __retVal;
		}

		/// <summary>
		/// Creates a UserMessage from a message ID.
		/// </summary>
		/// <param name="messageId">The ID of the message.</param>
		/// <returns>A pointer to the newly created UserMessage.</returns>
		internal static delegate*<short, nint> UserMessageCreateFromId = &___UserMessageCreateFromId;
		internal static delegate* unmanaged[Cdecl]<short, nint> __UserMessageCreateFromId;
		private static nint ___UserMessageCreateFromId(short messageId)
		{
			nint __retVal = __UserMessageCreateFromId(messageId);
			return __retVal;
		}

		/// <summary>
		/// Destroys a UserMessage and frees its memory.
		/// </summary>
		/// <param name="userMessage">The UserMessage to destroy.</param>
		internal static delegate*<nint, void> UserMessageDestroy = &___UserMessageDestroy;
		internal static delegate* unmanaged[Cdecl]<nint, void> __UserMessageDestroy;
		private static void ___UserMessageDestroy(nint userMessage)
		{
			__UserMessageDestroy(userMessage);
		}

		/// <summary>
		/// Sends a UserMessage to the specified recipients.
		/// </summary>
		/// <param name="userMessage">The UserMessage to send.</param>
		internal static delegate*<nint, void> UserMessageSend = &___UserMessageSend;
		internal static delegate* unmanaged[Cdecl]<nint, void> __UserMessageSend;
		private static void ___UserMessageSend(nint userMessage)
		{
			__UserMessageSend(userMessage);
		}

		/// <summary>
		/// Gets the name of the message.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>The name of the message as a string.</returns>
		internal static delegate*<nint, string> UserMessageGetMessageName = &___UserMessageGetMessageName;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __UserMessageGetMessageName;
		private static string ___UserMessageGetMessageName(nint userMessage)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __UserMessageGetMessageName(userMessage);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the ID of the message.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>The ID of the message.</returns>
		internal static delegate*<nint, short> UserMessageGetMessageID = &___UserMessageGetMessageID;
		internal static delegate* unmanaged[Cdecl]<nint, short> __UserMessageGetMessageID;
		private static short ___UserMessageGetMessageID(nint userMessage)
		{
			short __retVal = __UserMessageGetMessageID(userMessage);
			return __retVal;
		}

		/// <summary>
		/// Checks if the message has a specific field.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field to check.</param>
		/// <returns>True if the field exists, false otherwise.</returns>
		internal static delegate*<nint, string, Bool8> UserMessageHasField = &___UserMessageHasField;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8> __UserMessageHasField;
		private static Bool8 ___UserMessageHasField(nint userMessage, string fieldName)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageHasField(userMessage, &__fieldName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the protobuf message associated with the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>A pointer to the protobuf message.</returns>
		internal static delegate*<nint, nint> UserMessageGetProtobufMessage = &___UserMessageGetProtobufMessage;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __UserMessageGetProtobufMessage;
		private static nint ___UserMessageGetProtobufMessage(nint userMessage)
		{
			nint __retVal = __UserMessageGetProtobufMessage(userMessage);
			return __retVal;
		}

		/// <summary>
		/// Gets the serializable message associated with the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>A pointer to the serializable message.</returns>
		internal static delegate*<nint, nint> UserMessageGetSerializableMessage = &___UserMessageGetSerializableMessage;
		internal static delegate* unmanaged[Cdecl]<nint, nint> __UserMessageGetSerializableMessage;
		private static nint ___UserMessageGetSerializableMessage(nint userMessage)
		{
			nint __retVal = __UserMessageGetSerializableMessage(userMessage);
			return __retVal;
		}

		/// <summary>
		/// Finds a message ID by its name.
		/// </summary>
		/// <param name="messageName">The name of the message.</param>
		/// <returns>The ID of the message, or 0 if the message was not found.</returns>
		internal static delegate*<string, short> UserMessageFindMessageIdByName = &___UserMessageFindMessageIdByName;
		internal static delegate* unmanaged[Cdecl]<String192*, short> __UserMessageFindMessageIdByName;
		private static short ___UserMessageFindMessageIdByName(string messageName)
		{
			short __retVal;
			var __messageName = NativeMethods.ConstructString(messageName);
			try {
				__retVal = __UserMessageFindMessageIdByName(&__messageName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__messageName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the recipient mask for the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>The recipient mask.</returns>
		internal static delegate*<nint, ulong> UserMessageGetRecipientMask = &___UserMessageGetRecipientMask;
		internal static delegate* unmanaged[Cdecl]<nint, ulong> __UserMessageGetRecipientMask;
		private static ulong ___UserMessageGetRecipientMask(nint userMessage)
		{
			ulong __retVal = __UserMessageGetRecipientMask(userMessage);
			return __retVal;
		}

		/// <summary>
		/// Adds a single recipient (player) to the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="playerSlot">The slot index of the player to add as a recipient.</param>
		internal static delegate*<nint, int, void> UserMessageAddRecipient = &___UserMessageAddRecipient;
		internal static delegate* unmanaged[Cdecl]<nint, int, void> __UserMessageAddRecipient;
		private static void ___UserMessageAddRecipient(nint userMessage, int playerSlot)
		{
			__UserMessageAddRecipient(userMessage, playerSlot);
		}

		/// <summary>
		/// Adds all connected players as recipients to the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		internal static delegate*<nint, void> UserMessageAddAllPlayers = &___UserMessageAddAllPlayers;
		internal static delegate* unmanaged[Cdecl]<nint, void> __UserMessageAddAllPlayers;
		private static void ___UserMessageAddAllPlayers(nint userMessage)
		{
			__UserMessageAddAllPlayers(userMessage);
		}

		/// <summary>
		/// Sets the recipient mask for the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="mask">The recipient mask to set.</param>
		internal static delegate*<nint, ulong, void> UserMessageSetRecipientMask = &___UserMessageSetRecipientMask;
		internal static delegate* unmanaged[Cdecl]<nint, ulong, void> __UserMessageSetRecipientMask;
		private static void ___UserMessageSetRecipientMask(nint userMessage, ulong mask)
		{
			__UserMessageSetRecipientMask(userMessage, mask);
		}

		/// <summary>
		/// Gets a nested message from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="message">A pointer to store the retrieved message.</param>
		/// <returns>True if the message was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> UserMessageGetMessage = &___UserMessageGetMessage;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __UserMessageGetMessage;
		private static Bool8 ___UserMessageGetMessage(nint userMessage, string fieldName, nint message)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageGetMessage(userMessage, &__fieldName, message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated nested message from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="message">A pointer to store the retrieved message.</param>
		/// <returns>True if the message was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> UserMessageGetRepeatedMessage = &___UserMessageGetRepeatedMessage;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __UserMessageGetRepeatedMessage;
		private static Bool8 ___UserMessageGetRepeatedMessage(nint userMessage, string fieldName, int index, nint message)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageGetRepeatedMessage(userMessage, &__fieldName, index, message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a nested message to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="message">A pointer to the message to add.</param>
		/// <returns>True if the message was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> UserMessageAddMessage = &___UserMessageAddMessage;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __UserMessageAddMessage;
		private static Bool8 ___UserMessageAddMessage(nint userMessage, string fieldName, nint message)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageAddMessage(userMessage, &__fieldName, message);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the count of repeated fields in a field of the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>The count of repeated fields, or -1 if the field is not repeated or does not exist.</returns>
		internal static delegate*<nint, string, int> UserMessageGetRepeatedFieldCount = &___UserMessageGetRepeatedFieldCount;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int> __UserMessageGetRepeatedFieldCount;
		private static int ___UserMessageGetRepeatedFieldCount(nint userMessage, string fieldName)
		{
			int __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageGetRepeatedFieldCount(userMessage, &__fieldName);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Removes a value from a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the value to remove.</param>
		/// <returns>True if the value was successfully removed, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> UserMessageRemoveRepeatedFieldValue = &___UserMessageRemoveRepeatedFieldValue;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __UserMessageRemoveRepeatedFieldValue;
		private static Bool8 ___UserMessageRemoveRepeatedFieldValue(nint userMessage, string fieldName, int index)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __UserMessageRemoveRepeatedFieldValue(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets the debug string representation of the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <returns>The debug string as a string.</returns>
		internal static delegate*<nint, string> UserMessageGetDebugString = &___UserMessageGetDebugString;
		internal static delegate* unmanaged[Cdecl]<nint, String192> __UserMessageGetDebugString;
		private static string ___UserMessageGetDebugString(nint userMessage)
		{
			string __retVal;
			String192 __retVal_native;
			try {
				__retVal_native = __UserMessageGetDebugString(userMessage);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads an enum value from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The integer representation of the enum value, or 0 if invalid.</returns>
		internal static delegate*<nint, string, int, int> PbReadEnum = &___PbReadEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __PbReadEnum;
		private static int ___PbReadEnum(nint userMessage, string fieldName, int index)
		{
			int __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadEnum(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a 32-bit integer from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The int32_t value read, or 0 if invalid.</returns>
		internal static delegate*<nint, string, int, int> PbReadInt32 = &___PbReadInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __PbReadInt32;
		private static int ___PbReadInt32(nint userMessage, string fieldName, int index)
		{
			int __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadInt32(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a 64-bit integer from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The int64_t value read, or 0 if invalid.</returns>
		internal static delegate*<nint, string, int, long> PbReadInt64 = &___PbReadInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, long> __PbReadInt64;
		private static long ___PbReadInt64(nint userMessage, string fieldName, int index)
		{
			long __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadInt64(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads an unsigned 32-bit integer from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The uint32_t value read, or 0 if invalid.</returns>
		internal static delegate*<nint, string, int, uint> PbReadUInt32 = &___PbReadUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, uint> __PbReadUInt32;
		private static uint ___PbReadUInt32(nint userMessage, string fieldName, int index)
		{
			uint __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadUInt32(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads an unsigned 64-bit integer from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The uint64_t value read, or 0 if invalid.</returns>
		internal static delegate*<nint, string, int, ulong> PbReadUInt64 = &___PbReadUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, ulong> __PbReadUInt64;
		private static ulong ___PbReadUInt64(nint userMessage, string fieldName, int index)
		{
			ulong __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadUInt64(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a floating-point value from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The float value read, or 0.0 if invalid.</returns>
		internal static delegate*<nint, string, int, float> PbReadFloat = &___PbReadFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, float> __PbReadFloat;
		private static float ___PbReadFloat(nint userMessage, string fieldName, int index)
		{
			float __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadFloat(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a double-precision floating-point value from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The double value read, or 0.0 if invalid.</returns>
		internal static delegate*<nint, string, int, double> PbReadDouble = &___PbReadDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, double> __PbReadDouble;
		private static double ___PbReadDouble(nint userMessage, string fieldName, int index)
		{
			double __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadDouble(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a boolean value from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The boolean value read, or false if invalid.</returns>
		internal static delegate*<nint, string, int, Bool8> PbReadBool = &___PbReadBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbReadBool;
		private static Bool8 ___PbReadBool(nint userMessage, string fieldName, int index)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadBool(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a string from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The string value read, or an empty string if invalid.</returns>
		internal static delegate*<nint, string, int, string> PbReadString = &___PbReadString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, String192> __PbReadString;
		private static string ___PbReadString(nint userMessage, string fieldName, int index)
		{
			string __retVal;
			String192 __retVal_native;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal_native = __PbReadString(userMessage, &__fieldName, index);
				// Unmarshal - Convert native data to managed data.
				__retVal = NativeMethods.GetStringData(&__retVal_native);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__retVal_native);
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a color value from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The color value read, or an empty value if invalid.</returns>
		internal static delegate*<nint, string, int, int> PbReadColor = &___PbReadColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int> __PbReadColor;
		private static int ___PbReadColor(nint userMessage, string fieldName, int index)
		{
			int __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadColor(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a 2D vector from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The 2D vector value read, or an empty value if invalid.</returns>
		internal static delegate*<nint, string, int, Vector2> PbReadVector2 = &___PbReadVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector2> __PbReadVector2;
		private static Vector2 ___PbReadVector2(nint userMessage, string fieldName, int index)
		{
			Vector2 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadVector2(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a 3D vector from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The 3D vector value read, or an empty value if invalid.</returns>
		internal static delegate*<nint, string, int, Vector3> PbReadVector3 = &___PbReadVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector3> __PbReadVector3;
		private static Vector3 ___PbReadVector3(nint userMessage, string fieldName, int index)
		{
			Vector3 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadVector3(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Reads a QAngle (rotation vector) from a UserMessage.
		/// </summary>
		/// <param name="userMessage">Pointer to the UserMessage object.</param>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The QAngle value read, or an empty value if invalid.</returns>
		internal static delegate*<nint, string, int, Vector3> PbReadQAngle = &___PbReadQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector3> __PbReadQAngle;
		private static Vector3 ___PbReadQAngle(nint userMessage, string fieldName, int index)
		{
			Vector3 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbReadQAngle(userMessage, &__fieldName, index);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a enum value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetEnum = &___PbGetEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetEnum;
		private static Bool8 ___PbGetEnum(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetEnum(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a enum value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbSetEnum = &___PbSetEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbSetEnum;
		private static Bool8 ___PbSetEnum(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetEnum(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 32-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetInt32 = &___PbGetInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetInt32;
		private static Bool8 ___PbGetInt32(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetInt32(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a 32-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbSetInt32 = &___PbSetInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbSetInt32;
		private static Bool8 ___PbSetInt32(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetInt32(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a 64-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetInt64 = &___PbGetInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetInt64;
		private static Bool8 ___PbGetInt64(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetInt64(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a 64-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, long, Bool8> PbSetInt64 = &___PbSetInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, long, Bool8> __PbSetInt64;
		private static Bool8 ___PbSetInt64(nint userMessage, string fieldName, long value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetInt64(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 32-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetUInt32 = &___PbGetUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetUInt32;
		private static Bool8 ___PbGetUInt32(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetUInt32(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an unsigned 32-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, uint, Bool8> PbSetUInt32 = &___PbSetUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, Bool8> __PbSetUInt32;
		private static Bool8 ___PbSetUInt32(nint userMessage, string fieldName, uint value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetUInt32(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets an unsigned 64-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetUInt64 = &___PbGetUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetUInt64;
		private static Bool8 ___PbGetUInt64(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetUInt64(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets an unsigned 64-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, ulong, Bool8> PbSetUInt64 = &___PbSetUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong, Bool8> __PbSetUInt64;
		private static Bool8 ___PbSetUInt64(nint userMessage, string fieldName, ulong value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetUInt64(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a bool value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetBool = &___PbGetBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetBool;
		private static Bool8 ___PbGetBool(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetBool(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a bool value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, Bool8, Bool8> PbSetBool = &___PbSetBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, Bool8> __PbSetBool;
		private static Bool8 ___PbSetBool(nint userMessage, string fieldName, Bool8 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetBool(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a float value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetFloat = &___PbGetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetFloat;
		private static Bool8 ___PbGetFloat(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetFloat(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a float value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, float, Bool8> PbSetFloat = &___PbSetFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, Bool8> __PbSetFloat;
		private static Bool8 ___PbSetFloat(nint userMessage, string fieldName, float value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetFloat(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a double value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetDouble = &___PbGetDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetDouble;
		private static Bool8 ___PbGetDouble(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetDouble(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a double value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, double, Bool8> PbSetDouble = &___PbSetDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, double, Bool8> __PbSetDouble;
		private static Bool8 ___PbSetDouble(nint userMessage, string fieldName, double value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetDouble(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a string value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, ref string, Bool8> PbGetString = &___PbGetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Bool8> __PbGetString;
		private static Bool8 ___PbGetString(nint userMessage, string fieldName, ref string out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			var __out_ = NativeMethods.ConstructString(out_);
			try {
				__retVal = __PbGetString(userMessage, &__fieldName, &__out_);
				// Unmarshal - Convert native data to managed data.
				out_ = NativeMethods.GetStringData(&__out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
				NativeMethods.DestroyString(&__out_);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a string value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, string, Bool8> PbSetString = &___PbSetString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Bool8> __PbSetString;
		private static Bool8 ___PbSetString(nint userMessage, string fieldName, string value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__retVal = __PbSetString(userMessage, &__fieldName, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
				NativeMethods.DestroyString(&__value);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a color value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetColor = &___PbGetColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetColor;
		private static Bool8 ___PbGetColor(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetColor(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a color value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbSetColor = &___PbSetColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbSetColor;
		private static Bool8 ___PbSetColor(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetColor(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a Vector2 value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetVector2 = &___PbGetVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetVector2;
		private static Bool8 ___PbGetVector2(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetVector2(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a Vector2 value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, Vector2, Bool8> PbSetVector2 = &___PbSetVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector2*, Bool8> __PbSetVector2;
		private static Bool8 ___PbSetVector2(nint userMessage, string fieldName, Vector2 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetVector2(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a Vector3 value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetVector3 = &___PbGetVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetVector3;
		private static Bool8 ___PbGetVector3(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetVector3(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a Vector3 value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, Vector3, Bool8> PbSetVector3 = &___PbSetVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Bool8> __PbSetVector3;
		private static Bool8 ___PbSetVector3(nint userMessage, string fieldName, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetVector3(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a QAngle value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, nint, Bool8> PbGetQAngle = &___PbGetQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, nint, Bool8> __PbGetQAngle;
		private static Bool8 ___PbGetQAngle(nint userMessage, string fieldName, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetQAngle(userMessage, &__fieldName, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a QAngle value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, Vector3, Bool8> PbSetQAngle = &___PbSetQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Bool8> __PbSetQAngle;
		private static Bool8 ___PbSetQAngle(nint userMessage, string fieldName, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetQAngle(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated enum value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedEnum = &___PbGetRepeatedEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedEnum;
		private static Bool8 ___PbGetRepeatedEnum(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedEnum(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated enum value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, int, Bool8> PbSetRepeatedEnum = &___PbSetRepeatedEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int, Bool8> __PbSetRepeatedEnum;
		private static Bool8 ___PbSetRepeatedEnum(nint userMessage, string fieldName, int index, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedEnum(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a enum value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbAddEnum = &___PbAddEnum;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbAddEnum;
		private static Bool8 ___PbAddEnum(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddEnum(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated int32_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedInt32 = &___PbGetRepeatedInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedInt32;
		private static Bool8 ___PbGetRepeatedInt32(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedInt32(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated int32_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, int, Bool8> PbSetRepeatedInt32 = &___PbSetRepeatedInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int, Bool8> __PbSetRepeatedInt32;
		private static Bool8 ___PbSetRepeatedInt32(nint userMessage, string fieldName, int index, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedInt32(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a 32-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbAddInt32 = &___PbAddInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbAddInt32;
		private static Bool8 ___PbAddInt32(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddInt32(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated int64_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedInt64 = &___PbGetRepeatedInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedInt64;
		private static Bool8 ___PbGetRepeatedInt64(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedInt64(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated int64_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, long, Bool8> PbSetRepeatedInt64 = &___PbSetRepeatedInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, long, Bool8> __PbSetRepeatedInt64;
		private static Bool8 ___PbSetRepeatedInt64(nint userMessage, string fieldName, int index, long value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedInt64(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a 64-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, long, Bool8> PbAddInt64 = &___PbAddInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, long, Bool8> __PbAddInt64;
		private static Bool8 ___PbAddInt64(nint userMessage, string fieldName, long value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddInt64(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated uint32_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedUInt32 = &___PbGetRepeatedUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedUInt32;
		private static Bool8 ___PbGetRepeatedUInt32(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedUInt32(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated uint32_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, uint, Bool8> PbSetRepeatedUInt32 = &___PbSetRepeatedUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, uint, Bool8> __PbSetRepeatedUInt32;
		private static Bool8 ___PbSetRepeatedUInt32(nint userMessage, string fieldName, int index, uint value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedUInt32(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds an unsigned 32-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, uint, Bool8> PbAddUInt32 = &___PbAddUInt32;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, uint, Bool8> __PbAddUInt32;
		private static Bool8 ___PbAddUInt32(nint userMessage, string fieldName, uint value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddUInt32(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated uint64_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedUInt64 = &___PbGetRepeatedUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedUInt64;
		private static Bool8 ___PbGetRepeatedUInt64(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedUInt64(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated uint64_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, ulong, Bool8> PbSetRepeatedUInt64 = &___PbSetRepeatedUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, ulong, Bool8> __PbSetRepeatedUInt64;
		private static Bool8 ___PbSetRepeatedUInt64(nint userMessage, string fieldName, int index, ulong value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedUInt64(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds an unsigned 64-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, ulong, Bool8> PbAddUInt64 = &___PbAddUInt64;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, ulong, Bool8> __PbAddUInt64;
		private static Bool8 ___PbAddUInt64(nint userMessage, string fieldName, ulong value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddUInt64(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated bool value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedBool = &___PbGetRepeatedBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedBool;
		private static Bool8 ___PbGetRepeatedBool(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedBool(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated bool value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8, Bool8> PbSetRepeatedBool = &___PbSetRepeatedBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8, Bool8> __PbSetRepeatedBool;
		private static Bool8 ___PbSetRepeatedBool(nint userMessage, string fieldName, int index, Bool8 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedBool(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a bool value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, Bool8, Bool8> PbAddBool = &___PbAddBool;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Bool8, Bool8> __PbAddBool;
		private static Bool8 ___PbAddBool(nint userMessage, string fieldName, Bool8 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddBool(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated float value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedFloat = &___PbGetRepeatedFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedFloat;
		private static Bool8 ___PbGetRepeatedFloat(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedFloat(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated float value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, float, Bool8> PbSetRepeatedFloat = &___PbSetRepeatedFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, float, Bool8> __PbSetRepeatedFloat;
		private static Bool8 ___PbSetRepeatedFloat(nint userMessage, string fieldName, int index, float value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedFloat(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a float value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, float, Bool8> PbAddFloat = &___PbAddFloat;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, float, Bool8> __PbAddFloat;
		private static Bool8 ___PbAddFloat(nint userMessage, string fieldName, float value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddFloat(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated double value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedDouble = &___PbGetRepeatedDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedDouble;
		private static Bool8 ___PbGetRepeatedDouble(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedDouble(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated double value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, double, Bool8> PbSetRepeatedDouble = &___PbSetRepeatedDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, double, Bool8> __PbSetRepeatedDouble;
		private static Bool8 ___PbSetRepeatedDouble(nint userMessage, string fieldName, int index, double value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedDouble(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a double value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, double, Bool8> PbAddDouble = &___PbAddDouble;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, double, Bool8> __PbAddDouble;
		private static Bool8 ___PbAddDouble(nint userMessage, string fieldName, double value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddDouble(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated string value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, ref string, Bool8> PbGetRepeatedString = &___PbGetRepeatedString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, String192*, Bool8> __PbGetRepeatedString;
		private static Bool8 ___PbGetRepeatedString(nint userMessage, string fieldName, int index, ref string out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			var __out_ = NativeMethods.ConstructString(out_);
			try {
				__retVal = __PbGetRepeatedString(userMessage, &__fieldName, index, &__out_);
				// Unmarshal - Convert native data to managed data.
				out_ = NativeMethods.GetStringData(&__out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
				NativeMethods.DestroyString(&__out_);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated string value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, string, Bool8> PbSetRepeatedString = &___PbSetRepeatedString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, String192*, Bool8> __PbSetRepeatedString;
		private static Bool8 ___PbSetRepeatedString(nint userMessage, string fieldName, int index, string value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__retVal = __PbSetRepeatedString(userMessage, &__fieldName, index, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
				NativeMethods.DestroyString(&__value);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a string value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, string, Bool8> PbAddString = &___PbAddString;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, String192*, Bool8> __PbAddString;
		private static Bool8 ___PbAddString(nint userMessage, string fieldName, string value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			var __value = NativeMethods.ConstructString(value);
			try {
				__retVal = __PbAddString(userMessage, &__fieldName, &__value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
				NativeMethods.DestroyString(&__value);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated color value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output color.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedColor = &___PbGetRepeatedColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedColor;
		private static Bool8 ___PbGetRepeatedColor(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedColor(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated color value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, int, Bool8> PbSetRepeatedColor = &___PbSetRepeatedColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, int, Bool8> __PbSetRepeatedColor;
		private static Bool8 ___PbSetRepeatedColor(nint userMessage, string fieldName, int index, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedColor(userMessage, &__fieldName, index, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a color value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, int, Bool8> PbAddColor = &___PbAddColor;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Bool8> __PbAddColor;
		private static Bool8 ___PbAddColor(nint userMessage, string fieldName, int value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddColor(userMessage, &__fieldName, value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated Vector2 value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedVector2 = &___PbGetRepeatedVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedVector2;
		private static Bool8 ___PbGetRepeatedVector2(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedVector2(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated Vector2 value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Vector2, Bool8> PbSetRepeatedVector2 = &___PbSetRepeatedVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector2*, Bool8> __PbSetRepeatedVector2;
		private static Bool8 ___PbSetRepeatedVector2(nint userMessage, string fieldName, int index, Vector2 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedVector2(userMessage, &__fieldName, index, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a Vector2 value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, Vector2, Bool8> PbAddVector2 = &___PbAddVector2;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector2*, Bool8> __PbAddVector2;
		private static Bool8 ___PbAddVector2(nint userMessage, string fieldName, Vector2 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddVector2(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated Vector3 value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedVector3 = &___PbGetRepeatedVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedVector3;
		private static Bool8 ___PbGetRepeatedVector3(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedVector3(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated Vector3 value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Vector3, Bool8> PbSetRepeatedVector3 = &___PbSetRepeatedVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector3*, Bool8> __PbSetRepeatedVector3;
		private static Bool8 ___PbSetRepeatedVector3(nint userMessage, string fieldName, int index, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedVector3(userMessage, &__fieldName, index, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a Vector3 value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, Vector3, Bool8> PbAddVector3 = &___PbAddVector3;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Bool8> __PbAddVector3;
		private static Bool8 ___PbAddVector3(nint userMessage, string fieldName, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddVector3(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Gets a repeated QAngle value from a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		internal static delegate*<nint, string, int, nint, Bool8> PbGetRepeatedQAngle = &___PbGetRepeatedQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, nint, Bool8> __PbGetRepeatedQAngle;
		private static Bool8 ___PbGetRepeatedQAngle(nint userMessage, string fieldName, int index, nint out_)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbGetRepeatedQAngle(userMessage, &__fieldName, index, out_);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Sets a repeated QAngle value for a field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		internal static delegate*<nint, string, int, Vector3, Bool8> PbSetRepeatedQAngle = &___PbSetRepeatedQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, int, Vector3*, Bool8> __PbSetRepeatedQAngle;
		private static Bool8 ___PbSetRepeatedQAngle(nint userMessage, string fieldName, int index, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbSetRepeatedQAngle(userMessage, &__fieldName, index, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

		/// <summary>
		/// Adds a QAngle value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="userMessage">The UserMessage instance.</param>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		internal static delegate*<nint, string, Vector3, Bool8> PbAddQAngle = &___PbAddQAngle;
		internal static delegate* unmanaged[Cdecl]<nint, String192*, Vector3*, Bool8> __PbAddQAngle;
		private static Bool8 ___PbAddQAngle(nint userMessage, string fieldName, Vector3 value)
		{
			Bool8 __retVal;
			var __fieldName = NativeMethods.ConstructString(fieldName);
			try {
				__retVal = __PbAddQAngle(userMessage, &__fieldName, &value);
			}
			finally {
				// Perform cleanup.
				NativeMethods.DestroyString(&__fieldName);
			}
			return __retVal;
		}

	}

	/// <summary>
	/// RAII wrapper for UserMessage pointer.
	/// </summary>
	internal sealed unsafe class UserMessage : SafeHandle
	{
		/// <summary>
		/// Creates a UserMessage from a serializable message.
		/// </summary>
		/// <param name="msgSerializable">The serializable message.</param>
		/// <param name="message">The network message.</param>
		/// <param name="recipientMask">The recipient mask.</param>
		public UserMessage(nint msgSerializable, nint message, ulong recipientMask) : this(s2sdk.UserMessageCreateFromSerializable(msgSerializable, message, recipientMask), Ownership.Owned)
		{
		}

		/// <summary>
		/// Creates a UserMessage from a message name.
		/// </summary>
		/// <param name="messageName">The name of the message.</param>
		public UserMessage(string messageName) : this(s2sdk.UserMessageCreateFromName(messageName), Ownership.Owned)
		{
		}

		/// <summary>
		/// Creates a UserMessage from a message ID.
		/// </summary>
		/// <param name="messageId">The ID of the message.</param>
		public UserMessage(short messageId) : this(s2sdk.UserMessageCreateFromId(messageId), Ownership.Owned)
		{
		}

		/// <summary>
		/// Internal constructor for creating UserMessage from existing handle
		/// </summary>
		public UserMessage(nint handle, Ownership ownership = Ownership.Borrowed) : base((nint)handle, ownsHandle: ownership == Ownership.Owned)
		{
		}

		/// <summary>
		/// Releases the handle (called automatically by SafeHandle)
		/// </summary>
		protected override bool ReleaseHandle()
		{
			s2sdk.UserMessageDestroy((nint)handle);
			return true;
		}

		/// <summary>
		/// Checks if the UserMessage has a valid handle
		/// </summary>
		public override bool IsInvalid => handle == nint.Zero;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Handle => (nint)handle;

		/// <summary>
		/// Checks if the handle is valid
		/// </summary>
		public bool IsValid => handle != nint.Zero;

		/// <summary>
		/// Gets the underlying handle
		/// </summary>
		public nint Get() => (nint)handle;

		/// <summary>
		/// Releases ownership of the handle and returns it
		/// </summary>
		public nint Release()
		{
			var h = handle;
			SetHandleAsInvalid();
			return (nint)h;
		}

		/// <summary>
		/// Disposes the handle
		/// </summary>
		public void Reset()
		{
			Dispose();
		}

		/// <summary>
		/// Sends a UserMessage to the specified recipients.
		/// </summary>
		public void Send()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.UserMessageSend(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the name of the message.
		/// </summary>
		/// <returns>The name of the message as a string.</returns>
		public string GetMessageName()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetMessageName(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the ID of the message.
		/// </summary>
		/// <returns>The ID of the message.</returns>
		public short GetMessageID()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetMessageID(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Checks if the message has a specific field.
		/// </summary>
		/// <param name="fieldName">The name of the field to check.</param>
		/// <returns>True if the field exists, false otherwise.</returns>
		public Bool8 HasField(string fieldName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageHasField(Handle, fieldName);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the protobuf message associated with the UserMessage.
		/// </summary>
		/// <returns>A pointer to the protobuf message.</returns>
		public nint GetProtobufMessage()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetProtobufMessage(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the serializable message associated with the UserMessage.
		/// </summary>
		/// <returns>A pointer to the serializable message.</returns>
		public nint GetSerializableMessage()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetSerializableMessage(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Finds a message ID by its name.
		/// </summary>
		/// <param name="messageName">The name of the message.</param>
		/// <returns>The ID of the message, or 0 if the message was not found.</returns>
		public static short FindMessageIdByName(string messageName)
		{
			return s2sdk.UserMessageFindMessageIdByName(messageName);
		}

		/// <summary>
		/// Gets the recipient mask for the UserMessage.
		/// </summary>
		/// <returns>The recipient mask.</returns>
		public ulong GetRecipientMask()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetRecipientMask(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a single recipient (player) to the UserMessage.
		/// </summary>
		/// <param name="playerSlot">The slot index of the player to add as a recipient.</param>
		public void AddRecipient(int playerSlot)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.UserMessageAddRecipient(Handle, playerSlot);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds all connected players as recipients to the UserMessage.
		/// </summary>
		public void AddAllPlayers()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.UserMessageAddAllPlayers(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets the recipient mask for the UserMessage.
		/// </summary>
		/// <param name="mask">The recipient mask to set.</param>
		public void SetRecipientMask(ulong mask)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				s2sdk.UserMessageSetRecipientMask(Handle, mask);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a nested message from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="message">A pointer to store the retrieved message.</param>
		/// <returns>True if the message was successfully retrieved, false otherwise.</returns>
		public Bool8 GetMessage(string fieldName, nint message)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetMessage(Handle, fieldName, message);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated nested message from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="message">A pointer to store the retrieved message.</param>
		/// <returns>True if the message was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedMessage(string fieldName, int index, nint message)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetRepeatedMessage(Handle, fieldName, index, message);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a nested message to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="message">A pointer to the message to add.</param>
		/// <returns>True if the message was successfully added, false otherwise.</returns>
		public Bool8 AddMessage(string fieldName, nint message)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageAddMessage(Handle, fieldName, message);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the count of repeated fields in a field of the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <returns>The count of repeated fields, or -1 if the field is not repeated or does not exist.</returns>
		public int GetRepeatedFieldCount(string fieldName)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetRepeatedFieldCount(Handle, fieldName);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Removes a value from a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the value to remove.</param>
		/// <returns>True if the value was successfully removed, false otherwise.</returns>
		public Bool8 RemoveRepeatedFieldValue(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageRemoveRepeatedFieldValue(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets the debug string representation of the UserMessage.
		/// </summary>
		/// <returns>The debug string as a string.</returns>
		public string GetDebugString()
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.UserMessageGetDebugString(Handle);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads an enum value from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The integer representation of the enum value, or 0 if invalid.</returns>
		public int ReadEnum(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadEnum(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a 32-bit integer from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The int32_t value read, or 0 if invalid.</returns>
		public int ReadInt32(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadInt32(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a 64-bit integer from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The int64_t value read, or 0 if invalid.</returns>
		public long ReadInt64(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadInt64(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads an unsigned 32-bit integer from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The uint32_t value read, or 0 if invalid.</returns>
		public uint ReadUInt32(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadUInt32(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads an unsigned 64-bit integer from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The uint64_t value read, or 0 if invalid.</returns>
		public ulong ReadUInt64(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadUInt64(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a floating-point value from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The float value read, or 0.0 if invalid.</returns>
		public float ReadFloat(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadFloat(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a double-precision floating-point value from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The double value read, or 0.0 if invalid.</returns>
		public double ReadDouble(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadDouble(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a boolean value from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The boolean value read, or false if invalid.</returns>
		public Bool8 ReadBool(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadBool(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a string from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The string value read, or an empty string if invalid.</returns>
		public string ReadString(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadString(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a color value from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The color value read, or an empty value if invalid.</returns>
		public int ReadColor(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadColor(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a 2D vector from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The 2D vector value read, or an empty value if invalid.</returns>
		public Vector2 ReadVector2(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadVector2(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a 3D vector from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The 3D vector value read, or an empty value if invalid.</returns>
		public Vector3 ReadVector3(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadVector3(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Reads a QAngle (rotation vector) from a UserMessage.
		/// </summary>
		/// <param name="fieldName">Name of the field to read.</param>
		/// <param name="index">Index of the repeated field (use -1 for non-repeated fields).</param>
		/// <returns>The QAngle value read, or an empty value if invalid.</returns>
		public Vector3 ReadQAngle(string fieldName, int index)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbReadQAngle(Handle, fieldName, index);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a enum value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetEnum(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetEnum(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a enum value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetEnum(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetEnum(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 32-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetInt32(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetInt32(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a 32-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetInt32(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetInt32(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a 64-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetInt64(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetInt64(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a 64-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetInt64(string fieldName, long value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetInt64(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 32-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetUInt32(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetUInt32(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets an unsigned 32-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetUInt32(string fieldName, uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetUInt32(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets an unsigned 64-bit integer value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetUInt64(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetUInt64(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets an unsigned 64-bit integer value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetUInt64(string fieldName, ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetUInt64(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a bool value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetBool(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetBool(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a bool value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetBool(string fieldName, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetBool(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a float value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetFloat(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetFloat(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a float value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetFloat(string fieldName, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetFloat(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a double value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetDouble(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetDouble(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a double value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetDouble(string fieldName, double value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetDouble(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a string value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetString(string fieldName, ref string out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetString(Handle, fieldName, ref out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a string value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetString(string fieldName, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetString(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a color value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetColor(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetColor(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a color value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetColor(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetColor(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a Vector2 value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetVector2(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetVector2(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a Vector2 value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetVector2(string fieldName, Vector2 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetVector2(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a Vector3 value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetVector3(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetVector3(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a Vector3 value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetVector3(string fieldName, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetVector3(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a QAngle value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetQAngle(string fieldName, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetQAngle(Handle, fieldName, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a QAngle value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetQAngle(string fieldName, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetQAngle(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated enum value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedEnum(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedEnum(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated enum value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedEnum(string fieldName, int index, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedEnum(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a enum value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddEnum(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddEnum(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated int32_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedInt32(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedInt32(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated int32_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedInt32(string fieldName, int index, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedInt32(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a 32-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddInt32(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddInt32(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated int64_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedInt64(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedInt64(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated int64_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedInt64(string fieldName, int index, long value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedInt64(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a 64-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddInt64(string fieldName, long value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddInt64(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated uint32_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedUInt32(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedUInt32(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated uint32_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedUInt32(string fieldName, int index, uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedUInt32(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds an unsigned 32-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddUInt32(string fieldName, uint value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddUInt32(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated uint64_t value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedUInt64(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedUInt64(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated uint64_t value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedUInt64(string fieldName, int index, ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedUInt64(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds an unsigned 64-bit integer value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddUInt64(string fieldName, ulong value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddUInt64(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated bool value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedBool(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedBool(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated bool value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedBool(string fieldName, int index, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedBool(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a bool value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddBool(string fieldName, Bool8 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddBool(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated float value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedFloat(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedFloat(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated float value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedFloat(string fieldName, int index, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedFloat(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a float value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddFloat(string fieldName, float value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddFloat(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated double value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output value.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedDouble(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedDouble(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated double value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedDouble(string fieldName, int index, double value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedDouble(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a double value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddDouble(string fieldName, double value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddDouble(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated string value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output string.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedString(string fieldName, int index, ref string out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedString(Handle, fieldName, index, ref out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated string value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedString(string fieldName, int index, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedString(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a string value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddString(string fieldName, string value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddString(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated color value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output color.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedColor(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedColor(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated color value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedColor(string fieldName, int index, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedColor(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a color value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddColor(string fieldName, int value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddColor(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated Vector2 value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedVector2(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedVector2(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated Vector2 value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedVector2(string fieldName, int index, Vector2 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedVector2(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a Vector2 value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddVector2(string fieldName, Vector2 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddVector2(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated Vector3 value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedVector3(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedVector3(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated Vector3 value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedVector3(string fieldName, int index, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedVector3(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a Vector3 value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddVector3(string fieldName, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddVector3(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Gets a repeated QAngle value from a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="out_">The output vector2.</param>
		/// <returns>True if the field was successfully retrieved, false otherwise.</returns>
		public Bool8 GetRepeatedQAngle(string fieldName, int index, nint out_)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbGetRepeatedQAngle(Handle, fieldName, index, out_);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Sets a repeated QAngle value for a field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="index">The index of the repeated field.</param>
		/// <param name="value">The value to set.</param>
		/// <returns>True if the field was successfully set, false otherwise.</returns>
		public Bool8 SetRepeatedQAngle(string fieldName, int index, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbSetRepeatedQAngle(Handle, fieldName, index, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

		/// <summary>
		/// Adds a QAngle value to a repeated field in the UserMessage.
		/// </summary>
		/// <param name="fieldName">The name of the field.</param>
		/// <param name="value">The value to add.</param>
		/// <returns>True if the value was successfully added, false otherwise.</returns>
		public Bool8 AddQAngle(string fieldName, Vector3 value)
		{
			ObjectDisposedException.ThrowIf(!IsValid, this);
			bool success = false;
			DangerousAddRef(ref success);
			try
			{
				return s2sdk.PbAddQAngle(Handle, fieldName, value);
			}
			finally
			{
				if (success) DangerousRelease();
			}
		}

	}

#pragma warning restore CS0649
}
