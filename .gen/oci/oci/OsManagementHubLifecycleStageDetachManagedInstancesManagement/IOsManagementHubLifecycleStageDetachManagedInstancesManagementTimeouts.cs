using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts")]
    public interface IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#create OsManagementHubLifecycleStageDetachManagedInstancesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#delete OsManagementHubLifecycleStageDetachManagedInstancesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#update OsManagementHubLifecycleStageDetachManagedInstancesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubLifecycleStageDetachManagedInstancesManagement.OsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubLifecycleStageDetachManagedInstancesManagement.IOsManagementHubLifecycleStageDetachManagedInstancesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#create OsManagementHubLifecycleStageDetachManagedInstancesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#delete OsManagementHubLifecycleStageDetachManagedInstancesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_detach_managed_instances_management#update OsManagementHubLifecycleStageDetachManagedInstancesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
