using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardResponderRecipe
{
    [JsiiInterface(nativeType: typeof(ICloudGuardResponderRecipeResponderRules), fullyQualifiedName: "oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRules")]
    public interface ICloudGuardResponderRecipeResponderRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#details CloudGuardResponderRecipe#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRulesDetails\"}")]
        oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRulesDetails Details
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#responder_rule_id CloudGuardResponderRecipe#responder_rule_id}.</summary>
        [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
        string ResponderRuleId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#compartment_id CloudGuardResponderRecipe#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardResponderRecipeResponderRules), fullyQualifiedName: "oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRules")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#details CloudGuardResponderRecipe#details}
            /// </remarks>
            [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRulesDetails\"}")]
            public oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRulesDetails Details
            {
                get => GetInstanceProperty<oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRulesDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#responder_rule_id CloudGuardResponderRecipe#responder_rule_id}.</summary>
            [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponderRuleId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#compartment_id CloudGuardResponderRecipe#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
