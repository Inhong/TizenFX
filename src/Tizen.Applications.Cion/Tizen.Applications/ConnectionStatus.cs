﻿/*
 * Copyright (c) 2021 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Applications
{
    /// <summary>
    /// Enumeration for connection status.
    /// </summary>
    /// <since_tizen> 9 </since_tizen>
    public enum ConnectionStatus
    {
        /// <summary>
        /// The connection request is accepted.
        /// </summary>
        OK,
        /// <summary>
        /// The connection request is rejected.
        /// </summary>
        Rejected,
        /// <summary>
        /// The error occurred while the connection request is in-progress.
        /// </summary>
        Error,
    }
}
