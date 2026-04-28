using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceAutoscalingMetrics), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingMetrics")]
    public interface IAppSpecServiceAutoscalingMetrics
    {
        /// <summary>cpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cpu App#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu? Cpu
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceAutoscalingMetrics), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingMetrics")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceAutoscalingMetrics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cpu block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cpu App#cpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetricsCpu\"}", isOptional: true)]
            public digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu? Cpu
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu?>();
            }
        }
    }
}
