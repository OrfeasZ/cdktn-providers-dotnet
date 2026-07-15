using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetails")]
    public class PsqlDbSystemKerberosAuthDetails : oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        private object? _backupCredentials;

        /// <summary>backup_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#backup_credentials PsqlDbSystem#backup_credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsBackupCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BackupCredentials
        {
            get => _backupCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsBackupCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backupCredentials = value;
            }
        }

        private object? _credentials;

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#credentials PsqlDbSystem#credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemKerberosAuthDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Credentials
        {
            get => _credentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemKerberosAuthDetailsCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _credentials = value;
            }
        }
    }
}
