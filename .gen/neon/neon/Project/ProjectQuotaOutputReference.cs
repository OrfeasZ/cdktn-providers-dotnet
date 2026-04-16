using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiClass(nativeType: typeof(neon.Project.ProjectQuotaOutputReference), fullyQualifiedName: "neon.project.ProjectQuotaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ProjectQuotaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ProjectQuotaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ProjectQuotaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProjectQuotaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActiveTimeSeconds")]
        public virtual void ResetActiveTimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeTimeSeconds")]
        public virtual void ResetComputeTimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataTransferBytes")]
        public virtual void ResetDataTransferBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogicalSizeBytes")]
        public virtual void ResetLogicalSizeBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWrittenDataBytes")]
        public virtual void ResetWrittenDataBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeTimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ActiveTimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ComputeTimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTransferBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataTransferBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalSizeBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogicalSizeBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writtenDataBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WrittenDataBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "activeTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActiveTimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeTimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataTransferBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataTransferBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logicalSizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogicalSizeBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writtenDataBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WrittenDataBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"neon.project.ProjectQuota\"}", isOptional: true)]
        public virtual neon.Project.IProjectQuota? InternalValue
        {
            get => GetInstanceProperty<neon.Project.IProjectQuota?>();
            set => SetInstanceProperty(value);
        }
    }
}
