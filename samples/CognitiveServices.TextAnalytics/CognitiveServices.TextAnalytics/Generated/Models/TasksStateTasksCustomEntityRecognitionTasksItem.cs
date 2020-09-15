// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksCustomEntityRecognitionTasksItem. </summary>
    public partial class TasksStateTasksCustomEntityRecognitionTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksCustomEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksCustomEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }

        /// <summary> Initializes a new instance of TasksStateTasksCustomEntityRecognitionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal TasksStateTasksCustomEntityRecognitionTasksItem(DateTimeOffset lastUpdateDateTime, string name, State status, CustomEntitiesResult results) : base(lastUpdateDateTime, name, status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Results = results;
        }

        public CustomEntitiesResult Results { get; }
    }
}
