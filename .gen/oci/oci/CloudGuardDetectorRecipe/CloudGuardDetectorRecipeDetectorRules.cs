using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDetectorRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRules")]
    public class CloudGuardDetectorRecipeDetectorRules : oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#details CloudGuardDetectorRecipe#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardDetectorRecipe.CloudGuardDetectorRecipeDetectorRulesDetails\"}")]
        public oci.CloudGuardDetectorRecipe.ICloudGuardDetectorRecipeDetectorRulesDetails Details
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_detector_recipe#detector_rule_id CloudGuardDetectorRecipe#detector_rule_id}.</summary>
        [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public string DetectorRuleId
        {
            get;
            set;
        }
    }
}
