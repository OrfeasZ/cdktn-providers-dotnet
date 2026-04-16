using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiInterface(nativeType: typeof(ITransferWebAppEndpointDetails), fullyQualifiedName: "aws.transferWebApp.TransferWebAppEndpointDetails")]
    public interface ITransferWebAppEndpointDetails
    {
        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#vpc TransferWebApp#vpc}
        /// </remarks>
        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppEndpointDetailsVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Vpc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWebAppEndpointDetails), fullyQualifiedName: "aws.transferWebApp.TransferWebAppEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWebApp.ITransferWebAppEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>vpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#vpc TransferWebApp#vpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.transferWebApp.TransferWebAppEndpointDetailsVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Vpc
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
