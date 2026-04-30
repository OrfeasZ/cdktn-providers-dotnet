using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiInterface(nativeType: typeof(IEc2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement")]
    public interface IEc2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_addresses Ec2NetworkInsightsAccessScope#destination_addresses}.</summary>
        [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_ports Ec2NetworkInsightsAccessScope#destination_ports}.</summary>
        [JsiiProperty(name: "destinationPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_prefix_lists Ec2NetworkInsightsAccessScope#destination_prefix_lists}.</summary>
        [JsiiProperty(name: "destinationPrefixLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DestinationPrefixLists
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#protocols Ec2NetworkInsightsAccessScope#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_addresses Ec2NetworkInsightsAccessScope#source_addresses}.</summary>
        [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_ports Ec2NetworkInsightsAccessScope#source_ports}.</summary>
        [JsiiProperty(name: "sourcePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourcePorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_prefix_lists Ec2NetworkInsightsAccessScope#source_prefix_lists}.</summary>
        [JsiiProperty(name: "sourcePrefixLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourcePrefixLists
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement), fullyQualifiedName: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsSourcePacketHeaderStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_addresses Ec2NetworkInsightsAccessScope#destination_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_ports Ec2NetworkInsightsAccessScope#destination_ports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationPorts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination_prefix_lists Ec2NetworkInsightsAccessScope#destination_prefix_lists}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPrefixLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DestinationPrefixLists
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#protocols Ec2NetworkInsightsAccessScope#protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Protocols
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_addresses Ec2NetworkInsightsAccessScope#source_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_ports Ec2NetworkInsightsAccessScope#source_ports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourcePorts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source_prefix_lists Ec2NetworkInsightsAccessScope#source_prefix_lists}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePrefixLists", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourcePrefixLists
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
