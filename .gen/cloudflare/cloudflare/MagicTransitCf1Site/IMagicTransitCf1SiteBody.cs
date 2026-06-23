using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitCf1Site
{
    [JsiiInterface(nativeType: typeof(IMagicTransitCf1SiteBody), fullyQualifiedName: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBody")]
    public interface IMagicTransitCf1SiteBody
    {
        /// <summary>A human-provided name describing the CF1 Site that should be unique within the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>A human-provided description of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#description MagicTransitCf1Site#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#location MagicTransitCf1Site#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBodyLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBodyLocation? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitCf1SiteBody), fullyQualifiedName: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBody")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A human-provided name describing the CF1 Site that should be unique within the account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A human-provided description of the CF1 Site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#description MagicTransitCf1Site#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_cf1_site#location MagicTransitCf1Site#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBodyLocation\"}", isOptional: true)]
            public cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBodyLocation? Location
            {
                get => GetInstanceProperty<cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBodyLocation?>();
            }
        }
    }
}
