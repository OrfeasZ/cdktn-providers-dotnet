using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummary")]
    public class BdsBdsInstanceBdsClusterVersionSummary : oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#bds_version BdsBdsInstance#bds_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bdsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BdsVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/bds_bds_instance#odh_version BdsBdsInstance#odh_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "odhVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OdhVersion
        {
            get;
            set;
        }
    }
}
