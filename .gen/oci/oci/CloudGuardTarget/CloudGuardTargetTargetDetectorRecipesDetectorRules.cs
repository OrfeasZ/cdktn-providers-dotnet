using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules")]
    public class CloudGuardTargetTargetDetectorRecipesDetectorRules : oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails\"}")]
        public oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails Details
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rule_id CloudGuardTarget#detector_rule_id}.</summary>
        [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public string DetectorRuleId
        {
            get;
            set;
        }
    }
}
