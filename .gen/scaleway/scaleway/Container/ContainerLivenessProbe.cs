using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.container.ContainerLivenessProbe")]
    public class ContainerLivenessProbe : scaleway.Container.IContainerLivenessProbe
    {
        /// <summary>Number of consecutive failures before considering the container has to be restarted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#failure_threshold Container#failure_threshold}
        /// </remarks>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public double FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Time interval between checks (in duration notation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#interval Container#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Duration before the check times out (in duration notation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#timeout Container#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public string Timeout
        {
            get;
            set;
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container#http Container#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"scaleway.container.ContainerLivenessProbeHttp\"}", isOptional: true)]
        public scaleway.Container.IContainerLivenessProbeHttp? Http
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
