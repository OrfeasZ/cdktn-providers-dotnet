using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace postgresql.Provider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "postgresql.provider.PostgresqlProviderClientcert")]
    public class PostgresqlProviderClientcert : postgresql.Provider.IPostgresqlProviderClientcert
    {
        /// <summary>The SSL client certificate file path. The file must contain PEM encoded data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#cert PostgresqlProvider#cert}
        /// </remarks>
        [JsiiProperty(name: "cert", typeJson: "{\"primitive\":\"string\"}")]
        public string Cert
        {
            get;
            set;
        }

        /// <summary>The SSL client certificate private key file path. The file must contain PEM encoded data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#key PostgresqlProvider#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        private object? _sslinline;

        /// <summary>Must be set to true if you are inlining the cert/key instead of using a file path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cyrilgdn/postgresql/1.27.0/docs#sslinline PostgresqlProvider#sslinline}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslinline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Sslinline
        {
            get => _sslinline;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sslinline = value;
            }
        }
    }
}
