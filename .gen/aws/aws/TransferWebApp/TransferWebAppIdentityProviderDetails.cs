using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiByValue(fqn: "aws.transferWebApp.TransferWebAppIdentityProviderDetails")]
    public class TransferWebAppIdentityProviderDetails : aws.TransferWebApp.ITransferWebAppIdentityProviderDetails
    {
        private object? _identityCenterConfig;

        /// <summary>identity_center_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#identity_center_config TransferWebApp#identity_center_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenterConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityCenterConfig
        {
            get => _identityCenterConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.TransferWebApp.ITransferWebAppIdentityProviderDetailsIdentityCenterConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.TransferWebApp.ITransferWebAppIdentityProviderDetailsIdentityCenterConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityCenterConfig = value;
            }
        }
    }
}
