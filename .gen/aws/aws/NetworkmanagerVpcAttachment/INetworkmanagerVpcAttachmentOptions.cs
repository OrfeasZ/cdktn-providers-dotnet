using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerVpcAttachment
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerVpcAttachmentOptions), fullyQualifiedName: "aws.networkmanagerVpcAttachment.NetworkmanagerVpcAttachmentOptions")]
    public interface INetworkmanagerVpcAttachmentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#appliance_mode_support NetworkmanagerVpcAttachment#appliance_mode_support}.</summary>
        [JsiiProperty(name: "applianceModeSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplianceModeSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#dns_support NetworkmanagerVpcAttachment#dns_support}.</summary>
        [JsiiProperty(name: "dnsSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DnsSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#ipv6_support NetworkmanagerVpcAttachment#ipv6_support}.</summary>
        [JsiiProperty(name: "ipv6Support", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6Support
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#security_group_referencing_support NetworkmanagerVpcAttachment#security_group_referencing_support}.</summary>
        [JsiiProperty(name: "securityGroupReferencingSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecurityGroupReferencingSupport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerVpcAttachmentOptions), fullyQualifiedName: "aws.networkmanagerVpcAttachment.NetworkmanagerVpcAttachmentOptions")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerVpcAttachment.INetworkmanagerVpcAttachmentOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#appliance_mode_support NetworkmanagerVpcAttachment#appliance_mode_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applianceModeSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApplianceModeSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#dns_support NetworkmanagerVpcAttachment#dns_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DnsSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#ipv6_support NetworkmanagerVpcAttachment#ipv6_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Support", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv6Support
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_vpc_attachment#security_group_referencing_support NetworkmanagerVpcAttachment#security_group_referencing_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupReferencingSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SecurityGroupReferencingSupport
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
