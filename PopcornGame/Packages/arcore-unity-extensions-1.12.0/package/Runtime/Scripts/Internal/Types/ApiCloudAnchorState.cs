﻿//-----------------------------------------------------------------------
// <copyright file="ApiCloudAnchorState.cs" company="Google">
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
    // Internal states for Cloud Anchors.
    internal enum ApiCloudAnchorState
    {
        None = 0,
        TaskInProgress = 1,
        Success = 2,
        ErrorInternal = -1,
        ErrorNotAuthorized = -2,
        ErrorResourceExhausted = -4,
        ErrorHostingDatasetProcessingFailed = -5,
        ErrorResolvingCloudIdNotFound = -6,
        ErrorResolvingSDKTooOld = -8,
        ErrorResolvingSDKTooNew = -9,
        ErrorHostingServiceUnavailable = -10,
    }
}
