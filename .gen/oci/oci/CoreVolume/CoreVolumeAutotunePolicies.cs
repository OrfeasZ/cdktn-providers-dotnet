using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVolume.CoreVolumeAutotunePolicies")]
    public class CoreVolumeAutotunePolicies : oci.CoreVolume.ICoreVolumeAutotunePolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#autotune_type CoreVolume#autotune_type}.</summary>
        [JsiiProperty(name: "autotuneType", typeJson: "{\"primitive\":\"string\"}")]
        public string AutotuneType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_volume#max_vpus_per_gb CoreVolume#max_vpus_per_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxVpusPerGb
        {
            get;
            set;
        }
    }
}
