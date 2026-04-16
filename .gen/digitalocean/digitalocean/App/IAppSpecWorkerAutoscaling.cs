using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerAutoscaling), fullyQualifiedName: "digitalocean.app.AppSpecWorkerAutoscaling")]
    public interface IAppSpecWorkerAutoscaling
    {
        /// <summary>The maximum amount of instances for this component. Must be more than min_instance_count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#max_instance_count App#max_instance_count}
        /// </remarks>
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxInstanceCount
        {
            get;
        }

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#metrics App#metrics}
        /// </remarks>
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetrics\"}")]
        digitalocean.App.IAppSpecWorkerAutoscalingMetrics Metrics
        {
            get;
        }

        /// <summary>The minimum amount of instances for this component. Must be less than max_instance_count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#min_instance_count App#min_instance_count}
        /// </remarks>
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinInstanceCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerAutoscaling), fullyQualifiedName: "digitalocean.app.AppSpecWorkerAutoscaling")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerAutoscaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum amount of instances for this component. Must be more than min_instance_count.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#max_instance_count App#max_instance_count}
            /// </remarks>
            [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#metrics App#metrics}
            /// </remarks>
            [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerAutoscalingMetrics\"}")]
            public digitalocean.App.IAppSpecWorkerAutoscalingMetrics Metrics
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerAutoscalingMetrics>()!;
            }

            /// <summary>The minimum amount of instances for this component. Must be less than max_instance_count.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#min_instance_count App#min_instance_count}
            /// </remarks>
            [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
