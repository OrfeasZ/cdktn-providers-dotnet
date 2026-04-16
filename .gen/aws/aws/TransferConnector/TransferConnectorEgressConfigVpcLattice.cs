using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferConnector.TransferConnectorEgressConfigVpcLattice")]
    public class TransferConnectorEgressConfigVpcLattice : aws.TransferConnector.ITransferConnectorEgressConfigVpcLattice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_connector#resource_configuration_arn TransferConnector#resource_configuration_arn}.</summary>
        [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceConfigurationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_connector#port_number TransferConnector#port_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PortNumber
        {
            get;
            set;
        }
    }
}
