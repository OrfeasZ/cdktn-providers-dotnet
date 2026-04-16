using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InferenceDeployment
{
    [JsiiInterface(nativeType: typeof(IInferenceDeploymentPublicEndpoint), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint")]
    public interface IInferenceDeploymentPublicEndpoint
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

        /// <summary>Enable or disable public endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#is_enabled InferenceDeployment#is_enabled}
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInferenceDeploymentPublicEndpoint), fullyQualifiedName: "scaleway.inferenceDeployment.InferenceDeploymentPublicEndpoint")]
        internal sealed class _Proxy : DeputyBase, scaleway.InferenceDeployment.IInferenceDeploymentPublicEndpoint
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

            /// <summary>Enable or disable public endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/inference_deployment#is_enabled InferenceDeployment#is_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
