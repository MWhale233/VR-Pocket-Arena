// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform
{

  public enum InitConfigOptions : uint
  {
    /// Disables the initialization of the WebRTC networking stack, when you don't
    /// need to use any of the ovr_Voip_* or ovr_Net_* functions.
    DisableP2pNetworking = 0x1CDE5DDE,

    /// Enables the initialization of cowatching stack to use ovr_Cowatching_*
    /// functions.
    EnableCowatching = 0x7DD1C46E,

  }

}
