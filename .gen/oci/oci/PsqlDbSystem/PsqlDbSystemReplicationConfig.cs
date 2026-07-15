using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemReplicationConfig")]
    public class PsqlDbSystemReplicationConfig : oci.PsqlDbSystem.IPsqlDbSystemReplicationConfig
    {
        private object? _isRpoEnforced;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#is_rpo_enforced PsqlDbSystem#is_rpo_enforced}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRpoEnforced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRpoEnforced
        {
            get => _isRpoEnforced;
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
                _isRpoEnforced = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#rpo_in_seconds PsqlDbSystem#rpo_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rpoInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RpoInSeconds
        {
            get;
            set;
        }
    }
}
