// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
  using System;
  using System.Collections;
  using Oculus.Platform.Models;
  using System.Collections.Generic;
  using UnityEngine;

  public class CowatchViewerUpdate
  {
    /// List of viewer data of all cowatch participants.
    public readonly CowatchViewerList DataList;
    /// User ID of the user with updated viewer data.
    public readonly UInt64 Id;


    public CowatchViewerUpdate(IntPtr o)
    {
      DataList = new CowatchViewerList(CAPI.ovr_CowatchViewerUpdate_GetDataList(o));
      Id = CAPI.ovr_CowatchViewerUpdate_GetId(o);
    }
  }

}
