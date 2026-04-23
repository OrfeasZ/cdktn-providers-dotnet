using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiInterface(nativeType: typeof(ITransferWebAppIdentityProviderDetailsIdentityCenterConfig), fullyQualifiedName: "aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig")]
    public interface ITransferWebAppIdentityProviderDetailsIdentityCenterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_web_app#instance_arn TransferWebApp#instance_arn}.</summary>
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_web_app#role TransferWebApp#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWebAppIdentityProviderDetailsIdentityCenterConfig), fullyQualifiedName: "aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWebApp.ITransferWebAppIdentityProviderDetailsIdentityCenterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_web_app#instance_arn TransferWebApp#instance_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_web_app#role TransferWebApp#role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
