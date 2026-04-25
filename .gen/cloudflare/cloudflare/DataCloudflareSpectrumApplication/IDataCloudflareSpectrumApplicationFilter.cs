using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSpectrumApplication
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareSpectrumApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareSpectrumApplication.DataCloudflareSpectrumApplicationFilter")]
    public interface IDataCloudflareSpectrumApplicationFilter
    {
        /// <summary>Sets the direction by which results are ordered. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/spectrum_application#direction DataCloudflareSpectrumApplication#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Application field by which results are ordered. Available values: "protocol", "app_id", "created_on", "modified_on", "dns".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/spectrum_application#order DataCloudflareSpectrumApplication#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareSpectrumApplicationFilter), fullyQualifiedName: "cloudflare.dataCloudflareSpectrumApplication.DataCloudflareSpectrumApplicationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareSpectrumApplication.IDataCloudflareSpectrumApplicationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the direction by which results are ordered. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/spectrum_application#direction DataCloudflareSpectrumApplication#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Application field by which results are ordered. Available values: "protocol", "app_id", "created_on", "modified_on", "dns".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/spectrum_application#order DataCloudflareSpectrumApplication#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
