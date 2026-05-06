using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaaWebAppAccelerationPolicy
{
    [JsiiByValue(fqn: "oci.waaWebAppAccelerationPolicy.WaaWebAppAccelerationPolicyResponseCachingPolicy")]
    public class WaaWebAppAccelerationPolicyResponseCachingPolicy : oci.WaaWebAppAccelerationPolicy.IWaaWebAppAccelerationPolicyResponseCachingPolicy
    {
        private object? _isResponseHeaderBasedCachingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waa_web_app_acceleration_policy#is_response_header_based_caching_enabled WaaWebAppAccelerationPolicy#is_response_header_based_caching_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isResponseHeaderBasedCachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsResponseHeaderBasedCachingEnabled
        {
            get => _isResponseHeaderBasedCachingEnabled;
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
                _isResponseHeaderBasedCachingEnabled = value;
            }
        }
    }
}
