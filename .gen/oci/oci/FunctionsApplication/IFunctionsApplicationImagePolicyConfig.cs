using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiInterface(nativeType: typeof(IFunctionsApplicationImagePolicyConfig), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationImagePolicyConfig")]
    public interface IFunctionsApplicationImagePolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#is_policy_enabled FunctionsApplication#is_policy_enabled}.</summary>
        [JsiiProperty(name: "isPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsPolicyEnabled
        {
            get;
        }

        /// <summary>key_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#key_details FunctionsApplication#key_details}
        /// </remarks>
        [JsiiProperty(name: "keyDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeyDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsApplicationImagePolicyConfig), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationImagePolicyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsApplication.IFunctionsApplicationImagePolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#is_policy_enabled FunctionsApplication#is_policy_enabled}.</summary>
            [JsiiProperty(name: "isPolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsPolicyEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>key_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#key_details FunctionsApplication#key_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.functionsApplication.FunctionsApplicationImagePolicyConfigKeyDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeyDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
