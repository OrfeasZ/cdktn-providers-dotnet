using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseVanityUrlDetails")]
    public class DatabaseAutonomousDatabaseVanityUrlDetails : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseVanityUrlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_autonomous_database#api_gateway_id DatabaseAutonomousDatabase#api_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiGatewayId
        {
            get;
            set;
        }

        private object? _isDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDisabled
        {
            get => _isDisabled;
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
                _isDisabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_autonomous_database#vanity_url_host_name DatabaseAutonomousDatabase#vanity_url_host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vanityUrlHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VanityUrlHostName
        {
            get;
            set;
        }
    }
}
