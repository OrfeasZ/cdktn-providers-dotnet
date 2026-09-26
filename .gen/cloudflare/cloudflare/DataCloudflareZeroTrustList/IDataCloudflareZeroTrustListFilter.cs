using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustList
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustListFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustList.DataCloudflareZeroTrustListFilter")]
    public interface IDataCloudflareZeroTrustListFilter
    {
        /// <summary>Sort direction.</summary>
        /// <remarks>
        /// Applies to the field named in <c>order_by</c>; when <c>order_by</c>
        /// is omitted it applies to the default <c>created_at</c> ordering. When
        /// <c>direction</c> is omitted the default is field-specific: explicitly choosing
        /// <c>created_at</c> or <c>updated_at</c> defaults to descending (newest first); <c>name</c>
        /// and <c>item_count</c> default to ascending; and the default <c>created_at</c>
        /// ordering used when <c>order_by</c> is omitted is ascending (for backwards
        /// compatibility).
        ///
        /// <list type="bullet">
        /// <description><c>asc</c> — ascending.</description>
        /// <description><c>desc</c> — descending.
        /// Available values: "asc", "desc".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#direction DataCloudflareZeroTrustList#direction}
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

        /// <summary>Filter the returned lists by one or more `field:value` pairs.</summary>
        /// <remarks>
        /// Repeat the parameter to apply multiple filters; they are combined with
        /// logical AND (a list must satisfy every filter to be returned).
        ///
        /// Supported fields and their matching behaviour:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — case-insensitive substring match on the list name.</description>
        /// <description><c>id</c> — substring match on the list ID (UUID), with or without dashes.</description>
        /// <description><c>type</c> — exact match on the list type. Supersedes the legacy <c>type</c> query
        /// parameter when both are supplied. Must be one of the valid type values.</description>
        /// <description><c>item_count</c> — exact integer match on the number of items in the list.</description>
        /// </list>
        ///
        /// Each entry must match one of the per-field patterns below: the field must be
        /// one of <c>name</c>, <c>id</c>, <c>type</c>, or <c>item_count</c>; <c>name</c>/<c>id</c> accept any value,
        /// <c>type</c> is restricted to the valid list type values, and <c>item_count</c> must be
        /// a non-negative integer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#filter DataCloudflareZeroTrustList#filter}
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

        /// <summary>Field to sort the returned lists by.</summary>
        /// <remarks>
        /// When omitted, results are ordered by
        /// <c>created_at</c> in ascending order (i.e. creation order) for backwards
        /// compatibility. Supported values:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — sort alphabetically by list name.</description>
        /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
        /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.</description>
        /// <description><c>item_count</c> — sort by number of items in the list.
        /// Available values: "name", "created_at", "updated_at", "item_count".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#order_by DataCloudflareZeroTrustList#order_by}
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

        /// <summary>Case-insensitive substring match on the list name or description. When combined with `filter`, both must match (logical AND).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#search DataCloudflareZeroTrustList#search}
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

        /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#type DataCloudflareZeroTrustList#type}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustListFilter), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustList.DataCloudflareZeroTrustListFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustList.IDataCloudflareZeroTrustListFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sort direction.</summary>
            /// <remarks>
            /// Applies to the field named in <c>order_by</c>; when <c>order_by</c>
            /// is omitted it applies to the default <c>created_at</c> ordering. When
            /// <c>direction</c> is omitted the default is field-specific: explicitly choosing
            /// <c>created_at</c> or <c>updated_at</c> defaults to descending (newest first); <c>name</c>
            /// and <c>item_count</c> default to ascending; and the default <c>created_at</c>
            /// ordering used when <c>order_by</c> is omitted is ascending (for backwards
            /// compatibility).
            ///
            /// <list type="bullet">
            /// <description><c>asc</c> — ascending.</description>
            /// <description><c>desc</c> — descending.
            /// Available values: "asc", "desc".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#direction DataCloudflareZeroTrustList#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the returned lists by one or more `field:value` pairs.</summary>
            /// <remarks>
            /// Repeat the parameter to apply multiple filters; they are combined with
            /// logical AND (a list must satisfy every filter to be returned).
            ///
            /// Supported fields and their matching behaviour:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — case-insensitive substring match on the list name.</description>
            /// <description><c>id</c> — substring match on the list ID (UUID), with or without dashes.</description>
            /// <description><c>type</c> — exact match on the list type. Supersedes the legacy <c>type</c> query
            /// parameter when both are supplied. Must be one of the valid type values.</description>
            /// <description><c>item_count</c> — exact integer match on the number of items in the list.</description>
            /// </list>
            ///
            /// Each entry must match one of the per-field patterns below: the field must be
            /// one of <c>name</c>, <c>id</c>, <c>type</c>, or <c>item_count</c>; <c>name</c>/<c>id</c> accept any value,
            /// <c>type</c> is restricted to the valid list type values, and <c>item_count</c> must be
            /// a non-negative integer.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#filter DataCloudflareZeroTrustList#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Filter
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Field to sort the returned lists by.</summary>
            /// <remarks>
            /// When omitted, results are ordered by
            /// <c>created_at</c> in ascending order (i.e. creation order) for backwards
            /// compatibility. Supported values:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — sort alphabetically by list name.</description>
            /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
            /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.</description>
            /// <description><c>item_count</c> — sort by number of items in the list.
            /// Available values: "name", "created_at", "updated_at", "item_count".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#order_by DataCloudflareZeroTrustList#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Case-insensitive substring match on the list name or description. When combined with `filter`, both must match (logical AND).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#search DataCloudflareZeroTrustList#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_list#type DataCloudflareZeroTrustList#type}
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
