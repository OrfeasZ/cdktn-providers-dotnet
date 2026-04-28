using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcAcl
{
    [JsiiByValue(fqn: "scaleway.vpcAcl.VpcAclRules")]
    public class VpcAclRules : scaleway.VpcAcl.IVpcAclRules
    {
        /// <summary>The policy to apply to the packet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#action VpcAcl#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>The rule description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#description VpcAcl#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Destination IP range to which this rule applies (CIDR notation with subnet mask).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#destination VpcAcl#destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Destination
        {
            get;
            set;
        }

        /// <summary>Ending port of the destination port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#dst_port_high VpcAcl#dst_port_high}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dstPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DstPortHigh
        {
            get;
            set;
        }

        /// <summary>Starting port of the destination port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#dst_port_low VpcAcl#dst_port_low}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dstPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DstPortLow
        {
            get;
            set;
        }

        /// <summary>The protocol to which this rule applies. Default value: ANY.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#protocol VpcAcl#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Source IP range to which this rule applies (CIDR notation with subnet mask).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#source VpcAcl#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Ending port of the source port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#src_port_high VpcAcl#src_port_high}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "srcPortHigh", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SrcPortHigh
        {
            get;
            set;
        }

        /// <summary>Starting port of the source port range to which this rule applies (inclusive).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/vpc_acl#src_port_low VpcAcl#src_port_low}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "srcPortLow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SrcPortLow
        {
            get;
            set;
        }
    }
}
