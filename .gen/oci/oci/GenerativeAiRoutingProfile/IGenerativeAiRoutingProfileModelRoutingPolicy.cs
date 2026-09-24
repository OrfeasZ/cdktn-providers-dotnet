using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiRoutingProfile
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiRoutingProfileModelRoutingPolicy), fullyQualifiedName: "oci.generativeAiRoutingProfile.GenerativeAiRoutingProfileModelRoutingPolicy")]
    public interface IGenerativeAiRoutingProfileModelRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/generative_ai_routing_profile#allowed_models GenerativeAiRoutingProfile#allowed_models}.</summary>
        [JsiiProperty(name: "allowedModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedModels
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiRoutingProfileModelRoutingPolicy), fullyQualifiedName: "oci.generativeAiRoutingProfile.GenerativeAiRoutingProfileModelRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiRoutingProfile.IGenerativeAiRoutingProfileModelRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/generative_ai_routing_profile#allowed_models GenerativeAiRoutingProfile#allowed_models}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedModels
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
