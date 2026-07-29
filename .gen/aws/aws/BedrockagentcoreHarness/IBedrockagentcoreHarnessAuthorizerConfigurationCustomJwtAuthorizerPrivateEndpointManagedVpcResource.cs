using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource")]
    public interface IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#endpoint_ip_address_type BedrockagentcoreHarness#endpoint_ip_address_type}.</summary>
        [JsiiProperty(name: "endpointIpAddressType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointIpAddressType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#subnet_ids BedrockagentcoreHarness#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#vpc_identifier BedrockagentcoreHarness#vpc_identifier}.</summary>
        [JsiiProperty(name: "vpcIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string VpcIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#routing_domain BedrockagentcoreHarness#routing_domain}.</summary>
        [JsiiProperty(name: "routingDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#security_group_ids BedrockagentcoreHarness#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#tags BedrockagentcoreHarness#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointManagedVpcResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#endpoint_ip_address_type BedrockagentcoreHarness#endpoint_ip_address_type}.</summary>
            [JsiiProperty(name: "endpointIpAddressType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointIpAddressType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#subnet_ids BedrockagentcoreHarness#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#vpc_identifier BedrockagentcoreHarness#vpc_identifier}.</summary>
            [JsiiProperty(name: "vpcIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#routing_domain BedrockagentcoreHarness#routing_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#security_group_ids BedrockagentcoreHarness#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_harness#tags BedrockagentcoreHarness#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
