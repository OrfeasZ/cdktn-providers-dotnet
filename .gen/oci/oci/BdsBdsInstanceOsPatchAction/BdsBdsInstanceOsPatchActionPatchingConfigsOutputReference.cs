using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceOsPatchAction
{
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference), fullyQualifiedName: "oci.bdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceOsPatchActionPatchingConfigsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToleranceThresholdPerBatch")]
        public virtual void ResetToleranceThresholdPerBatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToleranceThresholdPerDomain")]
        public virtual void ResetToleranceThresholdPerDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitTimeBetweenBatchInSeconds")]
        public virtual void ResetWaitTimeBetweenBatchInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitTimeBetweenDomainInSeconds")]
        public virtual void ResetWaitTimeBetweenDomainInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchingConfigStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatchingConfigStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toleranceThresholdPerBatchInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ToleranceThresholdPerBatchInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toleranceThresholdPerDomainInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ToleranceThresholdPerDomainInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimeBetweenBatchInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitTimeBetweenBatchInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimeBetweenDomainInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitTimeBetweenDomainInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patchingConfigStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingConfigStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toleranceThresholdPerBatch", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ToleranceThresholdPerBatch
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toleranceThresholdPerDomain", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ToleranceThresholdPerDomain
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitTimeBetweenBatchInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimeBetweenBatchInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitTimeBetweenDomainInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimeBetweenDomainInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceOsPatchAction.BdsBdsInstanceOsPatchActionPatchingConfigs\"}", isOptional: true)]
        public virtual oci.BdsBdsInstanceOsPatchAction.IBdsBdsInstanceOsPatchActionPatchingConfigs? InternalValue
        {
            get => GetInstanceProperty<oci.BdsBdsInstanceOsPatchAction.IBdsBdsInstanceOsPatchActionPatchingConfigs?>();
            set => SetInstanceProperty(value);
        }
    }
}
