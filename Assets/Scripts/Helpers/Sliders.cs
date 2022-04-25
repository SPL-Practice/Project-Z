using UnityEngine;
using UnityEngine.UI;

namespace Helpers
{
    public static class Sliders
    {
        public static bool Drain(this Slider bar, int value)
        {
            bar.value = Mathf.Clamp(bar.value - value, bar.minValue, bar.maxValue);
            return bar.value <= bar.minValue;
        }

        public static void Fill(this Slider bar, int value)
        {
            bar.value = Mathf.Clamp(bar.value + value, bar.minValue, bar.maxValue);
        }
    }
}