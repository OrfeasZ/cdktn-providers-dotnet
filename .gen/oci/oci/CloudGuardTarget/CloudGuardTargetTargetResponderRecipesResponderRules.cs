using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules")]
    public class CloudGuardTargetTargetResponderRecipesResponderRules : oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRulesDetails\"}")]
        public oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRulesDetails Details
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rule_id CloudGuardTarget#responder_rule_id}.</summary>
        [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResponderRuleId
        {
            get;
            set;
        }
    }
}
