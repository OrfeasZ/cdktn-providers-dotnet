using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardResponderRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRules")]
    public class CloudGuardResponderRecipeResponderRules : oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#details CloudGuardResponderRecipe#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRulesDetails\"}")]
        public oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRulesDetails Details
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#responder_rule_id CloudGuardResponderRecipe#responder_rule_id}.</summary>
        [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResponderRuleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#compartment_id CloudGuardResponderRecipe#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }
    }
}
