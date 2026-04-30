using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiInterface(nativeType: typeof(IEc2NetworkInsightsAccessScopeMatchPathsDestination), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestination")]
    public interface IEc2NetworkInsightsAccessScopeMatchPathsDestination
    {
        /// <summary>packet_header_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#packet_header_statement Ec2NetworkInsightsAccessScope#packet_header_statement}
        /// </remarks>
        [JsiiProperty(name: "packetHeaderStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestinationPacketHeaderStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PacketHeaderStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resource_statement Ec2NetworkInsightsAccessScope#resource_statement}
        /// </remarks>
        [JsiiProperty(name: "resourceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestinationResourceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2NetworkInsightsAccessScopeMatchPathsDestination), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>packet_header_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#packet_header_statement Ec2NetworkInsightsAccessScope#packet_header_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "packetHeaderStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestinationPacketHeaderStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PacketHeaderStatement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resource_statement Ec2NetworkInsightsAccessScope#resource_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestinationResourceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceStatement
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
