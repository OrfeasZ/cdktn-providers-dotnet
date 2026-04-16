using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InferenceDeployment
{
    [JsiiByValue(fqn: "scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint")]
    public class InferenceDeploymentPrivateEndpoint : scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint
    {
        private object? _disableAuth;

        /// <summary>Disable the authentication on the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#disable_auth InferenceDeployment#disable_auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disableAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DisableAuth
        {
            get => _disableAuth;
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
                _disableAuth = value;
            }
        }

        /// <summary>The id of the private network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_network_id InferenceDeployment#private_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateNetworkId
        {
            get;
            set;
        }
    }
}
