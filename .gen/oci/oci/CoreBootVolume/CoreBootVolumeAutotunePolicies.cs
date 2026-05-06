using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreBootVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreBootVolume.CoreBootVolumeAutotunePolicies")]
    public class CoreBootVolumeAutotunePolicies : oci.CoreBootVolume.ICoreBootVolumeAutotunePolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#autotune_type CoreBootVolume#autotune_type}.</summary>
        [JsiiProperty(name: "autotuneType", typeJson: "{\"primitive\":\"string\"}")]
        public string AutotuneType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_boot_volume#max_vpus_per_gb CoreBootVolume#max_vpus_per_gb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxVpusPerGb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxVpusPerGb
        {
            get;
            set;
        }
    }
}
