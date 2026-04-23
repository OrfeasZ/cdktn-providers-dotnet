using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    [JsiiByValue(fqn: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration")]
    public class TimestreaminfluxdbDbClusterLogDeliveryConfiguration : aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfiguration
    {
        private object? _s3Configuration;

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreaminfluxdb_db_cluster#s3_configuration TimestreaminfluxdbDbCluster#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Configuration
        {
            get => _s3Configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Configuration = value;
            }
        }
    }
}
