using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailRoutingAddress
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareEmailRoutingAddressFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingAddress.DataCloudflareEmailRoutingAddressFilter")]
    public interface IDataCloudflareEmailRoutingAddressFilter
    {
        /// <summary>Sorts results in an ascending or descending order. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_address#direction DataCloudflareEmailRoutingAddress#direction}
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

        /// <summary>Filter by verified destination addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_address#verified DataCloudflareEmailRoutingAddress#verified}
        /// </remarks>
        [JsiiProperty(name: "verified", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Verified
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareEmailRoutingAddressFilter), fullyQualifiedName: "cloudflare.dataCloudflareEmailRoutingAddress.DataCloudflareEmailRoutingAddressFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareEmailRoutingAddress.IDataCloudflareEmailRoutingAddressFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sorts results in an ascending or descending order. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_address#direction DataCloudflareEmailRoutingAddress#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter by verified destination addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_routing_address#verified DataCloudflareEmailRoutingAddress#verified}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verified", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Verified
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
