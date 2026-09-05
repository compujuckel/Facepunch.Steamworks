using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal unsafe partial class ISteamMatchmakingServerFriendsResponse : SteamInterface
	{
		internal ISteamMatchmakingServerFriendsResponse( bool IsGameServer )
		{
			SetupInterface( IsGameServer );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerFriendsResponse_AddFriendToList", CallingConvention = Platform.CC)]
		private static extern void _AddFriendToList( IntPtr self, SteamId steamID, IntPtr pchName, [MarshalAs( UnmanagedType.U1 )] bool bCurrentlyConnected );
		
		#endregion
		internal void AddFriendToList( SteamId steamID, string pchName, [MarshalAs( UnmanagedType.U1 )] bool bCurrentlyConnected )
		{
			using var str__pchName = new Utf8StringToNative( pchName );
			_AddFriendToList( Self, steamID, str__pchName.Pointer, bCurrentlyConnected );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerFriendsResponse_FriendsFailedToRespond", CallingConvention = Platform.CC)]
		private static extern void _FriendsFailedToRespond( IntPtr self );
		
		#endregion
		internal void FriendsFailedToRespond()
		{
			_FriendsFailedToRespond( Self );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerFriendsResponse_FriendsRefreshComplete", CallingConvention = Platform.CC)]
		private static extern void _FriendsRefreshComplete( IntPtr self );
		
		#endregion
		internal void FriendsRefreshComplete()
		{
			_FriendsRefreshComplete( Self );
		}
		
	}
}
