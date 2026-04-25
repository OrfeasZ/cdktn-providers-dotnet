using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSite
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLocation), fullyQualifiedName: "cloudflare.magicTransitSite.MagicTransitSiteLocation")]
    public interface IMagicTransitSiteLocation
    {
        /// <summary>Latitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site#lat MagicTransitSite#lat}
        /// </remarks>
        [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Longitude.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site#lon MagicTransitSite#lon}
        /// </remarks>
        [JsiiProperty(name: "lon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lon
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLocation), fullyQualifiedName: "cloudflare.magicTransitSite.MagicTransitSiteLocation")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSite.IMagicTransitSiteLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Latitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site#lat MagicTransitSite#lat}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Longitude.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site#lon MagicTransitSite#lon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lon
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
