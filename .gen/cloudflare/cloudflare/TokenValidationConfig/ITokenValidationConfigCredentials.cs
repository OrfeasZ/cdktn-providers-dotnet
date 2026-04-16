using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationConfig
{
    [JsiiInterface(nativeType: typeof(ITokenValidationConfigCredentials), fullyQualifiedName: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentials")]
    public interface ITokenValidationConfigCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#keys TokenValidationConfig#keys}.</summary>
        [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys\"},\"kind\":\"array\"}}]}}")]
        object Keys
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationConfigCredentials), fullyQualifiedName: "cloudflare.tokenValidationConfig.TokenValidationConfigCredentials")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationConfig.ITokenValidationConfigCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_config#keys TokenValidationConfig#keys}.</summary>
            [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationConfig.TokenValidationConfigCredentialsKeys\"},\"kind\":\"array\"}}]}}")]
            public object Keys
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
