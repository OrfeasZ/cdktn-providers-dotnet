using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric\"}}]")]
        public virtual void PutMetric(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxMemoryPerNode")]
        public virtual void ResetMaxMemoryPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxOcpusPerNode")]
        public virtual void ResetMaxOcpusPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryStepSize")]
        public virtual void ResetMemoryStepSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetric")]
        public virtual void ResetMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpuStepSize")]
        public virtual void ResetOcpuStepSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetricOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetricOutputReference Metric
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetricOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxMemoryPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxMemoryPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxOcpusPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxOcpusPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryStepSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryStepSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric? MetricInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpuStepSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpuStepSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxMemoryPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxMemoryPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxOcpusPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxOcpusPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryStepSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpuStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuStepSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfig\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig? InternalValue
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
