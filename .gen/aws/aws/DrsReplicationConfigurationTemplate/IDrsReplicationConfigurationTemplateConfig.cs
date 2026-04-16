using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DrsReplicationConfigurationTemplate
{
    [JsiiInterface(nativeType: typeof(IDrsReplicationConfigurationTemplateConfig), fullyQualifiedName: "aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateConfig")]
    public interface IDrsReplicationConfigurationTemplateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#associate_default_security_group DrsReplicationConfigurationTemplate#associate_default_security_group}.</summary>
        [JsiiProperty(name: "associateDefaultSecurityGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AssociateDefaultSecurityGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#bandwidth_throttling DrsReplicationConfigurationTemplate#bandwidth_throttling}.</summary>
        [JsiiProperty(name: "bandwidthThrottling", typeJson: "{\"primitive\":\"number\"}")]
        double BandwidthThrottling
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#create_public_ip DrsReplicationConfigurationTemplate#create_public_ip}.</summary>
        [JsiiProperty(name: "createPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object CreatePublicIp
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#data_plane_routing DrsReplicationConfigurationTemplate#data_plane_routing}.</summary>
        [JsiiProperty(name: "dataPlaneRouting", typeJson: "{\"primitive\":\"string\"}")]
        string DataPlaneRouting
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#default_large_staging_disk_type DrsReplicationConfigurationTemplate#default_large_staging_disk_type}.</summary>
        [JsiiProperty(name: "defaultLargeStagingDiskType", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultLargeStagingDiskType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#ebs_encryption DrsReplicationConfigurationTemplate#ebs_encryption}.</summary>
        [JsiiProperty(name: "ebsEncryption", typeJson: "{\"primitive\":\"string\"}")]
        string EbsEncryption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#replication_server_instance_type DrsReplicationConfigurationTemplate#replication_server_instance_type}.</summary>
        [JsiiProperty(name: "replicationServerInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationServerInstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#replication_servers_security_groups_ids DrsReplicationConfigurationTemplate#replication_servers_security_groups_ids}.</summary>
        [JsiiProperty(name: "replicationServersSecurityGroupsIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ReplicationServersSecurityGroupsIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#staging_area_subnet_id DrsReplicationConfigurationTemplate#staging_area_subnet_id}.</summary>
        [JsiiProperty(name: "stagingAreaSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string StagingAreaSubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#staging_area_tags DrsReplicationConfigurationTemplate#staging_area_tags}.</summary>
        [JsiiProperty(name: "stagingAreaTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> StagingAreaTags
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#use_dedicated_replication_server DrsReplicationConfigurationTemplate#use_dedicated_replication_server}.</summary>
        [JsiiProperty(name: "useDedicatedReplicationServer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object UseDedicatedReplicationServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#auto_replicate_new_disks DrsReplicationConfigurationTemplate#auto_replicate_new_disks}.</summary>
        [JsiiProperty(name: "autoReplicateNewDisks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoReplicateNewDisks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#ebs_encryption_key_arn DrsReplicationConfigurationTemplate#ebs_encryption_key_arn}.</summary>
        [JsiiProperty(name: "ebsEncryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EbsEncryptionKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>pit_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#pit_policy DrsReplicationConfigurationTemplate#pit_policy}
        /// </remarks>
        [JsiiProperty(name: "pitPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplatePitPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PitPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#region DrsReplicationConfigurationTemplate#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#tags DrsReplicationConfigurationTemplate#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#timeouts DrsReplicationConfigurationTemplate#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DrsReplicationConfigurationTemplate.IDrsReplicationConfigurationTemplateTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDrsReplicationConfigurationTemplateConfig), fullyQualifiedName: "aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DrsReplicationConfigurationTemplate.IDrsReplicationConfigurationTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#associate_default_security_group DrsReplicationConfigurationTemplate#associate_default_security_group}.</summary>
            [JsiiProperty(name: "associateDefaultSecurityGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AssociateDefaultSecurityGroup
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#bandwidth_throttling DrsReplicationConfigurationTemplate#bandwidth_throttling}.</summary>
            [JsiiProperty(name: "bandwidthThrottling", typeJson: "{\"primitive\":\"number\"}")]
            public double BandwidthThrottling
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#create_public_ip DrsReplicationConfigurationTemplate#create_public_ip}.</summary>
            [JsiiProperty(name: "createPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object CreatePublicIp
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#data_plane_routing DrsReplicationConfigurationTemplate#data_plane_routing}.</summary>
            [JsiiProperty(name: "dataPlaneRouting", typeJson: "{\"primitive\":\"string\"}")]
            public string DataPlaneRouting
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#default_large_staging_disk_type DrsReplicationConfigurationTemplate#default_large_staging_disk_type}.</summary>
            [JsiiProperty(name: "defaultLargeStagingDiskType", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultLargeStagingDiskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#ebs_encryption DrsReplicationConfigurationTemplate#ebs_encryption}.</summary>
            [JsiiProperty(name: "ebsEncryption", typeJson: "{\"primitive\":\"string\"}")]
            public string EbsEncryption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#replication_server_instance_type DrsReplicationConfigurationTemplate#replication_server_instance_type}.</summary>
            [JsiiProperty(name: "replicationServerInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationServerInstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#replication_servers_security_groups_ids DrsReplicationConfigurationTemplate#replication_servers_security_groups_ids}.</summary>
            [JsiiProperty(name: "replicationServersSecurityGroupsIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ReplicationServersSecurityGroupsIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#staging_area_subnet_id DrsReplicationConfigurationTemplate#staging_area_subnet_id}.</summary>
            [JsiiProperty(name: "stagingAreaSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string StagingAreaSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#staging_area_tags DrsReplicationConfigurationTemplate#staging_area_tags}.</summary>
            [JsiiProperty(name: "stagingAreaTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> StagingAreaTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#use_dedicated_replication_server DrsReplicationConfigurationTemplate#use_dedicated_replication_server}.</summary>
            [JsiiProperty(name: "useDedicatedReplicationServer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object UseDedicatedReplicationServer
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#auto_replicate_new_disks DrsReplicationConfigurationTemplate#auto_replicate_new_disks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoReplicateNewDisks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoReplicateNewDisks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#ebs_encryption_key_arn DrsReplicationConfigurationTemplate#ebs_encryption_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsEncryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EbsEncryptionKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pit_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#pit_policy DrsReplicationConfigurationTemplate#pit_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pitPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplatePitPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PitPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#region DrsReplicationConfigurationTemplate#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#tags DrsReplicationConfigurationTemplate#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/drs_replication_configuration_template#timeouts DrsReplicationConfigurationTemplate#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.drsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateTimeouts\"}", isOptional: true)]
            public aws.DrsReplicationConfigurationTemplate.IDrsReplicationConfigurationTemplateTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DrsReplicationConfigurationTemplate.IDrsReplicationConfigurationTemplateTimeouts?>();
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
