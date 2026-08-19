using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiHostedApplicationIam
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfigOutputReference), fullyQualifiedName: "oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiHostedApplicationIamScalingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiHostedApplicationIamScalingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiHostedApplicationIamScalingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiHostedApplicationIamScalingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxReplica")]
        public virtual void ResetMaxReplica()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinReplica")]
        public virtual void ResetMinReplica()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetConcurrencyThreshold")]
        public virtual void ResetTargetConcurrencyThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCpuThreshold")]
        public virtual void ResetTargetCpuThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetMemoryThreshold")]
        public virtual void ResetTargetMemoryThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetRpsThreshold")]
        public virtual void ResetTargetRpsThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxReplicaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxReplicaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minReplicaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinReplicaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScalingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetConcurrencyThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetConcurrencyThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCpuThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetCpuThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetMemoryThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetRpsThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetRpsThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxReplica", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplica
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minReplica", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinReplica
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetConcurrencyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetConcurrencyThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCpuThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCpuThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetMemoryThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetMemoryThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetRpsThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetRpsThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiHostedApplicationIam.GenerativeAiHostedApplicationIamScalingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamScalingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiHostedApplicationIam.IGenerativeAiHostedApplicationIamScalingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
