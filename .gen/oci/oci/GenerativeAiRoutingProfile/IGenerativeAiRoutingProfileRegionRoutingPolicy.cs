using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiRoutingProfile
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiRoutingProfileRegionRoutingPolicy), fullyQualifiedName: "oci.generativeAiRoutingProfile.GenerativeAiRoutingProfileRegionRoutingPolicy")]
    public interface IGenerativeAiRoutingProfileRegionRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/generative_ai_routing_profile#allowed_regions GenerativeAiRoutingProfile#allowed_regions}.</summary>
        [JsiiProperty(name: "allowedRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedRegions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiRoutingProfileRegionRoutingPolicy), fullyQualifiedName: "oci.generativeAiRoutingProfile.GenerativeAiRoutingProfileRegionRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiRoutingProfile.IGenerativeAiRoutingProfileRegionRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/generative_ai_routing_profile#allowed_regions GenerativeAiRoutingProfile#allowed_regions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedRegions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
