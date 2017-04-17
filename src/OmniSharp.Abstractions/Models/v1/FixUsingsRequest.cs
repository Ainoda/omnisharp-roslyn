using OmniSharp.Mef;

﻿namespace OmniSharp.Models
{
    [OmniSharpEndpoint(OmniSharpEndpoints.FixUsings, typeof(FixUsingsRequest), typeof(FixUsingsResponse))]
    public class FixUsingsRequest : Request
    {
        public bool WantsTextChanges { get; set; }
        public bool ApplyTextChanges { get; set; } = true;
    }
}
