using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.HostnameTlsSetting
{
    [JsiiInterface(nativeType: typeof(IHostnameTlsSettingConfig), fullyQualifiedName: "cloudflare.hostnameTlsSetting.HostnameTlsSettingConfig")]
    public interface IHostnameTlsSettingConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The hostname for which the tls settings are set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#hostname HostnameTlsSetting#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>The TLS Setting name.</summary>
        /// <remarks>
        /// The value type depends on the setting:
        ///
        /// <list type="bullet">
        /// <description><c>ciphers</c>: value is an array of cipher suite strings (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>)</description>
        /// <description><c>min_tls_version</c>: value is a TLS version string (<c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c>)</description>
        /// <description><c>http2</c>: value is <c>"on"</c> or <c>"off"</c>
        /// Available values: "ciphers", "min_tls_version", "http2".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#setting_id HostnameTlsSetting#setting_id}
        /// </remarks>
        [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
        string SettingId
        {
            get;
        }

        /// <summary>The TLS setting value.</summary>
        /// <remarks>
        /// The type depends on the <c>setting_id</c> used in the request path:
        ///
        /// <list type="bullet">
        /// <description><c>ciphers</c>: an array of allowed cipher suite strings in BoringSSL format (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>)</description>
        /// <description><c>min_tls_version</c>: a string indicating the minimum TLS version — one of <c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c> (e.g., <c>"1.2"</c>)</description>
        /// <description><c>http2</c>: a string indicating whether HTTP/2 is enabled — <c>"on"</c> or <c>"off"</c> (e.g., <c>"on"</c>)
        /// Available values: "1.0", "1.1", "1.2", "1.3", "on", "off".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#value HostnameTlsSetting#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, object> Value
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#zone_id HostnameTlsSetting#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHostnameTlsSettingConfig), fullyQualifiedName: "cloudflare.hostnameTlsSetting.HostnameTlsSettingConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.HostnameTlsSetting.IHostnameTlsSettingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The hostname for which the tls settings are set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#hostname HostnameTlsSetting#hostname}
            /// </remarks>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The TLS Setting name.</summary>
            /// <remarks>
            /// The value type depends on the setting:
            ///
            /// <list type="bullet">
            /// <description><c>ciphers</c>: value is an array of cipher suite strings (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>)</description>
            /// <description><c>min_tls_version</c>: value is a TLS version string (<c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c>)</description>
            /// <description><c>http2</c>: value is <c>"on"</c> or <c>"off"</c>
            /// Available values: "ciphers", "min_tls_version", "http2".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#setting_id HostnameTlsSetting#setting_id}
            /// </remarks>
            [JsiiProperty(name: "settingId", typeJson: "{\"primitive\":\"string\"}")]
            public string SettingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The TLS setting value.</summary>
            /// <remarks>
            /// The type depends on the <c>setting_id</c> used in the request path:
            ///
            /// <list type="bullet">
            /// <description><c>ciphers</c>: an array of allowed cipher suite strings in BoringSSL format (e.g., <c>["ECDHE-RSA-AES128-GCM-SHA256", "AES128-GCM-SHA256"]</c>)</description>
            /// <description><c>min_tls_version</c>: a string indicating the minimum TLS version — one of <c>"1.0"</c>, <c>"1.1"</c>, <c>"1.2"</c>, or <c>"1.3"</c> (e.g., <c>"1.2"</c>)</description>
            /// <description><c>http2</c>: a string indicating whether HTTP/2 is enabled — <c>"on"</c> or <c>"off"</c> (e.g., <c>"on"</c>)
            /// Available values: "1.0", "1.1", "1.2", "1.3", "on", "off".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#value HostnameTlsSetting#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, object> Value
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/hostname_tls_setting#zone_id HostnameTlsSetting#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
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
