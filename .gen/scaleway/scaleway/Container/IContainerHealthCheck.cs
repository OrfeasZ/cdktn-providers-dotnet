using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiInterface(nativeType: typeof(IContainerHealthCheck), fullyQualifiedName: "scaleway.container.ContainerHealthCheck")]
    public interface IContainerHealthCheck
    {
        /// <summary>Number of consecutive health check failures before considering the container unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
        /// </remarks>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerHealthCheckHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.Container.IContainerHealthCheckHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>Period between health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Perform TCP check on the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#tcp Container#tcp}
        /// </remarks>
        [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tcp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerHealthCheck), fullyQualifiedName: "scaleway.container.ContainerHealthCheck")]
        internal sealed class _Proxy : DeputyBase, scaleway.Container.IContainerHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of consecutive health check failures before considering the container unhealthy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerHealthCheckHttp\"}", isOptional: true)]
            public scaleway.Container.IContainerHealthCheckHttp? Http
            {
                get => GetInstanceProperty<scaleway.Container.IContainerHealthCheckHttp?>();
            }

            /// <summary>Period between health checks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Interval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Perform TCP check on the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#tcp Container#tcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Tcp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
