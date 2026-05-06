using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetResponderRecipesResponderRules), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules")]
    public interface ICloudGuardTargetTargetResponderRecipesResponderRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRulesDetails\"}")]
        oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRulesDetails Details
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rule_id CloudGuardTarget#responder_rule_id}.</summary>
        [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
        string ResponderRuleId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetResponderRecipesResponderRules), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
            /// </remarks>
            [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRulesDetails\"}")]
            public oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRulesDetails Details
            {
                get => GetInstanceProperty<oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipesResponderRulesDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rule_id CloudGuardTarget#responder_rule_id}.</summary>
            [JsiiProperty(name: "responderRuleId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponderRuleId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
