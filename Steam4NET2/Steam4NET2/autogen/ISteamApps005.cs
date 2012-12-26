// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamApps005VTable
	{
		public IntPtr BIsSubscribed0;
		public IntPtr BIsLowViolence1;
		public IntPtr BIsCybercafe2;
		public IntPtr BIsVACBanned3;
		public IntPtr GetCurrentGameLanguage4;
		public IntPtr GetAvailableGameLanguages5;
		public IntPtr BIsSubscribedApp6;
		public IntPtr BIsDlcInstalled7;
		public IntPtr GetEarliestPurchaseUnixTime8;
		public IntPtr BIsSubscribedFromFreeWeekend9;
		public IntPtr GetDLCCount10;
		public IntPtr BGetDLCDataByIndex11;
		public IntPtr InstallDLC12;
		public IntPtr UninstallDLC13;
		public IntPtr RequestAppProofOfPurchaseKey14;
		public IntPtr GetCurrentBetaName15;
		public IntPtr MarkContentCorrupt16;
		private IntPtr DTorISteamApps00517;
	};
	
	[InteropHelp.InterfaceVersion("STEAMAPPS_INTERFACE_VERSION005")]
	public class ISteamApps005 : InteropHelp.NativeWrapper<ISteamApps005VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsSubscribed( IntPtr thisptr );
		public bool BIsSubscribed(  ) 
		{
			return this.GetFunction<NativeBIsSubscribed>( this.Functions.BIsSubscribed0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsLowViolence( IntPtr thisptr );
		public bool BIsLowViolence(  ) 
		{
			return this.GetFunction<NativeBIsLowViolence>( this.Functions.BIsLowViolence1 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsCybercafe( IntPtr thisptr );
		public bool BIsCybercafe(  ) 
		{
			return this.GetFunction<NativeBIsCybercafe>( this.Functions.BIsCybercafe2 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsVACBanned( IntPtr thisptr );
		public bool BIsVACBanned(  ) 
		{
			return this.GetFunction<NativeBIsVACBanned>( this.Functions.BIsVACBanned3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetCurrentGameLanguage( IntPtr thisptr );
		public string GetCurrentGameLanguage(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetCurrentGameLanguage>( this.Functions.GetCurrentGameLanguage4 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetAvailableGameLanguages( IntPtr thisptr );
		public string GetAvailableGameLanguages(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetAvailableGameLanguages>( this.Functions.GetAvailableGameLanguages5 )( this.ObjectAddress ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsSubscribedAppU( IntPtr thisptr, UInt32 nAppID );
		public bool BIsSubscribedApp( UInt32 nAppID ) 
		{
			return this.GetFunction<NativeBIsSubscribedAppU>( this.Functions.BIsSubscribedApp6 )( this.ObjectAddress, nAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsDlcInstalledU( IntPtr thisptr, UInt32 nAppID );
		public bool BIsDlcInstalled( UInt32 nAppID ) 
		{
			return this.GetFunction<NativeBIsDlcInstalledU>( this.Functions.BIsDlcInstalled7 )( this.ObjectAddress, nAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetEarliestPurchaseUnixTimeU( IntPtr thisptr, UInt32 nAppID );
		public UInt32 GetEarliestPurchaseUnixTime( UInt32 nAppID ) 
		{
			return this.GetFunction<NativeGetEarliestPurchaseUnixTimeU>( this.Functions.GetEarliestPurchaseUnixTime8 )( this.ObjectAddress, nAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsSubscribedFromFreeWeekend( IntPtr thisptr );
		public bool BIsSubscribedFromFreeWeekend(  ) 
		{
			return this.GetFunction<NativeBIsSubscribedFromFreeWeekend>( this.Functions.BIsSubscribedFromFreeWeekend9 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetDLCCount( IntPtr thisptr );
		public Int32 GetDLCCount(  ) 
		{
			return this.GetFunction<NativeGetDLCCount>( this.Functions.GetDLCCount10 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetDLCDataByIndexIUBSI( IntPtr thisptr, Int32 iDLC, ref UInt32 pAppID, ref bool pbAvailable, StringBuilder pchName, Int32 cchNameBufferSize );
		public bool BGetDLCDataByIndex( Int32 iDLC, ref UInt32 pAppID, ref bool pbAvailable, StringBuilder pchName ) 
		{
			return this.GetFunction<NativeBGetDLCDataByIndexIUBSI>( this.Functions.BGetDLCDataByIndex11 )( this.ObjectAddress, iDLC, ref pAppID, ref pbAvailable, pchName, (Int32) pchName.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeInstallDLCU( IntPtr thisptr, UInt32 nAppID );
		public void InstallDLC( UInt32 nAppID ) 
		{
			this.GetFunction<NativeInstallDLCU>( this.Functions.InstallDLC12 )( this.ObjectAddress, nAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUninstallDLCU( IntPtr thisptr, UInt32 nAppID );
		public void UninstallDLC( UInt32 nAppID ) 
		{
			this.GetFunction<NativeUninstallDLCU>( this.Functions.UninstallDLC13 )( this.ObjectAddress, nAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestAppProofOfPurchaseKeyU( IntPtr thisptr, UInt32 nDLCAppID );
		public void RequestAppProofOfPurchaseKey( UInt32 nDLCAppID ) 
		{
			this.GetFunction<NativeRequestAppProofOfPurchaseKeyU>( this.Functions.RequestAppProofOfPurchaseKey14 )( this.ObjectAddress, nDLCAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCurrentBetaNameSI( IntPtr thisptr, StringBuilder pchName, Int32 cchNameBufferSize );
		public bool GetCurrentBetaName( StringBuilder pchName ) 
		{
			return this.GetFunction<NativeGetCurrentBetaNameSI>( this.Functions.GetCurrentBetaName15 )( this.ObjectAddress, pchName, (Int32) pchName.Capacity ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeMarkContentCorruptB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bCorrupt );
		public bool MarkContentCorrupt( bool bCorrupt ) 
		{
			return this.GetFunction<NativeMarkContentCorruptB>( this.Functions.MarkContentCorrupt16 )( this.ObjectAddress, bCorrupt ); 
		}
		
	};
}