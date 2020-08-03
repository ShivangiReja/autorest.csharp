// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The CommentFeedback. </summary>
    internal partial class CommentFeedback : MetricFeedback
    {
        /// <summary> Initializes a new instance of CommentFeedback. </summary>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="value"> . </param>
        internal CommentFeedback(Guid metricId, CommentFeedbackValue value) : base(metricId)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            FeedbackType = new FeedbackType("CommentFeedback");
        }

        /// <summary> Initializes a new instance of CommentFeedback. </summary>
        /// <param name="feedbackType"> . </param>
        /// <param name="feedbackId"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="startTime"> the start timestamp of feedback timerange. </param>
        /// <param name="endTime"> the end timestamp of feedback timerange, when equals to startTime means only one timestamp. </param>
        /// <param name="value"> . </param>
        internal CommentFeedback(FeedbackType feedbackType, Guid? feedbackId, DateTimeOffset? createdTime, string userPrincipal, Guid metricId, FeedbackDimensionFilter dimensionFilter, DateTimeOffset? startTime, DateTimeOffset? endTime, CommentFeedbackValue value) : base(feedbackType, feedbackId, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            StartTime = startTime;
            EndTime = endTime;
            Value = value;
            FeedbackType = feedbackType;
        }

        /// <summary> the start timestamp of feedback timerange. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> the end timestamp of feedback timerange, when equals to startTime means only one timestamp. </summary>
        public DateTimeOffset? EndTime { get; }
        public CommentFeedbackValue Value { get; }
    }
}
