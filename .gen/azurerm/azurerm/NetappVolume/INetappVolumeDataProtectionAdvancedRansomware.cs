using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    [JsiiInterface(nativeType: typeof(INetappVolumeDataProtectionAdvancedRansomware), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionAdvancedRansomware")]
    public interface INetappVolumeDataProtectionAdvancedRansomware
    {
        /// <summary>Enable or disable the Advanced Ransomware Protection feature.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume#protection_enabled NetappVolume#protection_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "protectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ProtectionEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeDataProtectionAdvancedRansomware), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionAdvancedRansomware")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolume.INetappVolumeDataProtectionAdvancedRansomware
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enable or disable the Advanced Ransomware Protection feature.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume#protection_enabled NetappVolume#protection_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "protectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ProtectionEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
