using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingCatchAll
{
    [JsiiInterface(nativeType: typeof(IEmailRoutingCatchAllMatchers), fullyQualifiedName: "cloudflare.emailRoutingCatchAll.EmailRoutingCatchAllMatchers")]
    public interface IEmailRoutingCatchAllMatchers
    {
        /// <summary>Type of matcher. Default is 'all'. Available values: "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#type EmailRoutingCatchAll#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailRoutingCatchAllMatchers), fullyQualifiedName: "cloudflare.emailRoutingCatchAll.EmailRoutingCatchAllMatchers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailRoutingCatchAll.IEmailRoutingCatchAllMatchers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of matcher. Default is 'all'. Available values: "all".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#type EmailRoutingCatchAll#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
