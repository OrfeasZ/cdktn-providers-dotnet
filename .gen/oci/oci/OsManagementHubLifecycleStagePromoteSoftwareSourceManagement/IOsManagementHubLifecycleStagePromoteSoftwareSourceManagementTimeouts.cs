using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts), fullyQualifiedName: "oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts")]
    public interface IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#create OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#delete OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#update OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts), fullyQualifiedName: "oci.osManagementHubLifecycleStagePromoteSoftwareSourceManagement.OsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubLifecycleStagePromoteSoftwareSourceManagement.IOsManagementHubLifecycleStagePromoteSoftwareSourceManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#create OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#delete OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_lifecycle_stage_promote_software_source_management#update OsManagementHubLifecycleStagePromoteSoftwareSourceManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
