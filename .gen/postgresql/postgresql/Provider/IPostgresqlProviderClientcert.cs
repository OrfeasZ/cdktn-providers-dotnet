using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.Provider
{
    [JsiiInterface(nativeType: typeof(IPostgresqlProviderClientcert), fullyQualifiedName: "postgresql.provider.PostgresqlProviderClientcert")]
    public interface IPostgresqlProviderClientcert
    {
        /// <summary>The SSL client certificate file path. The file must contain PEM encoded data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#cert PostgresqlProvider#cert}
        /// </remarks>
        [JsiiProperty(name: "cert", typeJson: "{\"primitive\":\"string\"}")]
        string Cert
        {
            get;
        }

        /// <summary>The SSL client certificate private key file path. The file must contain PEM encoded data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#key PostgresqlProvider#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Must be set to true if you are inlining the cert/key instead of using a file path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslinline PostgresqlProvider#sslinline}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sslinline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sslinline
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlProviderClientcert), fullyQualifiedName: "postgresql.provider.PostgresqlProviderClientcert")]
        internal sealed class _Proxy : DeputyBase, postgresql.Provider.IPostgresqlProviderClientcert
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The SSL client certificate file path. The file must contain PEM encoded data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#cert PostgresqlProvider#cert}
            /// </remarks>
            [JsiiProperty(name: "cert", typeJson: "{\"primitive\":\"string\"}")]
            public string Cert
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The SSL client certificate private key file path. The file must contain PEM encoded data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#key PostgresqlProvider#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Must be set to true if you are inlining the cert/key instead of using a file path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslinline PostgresqlProvider#sslinline}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslinline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Sslinline
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
