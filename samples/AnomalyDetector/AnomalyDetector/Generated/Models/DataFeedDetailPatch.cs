// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AnomalyDetector.Models
{
    /// <summary> The DataFeedDetailPatch. </summary>
    internal partial class DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of DataFeedDetailPatch. </summary>
        internal DataFeedDetailPatch()
        {
        }

        /// <summary> Initializes a new instance of DataFeedDetailPatch. </summary>
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
        internal DataFeedDetailPatch(DataSourceType dataSourceType, string dataFeedName, string dataFeedDescription, DateTimeOffset? dataStartFrom, string timestampColumn, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, NeedRollupEnum? needRollup, RollUpMethod? rollUpMethod, string rollUpColumns, string allUpIdentification, FillMissingPointType? fillMissingPointForAd, double? fillMissingPointForAdValue, ViewMode? viewMode, IReadOnlyList<string> admins, IReadOnlyList<string> viewers, EntityStatus? status, string actionLinkTemplate)
        {
            DataSourceType = dataSourceType;
            DataFeedName = dataFeedName;
            DataFeedDescription = dataFeedDescription;
            DataStartFrom = dataStartFrom;
            TimestampColumn = timestampColumn;
            StartOffsetInSeconds = startOffsetInSeconds;
            MaxConcurrency = maxConcurrency;
            MinRetryIntervalInSeconds = minRetryIntervalInSeconds;
            StopRetryAfterInSeconds = stopRetryAfterInSeconds;
            NeedRollup = needRollup;
            RollUpMethod = rollUpMethod;
            RollUpColumns = rollUpColumns;
            AllUpIdentification = allUpIdentification;
            FillMissingPointForAd = fillMissingPointForAd;
            FillMissingPointForAdValue = fillMissingPointForAdValue;
            ViewMode = viewMode;
            Admins = admins;
            Viewers = viewers;
            Status = status;
            ActionLinkTemplate = actionLinkTemplate;
        }

        internal DataSourceType DataSourceType { get; set; }
        /// <summary> data feed name. </summary>
        public string DataFeedName { get; }
        /// <summary> data feed description. </summary>
        public string DataFeedDescription { get; }
        /// <summary> ingestion start time. </summary>
        public DateTimeOffset? DataStartFrom { get; }
        /// <summary> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </summary>
        public string TimestampColumn { get; }
        /// <summary> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </summary>
        public long? StartOffsetInSeconds { get; }
        /// <summary> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </summary>
        public int? MaxConcurrency { get; }
        /// <summary> the min retry interval for failed data ingestion tasks. </summary>
        public long? MinRetryIntervalInSeconds { get; }
        /// <summary> stop retry data ingestion after the data slice first schedule time in seconds. </summary>
        public long? StopRetryAfterInSeconds { get; }
        public NeedRollupEnum? NeedRollup { get; }
        public RollUpMethod? RollUpMethod { get; }
        /// <summary> roll up columns. </summary>
        public string RollUpColumns { get; }
        /// <summary> the identification value for the row of calculated all-up value. </summary>
        public string AllUpIdentification { get; }
        public FillMissingPointType? FillMissingPointForAd { get; }
        /// <summary> the value of fill missing point for anomaly detection. </summary>
        public double? FillMissingPointForAdValue { get; }
        public ViewMode? ViewMode { get; }
        /// <summary> data feed administrator. </summary>
        public IReadOnlyList<string> Admins { get; }
        /// <summary> data feed viewer. </summary>
        public IReadOnlyList<string> Viewers { get; }
        public EntityStatus? Status { get; }
        /// <summary> action link for alert. </summary>
        public string ActionLinkTemplate { get; }
    }
}
