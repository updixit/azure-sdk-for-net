// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents an metric aggregation.
    /// </summary>
    public partial class StorageMetricAggregation
    {
        private StorageMetricLevel _level;
        
        /// <summary>
        /// Optional. Gets or sets the level of metrics to collect.
        /// </summary>
        public StorageMetricLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private TimeSpan _retention;
        
        /// <summary>
        /// Optional. Gets or sets the retention period. Indicates the how long
        /// metrics data should be retained (must be an even number of days).
        /// All data older than this value will be deleted. The minimum number
        /// of days is 1; the largest value is 365 (one year).
        /// </summary>
        public TimeSpan Retention
        {
            get { return this._retention; }
            set { this._retention = value; }
        }
        
        private TimeSpan _scheduledTransferPeriod;
        
        /// <summary>
        /// Optional. Gets or sets the time grain (aggregation interval or
        /// frequency). Must be either one minute or one hour.
        /// </summary>
        public TimeSpan ScheduledTransferPeriod
        {
            get { return this._scheduledTransferPeriod; }
            set { this._scheduledTransferPeriod = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageMetricAggregation class.
        /// </summary>
        public StorageMetricAggregation()
        {
        }
    }
}
