using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdacoreNetworkConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration")]
    public class LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration : aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#associated_compute_resource_types LambdacoreNetworkConnector#associated_compute_resource_types}.</summary>
        [JsiiProperty(name: "associatedComputeResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AssociatedComputeResourceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#security_group_ids LambdacoreNetworkConnector#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#subnet_ids LambdacoreNetworkConnector#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#network_protocol LambdacoreNetworkConnector#network_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkProtocol
        {
            get;
            set;
        }
    }
}
