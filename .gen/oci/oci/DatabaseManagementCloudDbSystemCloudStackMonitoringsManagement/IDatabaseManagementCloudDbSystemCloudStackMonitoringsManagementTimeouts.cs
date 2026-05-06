using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudStackMonitoringsManagement.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts")]
    public interface IDatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#create DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#delete DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#update DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts), fullyQualifiedName: "oci.databaseManagementCloudDbSystemCloudStackMonitoringsManagement.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement.IDatabaseManagementCloudDbSystemCloudStackMonitoringsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#create DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#delete DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_cloud_db_system_cloud_stack_monitorings_management#update DatabaseManagementCloudDbSystemCloudStackMonitoringsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
