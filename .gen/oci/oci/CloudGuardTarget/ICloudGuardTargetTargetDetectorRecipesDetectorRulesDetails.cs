using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails")]
    public interface ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails
    {
        /// <summary>condition_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#condition_groups CloudGuardTarget#condition_groups}
        /// </remarks>
        [JsiiProperty(name: "conditionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConditionGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#condition_groups CloudGuardTarget#condition_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConditionGroups
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
