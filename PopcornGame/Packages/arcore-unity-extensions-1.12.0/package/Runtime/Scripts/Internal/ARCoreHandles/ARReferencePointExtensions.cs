﻿//-----------------------------------------------------------------------
// <copyright file="ARReferencePointExtensions.cs" company="Google">
//
// Copyright 2019 Google LLC All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace Google.XR.ARCoreExtensions.Internal
{
    using System;
    using System.Runtime.InteropServices;
    using UnityEngine.XR.ARFoundation;

    // Internal interface for ARReferencePoint native pointers.
    internal static class ARReferencePointExtensions
    {
        public static IntPtr AnchorHandle(this ARReferencePoint referencePoint)
        {
            NativePointerStruct info = (NativePointerStruct)
                Marshal.PtrToStructure(
                    referencePoint.nativePtr,
                    typeof(NativePointerStruct));

            return info.AnchorHandle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativePointerStruct
        {
            public int Version;
            public IntPtr AnchorHandle;
        }
    }
}
