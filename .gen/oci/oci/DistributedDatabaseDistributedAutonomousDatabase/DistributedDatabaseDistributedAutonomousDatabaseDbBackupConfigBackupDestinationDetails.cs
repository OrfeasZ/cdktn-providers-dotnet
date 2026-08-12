using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails")]
    public class DistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigBackupDestinationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#type DistributedDatabaseDistributedAutonomousDatabase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#dbrs_policy_id DistributedDatabaseDistributedAutonomousDatabase#dbrs_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbrsPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#id DistributedDatabaseDistributedAutonomousDatabase#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#internet_proxy DistributedDatabaseDistributedAutonomousDatabase#internet_proxy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "internetProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InternetProxy
        {
            get;
            set;
        }

        private object? _isRemote;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#is_remote DistributedDatabaseDistributedAutonomousDatabase#is_remote}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isRemote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRemote
        {
            get => _isRemote;
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
                _isRemote = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#remote_region DistributedDatabaseDistributedAutonomousDatabase#remote_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#vpc_password DistributedDatabaseDistributedAutonomousDatabase#vpc_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/distributed_database_distributed_autonomous_database#vpc_user DistributedDatabaseDistributedAutonomousDatabase#vpc_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcUser
        {
            get;
            set;
        }
    }
}
