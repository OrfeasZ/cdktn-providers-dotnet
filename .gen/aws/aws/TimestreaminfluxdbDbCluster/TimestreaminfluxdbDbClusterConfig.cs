using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterConfig")]
    public class TimestreaminfluxdbDbClusterConfig : aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterConfig
    {
        /// <summary>The Timestream for InfluxDB DB instance type to run InfluxDB on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_instance_type TimestreaminfluxdbDbCluster#db_instance_type}
        /// </remarks>
        [JsiiProperty(name: "dbInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string DbInstanceType
        {
            get;
            set;
        }

        /// <summary>The name that uniquely identifies the DB cluster when interacting with the  					Amazon Timestream for InfluxDB API and CLI commands.</summary>
        /// <remarks>
        /// This name will also be a
        /// prefix included in the endpoint. DB cluster names must be unique per customer
        /// and per region.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#name TimestreaminfluxdbDbCluster#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#vpc_security_group_ids TimestreaminfluxdbDbCluster#vpc_security_group_ids}
        /// </remarks>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] VpcSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>A list of VPC subnet IDs to associate with the DB cluster.</summary>
        /// <remarks>
        /// Provide at least
        /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#vpc_subnet_ids TimestreaminfluxdbDbCluster#vpc_subnet_ids}
        /// </remarks>
        [JsiiProperty(name: "vpcSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] VpcSubnetIds
        {
            get;
            set;
        }

        /// <summary>The amount of storage to allocate for your DB storage type in GiB (gibibytes).</summary>
        /// <remarks>
        /// This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#allocated_storage TimestreaminfluxdbDbCluster#allocated_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocatedStorage
        {
            get;
            set;
        }

        /// <summary>Name of the initial InfluxDB bucket.</summary>
        /// <remarks>
        /// All InfluxDB data is stored in a bucket.
        /// A bucket combines the concept of a database and a retention period (the duration of time
        /// that each data point persists). A bucket belongs to an organization. Along with organization,
        /// username, and password, this argument will be stored in the secret referred to by the
        /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
        /// (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#bucket TimestreaminfluxdbDbCluster#bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>The ID of the DB parameter group to assign to your DB cluster.</summary>
        /// <remarks>
        /// DB parameter groups specify how the database is configured. For example, DB parameter groups
        /// can specify the limit for query concurrency.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_parameter_group_identifier TimestreaminfluxdbDbCluster#db_parameter_group_identifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbParameterGroupIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbParameterGroupIdentifier
        {
            get;
            set;
        }

        /// <summary>The Timestream for InfluxDB DB storage type to read and write InfluxDB data.</summary>
        /// <remarks>
        /// You can choose between 3 different types of provisioned Influx IOPS included storage according
        /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
        /// Influx IO Included 16000 IOPS.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_storage_type TimestreaminfluxdbDbCluster#db_storage_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbStorageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbStorageType
        {
            get;
            set;
        }

        /// <summary>Specifies the type of cluster to create.</summary>
        /// <remarks>
        /// This field is forbidden for InfluxDB V3 clusters
        /// (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#deployment_type TimestreaminfluxdbDbCluster#deployment_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentType
        {
            get;
            set;
        }

        /// <summary>Specifies the behavior of failure recovery when the primary node of the cluster 					fails.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#failover_mode TimestreaminfluxdbDbCluster#failover_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailoverMode
        {
            get;
            set;
        }

        private object? _logDeliveryConfiguration;

        /// <summary>log_delivery_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#log_delivery_configuration TimestreaminfluxdbDbCluster#log_delivery_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logDeliveryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogDeliveryConfiguration
        {
            get => _logDeliveryConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logDeliveryConfiguration = value;
            }
        }

        /// <summary>Specifies whether the networkType of the Timestream for InfluxDB cluster is  					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate  					over both IPv4 and IPv6 protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#network_type TimestreaminfluxdbDbCluster#network_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkType
        {
            get;
            set;
        }

        /// <summary>Name of the initial organization for the initial admin user in InfluxDB.</summary>
        /// <remarks>
        /// An
        /// InfluxDB organization is a workspace for a group of users. Along with bucket, username,
        /// and password, this argument will be stored in the secret referred to by the
        /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
        /// (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#organization TimestreaminfluxdbDbCluster#organization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Organization
        {
            get;
            set;
        }

        /// <summary>Password of the initial admin user created in InfluxDB.</summary>
        /// <remarks>
        /// This password will
        /// allow you to access the InfluxDB UI to perform various administrative tasks and
        /// also use the InfluxDB CLI to create an operator token. Along with bucket, username,
        /// and organization, this argument will be stored in the secret referred to by the
        /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
        /// (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#password TimestreaminfluxdbDbCluster#password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>The port number on which InfluxDB accepts connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#port TimestreaminfluxdbDbCluster#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        private object? _publiclyAccessible;

        /// <summary>Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#publicly_accessible TimestreaminfluxdbDbCluster#publicly_accessible}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PubliclyAccessible
        {
            get => _publiclyAccessible;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publiclyAccessible = value;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#region TimestreaminfluxdbDbCluster#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#tags TimestreaminfluxdbDbCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#timeouts TimestreaminfluxdbDbCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterTimeouts\"}", isOptional: true)]
        public aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Username of the initial admin user created in InfluxDB.</summary>
        /// <remarks>
        /// Must start with a letter
        /// and can't end with a hyphen or contain two consecutive hyphens. This username will allow
        /// you to access the InfluxDB UI to perform various administrative tasks and also use the
        /// InfluxDB CLI to create an operator token. Along with bucket, organization, and password,
        /// this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn
        /// attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#username TimestreaminfluxdbDbCluster#username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
