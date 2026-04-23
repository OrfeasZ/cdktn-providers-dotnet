using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3FilesMountTarget
{
    [JsiiInterface(nativeType: typeof(IS3FilesMountTargetConfig), fullyQualifiedName: "aws.s3FilesMountTarget.S3FilesMountTargetConfig")]
    public interface IS3FilesMountTargetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>File system ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#file_system_id S3FilesMountTarget#file_system_id}
        /// </remarks>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>Subnet ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#subnet_id S3FilesMountTarget#subnet_id}
        /// </remarks>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>IP address type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ip_address_type S3FilesMountTarget#ip_address_type}
        /// </remarks>
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ipv4_address S3FilesMountTarget#ipv4_address}
        /// </remarks>
        [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>IPv6 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ipv6_address S3FilesMountTarget#ipv6_address}
        /// </remarks>
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#region S3FilesMountTarget#region}
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

        /// <summary>Security group IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#security_groups S3FilesMountTarget#security_groups}
        /// </remarks>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#timeouts S3FilesMountTarget#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3FilesMountTarget.S3FilesMountTargetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3FilesMountTarget.IS3FilesMountTargetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3FilesMountTargetConfig), fullyQualifiedName: "aws.s3FilesMountTarget.S3FilesMountTargetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3FilesMountTarget.IS3FilesMountTargetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>File system ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#file_system_id S3FilesMountTarget#file_system_id}
            /// </remarks>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Subnet ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#subnet_id S3FilesMountTarget#subnet_id}
            /// </remarks>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IP address type.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ip_address_type S3FilesMountTarget#ip_address_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ipv4_address S3FilesMountTarget#ipv4_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv4Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IPv6 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#ipv6_address S3FilesMountTarget#ipv6_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#region S3FilesMountTarget#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Security group IDs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#security_groups S3FilesMountTarget#security_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3files_mount_target#timeouts S3FilesMountTarget#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3FilesMountTarget.S3FilesMountTargetTimeouts\"}", isOptional: true)]
            public aws.S3FilesMountTarget.IS3FilesMountTargetTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.S3FilesMountTarget.IS3FilesMountTargetTimeouts?>();
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
