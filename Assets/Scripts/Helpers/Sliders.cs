using UnityEngine;
using UnityEngine.UI;

namespace Helpers
{
    public static class Sliders
    {
        public static bool Drain(this Slider bar, uint value)
        {
            bar.value = Mathf.Max(bar.value - value, bar.minValue);
            return bar.value <= bar.minValue;
        }

        public static bool Fill(this Slider bar, uint value)
        {
            bar.value = Mathf.Min(bar.value + value, bar.maxValue);
            return bar.value >= bar.maxValue;
        }
    }
}