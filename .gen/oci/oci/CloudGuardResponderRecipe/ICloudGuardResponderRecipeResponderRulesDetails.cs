using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardResponderRecipe
{
    [JsiiInterface(nativeType: typeof(ICloudGuardResponderRecipeResponderRulesDetails), fullyQualifiedName: "oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRulesDetails")]
    public interface ICloudGuardResponderRecipeResponderRulesDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#is_enabled CloudGuardResponderRecipe#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardResponderRecipeResponderRulesDetails), fullyQualifiedName: "oci.cloudGuardResponderRecipe.CloudGuardResponderRecipeResponderRulesDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardResponderRecipe.ICloudGuardResponderRecipeResponderRulesDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_responder_recipe#is_enabled CloudGuardResponderRecipe#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
