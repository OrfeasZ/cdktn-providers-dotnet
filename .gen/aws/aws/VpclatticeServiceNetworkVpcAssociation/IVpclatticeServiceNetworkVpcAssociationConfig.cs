using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeServiceNetworkVpcAssociation
{
    [JsiiInterface(nativeType: typeof(IVpclatticeServiceNetworkVpcAssociationConfig), fullyQualifiedName: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationConfig")]
    public interface IVpclatticeServiceNetworkVpcAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#service_network_identifier VpclatticeServiceNetworkVpcAssociation#service_network_identifier}.</summary>
        [JsiiProperty(name: "serviceNetworkIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNetworkIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#vpc_identifier VpclatticeServiceNetworkVpcAssociation#vpc_identifier}.</summary>
        [JsiiProperty(name: "vpcIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string VpcIdentifier
        {
            get;
        }

        /// <summary>dns_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#dns_options VpclatticeServiceNetworkVpcAssociation#dns_options}
        /// </remarks>
        [JsiiProperty(name: "dnsOptions", typeJson: "{\"fqn\":\"aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions? DnsOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#id VpclatticeServiceNetworkVpcAssociation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_enabled VpclatticeServiceNetworkVpcAssociation#private_dns_enabled}.</summary>
        [JsiiProperty(name: "privateDnsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateDnsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#region VpclatticeServiceNetworkVpcAssociation#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#security_group_ids VpclatticeServiceNetworkVpcAssociation#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#tags VpclatticeServiceNetworkVpcAssociation#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#tags_all VpclatticeServiceNetworkVpcAssociation#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#timeouts VpclatticeServiceNetworkVpcAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeServiceNetworkVpcAssociationConfig), fullyQualifiedName: "aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#service_network_identifier VpclatticeServiceNetworkVpcAssociation#service_network_identifier}.</summary>
            [JsiiProperty(name: "serviceNetworkIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNetworkIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#vpc_identifier VpclatticeServiceNetworkVpcAssociation#vpc_identifier}.</summary>
            [JsiiProperty(name: "vpcIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dns_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#dns_options VpclatticeServiceNetworkVpcAssociation#dns_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsOptions", typeJson: "{\"fqn\":\"aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationDnsOptions\"}", isOptional: true)]
            public aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions? DnsOptions
            {
                get => GetInstanceProperty<aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationDnsOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#id VpclatticeServiceNetworkVpcAssociation#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#private_dns_enabled VpclatticeServiceNetworkVpcAssociation#private_dns_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrivateDnsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#region VpclatticeServiceNetworkVpcAssociation#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#security_group_ids VpclatticeServiceNetworkVpcAssociation#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#tags VpclatticeServiceNetworkVpcAssociation#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#tags_all VpclatticeServiceNetworkVpcAssociation#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpclattice_service_network_vpc_association#timeouts VpclatticeServiceNetworkVpcAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpclatticeServiceNetworkVpcAssociation.VpclatticeServiceNetworkVpcAssociationTimeouts\"}", isOptional: true)]
            public aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.VpclatticeServiceNetworkVpcAssociation.IVpclatticeServiceNetworkVpcAssociationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
