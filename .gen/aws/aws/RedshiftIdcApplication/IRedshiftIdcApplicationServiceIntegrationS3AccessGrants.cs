using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiInterface(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationS3AccessGrants), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants")]
    public interface IRedshiftIdcApplicationServiceIntegrationS3AccessGrants
    {
        /// <summary>read_write_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/redshift_idc_application#read_write_access RedshiftIdcApplication#read_write_access}
        /// </remarks>
        [JsiiProperty(name: "readWriteAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsReadWriteAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadWriteAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftIdcApplicationServiceIntegrationS3AccessGrants), fullyQualifiedName: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>read_write_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/redshift_idc_application#read_write_access RedshiftIdcApplication#read_write_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readWriteAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsReadWriteAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ReadWriteAccess
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
