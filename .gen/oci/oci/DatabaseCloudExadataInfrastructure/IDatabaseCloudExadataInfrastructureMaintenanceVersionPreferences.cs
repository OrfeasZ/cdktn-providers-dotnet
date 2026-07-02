using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceVersionPreferences), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceVersionPreferences")]
    public interface IDatabaseCloudExadataInfrastructureMaintenanceVersionPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_cloud_exadata_infrastructure#reference_resource_id_for_image_updates DatabaseCloudExadataInfrastructure#reference_resource_id_for_image_updates}.</summary>
        [JsiiProperty(name: "referenceResourceIdForImageUpdates", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReferenceResourceIdForImageUpdates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceVersionPreferences), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceVersionPreferences")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureMaintenanceVersionPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_cloud_exadata_infrastructure#reference_resource_id_for_image_updates DatabaseCloudExadataInfrastructure#reference_resource_id_for_image_updates}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "referenceResourceIdForImageUpdates", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReferenceResourceIdForImageUpdates
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
