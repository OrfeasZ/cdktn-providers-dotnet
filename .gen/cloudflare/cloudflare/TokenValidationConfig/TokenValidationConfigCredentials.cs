using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentials")]
    public class TokenValidationConfigCredentials : cloudflare.TokenValidationConfig.ITokenValidationConfigCredentials
    {
        private object _keys;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#keys TokenValidationConfig#keys}.</summary>
        [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys\"},\"kind\":\"array\"}}]}}")]
        public object Keys
        {
            get => _keys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.TokenValidationConfig.ITokenValidationConfigCredentialsKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.TokenValidationConfig.ITokenValidationConfigCredentialsKeys).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.TokenValidationConfig.ITokenValidationConfigCredentialsKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keys = value;
            }
        }
    }
}
