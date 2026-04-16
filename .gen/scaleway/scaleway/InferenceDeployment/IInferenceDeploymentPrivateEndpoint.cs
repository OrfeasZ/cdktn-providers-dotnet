using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InferenceDeployment
{
    [JsiiInterface(nativeType: typeof(IInferenceDeploymentPrivateEndpoint), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint")]
    public interface IInferenceDeploymentPrivateEndpoint
    {
        /// <summary>Disable the authentication on the endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#disable_auth InferenceDeployment#disable_auth}
        /// </remarks>
        [JsiiProperty(name: "disableAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>The id of the private network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_network_id InferenceDeployment#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateNetworkId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInferenceDeploymentPrivateEndpoint), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentPrivateEndpoint")]
        internal sealed class _Proxy : DeputyBase, scaleway.InferenceDeployment.IInferenceDeploymentPrivateEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Disable the authentication on the endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#disable_auth InferenceDeployment#disable_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableAuth
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The id of the private network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#private_network_id InferenceDeployment#private_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateNetworkId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
