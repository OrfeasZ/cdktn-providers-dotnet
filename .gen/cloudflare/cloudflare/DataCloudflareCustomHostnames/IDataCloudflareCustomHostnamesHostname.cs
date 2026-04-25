using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostnames
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareCustomHostnamesHostname), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesHostname")]
    public interface IDataCloudflareCustomHostnamesHostname
    {
        /// <summary>Filters hostnames by a substring match on the hostname value. This parameter cannot be used with the 'id' parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostnames#contain DataCloudflareCustomHostnames#contain}
        /// </remarks>
        [JsiiProperty(name: "contain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Contain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareCustomHostnamesHostname), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesHostname")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesHostname
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filters hostnames by a substring match on the hostname value. This parameter cannot be used with the 'id' parameter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/custom_hostnames#contain DataCloudflareCustomHostnames#contain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
