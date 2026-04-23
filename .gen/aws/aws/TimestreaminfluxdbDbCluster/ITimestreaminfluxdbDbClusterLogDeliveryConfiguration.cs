using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    [JsiiInterface(nativeType: typeof(ITimestreaminfluxdbDbClusterLogDeliveryConfiguration), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration")]
    public interface ITimestreaminfluxdbDbClusterLogDeliveryConfiguration
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreaminfluxdb_db_cluster#s3_configuration TimestreaminfluxdbDbCluster#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Configuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreaminfluxdbDbClusterLogDeliveryConfiguration), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/timestreaminfluxdb_db_cluster#s3_configuration TimestreaminfluxdbDbCluster#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Configuration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
