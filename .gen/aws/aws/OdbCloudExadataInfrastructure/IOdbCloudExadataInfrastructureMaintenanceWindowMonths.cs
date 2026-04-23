using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IOdbCloudExadataInfrastructureMaintenanceWindowMonths), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowMonths")]
    public interface IOdbCloudExadataInfrastructureMaintenanceWindowMonths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_exadata_infrastructure#name OdbCloudExadataInfrastructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudExadataInfrastructureMaintenanceWindowMonths), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindowMonths")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureMaintenanceWindowMonths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_exadata_infrastructure#name OdbCloudExadataInfrastructure#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
