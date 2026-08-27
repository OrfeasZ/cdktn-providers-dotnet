using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails")]
    public interface IDistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#type DistributedDatabaseDistributedDatabase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#dbrs_policy_id DistributedDatabaseDistributedDatabase#dbrs_policy_id}.</summary>
        [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbrsPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#id DistributedDatabaseDistributedDatabase#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#internet_proxy DistributedDatabaseDistributedDatabase#internet_proxy}.</summary>
        [JsiiProperty(name: "internetProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InternetProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_remote DistributedDatabaseDistributedDatabase#is_remote}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRemote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRemote
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_zero_data_loss_enabled DistributedDatabaseDistributedDatabase#is_zero_data_loss_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isZeroDataLossEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsZeroDataLossEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#remote_region DistributedDatabaseDistributedDatabase#remote_region}.</summary>
        [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#vpc_password DistributedDatabaseDistributedDatabase#vpc_password}.</summary>
        [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#vpc_user DistributedDatabaseDistributedDatabase#vpc_user}.</summary>
        [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseDbBackupConfigBackupDestinationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#type DistributedDatabaseDistributedDatabase#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#dbrs_policy_id DistributedDatabaseDistributedDatabase#dbrs_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbrsPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#id DistributedDatabaseDistributedDatabase#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#internet_proxy DistributedDatabaseDistributedDatabase#internet_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internetProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InternetProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_remote DistributedDatabaseDistributedDatabase#is_remote}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRemote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRemote
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_zero_data_loss_enabled DistributedDatabaseDistributedDatabase#is_zero_data_loss_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isZeroDataLossEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsZeroDataLossEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#remote_region DistributedDatabaseDistributedDatabase#remote_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#vpc_password DistributedDatabaseDistributedDatabase#vpc_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#vpc_user DistributedDatabaseDistributedDatabase#vpc_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcUser
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
