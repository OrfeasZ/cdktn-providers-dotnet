using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiByValue(fqn: "aws.transferConnector.TransferConnectorEgressConfig")]
    public class TransferConnectorEgressConfig : aws.TransferConnector.ITransferConnectorEgressConfig
    {
        /// <summary>vpc_lattice block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_connector#vpc_lattice TransferConnector#vpc_lattice}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcLattice", typeJson: "{\"fqn\":\"aws.transferConnector.TransferConnectorEgressConfigVpcLattice\"}", isOptional: true)]
        public aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice? VpcLattice
        {
            get;
            set;
        }
    }
}
