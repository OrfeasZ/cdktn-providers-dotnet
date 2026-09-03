using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdacoreNetworkConnector
{
    [JsiiInterface(nativeType: typeof(ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration), fullyQualifiedName: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration")]
    public interface ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#associated_compute_resource_types LambdacoreNetworkConnector#associated_compute_resource_types}.</summary>
        [JsiiProperty(name: "associatedComputeResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AssociatedComputeResourceTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#security_group_ids LambdacoreNetworkConnector#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#subnet_ids LambdacoreNetworkConnector#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#network_protocol LambdacoreNetworkConnector#network_protocol}.</summary>
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration), fullyQualifiedName: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#associated_compute_resource_types LambdacoreNetworkConnector#associated_compute_resource_types}.</summary>
            [JsiiProperty(name: "associatedComputeResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AssociatedComputeResourceTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#security_group_ids LambdacoreNetworkConnector#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#subnet_ids LambdacoreNetworkConnector#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#network_protocol LambdacoreNetworkConnector#network_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
