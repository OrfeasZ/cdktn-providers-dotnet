using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHostnameTlsSettings
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareHostnameTlsSettingsConfig), fullyQualifiedName: "cloudflare.dataCloudflareHostnameTlsSettings.DataCloudflareHostnameTlsSettingsConfig")]
    public interface IDataCloudflareHostnameTlsSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The TLS Setting name.</summary>
        /// <remarks>
        /// The value type depends on the setting:
        ///
        /// <list type="bullet">
        /// <description><c>ciphers</c>: value is an array of cipher suite strings (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>).</description>
        /// <description><c>min_tls_version</c>: value is a TLS version string (<c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c>).</description>
        /// <description><c>http2</c>: value is <c>"on"</c> or <c>"off"</c>.
        /// Available values: "ciphers", "min_tls_version", "http2".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#setting_id DataCloudflareHostnameTlsSettings#setting_id}
        /// </remarks>
        [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
        string SettingId
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#zone_id DataCloudflareHostnameTlsSettings#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#max_items DataCloudflareHostnameTlsSettings#max_items}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareHostnameTlsSettingsConfig), fullyQualifiedName: "cloudflare.dataCloudflareHostnameTlsSettings.DataCloudflareHostnameTlsSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareHostnameTlsSettings.IDataCloudflareHostnameTlsSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The TLS Setting name.</summary>
            /// <remarks>
            /// The value type depends on the setting:
            ///
            /// <list type="bullet">
            /// <description><c>ciphers</c>: value is an array of cipher suite strings (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>).</description>
            /// <description><c>min_tls_version</c>: value is a TLS version string (<c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c>).</description>
            /// <description><c>http2</c>: value is <c>"on"</c> or <c>"off"</c>.
            /// Available values: "ciphers", "min_tls_version", "http2".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#setting_id DataCloudflareHostnameTlsSettings#setting_id}
            /// </remarks>
            [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
            public string SettingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#zone_id DataCloudflareHostnameTlsSettings#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/hostname_tls_settings#max_items DataCloudflareHostnameTlsSettings#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
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
