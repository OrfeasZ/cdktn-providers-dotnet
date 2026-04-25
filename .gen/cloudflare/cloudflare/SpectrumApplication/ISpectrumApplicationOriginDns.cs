using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiInterface(nativeType: typeof(ISpectrumApplicationOriginDns), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationOriginDns")]
    public interface ISpectrumApplicationOriginDns
    {
        /// <summary>The name of the DNS record associated with the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#name SpectrumApplication#name}
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

        /// <summary>The TTL of our resolution of your DNS record in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ttl SpectrumApplication#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of DNS record associated with the origin.</summary>
        /// <remarks>
        /// "" is used to specify a combination of A/AAAA records.
        /// Available values: "", "A", "AAAA", "SRV".
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

        [JsiiTypeProxy(nativeType: typeof(ISpectrumApplicationOriginDns), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationOriginDns")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SpectrumApplication.ISpectrumApplicationOriginDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the DNS record associated with the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#name SpectrumApplication#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The TTL of our resolution of your DNS record in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ttl SpectrumApplication#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The type of DNS record associated with the origin.</summary>
            /// <remarks>
            /// "" is used to specify a combination of A/AAAA records.
            /// Available values: "", "A", "AAAA", "SRV".
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
