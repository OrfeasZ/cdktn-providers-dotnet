using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiClass(nativeType: typeof(aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatasetFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat\"}}]")]
        public virtual void PutDatasetFormat(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEndTimeOffset")]
        public virtual void ResetEndTimeOffset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeFeaturesAttribute")]
        public virtual void ResetExcludeFeaturesAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeaturesAttribute")]
        public virtual void ResetFeaturesAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAttribute")]
        public virtual void ResetInferenceAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProbabilityAttribute")]
        public virtual void ResetProbabilityAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProbabilityThresholdAttribute")]
        public virtual void ResetProbabilityThresholdAttribute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3DataDistributionType")]
        public virtual void ResetS3DataDistributionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3InputMode")]
        public virtual void ResetS3InputMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartTimeOffset")]
        public virtual void ResetStartTimeOffset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "datasetFormat", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatOutputReference\"}")]
        public virtual aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatOutputReference DatasetFormat
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCapturedDestinationS3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataCapturedDestinationS3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetFormatInput", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat? DatasetFormatInput
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInputDatasetFormat?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endTimeOffsetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndTimeOffsetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeFeaturesAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcludeFeaturesAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeaturesAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InferenceAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "probabilityAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProbabilityAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "probabilityThresholdAttributeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProbabilityThresholdAttributeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DataDistributionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3DataDistributionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3InputModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3InputModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startTimeOffsetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartTimeOffsetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataCapturedDestinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCapturedDestinationS3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endTimeOffset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTimeOffset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludeFeaturesAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcludeFeaturesAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featuresAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeaturesAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferenceAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "probabilityAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProbabilityAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "probabilityThresholdAttribute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProbabilityThresholdAttribute
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3DataDistributionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3DataDistributionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3InputMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3InputMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startTimeOffset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTimeOffset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput\"}", isOptional: true)]
        public virtual aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsBatchTransformInput?>();
            set => SetInstanceProperty(value);
        }
    }
}
