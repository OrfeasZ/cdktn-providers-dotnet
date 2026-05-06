using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipes), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipes")]
    public interface ICloudGuardTargetTargetDetectorRecipes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_recipe_id CloudGuardTarget#detector_recipe_id}.</summary>
        [JsiiProperty(name: "detectorRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        string DetectorRecipeId
        {
            get;
        }

        /// <summary>detector_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rules CloudGuardTarget#detector_rules}
        /// </remarks>
        [JsiiProperty(name: "detectorRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DetectorRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetDetectorRecipes), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipes")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetDetectorRecipes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_recipe_id CloudGuardTarget#detector_recipe_id}.</summary>
            [JsiiProperty(name: "detectorRecipeId", typeJson: "{\"primitive\":\"string\"}")]
            public string DetectorRecipeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>detector_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#detector_rules CloudGuardTarget#detector_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "detectorRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetDetectorRecipesDetectorRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DetectorRules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
