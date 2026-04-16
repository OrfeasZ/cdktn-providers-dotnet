using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiInterface(nativeType: typeof(ISpectrumApplicationDns), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationDns")]
    public interface ISpectrumApplicationDns
    {
        /// <summary>The name of the DNS record associated with the application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#name SpectrumApplication#name}
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

        /// <summary>The type of DNS record associated with the application. Available values: "CNAME", "ADDRESS".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#type SpectrumApplication#type}
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

        [JsiiTypeProxy(nativeType: typeof(ISpectrumApplicationDns), fullyQualifiedName: "cloudflare.spectrumApplication.SpectrumApplicationDns")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SpectrumApplication.ISpectrumApplicationDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the DNS record associated with the application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#name SpectrumApplication#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of DNS record associated with the application. Available values: "CNAME", "ADDRESS".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#type SpectrumApplication#type}
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
