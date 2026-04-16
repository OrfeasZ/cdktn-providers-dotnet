using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiInterface(nativeType: typeof(IContainerHealthCheck), fullyQualifiedName: "scaleway.container.ContainerHealthCheck")]
    public interface IContainerHealthCheck
    {
        /// <summary>Number of consecutive health check failures before considering the container unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#failure_threshold Container#failure_threshold}
        /// </remarks>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double FailureThreshold
        {
            get;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#http Container#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerHealthCheckHttp\"},\"kind\":\"array\"}}]}}")]
        object Http
        {
            get;
        }

        /// <summary>Period between health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#interval Container#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerHealthCheck), fullyQualifiedName: "scaleway.container.ContainerHealthCheck")]
        internal sealed class _Proxy : DeputyBase, scaleway.Container.IContainerHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of consecutive health check failures before considering the container unhealthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#failure_threshold Container#failure_threshold}
            /// </remarks>
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double FailureThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#http Container#http}
            /// </remarks>
            [JsiiProperty(name: "http", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerHealthCheckHttp\"},\"kind\":\"array\"}}]}}")]
            public object Http
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Period between health checks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#interval Container#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
