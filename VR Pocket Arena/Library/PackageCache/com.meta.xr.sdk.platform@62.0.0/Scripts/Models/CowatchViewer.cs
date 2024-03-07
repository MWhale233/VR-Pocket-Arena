// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
  using System;
  using System.Collections;
  using Oculus.Platform.Models;
  using System.Collections.Generic;
  using UnityEngine;

  public class CowatchViewer
  {
    /// Viewer data set by this cowatching viewer.
    public readonly string Data;
    /// User ID of the owner of data.
    public readonly UInt64 Id;


    public CowatchViewer(IntPtr o)
    {
      Data = CAPI.ovr_CowatchViewer_GetData(o);
      Id = CAPI.ovr_CowatchViewer_GetId(o);
    }
  }

  public class CowatchViewerList : DeserializableList<CowatchViewer> {
    public CowatchViewerList(IntPtr a) {
      var count = (int)CAPI.ovr_CowatchViewerArray_GetSize(a);
      _Data = new List<CowatchViewer>(count);
      for (int i = 0; i < count; i++) {
        _Data.Add(new CowatchViewer(CAPI.ovr_CowatchViewerArray_GetElement(a, (UIntPtr)i)));
      }

      _NextUrl = CAPI.ovr_CowatchViewerArray_GetNextUrl(a);
    }

  }
}
