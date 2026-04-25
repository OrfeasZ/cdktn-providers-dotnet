using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiInterface(nativeType: typeof(ISpectrumApplicationEdgeIps), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationEdgeIps")]
    public interface ISpectrumApplicationEdgeIps
    {
        /// <summary>The IP versions supported for inbound connections on Spectrum anycast IPs. Available values: "all", "ipv4", "ipv6".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#connectivity SpectrumApplication#connectivity}
        /// </remarks>
        [JsiiProperty(name: "connectivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Connectivity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The array of customer owned IPs we broadcast via anycast for this hostname and application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ips SpectrumApplication#ips}
        /// </remarks>
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ips
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of edge IP configuration specified.</summary>
        /// <remarks>
        /// Dynamically allocated edge IPs use Spectrum anycast IPs in accordance with the connectivity you specify. Only valid with CNAME DNS names.
        /// Available values: "dynamic", "static".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#type SpectrumApplication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpectrumApplicationEdgeIps), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationEdgeIps")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SpectrumApplication.ISpectrumApplicationEdgeIps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The IP versions supported for inbound connections on Spectrum anycast IPs. Available values: "all", "ipv4", "ipv6".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#connectivity SpectrumApplication#connectivity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Connectivity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The array of customer owned IPs we broadcast via anycast for this hostname and application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ips SpectrumApplication#ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ips
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The type of edge IP configuration specified.</summary>
            /// <remarks>
            /// Dynamically allocated edge IPs use Spectrum anycast IPs in accordance with the connectivity you specify. Only valid with CNAME DNS names.
            /// Available values: "dynamic", "static".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#type SpectrumApplication#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
