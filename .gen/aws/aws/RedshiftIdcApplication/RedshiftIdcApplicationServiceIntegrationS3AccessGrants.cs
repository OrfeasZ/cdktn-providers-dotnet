using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftIdcApplication
{
    [JsiiByValue(fqn: "aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrants")]
    public class RedshiftIdcApplicationServiceIntegrationS3AccessGrants : aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrants
    {
        private object? _readWriteAccess;

        /// <summary>read_write_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/redshift_idc_application#read_write_access RedshiftIdcApplication#read_write_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readWriteAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.redshiftIdcApplication.RedshiftIdcApplicationServiceIntegrationS3AccessGrantsReadWriteAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ReadWriteAccess
        {
            get => _readWriteAccess;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrantsReadWriteAccess[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.RedshiftIdcApplication.IRedshiftIdcApplicationServiceIntegrationS3AccessGrantsReadWriteAccess).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readWriteAccess = value;
            }
        }
    }
}
