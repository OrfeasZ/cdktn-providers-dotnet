using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiRoutingProfile
{
    [JsiiByValue(fqn: "oci.generativeAiRoutingProfile.GenerativeAiRoutingProfileRegionRoutingPolicy")]
    public class GenerativeAiRoutingProfileRegionRoutingPolicy : oci.GenerativeAiRoutingProfile.IGenerativeAiRoutingProfileRegionRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/generative_ai_routing_profile#allowed_regions GenerativeAiRoutingProfile#allowed_regions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedRegions
        {
            get;
            set;
        }
    }
}
