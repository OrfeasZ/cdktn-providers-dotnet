using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    [JsiiInterface(nativeType: typeof(IOptimizerProfileTargetTags), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetTags")]
    public interface IOptimizerProfileTargetTags
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#items OptimizerProfile#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetTagsItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOptimizerProfileTargetTags), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetTags")]
        internal sealed class _Proxy : DeputyBase, oci.OptimizerProfile.IOptimizerProfileTargetTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#items OptimizerProfile#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.optimizerProfile.OptimizerProfileTargetTagsItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
