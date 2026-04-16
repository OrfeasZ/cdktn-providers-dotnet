using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcEncryptionControl
{
    [JsiiInterface(nativeType: typeof(IVpcEncryptionControlConfig), fullyQualifiedName: "aws.vpcEncryptionControl.VpcEncryptionControlConfig")]
    public interface IVpcEncryptionControlConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#mode VpcEncryptionControl#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_id VpcEncryptionControl#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#egress_only_internet_gateway_exclusion VpcEncryptionControl#egress_only_internet_gateway_exclusion}.</summary>
        [JsiiProperty(name: "egressOnlyInternetGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EgressOnlyInternetGatewayExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#elastic_file_system_exclusion VpcEncryptionControl#elastic_file_system_exclusion}.</summary>
        [JsiiProperty(name: "elasticFileSystemExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticFileSystemExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#internet_gateway_exclusion VpcEncryptionControl#internet_gateway_exclusion}.</summary>
        [JsiiProperty(name: "internetGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InternetGatewayExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#lambda_exclusion VpcEncryptionControl#lambda_exclusion}.</summary>
        [JsiiProperty(name: "lambdaExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#nat_gateway_exclusion VpcEncryptionControl#nat_gateway_exclusion}.</summary>
        [JsiiProperty(name: "natGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NatGatewayExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#region VpcEncryptionControl#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#tags VpcEncryptionControl#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#timeouts VpcEncryptionControl#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpcEncryptionControl.IVpcEncryptionControlTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#virtual_private_gateway_exclusion VpcEncryptionControl#virtual_private_gateway_exclusion}.</summary>
        [JsiiProperty(name: "virtualPrivateGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualPrivateGatewayExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_lattice_exclusion VpcEncryptionControl#vpc_lattice_exclusion}.</summary>
        [JsiiProperty(name: "vpcLatticeExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcLatticeExclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_peering_exclusion VpcEncryptionControl#vpc_peering_exclusion}.</summary>
        [JsiiProperty(name: "vpcPeeringExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcPeeringExclusion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcEncryptionControlConfig), fullyQualifiedName: "aws.vpcEncryptionControl.VpcEncryptionControlConfig")]
        internal sealed class _Proxy : DeputyBase, aws.VpcEncryptionControl.IVpcEncryptionControlConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#mode VpcEncryptionControl#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_id VpcEncryptionControl#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#egress_only_internet_gateway_exclusion VpcEncryptionControl#egress_only_internet_gateway_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressOnlyInternetGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EgressOnlyInternetGatewayExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#elastic_file_system_exclusion VpcEncryptionControl#elastic_file_system_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticFileSystemExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticFileSystemExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#internet_gateway_exclusion VpcEncryptionControl#internet_gateway_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internetGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InternetGatewayExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#lambda_exclusion VpcEncryptionControl#lambda_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#nat_gateway_exclusion VpcEncryptionControl#nat_gateway_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "natGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NatGatewayExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#region VpcEncryptionControl#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#tags VpcEncryptionControl#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#timeouts VpcEncryptionControl#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpcEncryptionControl.VpcEncryptionControlTimeouts\"}", isOptional: true)]
            public aws.VpcEncryptionControl.IVpcEncryptionControlTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.VpcEncryptionControl.IVpcEncryptionControlTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#virtual_private_gateway_exclusion VpcEncryptionControl#virtual_private_gateway_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualPrivateGatewayExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualPrivateGatewayExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_lattice_exclusion VpcEncryptionControl#vpc_lattice_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcLatticeExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcLatticeExclusion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/vpc_encryption_control#vpc_peering_exclusion VpcEncryptionControl#vpc_peering_exclusion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcPeeringExclusion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcPeeringExclusion
            {
                get => GetInstanceProperty<string?>();
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
