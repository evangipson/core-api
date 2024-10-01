using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Domain.Constants
{
    public static class ColorConstants
    {
        public static readonly Color Red = new()
        {
            Name = "Red",
            Hex = "#ff0000",
            RGB = [255, 0, 0]
        };

        public static readonly Color Orange = new()
        {
            Name = "Orange",
            Hex = "#ffa500",
            RGB = [255, 165, 0]
        };

        public static readonly Color Yellow = new()
        {
            Name = "Yellow",
            Hex = "#ffff00",
            RGB = [255, 255, 0]
        };

        public static readonly Color Blue = new()
        {
            Name = "Blue",
            Hex = "#0000ff",
            RGB = [0, 0, 255]
        };

        public static readonly Color Indigo = new()
        {
            Name = "Indigo",
            Hex = "#4b0082",
            RGB = [75, 0, 130]
        };

        public static readonly Color Violet = new()
        {
            Name = "Violet",
            Hex = "#9400d3",
            RGB = [148, 0, 211]
        };
    }
}
