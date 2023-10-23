﻿using NLayer.Core.Abstract;

namespace NLayer.Core.DTOs.FeatureWithUserDtos.BelongingProductFeatureDtos
{
    public class BelongingProductFeatureDto : BaseFeatureProductDto
    {
        public string? Instegram { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? Text1 { get; set; }
        public string? Text2 { get; set; }
        public int ProductId { get; set; }
    }
}
