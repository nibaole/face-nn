// #if UNITY_EDITOR
using System;
using System.Diagnostics;
using UnityEngine;
namespace CFEngine
{

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class PostProcessAttribute : Attribute
    {
        public readonly string menuItem;
        public readonly bool isVirtualEffect;
        internal PostProcessAttribute(Type renderer, string menuItem, bool isVirtualEffect = false)
        {
            this.menuItem = menuItem;
            this.isVirtualEffect = isVirtualEffect;
        }
    }
    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFDisplayNameAttribute : Attribute
    {
        public readonly string displayName;

        public CFDisplayNameAttribute(string displayName)
        {
            this.displayName = displayName;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFMaxAttribute : Attribute
    {
        public readonly float max;

        public CFMaxAttribute(float max)
        {
            this.max = max;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFMinAttribute : Attribute
    {
        public readonly float min;

        public CFMinAttribute(float min)
        {
            this.min = min;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFMinMaxAttribute : Attribute
    {
        public readonly float min;
        public readonly float max;

        public CFMinMaxAttribute(float min, float max)
        {
            this.min = min;
            this.max = max;
        }
    }
    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFTrackballAttribute : Attribute
    {
        public enum Mode
        {
            None,
            Lift,
            Gamma,
            Gain
        }

        public readonly Mode mode;

        public CFTrackballAttribute(Mode mode)
        {
            this.mode = mode;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CFTooltipAttribute : PropertyAttribute
    {
        //
        // ժҪ:
        //     ///
        //     The tooltip text.
        //     ///
        public readonly string tooltip;
        //
        // ժҪ:
        //     ///
        //     Specify a tooltip for a field.
        //     ///
        //
        // ����:
        //   tooltip:
        //     The tooltip text.
        public CFTooltipAttribute(string tooltip)
        {
            this.tooltip = tooltip;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CFRangeAttribute : PropertyAttribute
    {
        public readonly float min;
        public readonly float max;

        //
        //     ///
        //     Attribute used to make a float or int variable in a script be restricted to a
        //     specific range.
        //     ///
        //
        //   min:
        //     The minimum allowed value.
        //
        //   max:
        //     The maximum allowed value.
        public CFRangeAttribute(float min, float max)
        {
            this.min = min;
            this.max = max;
        }
    }


    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CFResPathAttribute : PropertyAttribute
    {
        public readonly Type type;
        public readonly string buttonName;
        public readonly string buttonName2;
        public readonly string buttonName3;
        public CFResPathAttribute(Type type, string buttonName, string buttonName2, string buttonName3)
        {
            this.type = type;
            this.buttonName = buttonName;
            this.buttonName2 = buttonName2;
            this.buttonName3 = buttonName3;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFColorUsageAttribute : PropertyAttribute
    {
        //
        // ժҪ:
        //     ///
        //     If false then the alpha bar is hidden in the ColorField and the alpha value is
        //     not shown in the Color Picker.
        //     ///
        public readonly bool showAlpha;
        //
        // ժҪ:
        //     ///
        //     If set to true the Color is treated as a HDR color.
        //     ///
        public readonly bool hdr;
        //
        // ժҪ:
        //     ///
        //     Minimum allowed HDR color component value when using the Color Picker.
        //     ///
        public readonly float minBrightness;
        //
        // ժҪ:
        //     ///
        //     Maximum allowed HDR color component value when using the HDR Color Picker.
        //     ///
        public readonly float maxBrightness;
        //
        // ժҪ:
        //     ///
        //     Minimum exposure value allowed in the HDR Color Picker.
        //     ///
        public readonly float minExposureValue;
        //
        // ժҪ:
        //     ///
        //     Maximum exposure value allowed in the HDR Color Picker.
        //     ///
        public readonly float maxExposureValue;

        //
        // ժҪ:
        //     ///
        //     Attribute for Color fields. Used for configuring the GUI for the color.
        //     ///
        //
        // ����:
        //   showAlpha:
        //     If false then the alpha channel info is hidden both in the ColorField and in
        //     the Color Picker.
        //
        //   hdr:
        //     Set to true if the color should be treated as a HDR color (default value: false).
        //
        //   minBrightness:
        //     Minimum allowed HDR color component value when using the HDR Color Picker (default
        //     value: 0).
        //
        //   maxBrightness:
        //     Maximum allowed HDR color component value when using the HDR Color Picker (default
        //     value: 8).
        //
        //   minExposureValue:
        //     Minimum exposure value allowed in the HDR Color Picker (default value: 1/8 =
        //     0.125).
        //
        //   maxExposureValue:
        //     Maximum exposure value allowed in the HDR Color Picker (default value: 3).
        public CFColorUsageAttribute(bool showAlpha)
        {
            this.showAlpha = showAlpha;
        }

        //
        // ժҪ:
        //     ///
        //     Attribute for Color fields. Used for configuring the GUI for the color.
        //     ///
        //
        // ����:
        //   showAlpha:
        //     If false then the alpha channel info is hidden both in the ColorField and in
        //     the Color Picker.
        //
        //   hdr:
        //     Set to true if the color should be treated as a HDR color (default value: false).
        //
        //   minBrightness:
        //     Minimum allowed HDR color component value when using the HDR Color Picker (default
        //     value: 0).
        //
        //   maxBrightness:
        //     Maximum allowed HDR color component value when using the HDR Color Picker (default
        //     value: 8).
        //
        //   minExposureValue:
        //     Minimum exposure value allowed in the HDR Color Picker (default value: 1/8 =
        //     0.125).
        //
        //   maxExposureValue:
        //     Maximum exposure value allowed in the HDR Color Picker (default value: 3).
        public CFColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue)
        {
            this.showAlpha = showAlpha;

            this.hdr = showAlpha;

            this.minBrightness = minBrightness;

            this.maxBrightness = maxBrightness;

            this.minExposureValue = minExposureValue;

            this.maxExposureValue = maxExposureValue;
        }
    }

    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CFNoSerializedAttribute : Attribute
    {
        internal CFNoSerializedAttribute()
        {
        }
    }
}
// #endif