using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiInterface(nativeType: typeof(ITransferWebAppWebAppUnits), fullyQualifiedName: "aws.transferWebApp.TransferWebAppWebAppUnits")]
    public interface ITransferWebAppWebAppUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#provisioned TransferWebApp#provisioned}.</summary>
        [JsiiProperty(name: "provisioned", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Provisioned
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWebAppWebAppUnits), fullyQualifiedName: "aws.transferWebApp.TransferWebAppWebAppUnits")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWebApp.ITransferWebAppWebAppUnits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#provisioned TransferWebApp#provisioned}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisioned", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Provisioned
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
