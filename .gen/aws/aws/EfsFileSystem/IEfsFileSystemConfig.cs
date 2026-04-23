using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsFileSystem
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemConfig), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemConfig")]
    public interface IEfsFileSystemConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#availability_zone_name EfsFileSystem#availability_zone_name}.</summary>
        [JsiiProperty(name: "availabilityZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZoneName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#creation_token EfsFileSystem#creation_token}.</summary>
        [JsiiProperty(name: "creationToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreationToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#encrypted EfsFileSystem#encrypted}.</summary>
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Encrypted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#id EfsFileSystem#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#kms_key_id EfsFileSystem#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>lifecycle_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#lifecycle_policy EfsFileSystem#lifecycle_policy}
        /// </remarks>
        [JsiiProperty(name: "lifecyclePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.efsFileSystem.EfsFileSystemLifecyclePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LifecyclePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#performance_mode EfsFileSystem#performance_mode}.</summary>
        [JsiiProperty(name: "performanceMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PerformanceMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#protection EfsFileSystem#protection}
        /// </remarks>
        [JsiiProperty(name: "protection", typeJson: "{\"fqn\":\"aws.efsFileSystem.EfsFileSystemProtection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EfsFileSystem.IEfsFileSystemProtection? Protection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#provisioned_throughput_in_mibps EfsFileSystem#provisioned_throughput_in_mibps}.</summary>
        [JsiiProperty(name: "provisionedThroughputInMibps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProvisionedThroughputInMibps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#region EfsFileSystem#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#tags EfsFileSystem#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#tags_all EfsFileSystem#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#throughput_mode EfsFileSystem#throughput_mode}.</summary>
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThroughputMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemConfig), fullyQualifiedName: "aws.efsFileSystem.EfsFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EfsFileSystem.IEfsFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#availability_zone_name EfsFileSystem#availability_zone_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZoneName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#creation_token EfsFileSystem#creation_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creationToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreationToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#encrypted EfsFileSystem#encrypted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Encrypted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#id EfsFileSystem#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#kms_key_id EfsFileSystem#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lifecycle_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#lifecycle_policy EfsFileSystem#lifecycle_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecyclePolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.efsFileSystem.EfsFileSystemLifecyclePolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LifecyclePolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#performance_mode EfsFileSystem#performance_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "performanceMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PerformanceMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#protection EfsFileSystem#protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protection", typeJson: "{\"fqn\":\"aws.efsFileSystem.EfsFileSystemProtection\"}", isOptional: true)]
            public aws.EfsFileSystem.IEfsFileSystemProtection? Protection
            {
                get => GetInstanceProperty<aws.EfsFileSystem.IEfsFileSystemProtection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#provisioned_throughput_in_mibps EfsFileSystem#provisioned_throughput_in_mibps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedThroughputInMibps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProvisionedThroughputInMibps
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#region EfsFileSystem#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#tags EfsFileSystem#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#tags_all EfsFileSystem#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/efs_file_system#throughput_mode EfsFileSystem#throughput_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThroughputMode
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
