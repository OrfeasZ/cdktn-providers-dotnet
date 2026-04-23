using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbelasticCluster
{
    [JsiiInterface(nativeType: typeof(IDocdbelasticClusterConfig), fullyQualifiedName: "aws.docdbelasticCluster.DocdbelasticClusterConfig")]
    public interface IDocdbelasticClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#admin_user_name DocdbelasticCluster#admin_user_name}.</summary>
        [JsiiProperty(name: "adminUserName", typeJson: "{\"primitive\":\"string\"}")]
        string AdminUserName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#admin_user_password DocdbelasticCluster#admin_user_password}.</summary>
        [JsiiProperty(name: "adminUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminUserPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#auth_type DocdbelasticCluster#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#name DocdbelasticCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_capacity DocdbelasticCluster#shard_capacity}.</summary>
        [JsiiProperty(name: "shardCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double ShardCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_count DocdbelasticCluster#shard_count}.</summary>
        [JsiiProperty(name: "shardCount", typeJson: "{\"primitive\":\"number\"}")]
        double ShardCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#backup_retention_period DocdbelasticCluster#backup_retention_period}.</summary>
        [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupRetentionPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#kms_key_id DocdbelasticCluster#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#preferred_backup_window DocdbelasticCluster#preferred_backup_window}.</summary>
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredBackupWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#preferred_maintenance_window DocdbelasticCluster#preferred_maintenance_window}.</summary>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredMaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#region DocdbelasticCluster#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_instance_count DocdbelasticCluster#shard_instance_count}.</summary>
        [JsiiProperty(name: "shardInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShardInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#subnet_ids DocdbelasticCluster#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#tags DocdbelasticCluster#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#timeouts DocdbelasticCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.docdbelasticCluster.DocdbelasticClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DocdbelasticCluster.IDocdbelasticClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#vpc_security_group_ids DocdbelasticCluster#vpc_security_group_ids}.</summary>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbelasticClusterConfig), fullyQualifiedName: "aws.docdbelasticCluster.DocdbelasticClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DocdbelasticCluster.IDocdbelasticClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#admin_user_name DocdbelasticCluster#admin_user_name}.</summary>
            [JsiiProperty(name: "adminUserName", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminUserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#admin_user_password DocdbelasticCluster#admin_user_password}.</summary>
            [JsiiProperty(name: "adminUserPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminUserPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#auth_type DocdbelasticCluster#auth_type}.</summary>
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#name DocdbelasticCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_capacity DocdbelasticCluster#shard_capacity}.</summary>
            [JsiiProperty(name: "shardCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double ShardCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_count DocdbelasticCluster#shard_count}.</summary>
            [JsiiProperty(name: "shardCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ShardCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#backup_retention_period DocdbelasticCluster#backup_retention_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupRetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#kms_key_id DocdbelasticCluster#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#preferred_backup_window DocdbelasticCluster#preferred_backup_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredBackupWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#preferred_maintenance_window DocdbelasticCluster#preferred_maintenance_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredMaintenanceWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#region DocdbelasticCluster#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#shard_instance_count DocdbelasticCluster#shard_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shardInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShardInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#subnet_ids DocdbelasticCluster#subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#tags DocdbelasticCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#timeouts DocdbelasticCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.docdbelasticCluster.DocdbelasticClusterTimeouts\"}", isOptional: true)]
            public aws.DocdbelasticCluster.IDocdbelasticClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DocdbelasticCluster.IDocdbelasticClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/docdbelastic_cluster#vpc_security_group_ids DocdbelasticCluster#vpc_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
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
