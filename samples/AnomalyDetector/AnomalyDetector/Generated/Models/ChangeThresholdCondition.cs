// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The ChangeThresholdCondition. </summary>
    public partial class ChangeThresholdCondition
    {
        /// <summary> Initializes a new instance of ChangeThresholdCondition. </summary>
        /// <param name="changePercentage"> change percentage, value range : [0, +∞). </param>
        /// <param name="shiftPoint"> shift point, value range : [1, +∞). </param>
        /// <param name="withinRange">
        /// if the withinRange = true, detected data is abnormal when the value falls in the range, in this case anomalyDetectorDirection must be Both
        /// 
        /// if the withinRange = false, detected data is abnormal when the value falls out of the range.
        /// </param>
        /// <param name="anomalyDetectorDirection"> . </param>
        /// <param name="suppressCondition"> . </param>
        public ChangeThresholdCondition(double changePercentage, int shiftPoint, bool withinRange, AnomalyDetectorDirection anomalyDetectorDirection, SuppressCondition suppressCondition)
        {
            if (suppressCondition == null)
            {
                throw new ArgumentNullException(nameof(suppressCondition));
            }

            ChangePercentage = changePercentage;
            ShiftPoint = shiftPoint;
            WithinRange = withinRange;
            AnomalyDetectorDirection = anomalyDetectorDirection;
            SuppressCondition = suppressCondition;
        }

        /// <summary> change percentage, value range : [0, +∞). </summary>
        public double ChangePercentage { get; set; }
        /// <summary> shift point, value range : [1, +∞). </summary>
        public int ShiftPoint { get; set; }
        /// <summary>
        /// if the withinRange = true, detected data is abnormal when the value falls in the range, in this case anomalyDetectorDirection must be Both
        /// 
        /// if the withinRange = false, detected data is abnormal when the value falls out of the range.
        /// </summary>
        public bool WithinRange { get; set; }
        public AnomalyDetectorDirection AnomalyDetectorDirection { get; set; }
        public SuppressCondition SuppressCondition { get; set; }
    }
}
