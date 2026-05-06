using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts), fullyQualifiedName: "oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts")]
    public interface IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#create DatabaseCloudExadataInfrastructureConfigureExascaleManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#delete DatabaseCloudExadataInfrastructureConfigureExascaleManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#update DatabaseCloudExadataInfrastructureConfigureExascaleManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts), fullyQualifiedName: "oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#create DatabaseCloudExadataInfrastructureConfigureExascaleManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#delete DatabaseCloudExadataInfrastructureConfigureExascaleManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#update DatabaseCloudExadataInfrastructureConfigureExascaleManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
