using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolume
{
    [JsiiInterface(nativeType: typeof(ICoreVolumeAutotunePolicies), fullyQualifiedName: "oci.coreVolume.CoreVolumeAutotunePolicies")]
    public interface ICoreVolumeAutotunePolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#autotune_type CoreVolume#autotune_type}.</summary>
        [JsiiProperty(name: "autotuneType", typeJson: "{\"primitive\":\"string\"}")]
        string AutotuneType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#max_vpus_per_gb CoreVolume#max_vpus_per_gb}.</summary>
        [JsiiProperty(name: "maxVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxVpusPerGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVolumeAutotunePolicies), fullyQualifiedName: "oci.coreVolume.CoreVolumeAutotunePolicies")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVolume.ICoreVolumeAutotunePolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#autotune_type CoreVolume#autotune_type}.</summary>
            [JsiiProperty(name: "autotuneType", typeJson: "{\"primitive\":\"string\"}")]
            public string AutotuneType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#max_vpus_per_gb CoreVolume#max_vpus_per_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxVpusPerGb
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
