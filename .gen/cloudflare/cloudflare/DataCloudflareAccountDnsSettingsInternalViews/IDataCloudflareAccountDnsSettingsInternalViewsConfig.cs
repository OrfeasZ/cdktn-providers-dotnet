using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountDnsSettingsInternalViews
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAccountDnsSettingsInternalViewsConfig), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsConfig")]
    public interface IDataCloudflareAccountDnsSettingsInternalViewsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#account_id DataCloudflareAccountDnsSettingsInternalViews#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Direction to order DNS views in. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#direction DataCloudflareAccountDnsSettingsInternalViews#direction}
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

        /// <summary>Whether to match all search requirements or at least one (any).</summary>
        /// <remarks>
        /// If set to <c>all</c>, acts like a logical AND between filters. If set to <c>any</c>, acts like a logical OR instead.
        /// Available values: "any", "all".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#match DataCloudflareAccountDnsSettingsInternalViews#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#max_items DataCloudflareAccountDnsSettingsInternalViews#max_items}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#name DataCloudflareAccountDnsSettingsInternalViews#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsName\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareAccountDnsSettingsInternalViews.IDataCloudflareAccountDnsSettingsInternalViewsName? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order DNS views by. Available values: "name", "created_on", "modified_on".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#order DataCloudflareAccountDnsSettingsInternalViews#order}
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

        /// <summary>A zone ID that exists in the zones list for the view.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#zone_id DataCloudflareAccountDnsSettingsInternalViews#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        /// <summary>A zone name that exists in the zones list for the view.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#zone_name DataCloudflareAccountDnsSettingsInternalViews#zone_name}
        /// </remarks>
        [JsiiProperty(name: "zoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAccountDnsSettingsInternalViewsConfig), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAccountDnsSettingsInternalViews.IDataCloudflareAccountDnsSettingsInternalViewsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#account_id DataCloudflareAccountDnsSettingsInternalViews#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Direction to order DNS views in. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#direction DataCloudflareAccountDnsSettingsInternalViews#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to match all search requirements or at least one (any).</summary>
            /// <remarks>
            /// If set to <c>all</c>, acts like a logical AND between filters. If set to <c>any</c>, acts like a logical OR instead.
            /// Available values: "any", "all".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#match DataCloudflareAccountDnsSettingsInternalViews#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Match
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#max_items DataCloudflareAccountDnsSettingsInternalViews#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#name DataCloudflareAccountDnsSettingsInternalViews#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsName\"}", isOptional: true)]
            public cloudflare.DataCloudflareAccountDnsSettingsInternalViews.IDataCloudflareAccountDnsSettingsInternalViewsName? Name
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareAccountDnsSettingsInternalViews.IDataCloudflareAccountDnsSettingsInternalViewsName?>();
            }

            /// <summary>Field to order DNS views by. Available values: "name", "created_on", "modified_on".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#order DataCloudflareAccountDnsSettingsInternalViews#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A zone ID that exists in the zones list for the view.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#zone_id DataCloudflareAccountDnsSettingsInternalViews#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A zone name that exists in the zones list for the view.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#zone_name DataCloudflareAccountDnsSettingsInternalViews#zone_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
