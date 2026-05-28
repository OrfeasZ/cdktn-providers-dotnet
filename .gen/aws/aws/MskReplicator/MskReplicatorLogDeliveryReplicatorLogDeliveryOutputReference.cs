using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiClass(nativeType: typeof(aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskReplicatorLogDeliveryReplicatorLogDeliveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehose\"}}]")]
        public virtual void PutFirehose(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3\"}}]")]
        public virtual void PutS3(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogsOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehoseOutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3OutputReference\"}")]
        public virtual aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3OutputReference S3
        {
            get => GetInstanceProperty<aws.MskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryFirehose\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDeliveryS3\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3? S3Input
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDeliveryS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}", isOptional: true)]
        public virtual aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery? InternalValue
        {
            get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery?>();
            set => SetInstanceProperty(value);
        }
    }
}
