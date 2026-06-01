using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiInterface(nativeType: typeof(IContainerStartupProbe), fullyQualifiedName: "scaleway.container.ContainerStartupProbe")]
    public interface IContainerStartupProbe
    {
        /// <summary>Number of consecutive failures before considering the container has to be restarted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
        /// </remarks>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double FailureThreshold
        {
            get;
        }

        /// <summary>Time interval between checks (in duration notation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>Duration before the check times out (in duration notation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#timeout Container#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        string Timeout
        {
            get;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbeHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.Container.IContainerStartupProbeHttp? Http
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

        [JsiiTypeProxy(nativeType: typeof(IContainerStartupProbe), fullyQualifiedName: "scaleway.container.ContainerStartupProbe")]
        internal sealed class _Proxy : DeputyBase, scaleway.Container.IContainerStartupProbe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of consecutive failures before considering the container has to be restarted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
            /// </remarks>
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double FailureThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Time interval between checks (in duration notation).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Duration before the check times out (in duration notation).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#timeout Container#timeout}
            /// </remarks>
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
            public string Timeout
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbeHttp\"}", isOptional: true)]
            public scaleway.Container.IContainerStartupProbeHttp? Http
            {
                get => GetInstanceProperty<scaleway.Container.IContainerStartupProbeHttp?>();
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
