using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiByValue(fqn: "scaleway.container.ContainerHealthCheck")]
    public class ContainerHealthCheck : scaleway.Container.IContainerHealthCheck
    {
        /// <summary>Number of consecutive health check failures before considering the container unhealthy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerHealthCheckHttp\"}", isOptional: true)]
        public scaleway.Container.IContainerHealthCheckHttp? Http
        {
            get;
            set;
        }

        /// <summary>Period between health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Interval
        {
            get;
            set;
        }

        private object? _tcp;

        /// <summary>Perform TCP check on the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#tcp Container#tcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Tcp
        {
            get => _tcp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tcp = value;
            }
        }
    }
}
