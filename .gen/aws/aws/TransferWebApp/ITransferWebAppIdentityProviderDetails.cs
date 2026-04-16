using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiInterface(nativeType: typeof(ITransferWebAppIdentityProviderDetails), fullyQualifiedName: "aws.transferWebApp.TransferWebAppIdentityProviderDetails")]
    public interface ITransferWebAppIdentityProviderDetails
    {
        /// <summary>identity_center_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#identity_center_config TransferWebApp#identity_center_config}
        /// </remarks>
        [JsiiProperty(name: "identityCenterConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenterConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWebAppIdentityProviderDetails), fullyQualifiedName: "aws.transferWebApp.TransferWebAppIdentityProviderDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWebApp.ITransferWebAppIdentityProviderDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#identity_center_config TransferWebApp#identity_center_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenterConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenterConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
