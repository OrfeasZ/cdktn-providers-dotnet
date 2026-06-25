using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiClass(nativeType: typeof(oci.GoldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGatePipelineProcessOptionsInitialDataLoadOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActionOnExistingTable")]
        public virtual void ResetActionOnExistingTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdbWalletPath")]
        public virtual void ResetAdbWalletPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialLoadType")]
        public virtual void ResetInitialLoadType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceWalletPath")]
        public virtual void ResetSourceWalletPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetWalletPath")]
        public virtual void ResetTargetWalletPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnExistingTableInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnExistingTableInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adbWalletPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdbWalletPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialLoadTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialLoadTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isInitialLoadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IsInitialLoadInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceWalletPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceWalletPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetWalletPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetWalletPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnExistingTable
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adbWalletPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdbWalletPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialLoadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialLoadType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsInitialLoad
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceWalletPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceWalletPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetWalletPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetWalletPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}", isOptional: true)]
        public virtual oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad?>();
            set => SetInstanceProperty(value);
        }
    }
}
