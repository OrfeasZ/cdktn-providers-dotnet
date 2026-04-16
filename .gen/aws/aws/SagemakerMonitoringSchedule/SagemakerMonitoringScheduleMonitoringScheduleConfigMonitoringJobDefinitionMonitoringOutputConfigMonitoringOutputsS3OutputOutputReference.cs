using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiClass(nativeType: typeof(aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3OutputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetS3UploadMode")]
        public virtual void ResetS3UploadMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "localPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3UploadModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3UploadModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3UploadMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3UploadMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output?>();
            set => SetInstanceProperty(value);
        }
    }
}
