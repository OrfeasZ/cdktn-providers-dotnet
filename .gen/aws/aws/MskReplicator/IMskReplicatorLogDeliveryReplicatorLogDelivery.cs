using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorLogDeliveryReplicatorLogDelivery), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery")]
    public interface IMskReplicatorLogDeliveryReplicatorLogDelivery
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#cloudwatch_logs MskReplicator#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#firehose MskReplicator#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#s3 MskReplicator#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorLogDeliveryReplicatorLogDelivery), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#cloudwatch_logs MskReplicator#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#firehose MskReplicator#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehose\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose? Firehose
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#s3 MskReplicator#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3? S3
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3?>();
            }
        }
    }
}
