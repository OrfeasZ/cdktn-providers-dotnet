using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue")]
    public interface IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#compartment_id DatabaseManagementCloudDbSystemDiscovery#compartment_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connector DatabaseManagementCloudDbSystemDiscovery#connector}
        /// </remarks>
        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector? Connector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#display_name DatabaseManagementCloudDbSystemDiscovery#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#is_selected_for_monitoring DatabaseManagementCloudDbSystemDiscovery#is_selected_for_monitoring}.</summary>
        [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSelectedForMonitoring
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#compartment_id DatabaseManagementCloudDbSystemDiscovery#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#connector DatabaseManagementCloudDbSystemDiscovery#connector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector\"}", isOptional: true)]
            public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector? Connector
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#display_name DatabaseManagementCloudDbSystemDiscovery#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#is_selected_for_monitoring DatabaseManagementCloudDbSystemDiscovery#is_selected_for_monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSelectedForMonitoring
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
