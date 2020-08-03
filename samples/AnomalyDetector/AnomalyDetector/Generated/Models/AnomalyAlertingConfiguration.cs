// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyAlertingConfiguration. </summary>
    public partial class AnomalyAlertingConfiguration
    {
        /// <summary> Initializes a new instance of AnomalyAlertingConfiguration. </summary>
        /// <param name="name"> Anomaly alerting configuration name. </param>
        /// <param name="crossMetricsOperator"> . </param>
        /// <param name="hookIds"> hook unique ids. </param>
        /// <param name="metricAlertingConfigurations"> Anomaly alerting configurations. </param>
        public AnomalyAlertingConfiguration(string name, AnomalyAlertingConfigurationLogicType crossMetricsOperator, IEnumerable<Guid> hookIds, IEnumerable<MetricAlertingConfiguration> metricAlertingConfigurations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (hookIds == null)
            {
                throw new ArgumentNullException(nameof(hookIds));
            }
            if (metricAlertingConfigurations == null)
            {
                throw new ArgumentNullException(nameof(metricAlertingConfigurations));
            }

            Name = name;
            CrossMetricsOperator = crossMetricsOperator;
            HookIds = hookIds.ToList();
            MetricAlertingConfigurations = metricAlertingConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of AnomalyAlertingConfiguration. </summary>
        /// <param name="anomalyAlertingConfigurationId"> Anomaly alerting configuration unique id. </param>
        /// <param name="name"> Anomaly alerting configuration name. </param>
        /// <param name="crossMetricsOperator"> . </param>
        /// <param name="hookIds"> hook unique ids. </param>
        /// <param name="metricAlertingConfigurations"> Anomaly alerting configurations. </param>
        internal AnomalyAlertingConfiguration(Guid? anomalyAlertingConfigurationId, string name, AnomalyAlertingConfigurationLogicType crossMetricsOperator, IList<Guid> hookIds, IList<MetricAlertingConfiguration> metricAlertingConfigurations)
        {
            AnomalyAlertingConfigurationId = anomalyAlertingConfigurationId;
            Name = name;
            CrossMetricsOperator = crossMetricsOperator;
            HookIds = hookIds ?? new List<Guid>();
            MetricAlertingConfigurations = metricAlertingConfigurations ?? new List<MetricAlertingConfiguration>();
        }

        /// <summary> Anomaly alerting configuration unique id. </summary>
        public Guid? AnomalyAlertingConfigurationId { get; }
        /// <summary> Anomaly alerting configuration name. </summary>
        public string Name { get; set; }
        public AnomalyAlertingConfigurationLogicType CrossMetricsOperator { get; set; }
        /// <summary> hook unique ids. </summary>
        public IList<Guid> HookIds { get; }
        /// <summary> Anomaly alerting configurations. </summary>
        public IList<MetricAlertingConfiguration> MetricAlertingConfigurations { get; }
    }
}
