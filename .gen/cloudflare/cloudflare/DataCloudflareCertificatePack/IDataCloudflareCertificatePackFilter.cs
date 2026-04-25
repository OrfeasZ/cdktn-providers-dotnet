using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCertificatePack
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCertificatePackFilter), fullyQualifiedName: "cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilter")]
    public interface IDataCloudflareCertificatePackFilter
    {
        /// <summary>Specify the deployment environment for the certificate packs. Available values: "staging", "production".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/certificate_pack#deploy DataCloudflareCertificatePack#deploy}
        /// </remarks>
        [JsiiProperty(name: "deploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Deploy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include Certificate Packs of all statuses, not just active ones. Available values: "all".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/certificate_pack#status DataCloudflareCertificatePack#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCertificatePackFilter), fullyQualifiedName: "cloudflare.dataCloudflareCertificatePack.DataCloudflareCertificatePackFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCertificatePack.IDataCloudflareCertificatePackFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the deployment environment for the certificate packs. Available values: "staging", "production".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/certificate_pack#deploy DataCloudflareCertificatePack#deploy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Deploy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include Certificate Packs of all statuses, not just active ones. Available values: "all".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/certificate_pack#status DataCloudflareCertificatePack#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
