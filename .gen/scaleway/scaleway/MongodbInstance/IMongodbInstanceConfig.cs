using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbInstance
{
    [JsiiInterface(nativeType: typeof(IMongodbInstanceConfig), fullyQualifiedName: "scaleway.mongodbInstance.MongodbInstanceConfig")]
    public interface IMongodbInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Number of nodes in the instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#node_number MongodbInstance#node_number}
        /// </remarks>
        [JsiiProperty(name: "nodeNumber", typeJson: "{\"primitive\":\"number\"}")]
        double NodeNumber
        {
            get;
        }

        /// <summary>Type of node to use for the instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#node_type MongodbInstance#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#id MongodbInstance#id}.</summary>
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

        /// <summary>Enable or disable automatic snapshot scheduling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#is_snapshot_schedule_enabled MongodbInstance#is_snapshot_schedule_enabled}
        /// </remarks>
        [JsiiProperty(name: "isSnapshotScheduleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSnapshotScheduleEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the MongoDB cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#name MongodbInstance#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password of the user. Only one of `password` or `password_wo` should be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password MongodbInstance#password}
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

        /// <summary>Password of the user in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password_wo MongodbInstance#password_wo}
        /// </remarks>
        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password_wo_version MongodbInstance#password_wo_version}
        /// </remarks>
        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#private_ip MongodbInstance#private_ip}
        /// </remarks>
        [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#private_network MongodbInstance#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.MongodbInstance.IMongodbInstancePrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#project_id MongodbInstance#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#public_network MongodbInstance#public_network}
        /// </remarks>
        [JsiiProperty(name: "publicNetwork", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePublicNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.MongodbInstance.IMongodbInstancePublicNetwork? PublicNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#region MongodbInstance#region}
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

        /// <summary>Map of settings to define for the instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#settings MongodbInstance#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Snapshot ID to restore the MongoDB instance from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_id MongodbInstance#snapshot_id}
        /// </remarks>
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Snapshot schedule frequency in hours.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_schedule_frequency_hours MongodbInstance#snapshot_schedule_frequency_hours}
        /// </remarks>
        [JsiiProperty(name: "snapshotScheduleFrequencyHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SnapshotScheduleFrequencyHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Snapshot schedule retention in days.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_schedule_retention_days MongodbInstance#snapshot_schedule_retention_days}
        /// </remarks>
        [JsiiProperty(name: "snapshotScheduleRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SnapshotScheduleRetentionDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags ["tag1", "tag2", ...] attached to a MongoDB instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#tags MongodbInstance#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#timeouts MongodbInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.MongodbInstance.IMongodbInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the user created when the cluster is created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#user_name MongodbInstance#user_name}
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>MongoDB version of the instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#version MongodbInstance#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume size (in GB).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#volume_size_in_gb MongodbInstance#volume_size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Volume type of the instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#volume_type MongodbInstance#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMongodbInstanceConfig), fullyQualifiedName: "scaleway.mongodbInstance.MongodbInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.MongodbInstance.IMongodbInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of nodes in the instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#node_number MongodbInstance#node_number}
            /// </remarks>
            [JsiiProperty(name: "nodeNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of node to use for the instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#node_type MongodbInstance#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#id MongodbInstance#id}.</summary>
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

            /// <summary>Enable or disable automatic snapshot scheduling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#is_snapshot_schedule_enabled MongodbInstance#is_snapshot_schedule_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSnapshotScheduleEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSnapshotScheduleEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the MongoDB cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#name MongodbInstance#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password of the user. Only one of `password` or `password_wo` should be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password MongodbInstance#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password of the user in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password_wo MongodbInstance#password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#password_wo_version MongodbInstance#password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>private_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#private_ip MongodbInstance#private_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#private_network MongodbInstance#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePrivateNetwork\"}", isOptional: true)]
            public scaleway.MongodbInstance.IMongodbInstancePrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.MongodbInstance.IMongodbInstancePrivateNetwork?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#project_id MongodbInstance#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#public_network MongodbInstance#public_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetwork", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstancePublicNetwork\"}", isOptional: true)]
            public scaleway.MongodbInstance.IMongodbInstancePublicNetwork? PublicNetwork
            {
                get => GetInstanceProperty<scaleway.MongodbInstance.IMongodbInstancePublicNetwork?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#region MongodbInstance#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Map of settings to define for the instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#settings MongodbInstance#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Settings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Snapshot ID to restore the MongoDB instance from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_id MongodbInstance#snapshot_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Snapshot schedule frequency in hours.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_schedule_frequency_hours MongodbInstance#snapshot_schedule_frequency_hours}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotScheduleFrequencyHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SnapshotScheduleFrequencyHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Snapshot schedule retention in days.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#snapshot_schedule_retention_days MongodbInstance#snapshot_schedule_retention_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotScheduleRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SnapshotScheduleRetentionDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>List of tags ["tag1", "tag2", ...] attached to a MongoDB instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#tags MongodbInstance#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#timeouts MongodbInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.mongodbInstance.MongodbInstanceTimeouts\"}", isOptional: true)]
            public scaleway.MongodbInstance.IMongodbInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.MongodbInstance.IMongodbInstanceTimeouts?>();
            }

            /// <summary>Name of the user created when the cluster is created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#user_name MongodbInstance#user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>MongoDB version of the instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#version MongodbInstance#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Volume size (in GB).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#volume_size_in_gb MongodbInstance#volume_size_in_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Volume type of the instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_instance#volume_type MongodbInstance#volume_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeType
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
