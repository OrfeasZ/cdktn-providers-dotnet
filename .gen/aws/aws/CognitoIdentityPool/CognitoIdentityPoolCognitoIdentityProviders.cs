using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoIdentityPool
{
    [JsiiByValue(fqn: "aws.cognitoIdentityPool.CognitoIdentityPoolCognitoIdentityProviders")]
    public class CognitoIdentityPoolCognitoIdentityProviders : aws.CognitoIdentityPool.ICognitoIdentityPoolCognitoIdentityProviders
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_identity_pool#client_id CognitoIdentityPool#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_identity_pool#provider_name CognitoIdentityPool#provider_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProviderName
        {
            get;
            set;
        }

        private object? _serverSideTokenCheck;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_identity_pool#server_side_token_check CognitoIdentityPool#server_side_token_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideTokenCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ServerSideTokenCheck
        {
            get => _serverSideTokenCheck;
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
                _serverSideTokenCheck = value;
            }
        }
    }
}
