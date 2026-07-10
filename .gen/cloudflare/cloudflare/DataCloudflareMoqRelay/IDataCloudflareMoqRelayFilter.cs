using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMoqRelay
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareMoqRelayFilter), fullyQualifiedName: "cloudflare.dataCloudflareMoqRelay.DataCloudflareMoqRelayFilter")]
    public interface IDataCloudflareMoqRelayFilter
    {
        /// <summary>Sort order by `created`. When true, results are returned oldest-first (ascending); otherwise newest-first (descending, the default).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#asc DataCloudflareMoqRelay#asc}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "asc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Asc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Cursor for pagination.</summary>
        /// <remarks>
        /// Returns relays created strictly after this
        /// RFC 3339 timestamp (typically the <c>created</c> value of the last item
        /// on the current page, to fetch the next page).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#created_after DataCloudflareMoqRelay#created_after}
        /// </remarks>
        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Cursor for pagination.</summary>
        /// <remarks>
        /// Returns relays created strictly before this
        /// RFC 3339 timestamp (typically the <c>created</c> value of the first item
        /// on the current page, to fetch the previous page).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#created_before DataCloudflareMoqRelay#created_before}
        /// </remarks>
        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBefore
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of relays to return per page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#per_page DataCloudflareMoqRelay#per_page}
        /// </remarks>
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerPage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareMoqRelayFilter), fullyQualifiedName: "cloudflare.dataCloudflareMoqRelay.DataCloudflareMoqRelayFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareMoqRelay.IDataCloudflareMoqRelayFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sort order by `created`. When true, results are returned oldest-first (ascending); otherwise newest-first (descending, the default).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#asc DataCloudflareMoqRelay#asc}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "asc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Asc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Cursor for pagination.</summary>
            /// <remarks>
            /// Returns relays created strictly after this
            /// RFC 3339 timestamp (typically the <c>created</c> value of the last item
            /// on the current page, to fetch the next page).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#created_after DataCloudflareMoqRelay#created_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Cursor for pagination.</summary>
            /// <remarks>
            /// Returns relays created strictly before this
            /// RFC 3339 timestamp (typically the <c>created</c> value of the first item
            /// on the current page, to fetch the previous page).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#created_before DataCloudflareMoqRelay#created_before}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBefore
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum number of relays to return per page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/data-sources/moq_relay#per_page DataCloudflareMoqRelay#per_page}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerPage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
