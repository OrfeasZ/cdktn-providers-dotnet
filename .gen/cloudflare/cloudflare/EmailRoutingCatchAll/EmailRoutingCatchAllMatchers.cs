using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingCatchAll
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.emailRoutingCatchAll.EmailRoutingCatchAllMatchers")]
    public class EmailRoutingCatchAllMatchers : cloudflare.EmailRoutingCatchAll.IEmailRoutingCatchAllMatchers
    {
        /// <summary>Type of matcher. Default is 'all'. Available values: "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#type EmailRoutingCatchAll#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
