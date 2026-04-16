using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecWorkerAutoscalingMetricsOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecWorkerAutoscalingMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecWorkerAutoscalingMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecWorkerAutoscalingMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecWorkerAutoscalingMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecWorkerAutoscalingMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetricsCpu\"}}]")]
        public virtual void PutCpu(digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetricsCpuOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerAutoscalingMetricsCpuOutputReference Cpu
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerAutoscalingMetricsCpuOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetricsCpu\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu? CpuInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerAutoscalingMetricsCpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetrics\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerAutoscalingMetrics? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerAutoscalingMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
