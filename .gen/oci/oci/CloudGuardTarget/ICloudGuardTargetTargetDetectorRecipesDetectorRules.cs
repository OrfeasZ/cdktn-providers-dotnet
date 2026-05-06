using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRules), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules")]
    public interface ICloudGuardTargetTargetDetectorRecipesDetectorRules
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails\"}")]
        oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails Details
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rule_id CloudGuardTarget#detector_rule_id}.</summary>
        [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
        string DetectorRuleId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRules), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#details CloudGuardTarget#details}
            /// </remarks>
            [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails\"}")]
            public oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails Details
            {
                get => GetInstanceProperty<oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rule_id CloudGuardTarget#detector_rule_id}.</summary>
            [JsiiProperty(name: "detectorRuleId", typeJson: "{\"primitive\":\"string\"}")]
            public string DetectorRuleId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
