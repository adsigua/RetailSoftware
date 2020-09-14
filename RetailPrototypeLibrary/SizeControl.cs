using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RetailPrototypeLibrary
{
    public static class SizeControl
    {
        const int maxClientWidth = 1902;
        const int maxClientHeight = 1049;
        const int minClientWidth = 1262;
        const int minClientHeight = 699;

        public static float[] ComputeScaleConstants(int minWidth, int maxWidth, int minVal, int maxVal, int currentWidth)
        {
            float[] newConstants = new float[2];
            newConstants[0] = (maxVal - minVal) / (maxWidth - minWidth);
            newConstants[1] = minVal - (newConstants[0] * minWidth);
            return newConstants;
        }

        /// <summary>
        /// Computes new value for control size using linear equation y = mx + b,
        /// where m is widthvalratio, x is current window width, and b is the computed
        /// value contant.
        /// <param name="minWidth"></param>
        /// <param name="minVal"></param>
        /// <param name="widthValRatio"></param>
        /// <param name="currentWidth"></param>
        /// <returns></returns>
        public static float GetSizeByWidth( int minSize, int maxSize,int currentWidth)
        {
            float widthValRatio = (float)((maxSize - minSize) / (float)(maxClientWidth - minClientWidth));
            float valConstant = minSize - (widthValRatio * minClientWidth);
            return (widthValRatio * currentWidth) + valConstant;
        }
        /// <summary>
        /// Get new size using y=mx+b;
        /// </summary>
        /// <param name="minWidth"></param>
        /// <param name="minVal"></param>
        /// <param name="widthValRatio"></param>
        /// <param name="currentWidth"></param>
        /// <returns></returns>
        public static Size GetIconSizeByWidth(int minSize, int maxSize, int currentWidth)
        {
            int newSize = (int)GetSizeByWidth(minSize, maxSize, currentWidth);
            return new Size(newSize, newSize);
        }
    }
}
