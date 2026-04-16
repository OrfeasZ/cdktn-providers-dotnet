using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions")]
    public class ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions
    {
        private object? _returnAccessTokenFromAuthorizationEndpoint;

        /// <summary>If an Access Token should be returned from the OIDC Authorization endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#return_access_token_from_authorization_endpoint ZeroTrustAccessApplication#return_access_token_from_authorization_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnAccessTokenFromAuthorizationEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReturnAccessTokenFromAuthorizationEndpoint
        {
            get => _returnAccessTokenFromAuthorizationEndpoint;
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
                _returnAccessTokenFromAuthorizationEndpoint = value;
            }
        }

        private object? _returnIdTokenFromAuthorizationEndpoint;

        /// <summary>If an ID Token should be returned from the OIDC Authorization endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#return_id_token_from_authorization_endpoint ZeroTrustAccessApplication#return_id_token_from_authorization_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnIdTokenFromAuthorizationEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReturnIdTokenFromAuthorizationEndpoint
        {
            get => _returnIdTokenFromAuthorizationEndpoint;
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
                _returnIdTokenFromAuthorizationEndpoint = value;
            }
        }
    }
}
