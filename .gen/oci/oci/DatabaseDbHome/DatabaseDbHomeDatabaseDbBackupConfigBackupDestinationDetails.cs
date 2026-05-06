using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiByValue(fqn: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails")]
    public class DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails : oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#backup_retention_policy_on_terminate DatabaseDbHome#backup_retention_policy_on_terminate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionPolicyOnTerminate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupRetentionPolicyOnTerminate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#dbrs_policy_id DatabaseDbHome#dbrs_policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbrsPolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#id DatabaseDbHome#id}.</summary>
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

        private object? _isRemote;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#is_remote DatabaseDbHome#is_remote}.</summary>
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

        private object? _isRetentionLockEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#is_retention_lock_enabled DatabaseDbHome#is_retention_lock_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsRetentionLockEnabled
        {
            get => _isRetentionLockEnabled;
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
                _isRetentionLockEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#remote_region DatabaseDbHome#remote_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#type DatabaseDbHome#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#vpc_password DatabaseDbHome#vpc_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_home#vpc_user DatabaseDbHome#vpc_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcUser
        {
            get;
            set;
        }
    }
}
