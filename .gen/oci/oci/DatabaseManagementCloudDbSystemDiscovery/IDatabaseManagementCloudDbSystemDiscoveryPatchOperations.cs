using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperations), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperations")]
    public interface IDatabaseManagementCloudDbSystemDiscoveryPatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#operation DatabaseManagementCloudDbSystemDiscovery#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#selection DatabaseManagementCloudDbSystemDiscovery#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#value DatabaseManagementCloudDbSystemDiscovery#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemDiscoveryPatchOperations), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#operation DatabaseManagementCloudDbSystemDiscovery#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#selection DatabaseManagementCloudDbSystemDiscovery#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_discovery#value DatabaseManagementCloudDbSystemDiscovery#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue\"}", isOptional: true)]
            public oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue? Value
            {
                get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue?>();
            }
        }
    }
}
