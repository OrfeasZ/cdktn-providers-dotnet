using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups")]
    public interface ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#compartment_id CloudGuardTarget#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#condition CloudGuardTarget#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipesDetectorRulesDetailsConditionGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#compartment_id CloudGuardTarget#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#condition CloudGuardTarget#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
