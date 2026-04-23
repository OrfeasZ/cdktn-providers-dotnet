using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IOdbCloudExadataInfrastructureCustomerContactsToSendToOci), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureCustomerContactsToSendToOci")]
    public interface IOdbCloudExadataInfrastructureCustomerContactsToSendToOci
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_exadata_infrastructure#email OdbCloudExadataInfrastructure#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudExadataInfrastructureCustomerContactsToSendToOci), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureCustomerContactsToSendToOci")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureCustomerContactsToSendToOci
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_exadata_infrastructure#email OdbCloudExadataInfrastructure#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
