using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    [JsiiInterface(nativeType: typeof(ITimestreaminfluxdbDbClusterConfig), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterConfig")]
    public interface ITimestreaminfluxdbDbClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Timestream for InfluxDB DB instance type to run InfluxDB on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_instance_type TimestreaminfluxdbDbCluster#db_instance_type}
        /// </remarks>
        [JsiiProperty(name: "dbInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string DbInstanceType
        {
            get;
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
        string Name
        {
            get;
        }

        /// <summary>A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#vpc_security_group_ids TimestreaminfluxdbDbCluster#vpc_security_group_ids}
        /// </remarks>
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] VpcSecurityGroupIds
        {
            get;
        }

        /// <summary>A list of VPC subnet IDs to associate with the DB cluster.</summary>
        /// <remarks>
        /// Provide at least
        /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#vpc_subnet_ids TimestreaminfluxdbDbCluster#vpc_subnet_ids}
        /// </remarks>
        [JsiiProperty(name: "vpcSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] VpcSubnetIds
        {
            get;
        }

        /// <summary>The amount of storage to allocate for your DB storage type in GiB (gibibytes).</summary>
        /// <remarks>
        /// This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#allocated_storage TimestreaminfluxdbDbCluster#allocated_storage}
        /// </remarks>
        [JsiiProperty(name: "allocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllocatedStorage
        {
            get
            {
                return null;
            }
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
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the DB parameter group to assign to your DB cluster.</summary>
        /// <remarks>
        /// DB parameter groups specify how the database is configured. For example, DB parameter groups
        /// can specify the limit for query concurrency.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_parameter_group_identifier TimestreaminfluxdbDbCluster#db_parameter_group_identifier}
        /// </remarks>
        [JsiiProperty(name: "dbParameterGroupIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbParameterGroupIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Timestream for InfluxDB DB storage type to read and write InfluxDB data.</summary>
        /// <remarks>
        /// You can choose between 3 different types of provisioned Influx IOPS included storage according
        /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
        /// Influx IO Included 16000 IOPS.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_storage_type TimestreaminfluxdbDbCluster#db_storage_type}
        /// </remarks>
        [JsiiProperty(name: "dbStorageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbStorageType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the type of cluster to create.</summary>
        /// <remarks>
        /// This field is forbidden for InfluxDB V3 clusters
        /// (when using an InfluxDB V3 db parameter group).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#deployment_type TimestreaminfluxdbDbCluster#deployment_type}
        /// </remarks>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the behavior of failure recovery when the primary node of the cluster 					fails.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#failover_mode TimestreaminfluxdbDbCluster#failover_mode}
        /// </remarks>
        [JsiiProperty(name: "failoverMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailoverMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_delivery_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#log_delivery_configuration TimestreaminfluxdbDbCluster#log_delivery_configuration}
        /// </remarks>
        [JsiiProperty(name: "logDeliveryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogDeliveryConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether the networkType of the Timestream for InfluxDB cluster is  					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate  					over both IPv4 and IPv6 protocols.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#network_type TimestreaminfluxdbDbCluster#network_type}
        /// </remarks>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkType
        {
            get
            {
                return null;
            }
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
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Organization
        {
            get
            {
                return null;
            }
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
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>The port number on which InfluxDB accepts connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#port TimestreaminfluxdbDbCluster#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#publicly_accessible TimestreaminfluxdbDbCluster#publicly_accessible}
        /// </remarks>
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PubliclyAccessible
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#region TimestreaminfluxdbDbCluster#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#tags TimestreaminfluxdbDbCluster#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#timeouts TimestreaminfluxdbDbCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
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
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreaminfluxdbDbClusterConfig), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Timestream for InfluxDB DB instance type to run InfluxDB on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#db_instance_type TimestreaminfluxdbDbCluster#db_instance_type}
            /// </remarks>
            [JsiiProperty(name: "dbInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string DbInstanceType
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#vpc_security_group_ids TimestreaminfluxdbDbCluster#vpc_security_group_ids}
            /// </remarks>
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
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
                get => GetInstanceProperty<string[]>()!;
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the behavior of failure recovery when the primary node of the cluster 					fails.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#failover_mode TimestreaminfluxdbDbCluster#failover_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailoverMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_delivery_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#log_delivery_configuration TimestreaminfluxdbDbCluster#log_delivery_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logDeliveryConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogDeliveryConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies whether the networkType of the Timestream for InfluxDB cluster is  					IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate  					over both IPv4 and IPv6 protocols.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#network_type TimestreaminfluxdbDbCluster#network_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkType
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The port number on which InfluxDB accepts connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#port TimestreaminfluxdbDbCluster#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#publicly_accessible TimestreaminfluxdbDbCluster#publicly_accessible}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PubliclyAccessible
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#region TimestreaminfluxdbDbCluster#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#tags TimestreaminfluxdbDbCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/timestreaminfluxdb_db_cluster#timeouts TimestreaminfluxdbDbCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterTimeouts\"}", isOptional: true)]
            public aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterTimeouts?>();
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
