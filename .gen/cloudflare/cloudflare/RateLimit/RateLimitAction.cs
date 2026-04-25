using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiByValue(fqn: "cloudflare.rateLimit.RateLimitAction")]
    public class RateLimitAction : cloudflare.RateLimit.IRateLimitAction
    {
        /// <summary>The action to perform. Available values: "simulate", "ban", "challenge", "js_challenge", "managed_challenge".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#mode RateLimit#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>A custom content type and reponse to return when the threshold is exceeded.</summary>
        /// <remarks>
        /// The custom response configured in this object will override the custom error for the zone. This object is optional.
        /// Notes: If you omit this object, Cloudflare will use the default HTML error page. If "mode" is "challenge", "managed_challenge", or "js_challenge", Cloudflare will use the zone challenge pages and you should not provide the "response" object.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#response RateLimit#response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitActionResponse\"}", isOptional: true)]
        public cloudflare.RateLimit.IRateLimitActionResponse? Response
        {
            get;
            set;
        }

        /// <summary>The time in seconds during which Cloudflare will perform the mitigation action.</summary>
        /// <remarks>
        /// Must be an integer value greater than or equal to the period.
        /// Notes: If "mode" is "challenge", "managed_challenge", or "js_challenge", Cloudflare will use the zone's Challenge Passage time and you should not provide this value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/rate_limit#timeout RateLimit#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
