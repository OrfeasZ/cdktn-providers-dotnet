using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileAttachLifecycleStageManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubProfileAttachLifecycleStageManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileAttachLifecycleStageManagement.OsManagementHubProfileAttachLifecycleStageManagementTimeouts")]
    public interface IOsManagementHubProfileAttachLifecycleStageManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#create OsManagementHubProfileAttachLifecycleStageManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#delete OsManagementHubProfileAttachLifecycleStageManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#update OsManagementHubProfileAttachLifecycleStageManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubProfileAttachLifecycleStageManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileAttachLifecycleStageManagement.OsManagementHubProfileAttachLifecycleStageManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubProfileAttachLifecycleStageManagement.IOsManagementHubProfileAttachLifecycleStageManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#create OsManagementHubProfileAttachLifecycleStageManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#delete OsManagementHubProfileAttachLifecycleStageManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_attach_lifecycle_stage_management#update OsManagementHubProfileAttachLifecycleStageManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
