using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountDnsSettingsInternalViews
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareAccountDnsSettingsInternalViewsName), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsName")]
    public interface IDataCloudflareAccountDnsSettingsInternalViewsName
    {
        /// <summary>Substring of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#contains DataCloudflareAccountDnsSettingsInternalViews#contains}
        /// </remarks>
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Contains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Suffix of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#endswith DataCloudflareAccountDnsSettingsInternalViews#endswith}
        /// </remarks>
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endswith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Exact value of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#exact DataCloudflareAccountDnsSettingsInternalViews#exact}
        /// </remarks>
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exact
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prefix of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#startswith DataCloudflareAccountDnsSettingsInternalViews#startswith}
        /// </remarks>
        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Startswith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareAccountDnsSettingsInternalViewsName), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalViews.DataCloudflareAccountDnsSettingsInternalViewsName")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareAccountDnsSettingsInternalViews.IDataCloudflareAccountDnsSettingsInternalViewsName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Substring of the DNS view name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#contains DataCloudflareAccountDnsSettingsInternalViews#contains}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Contains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Suffix of the DNS view name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#endswith DataCloudflareAccountDnsSettingsInternalViews#endswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endswith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Exact value of the DNS view name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#exact DataCloudflareAccountDnsSettingsInternalViews#exact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exact
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Prefix of the DNS view name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_views#startswith DataCloudflareAccountDnsSettingsInternalViews#startswith}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Startswith
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
