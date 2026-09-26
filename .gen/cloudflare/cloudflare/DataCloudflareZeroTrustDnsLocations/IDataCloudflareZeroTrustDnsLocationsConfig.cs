using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocations
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareZeroTrustDnsLocationsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsConfig")]
    public interface IDataCloudflareZeroTrustDnsLocationsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#account_id DataCloudflareZeroTrustDnsLocations#account_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#direction DataCloudflareZeroTrustDnsLocations#direction}
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

        /// <summary>Filter the returned locations by one or more `field:value` pairs.</summary>
        /// <remarks>
        /// Repeat the parameter to apply multiple filters; they are combined with
        /// logical AND (a location must satisfy every filter to be returned).
        ///
        /// Supported fields and their matching behaviour:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — case-insensitive substring match on the location name.</description>
        /// <description><c>id</c> — substring match on the location ID (UUID), with or without dashes.</description>
        /// <description><c>is_default</c> — whether it is the default for the account.</description>
        /// </list>
        ///
        /// Each entry must match one of the per-field patterns below:
        ///
        /// <list type="bullet">
        /// <description>the field must be one of <c>name</c>, <c>id</c>, or <c>is_default</c>;</description>
        /// <description><c>name</c>/<c>id</c> accept any value;</description>
        /// <description><c>is_default</c> only accepts <c>true</c> or <c>false</c>; any other value returns <c>400</c></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#filter DataCloudflareZeroTrustDnsLocations#filter}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#max_items DataCloudflareZeroTrustDnsLocations#max_items}
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

        /// <summary>Field to sort the returned locations by.</summary>
        /// <remarks>
        /// When omitted, the order of
        /// results is unspecified. Supported values:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> — sort alphabetically by location name.</description>
        /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
        /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.
        /// Available values: "name", "created_at", "updated_at".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#order_by DataCloudflareZeroTrustDnsLocations#order_by}
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

        /// <summary>Case-insensitive substring match on the location name. When combined with `filter`, both must match (logical AND).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#search DataCloudflareZeroTrustDnsLocations#search}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareZeroTrustDnsLocationsConfig), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareZeroTrustDnsLocations.IDataCloudflareZeroTrustDnsLocationsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#account_id DataCloudflareZeroTrustDnsLocations#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#direction DataCloudflareZeroTrustDnsLocations#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter the returned locations by one or more `field:value` pairs.</summary>
            /// <remarks>
            /// Repeat the parameter to apply multiple filters; they are combined with
            /// logical AND (a location must satisfy every filter to be returned).
            ///
            /// Supported fields and their matching behaviour:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — case-insensitive substring match on the location name.</description>
            /// <description><c>id</c> — substring match on the location ID (UUID), with or without dashes.</description>
            /// <description><c>is_default</c> — whether it is the default for the account.</description>
            /// </list>
            ///
            /// Each entry must match one of the per-field patterns below:
            ///
            /// <list type="bullet">
            /// <description>the field must be one of <c>name</c>, <c>id</c>, or <c>is_default</c>;</description>
            /// <description><c>name</c>/<c>id</c> accept any value;</description>
            /// <description><c>is_default</c> only accepts <c>true</c> or <c>false</c>; any other value returns <c>400</c></description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#filter DataCloudflareZeroTrustDnsLocations#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Filter
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#max_items DataCloudflareZeroTrustDnsLocations#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Field to sort the returned locations by.</summary>
            /// <remarks>
            /// When omitted, the order of
            /// results is unspecified. Supported values:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> — sort alphabetically by location name.</description>
            /// <description><c>created_at</c> — sort by creation time; defaults to descending unless <c>direction</c> is set.</description>
            /// <description><c>updated_at</c> — sort by last-modified time; defaults to descending unless <c>direction</c> is set.
            /// Available values: "name", "created_at", "updated_at".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#order_by DataCloudflareZeroTrustDnsLocations#order_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Case-insensitive substring match on the location name. When combined with `filter`, both must match (logical AND).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/zero_trust_dns_locations#search DataCloudflareZeroTrustDnsLocations#search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Search
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
