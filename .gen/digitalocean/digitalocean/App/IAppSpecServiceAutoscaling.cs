using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceAutoscaling), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscaling")]
    public interface IAppSpecServiceAutoscaling
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
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetrics\"}")]
        digitalocean.App.IAppSpecServiceAutoscalingMetrics Metrics
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

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceAutoscaling), fullyQualifiedName: "digitalocean.app.AppSpecServiceAutoscaling")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceAutoscaling
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
            [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingMetrics\"}")]
            public digitalocean.App.IAppSpecServiceAutoscalingMetrics Metrics
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscalingMetrics>()!;
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
