﻿using SixLabors.ImageSharp;

namespace ImageSharp.Processing.AutoCrop.Models
{
    public class RenderInstructions
    {
        public Size Size { get; set; }
        public Rectangle Source { get; set; }
        public Rectangle Target { get; set; }
        public Point Translate { get; set; }
        public double Scale { get; set; }
    }
}
