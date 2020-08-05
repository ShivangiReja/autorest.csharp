// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentEntities. </summary>
    public partial class DocumentEntities
    {
        /// <summary> Initializes a new instance of DocumentEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="entities"/> is null. </exception>
        internal DocumentEntities(string id, IEnumerable<Entity> entities)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            Id = id;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of DocumentEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal DocumentEntities(string id, IReadOnlyList<Entity> entities, DocumentStatistics statistics)
        {
            Id = id;
            Entities = entities;
            Statistics = statistics;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Recognized entities in the document. </summary>
        public IReadOnlyList<Entity> Entities { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
    }
}
