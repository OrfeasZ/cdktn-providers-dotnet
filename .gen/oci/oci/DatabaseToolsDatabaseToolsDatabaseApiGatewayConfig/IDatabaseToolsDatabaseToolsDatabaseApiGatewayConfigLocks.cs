using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks")]
    public interface IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#type DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#message DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#related_resource_id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#related_resource_id}.</summary>
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelatedResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#time_created DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsDatabaseApiGatewayConfig.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig.IDatabaseToolsDatabaseToolsDatabaseApiGatewayConfigLocks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#type DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#message DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#related_resource_id DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#related_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelatedResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_tools_database_tools_database_api_gateway_config#time_created DatabaseToolsDatabaseToolsDatabaseApiGatewayConfig#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
