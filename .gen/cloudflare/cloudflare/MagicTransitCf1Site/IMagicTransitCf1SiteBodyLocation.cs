using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitCf1Site
{
    [JsiiInterface(nativeType: typeof(IMagicTransitCf1SiteBodyLocation), fullyQualifiedName: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBodyLocation")]
    public interface IMagicTransitCf1SiteBodyLocation
    {
        /// <summary>Latitude of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#lat MagicTransitCf1Site#lat}
        /// </remarks>
        [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Lat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Longitude of the CF1 Site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#long MagicTransitCf1Site#long}
        /// </remarks>
        [JsiiProperty(name: "long", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Long
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of nearest town, city, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitCf1SiteBodyLocation), fullyQualifiedName: "cloudflare.magicTransitCf1Site.MagicTransitCf1SiteBodyLocation")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitCf1Site.IMagicTransitCf1SiteBodyLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Latitude of the CF1 Site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#lat MagicTransitCf1Site#lat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Lat
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Longitude of the CF1 Site.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#long MagicTransitCf1Site#long}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "long", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Long
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Name of nearest town, city, or village.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/magic_transit_cf1_site#name MagicTransitCf1Site#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
