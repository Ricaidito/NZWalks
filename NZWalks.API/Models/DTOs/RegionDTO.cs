﻿namespace NZWalks.API.Models.DTOs
{
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
