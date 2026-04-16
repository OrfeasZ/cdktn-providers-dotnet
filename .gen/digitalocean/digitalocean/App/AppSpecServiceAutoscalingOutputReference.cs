using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecServiceAutoscalingOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecServiceAutoscalingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecServiceAutoscalingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecServiceAutoscalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceAutoscalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetrics\"}}]")]
        public virtual void PutMetrics(digitalocean.App.IAppSpecServiceAutoscalingMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceAutoscalingMetrics)}, new object[]{@value});
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceAutoscalingMetricsOutputReference Metrics
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceAutoscalingMetricsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetrics\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceAutoscalingMetrics? MetricsInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscalingMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscaling\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceAutoscaling? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
