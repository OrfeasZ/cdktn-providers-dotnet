using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceAutoscalingMetricsCpu), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingMetricsCpu")]
    public interface IAppSpecServiceAutoscalingMetricsCpu
    {
        /// <summary>The average target CPU utilization for the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#percent App#percent}
        /// </remarks>
        [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}")]
        double Percent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceAutoscalingMetricsCpu), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscalingMetricsCpu")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceAutoscalingMetricsCpu
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The average target CPU utilization for the component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#percent App#percent}
            /// </remarks>
            [JsiiProperty(name: "percent", typeJson: "{\"primitive\":\"number\"}")]
            public double Percent
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
