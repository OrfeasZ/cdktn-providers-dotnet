using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaaWebAppAccelerationPolicy
{
    [JsiiInterface(nativeType: typeof(IWaaWebAppAccelerationPolicyResponseCachingPolicy), fullyQualifiedName: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCachingPolicy")]
    public interface IWaaWebAppAccelerationPolicyResponseCachingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waa_web_app_acceleration_policy#is_response_header_based_caching_enabled WaaWebAppAccelerationPolicy#is_response_header_based_caching_enabled}.</summary>
        [JsiiProperty(name: "isResponseHeaderBasedCachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsResponseHeaderBasedCachingEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaaWebAppAccelerationPolicyResponseCachingPolicy), fullyQualifiedName: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCachingPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCachingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waa_web_app_acceleration_policy#is_response_header_based_caching_enabled WaaWebAppAccelerationPolicy#is_response_header_based_caching_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isResponseHeaderBasedCachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsResponseHeaderBasedCachingEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
