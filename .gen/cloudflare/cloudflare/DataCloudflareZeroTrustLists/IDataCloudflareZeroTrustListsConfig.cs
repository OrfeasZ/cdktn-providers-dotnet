using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustLists
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustListsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustLists.DataCloudflareZeroTrustListsConfig")]
    public interface IDataCloudflareZeroTrustListsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#account_id DataCloudflareZeroTrustLists#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#direction DataCloudflareZeroTrustLists#direction}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#filter DataCloudflareZeroTrustLists#filter}
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

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#max_items DataCloudflareZeroTrustLists#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#order_by DataCloudflareZeroTrustLists#order_by}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#search DataCloudflareZeroTrustLists#search}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#type DataCloudflareZeroTrustLists#type}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustListsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustLists.DataCloudflareZeroTrustListsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustLists.IDataCloudflareZeroTrustListsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#account_id DataCloudflareZeroTrustLists#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#direction DataCloudflareZeroTrustLists#direction}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#filter DataCloudflareZeroTrustLists#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Filter
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#max_items DataCloudflareZeroTrustLists#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#order_by DataCloudflareZeroTrustLists#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Case-insensitive substring match on the list name or description. When combined with `filter`, both must match (logical AND).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#search DataCloudflareZeroTrustLists#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the list type. Available values: "SERIAL", "URL", "DOMAIN", "EMAIL", "IP", "CATEGORY", "LOCATION", "DEVICE", "AAGUID".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_lists#type DataCloudflareZeroTrustLists#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
