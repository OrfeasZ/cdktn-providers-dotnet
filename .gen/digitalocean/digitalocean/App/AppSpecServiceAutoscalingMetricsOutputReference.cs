using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecServiceAutoscalingMetricsOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecServiceAutoscalingMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecServiceAutoscalingMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecServiceAutoscalingMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceAutoscalingMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpu\"}}]")]
        public virtual void PutCpu(digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpuOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceAutoscalingMetricsCpuOutputReference Cpu
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceAutoscalingMetricsCpuOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpu\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu? CpuInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetrics\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceAutoscalingMetrics? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscalingMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
