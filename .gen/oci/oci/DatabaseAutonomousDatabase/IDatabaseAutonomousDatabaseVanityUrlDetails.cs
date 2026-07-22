using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseVanityUrlDetails), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseVanityUrlDetails")]
    public interface IDatabaseAutonomousDatabaseVanityUrlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#api_gateway_id DatabaseAutonomousDatabase#api_gateway_id}.</summary>
        [JsiiProperty(name: "apiGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#vanity_url_host_name DatabaseAutonomousDatabase#vanity_url_host_name}.</summary>
        [JsiiProperty(name: "vanityUrlHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VanityUrlHostName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseVanityUrlDetails), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseVanityUrlDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseVanityUrlDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#api_gateway_id DatabaseAutonomousDatabase#api_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apiGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#is_disabled DatabaseAutonomousDatabase#is_disabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_autonomous_database#vanity_url_host_name DatabaseAutonomousDatabase#vanity_url_host_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vanityUrlHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VanityUrlHostName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
