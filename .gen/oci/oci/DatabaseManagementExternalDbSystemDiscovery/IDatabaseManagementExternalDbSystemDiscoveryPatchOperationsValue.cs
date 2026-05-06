using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue")]
    public interface IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#compartment_id DatabaseManagementExternalDbSystemDiscovery#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>connector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connector DatabaseManagementExternalDbSystemDiscovery#connector}
        /// </remarks>
        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector? Connector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#display_name DatabaseManagementExternalDbSystemDiscovery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#is_selected_for_monitoring DatabaseManagementExternalDbSystemDiscovery#is_selected_for_monitoring}.</summary>
        [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSelectedForMonitoring
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue), fullyQualifiedName: "oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#compartment_id DatabaseManagementExternalDbSystemDiscovery#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#connector DatabaseManagementExternalDbSystemDiscovery#connector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.databaseManagementExternalDbSystemDiscovery.DatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector\"}", isOptional: true)]
            public oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector? Connector
            {
                get => GetInstanceProperty<oci.DatabaseManagementExternalDbSystemDiscovery.IDatabaseManagementExternalDbSystemDiscoveryPatchOperationsValueConnector?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#display_name DatabaseManagementExternalDbSystemDiscovery#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system_discovery#is_selected_for_monitoring DatabaseManagementExternalDbSystemDiscovery#is_selected_for_monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSelectedForMonitoring
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
