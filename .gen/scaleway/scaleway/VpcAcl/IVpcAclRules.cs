using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcAcl
{
    [JsiiInterface(nativeType: typeof(IVpcAclRules), fullyQualifiedName: "scaleway.vpcAcl.VpcAclRules")]
    public interface IVpcAclRules
    {
        /// <summary>The policy to apply to the packet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#action VpcAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rule description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#description VpcAcl#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Destination IP range to which this rule applies (CIDR notation with subnet mask).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#destination VpcAcl#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Destination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ending port of the destination port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#dst_port_high VpcAcl#dst_port_high}
        /// </remarks>
        [JsiiProperty(name: "dstPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DstPortHigh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Starting port of the destination port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#dst_port_low VpcAcl#dst_port_low}
        /// </remarks>
        [JsiiProperty(name: "dstPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DstPortLow
        {
            get
            {
                return null;
            }
        }

        /// <summary>The protocol to which this rule applies. Default value: ANY.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#protocol VpcAcl#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Source IP range to which this rule applies (CIDR notation with subnet mask).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#source VpcAcl#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ending port of the source port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#src_port_high VpcAcl#src_port_high}
        /// </remarks>
        [JsiiProperty(name: "srcPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SrcPortHigh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Starting port of the source port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#src_port_low VpcAcl#src_port_low}
        /// </remarks>
        [JsiiProperty(name: "srcPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SrcPortLow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcAclRules), fullyQualifiedName: "scaleway.vpcAcl.VpcAclRules")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcAcl.IVpcAclRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The policy to apply to the packet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#action VpcAcl#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The rule description.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#description VpcAcl#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Destination IP range to which this rule applies (CIDR notation with subnet mask).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#destination VpcAcl#destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Destination
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Ending port of the destination port range to which this rule applies (inclusive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#dst_port_high VpcAcl#dst_port_high}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dstPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DstPortHigh
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Starting port of the destination port range to which this rule applies (inclusive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#dst_port_low VpcAcl#dst_port_low}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dstPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DstPortLow
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The protocol to which this rule applies. Default value: ANY.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#protocol VpcAcl#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Source IP range to which this rule applies (CIDR notation with subnet mask).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#source VpcAcl#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Ending port of the source port range to which this rule applies (inclusive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#src_port_high VpcAcl#src_port_high}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "srcPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SrcPortHigh
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Starting port of the source port range to which this rule applies (inclusive).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_acl#src_port_low VpcAcl#src_port_low}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "srcPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SrcPortLow
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
