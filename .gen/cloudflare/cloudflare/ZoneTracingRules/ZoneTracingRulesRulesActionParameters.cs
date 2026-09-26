using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneTracingRules
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zoneTracingRules.ZoneTracingRulesRulesActionParameters")]
    public class ZoneTracingRulesRulesActionParameters : cloudflare.ZoneTracingRules.IZoneTracingRulesRulesActionParameters
    {
        /// <summary>The ratio of requests sampled for tracing, from 0 to 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zone_tracing_rules#sampling_ratio ZoneTracingRules#sampling_ratio}
        /// </remarks>
        [JsiiProperty(name: "samplingRatio", typeJson: "{\"primitive\":\"number\"}")]
        public double SamplingRatio
        {
            get;
            set;
        }
    }
}
