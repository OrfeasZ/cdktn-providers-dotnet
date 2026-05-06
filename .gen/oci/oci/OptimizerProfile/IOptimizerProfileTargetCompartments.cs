using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    [JsiiInterface(nativeType: typeof(IOptimizerProfileTargetCompartments), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetCompartments")]
    public interface IOptimizerProfileTargetCompartments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#items OptimizerProfile#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOptimizerProfileTargetCompartments), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetCompartments")]
        internal sealed class _Proxy : DeputyBase, oci.OptimizerProfile.IOptimizerProfileTargetCompartments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#items OptimizerProfile#items}.</summary>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Items
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
