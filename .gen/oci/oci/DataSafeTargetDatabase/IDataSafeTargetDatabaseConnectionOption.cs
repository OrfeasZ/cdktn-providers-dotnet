using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabaseConnectionOption), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption")]
    public interface IDataSafeTargetDatabaseConnectionOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#connection_type DataSafeTargetDatabase#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#datasafe_private_endpoint_id DataSafeTargetDatabase#datasafe_private_endpoint_id}.</summary>
        [JsiiProperty(name: "datasafePrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasafePrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#on_prem_connector_id DataSafeTargetDatabase#on_prem_connector_id}.</summary>
        [JsiiProperty(name: "onPremConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnPremConnectorId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabaseConnectionOption), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#connection_type DataSafeTargetDatabase#connection_type}.</summary>
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#datasafe_private_endpoint_id DataSafeTargetDatabase#datasafe_private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "datasafePrivateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasafePrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#on_prem_connector_id DataSafeTargetDatabase#on_prem_connector_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onPremConnectorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnPremConnectorId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
