// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace xml_service.Models
{
    /// <summary> An enumeration of blobs. </summary>
    public partial class ListBlobsResponse
    {
        public string ServiceEndpoint { get; set; }
        public string ContainerName { get; set; }
        public string Prefix { get; set; }
        public string Marker { get; set; }
        public int MaxResults { get; set; }
        public string Delimiter { get; set; }
        public Blobs Blobs { get; set; } = new Blobs();
        public string NextMarker { get; set; }
    }
}