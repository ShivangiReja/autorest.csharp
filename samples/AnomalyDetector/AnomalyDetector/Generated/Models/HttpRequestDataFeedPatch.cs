// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AnomalyDetector.Models
{
    /// <summary> The HttpRequestDataFeedPatch. </summary>
    internal partial class HttpRequestDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of HttpRequestDataFeedPatch. </summary>
        internal HttpRequestDataFeedPatch()
        {
            DataSourceType = new DataSourceType("HttpRequestDataFeedPatch");
        }

        /// <summary> Initializes a new instance of HttpRequestDataFeedPatch. </summary>
        /// <param name="dataSourceType"> . </param>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="dataFeedDescription"> data feed description. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="timestampColumn"> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </param>
        /// <param name="startOffsetInSeconds"> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </param>
        /// <param name="maxConcurrency"> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </param>
        /// <param name="minRetryIntervalInSeconds"> the min retry interval for failed data ingestion tasks. </param>
        /// <param name="stopRetryAfterInSeconds"> stop retry data ingestion after the data slice first schedule time in seconds. </param>
        /// <param name="needRollup"> . </param>
        /// <param name="rollUpMethod"> . </param>
        /// <param name="rollUpColumns"> roll up columns. </param>
        /// <param name="allUpIdentification"> the identification value for the row of calculated all-up value. </param>
        /// <param name="fillMissingPointForAd"> . </param>
        /// <param name="fillMissingPointForAdValue"> the value of fill missing point for anomaly detection. </param>
        /// <param name="viewMode"> . </param>
        /// <param name="admins"> data feed administrator. </param>
        /// <param name="viewers"> data feed viewer. </param>
        /// <param name="status"> . </param>
        /// <param name="actionLinkTemplate"> action link for alert. </param>
        /// <param name="dataSourceParameter"> . </param>
        internal HttpRequestDataFeedPatch(DataSourceType dataSourceType, string dataFeedName, string dataFeedDescription, DateTimeOffset? dataStartFrom, string timestampColumn, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, NeedRollupEnum? needRollup, RollUpMethod? rollUpMethod, string rollUpColumns, string allUpIdentification, FillMissingPointType? fillMissingPointForAd, double? fillMissingPointForAdValue, ViewMode? viewMode, IReadOnlyList<string> admins, IReadOnlyList<string> viewers, EntityStatus? status, string actionLinkTemplate, HttpRequestParameter dataSourceParameter) : base(dataSourceType, dataFeedName, dataFeedDescription, dataStartFrom, timestampColumn, startOffsetInSeconds, maxConcurrency, minRetryIntervalInSeconds, stopRetryAfterInSeconds, needRollup, rollUpMethod, rollUpColumns, allUpIdentification, fillMissingPointForAd, fillMissingPointForAdValue, viewMode, admins, viewers, status, actionLinkTemplate)
        {
            DataSourceParameter = dataSourceParameter;
            DataSourceType = dataSourceType;
        }

        public HttpRequestParameter DataSourceParameter { get; }
    }
}
