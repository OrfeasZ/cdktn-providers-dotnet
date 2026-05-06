using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudExadataInfrastructureCustomerContacts), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureCustomerContacts")]
    public interface IDatabaseCloudExadataInfrastructureCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#email DatabaseCloudExadataInfrastructure#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudExadataInfrastructureCustomerContacts), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureCustomerContacts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureCustomerContacts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#email DatabaseCloudExadataInfrastructure#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
