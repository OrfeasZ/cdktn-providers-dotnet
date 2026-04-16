using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionBindingsOutbound")]
    public class WorkerVersionBindingsOutbound : cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound
    {
        private object? _params;

        /// <summary>Pass information from the Dispatch Worker to the Outbound Worker through the parameters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#params WorkerVersion#params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "params", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Params
        {
            get => _params;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundParams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundParams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _params = value;
            }
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#worker WorkerVersion#worker}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutboundWorker\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionBindingsOutboundWorker? Worker
        {
            get;
            set;
        }
    }
}
