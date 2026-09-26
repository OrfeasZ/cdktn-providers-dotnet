using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayProxyEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustGatewayProxyEndpointFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayProxyEndpoint.DataCloudflareZeroTrustGatewayProxyEndpointFilter")]
    public interface IDataCloudflareZeroTrustGatewayProxyEndpointFilter
    {
        /// <summary>Sort direction.</summary>
        /// <remarks>
        /// Only takes effect when <c>order_by</c> is also provided; it
        /// is ignored otherwise. When <c>direction</c> is omitted the effective
        /// direction is field-specific: <c>created_at</c> and <c>updated_at</c> default to
        /// descending (newest first); <c>name</c> defaults to ascending.
        ///
        /// <list type="bullet">
        /// <description><c>asc</c> — ascending.</description>
        /// <description><c>desc</c> — descending.
        /// Available values: "asc", "desc".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#direction DataCloudflareZeroTrustGatewayProxyEndpoint#direction}
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

        /// <summary>Filter the returned proxy endpoints by one or more `field:value` pairs.</summary>
        /// <remarks>
        /// Repeat the parameter to apply multiple filters; they are combined with
        /// logical AND (an endpoint must satisfy every filter to be returned).
        ///
        /// Supported fields and their matching behaviour:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — case-insensitive substring match on the endpoint name.</description>
        /// <description><c>id</c> — substring match on the endpoint ID (UUID), with or without dashes.</description>
        /// <description><c>kind</c> — exact match on the endpoint kind. The value must be <c>ip</c> or <c>identity</c>; any other value returns <c>400</c>.</description>
        /// </list>
        ///
        /// Each entry must match one of the per-field patterns below: the field
        /// must be one of <c>name</c>, <c>id</c>, or <c>kind</c>; <c>name</c>/<c>id</c> accept any value,
        /// while <c>kind</c> only accepts <c>ip</c> or <c>identity</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#filter DataCloudflareZeroTrustGatewayProxyEndpoint#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to sort the returned endpoints by.</summary>
        /// <remarks>
        /// When omitted, the order of
        /// results is unspecified. Supported values:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — sort alphabetically by endpoint name.</description>
        /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
        /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.
        /// Available values: "name", "created_at", "updated_at".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#order_by DataCloudflareZeroTrustGatewayProxyEndpoint#order_by}
        /// </remarks>
        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Case-insensitive substring match on the endpoint name. When combined with `filter`, both must match (logical AND).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#search DataCloudflareZeroTrustGatewayProxyEndpoint#search}
        /// </remarks>
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Search
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustGatewayProxyEndpointFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayProxyEndpoint.DataCloudflareZeroTrustGatewayProxyEndpointFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustGatewayProxyEndpoint.IDataCloudflareZeroTrustGatewayProxyEndpointFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sort direction.</summary>
            /// <remarks>
            /// Only takes effect when <c>order_by</c> is also provided; it
            /// is ignored otherwise. When <c>direction</c> is omitted the effective
            /// direction is field-specific: <c>created_at</c> and <c>updated_at</c> default to
            /// descending (newest first); <c>name</c> defaults to ascending.
            ///
            /// <list type="bullet">
            /// <description><c>asc</c> — ascending.</description>
            /// <description><c>desc</c> — descending.
            /// Available values: "asc", "desc".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#direction DataCloudflareZeroTrustGatewayProxyEndpoint#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the returned proxy endpoints by one or more `field:value` pairs.</summary>
            /// <remarks>
            /// Repeat the parameter to apply multiple filters; they are combined with
            /// logical AND (an endpoint must satisfy every filter to be returned).
            ///
            /// Supported fields and their matching behaviour:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — case-insensitive substring match on the endpoint name.</description>
            /// <description><c>id</c> — substring match on the endpoint ID (UUID), with or without dashes.</description>
            /// <description><c>kind</c> — exact match on the endpoint kind. The value must be <c>ip</c> or <c>identity</c>; any other value returns <c>400</c>.</description>
            /// </list>
            ///
            /// Each entry must match one of the per-field patterns below: the field
            /// must be one of <c>name</c>, <c>id</c>, or <c>kind</c>; <c>name</c>/<c>id</c> accept any value,
            /// while <c>kind</c> only accepts <c>ip</c> or <c>identity</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#filter DataCloudflareZeroTrustGatewayProxyEndpoint#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Filter
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Field to sort the returned endpoints by.</summary>
            /// <remarks>
            /// When omitted, the order of
            /// results is unspecified. Supported values:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — sort alphabetically by endpoint name.</description>
            /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
            /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.
            /// Available values: "name", "created_at", "updated_at".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#order_by DataCloudflareZeroTrustGatewayProxyEndpoint#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Case-insensitive substring match on the endpoint name. When combined with `filter`, both must match (logical AND).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_gateway_proxy_endpoint#search DataCloudflareZeroTrustGatewayProxyEndpoint#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
