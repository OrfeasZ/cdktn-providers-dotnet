using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiInterface(nativeType: typeof(ITransferConnectorEgressConfig), fullyQualifiedName: "aws.transferConnector.TransferConnectorEgressConfig")]
    public interface ITransferConnectorEgressConfig
    {
        /// <summary>vpc_lattice block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_connector#vpc_lattice TransferConnector#vpc_lattice}
        /// </remarks>
        [JsiiProperty(name: "vpcLattice", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLattice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice? VpcLattice
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferConnectorEgressConfig), fullyQualifiedName: "aws.transferConnector.TransferConnectorEgressConfig")]
        internal sealed class _Proxy : DeputyBase, aws.TransferConnector.ITransferConnectorEgressConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>vpc_lattice block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_connector#vpc_lattice TransferConnector#vpc_lattice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcLattice", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLattice\"}", isOptional: true)]
            public aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice? VpcLattice
            {
                get => GetInstanceProperty<aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice?>();
            }
        }
    }
}
