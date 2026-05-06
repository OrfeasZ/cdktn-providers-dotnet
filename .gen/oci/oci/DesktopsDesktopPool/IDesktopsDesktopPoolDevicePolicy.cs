using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolDevicePolicy), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolDevicePolicy")]
    public interface IDesktopsDesktopPoolDevicePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#audio_mode DesktopsDesktopPool#audio_mode}.</summary>
        [JsiiProperty(name: "audioMode", typeJson: "{\"primitive\":\"string\"}")]
        string AudioMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#cdm_mode DesktopsDesktopPool#cdm_mode}.</summary>
        [JsiiProperty(name: "cdmMode", typeJson: "{\"primitive\":\"string\"}")]
        string CdmMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#clipboard_mode DesktopsDesktopPool#clipboard_mode}.</summary>
        [JsiiProperty(name: "clipboardMode", typeJson: "{\"primitive\":\"string\"}")]
        string ClipboardMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_display_enabled DesktopsDesktopPool#is_display_enabled}.</summary>
        [JsiiProperty(name: "isDisplayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsDisplayEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_keyboard_enabled DesktopsDesktopPool#is_keyboard_enabled}.</summary>
        [JsiiProperty(name: "isKeyboardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsKeyboardEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_pointer_enabled DesktopsDesktopPool#is_pointer_enabled}.</summary>
        [JsiiProperty(name: "isPointerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsPointerEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_printing_enabled DesktopsDesktopPool#is_printing_enabled}.</summary>
        [JsiiProperty(name: "isPrintingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsPrintingEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolDevicePolicy), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolDevicePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolDevicePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#audio_mode DesktopsDesktopPool#audio_mode}.</summary>
            [JsiiProperty(name: "audioMode", typeJson: "{\"primitive\":\"string\"}")]
            public string AudioMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#cdm_mode DesktopsDesktopPool#cdm_mode}.</summary>
            [JsiiProperty(name: "cdmMode", typeJson: "{\"primitive\":\"string\"}")]
            public string CdmMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#clipboard_mode DesktopsDesktopPool#clipboard_mode}.</summary>
            [JsiiProperty(name: "clipboardMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ClipboardMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_display_enabled DesktopsDesktopPool#is_display_enabled}.</summary>
            [JsiiProperty(name: "isDisplayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsDisplayEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_keyboard_enabled DesktopsDesktopPool#is_keyboard_enabled}.</summary>
            [JsiiProperty(name: "isKeyboardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsKeyboardEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_pointer_enabled DesktopsDesktopPool#is_pointer_enabled}.</summary>
            [JsiiProperty(name: "isPointerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsPointerEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#is_printing_enabled DesktopsDesktopPool#is_printing_enabled}.</summary>
            [JsiiProperty(name: "isPrintingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsPrintingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
