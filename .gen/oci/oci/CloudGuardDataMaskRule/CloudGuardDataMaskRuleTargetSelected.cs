using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataMaskRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDataMaskRule.CloudGuardDataMaskRuleTargetSelected")]
    public class CloudGuardDataMaskRuleTargetSelected : oci.CloudGuardDataMaskRule.ICloudGuardDataMaskRuleTargetSelected
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_mask_rule#kind CloudGuardDataMaskRule#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_mask_rule#values CloudGuardDataMaskRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
