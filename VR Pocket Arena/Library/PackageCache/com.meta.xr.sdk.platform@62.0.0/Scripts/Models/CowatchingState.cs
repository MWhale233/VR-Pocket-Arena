// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
  using System;
  using System.Collections;
  using Oculus.Platform.Models;
  using System.Collections.Generic;
  using UnityEngine;

  public class CowatchingState
  {
    /// Indicates if the current user is in a cowatching session.
    public readonly bool InSession;


    public CowatchingState(IntPtr o)
    {
      InSession = CAPI.ovr_CowatchingState_GetInSession(o);
    }
  }

}
