using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailRoutingCatchAll
{
    [JsiiInterface(nativeType: typeof(IEmailRoutingCatchAllActions), fullyQualifiedName: "cloudflare.emailRoutingCatchAll.EmailRoutingCatchAllActions")]
    public interface IEmailRoutingCatchAllActions
    {
        /// <summary>Type of action for catch-all rule. Available values: "drop", "forward", "worker".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#type EmailRoutingCatchAll#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#value EmailRoutingCatchAll#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailRoutingCatchAllActions), fullyQualifiedName: "cloudflare.emailRoutingCatchAll.EmailRoutingCatchAllActions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailRoutingCatchAll.IEmailRoutingCatchAllActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of action for catch-all rule. Available values: "drop", "forward", "worker".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#type EmailRoutingCatchAll#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/email_routing_catch_all#value EmailRoutingCatchAll#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Value
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
