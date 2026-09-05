using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal unsafe partial class ISteamRemotePlay : SteamInterface
	{
		public const string Version = "STEAMREMOTEPLAY_INTERFACE_VERSION004";
		
		internal ISteamRemotePlay( bool IsGameServer )
		{
			SetupInterface( IsGameServer );
		}
		
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemotePlay_v004", CallingConvention = Platform.CC)]
		internal static extern IntPtr SteamAPI_SteamRemotePlay_v004();
		public override IntPtr GetUserInterfacePointer() => SteamAPI_SteamRemotePlay_v004();
		
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionCount", CallingConvention = Platform.CC)]
		private static extern uint _GetSessionCount( IntPtr self );
		
		#endregion
		internal uint GetSessionCount()
		{
			var returnValue = _GetSessionCount( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionID", CallingConvention = Platform.CC)]
		private static extern RemotePlaySessionID_t _GetSessionID( IntPtr self, int iSessionIndex );
		
		#endregion
		internal RemotePlaySessionID_t GetSessionID( int iSessionIndex )
		{
			var returnValue = _GetSessionID( Self, iSessionIndex );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BSessionRemotePlayTogether", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BSessionRemotePlayTogether( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal bool BSessionRemotePlayTogether( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _BSessionRemotePlayTogether( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionSteamID", CallingConvention = Platform.CC)]
		private static extern SteamId _GetSessionSteamID( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal SteamId GetSessionSteamID( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionSteamID( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionGuestID", CallingConvention = Platform.CC)]
		private static extern uint _GetSessionGuestID( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal uint GetSessionGuestID( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionGuestID( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSmallSessionAvatar", CallingConvention = Platform.CC)]
		private static extern int _GetSmallSessionAvatar( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal int GetSmallSessionAvatar( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSmallSessionAvatar( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetMediumSessionAvatar", CallingConvention = Platform.CC)]
		private static extern int _GetMediumSessionAvatar( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal int GetMediumSessionAvatar( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetMediumSessionAvatar( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetLargeSessionAvatar", CallingConvention = Platform.CC)]
		private static extern int _GetLargeSessionAvatar( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal int GetLargeSessionAvatar( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetLargeSessionAvatar( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientName", CallingConvention = Platform.CC)]
		private static extern Utf8StringPointer _GetSessionClientName( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal string GetSessionClientName( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionClientName( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientFormFactor", CallingConvention = Platform.CC)]
		private static extern SteamDeviceFormFactor _GetSessionClientFormFactor( IntPtr self, RemotePlaySessionID_t unSessionID );
		
		#endregion
		internal SteamDeviceFormFactor GetSessionClientFormFactor( RemotePlaySessionID_t unSessionID )
		{
			var returnValue = _GetSessionClientFormFactor( Self, unSessionID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BGetSessionClientResolution", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BGetSessionClientResolution( IntPtr self, RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY );
		
		#endregion
		internal bool BGetSessionClientResolution( RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY )
		{
			var returnValue = _BGetSessionClientResolution( Self, unSessionID, ref pnResolutionX, ref pnResolutionY );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_ShowRemotePlayTogetherUI", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _ShowRemotePlayTogetherUI( IntPtr self );
		
		#endregion
		internal bool ShowRemotePlayTogetherUI()
		{
			var returnValue = _ShowRemotePlayTogetherUI( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BSendRemotePlayTogetherInvite", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BSendRemotePlayTogetherInvite( IntPtr self, SteamId steamIDFriend );
		
		#endregion
		internal bool BSendRemotePlayTogetherInvite( SteamId steamIDFriend )
		{
			var returnValue = _BSendRemotePlayTogetherInvite( Self, steamIDFriend );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BEnableRemotePlayTogetherDirectInput", CallingConvention = Platform.CC)]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _BEnableRemotePlayTogetherDirectInput( IntPtr self );
		
		#endregion
		internal bool BEnableRemotePlayTogetherDirectInput()
		{
			var returnValue = _BEnableRemotePlayTogetherDirectInput( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_DisableRemotePlayTogetherDirectInput", CallingConvention = Platform.CC)]
		private static extern void _DisableRemotePlayTogetherDirectInput( IntPtr self );
		
		#endregion
		internal void DisableRemotePlayTogetherDirectInput()
		{
			_DisableRemotePlayTogetherDirectInput( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetInput", CallingConvention = Platform.CC)]
		private static extern uint _GetInput( IntPtr self, ref RemotePlayInput_t pInput, uint unMaxEvents );
		
		#endregion
		internal uint GetInput( ref RemotePlayInput_t pInput, uint unMaxEvents )
		{
			var returnValue = _GetInput( Self, ref pInput, unMaxEvents );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_SetMouseVisibility", CallingConvention = Platform.CC)]
		private static extern void _SetMouseVisibility( IntPtr self, RemotePlaySessionID_t unSessionID, [MarshalAs( UnmanagedType.U1 )] bool bVisible );
		
		#endregion
		internal void SetMouseVisibility( RemotePlaySessionID_t unSessionID, [MarshalAs( UnmanagedType.U1 )] bool bVisible )
		{
			_SetMouseVisibility( Self, unSessionID, bVisible );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_SetMousePosition", CallingConvention = Platform.CC)]
		private static extern void _SetMousePosition( IntPtr self, RemotePlaySessionID_t unSessionID, float flNormalizedX, float flNormalizedY );
		
		#endregion
		internal void SetMousePosition( RemotePlaySessionID_t unSessionID, float flNormalizedX, float flNormalizedY )
		{
			_SetMousePosition( Self, unSessionID, flNormalizedX, flNormalizedY );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_CreateMouseCursor", CallingConvention = Platform.CC)]
		private static extern RemotePlayCursorID_t _CreateMouseCursor( IntPtr self, int nWidth, int nHeight, int nHotX, int nHotY, IntPtr pBGRA, int nPitch );
		
		#endregion
		internal RemotePlayCursorID_t CreateMouseCursor( int nWidth, int nHeight, int nHotX, int nHotY, IntPtr pBGRA, int nPitch )
		{
			var returnValue = _CreateMouseCursor( Self, nWidth, nHeight, nHotX, nHotY, pBGRA, nPitch );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_SetMouseCursor", CallingConvention = Platform.CC)]
		private static extern void _SetMouseCursor( IntPtr self, RemotePlaySessionID_t unSessionID, RemotePlayCursorID_t unCursorID );
		
		#endregion
		internal void SetMouseCursor( RemotePlaySessionID_t unSessionID, RemotePlayCursorID_t unCursorID )
		{
			_SetMouseCursor( Self, unSessionID, unCursorID );
		}
		
	}
}
