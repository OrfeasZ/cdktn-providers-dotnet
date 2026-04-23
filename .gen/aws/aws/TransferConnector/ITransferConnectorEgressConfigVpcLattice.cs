using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiInterface(nativeType: typeof(ITransferConnectorEgressConfigVpcLattice), fullyQualifiedName: "aws.transferConnector.TransferConnectorEgressConfigVpcLattice")]
    public interface ITransferConnectorEgressConfigVpcLattice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_connector#resource_configuration_arn TransferConnector#resource_configuration_arn}.</summary>
        [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceConfigurationArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_connector#port_number TransferConnector#port_number}.</summary>
        [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PortNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferConnectorEgressConfigVpcLattice), fullyQualifiedName: "aws.transferConnector.TransferConnectorEgressConfigVpcLattice")]
        internal sealed class _Proxy : DeputyBase, aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_connector#resource_configuration_arn TransferConnector#resource_configuration_arn}.</summary>
            [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/transfer_connector#port_number TransferConnector#port_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PortNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
