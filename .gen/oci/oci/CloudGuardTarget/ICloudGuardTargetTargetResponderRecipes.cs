using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardTarget
{
    [JsiiInterface(nativeType: typeof(ICloudGuardTargetTargetResponderRecipes), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipes")]
    public interface ICloudGuardTargetTargetResponderRecipes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_recipe_id CloudGuardTarget#responder_recipe_id}.</summary>
        [JsiiProperty(name: "responderRecipeId", typeJson: "{\"primitive\":\"string\"}")]
        string ResponderRecipeId
        {
            get;
        }

        /// <summary>responder_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rules CloudGuardTarget#responder_rules}
        /// </remarks>
        [JsiiProperty(name: "responderRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResponderRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardTargetTargetResponderRecipes), fullyQualifiedName: "oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipes")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardTarget.ICloudGuardTargetTargetResponderRecipes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_recipe_id CloudGuardTarget#responder_recipe_id}.</summary>
            [JsiiProperty(name: "responderRecipeId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponderRecipeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>responder_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_target#responder_rules CloudGuardTarget#responder_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responderRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardTarget.CloudGuardTargetTargetResponderRecipesResponderRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResponderRules
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
