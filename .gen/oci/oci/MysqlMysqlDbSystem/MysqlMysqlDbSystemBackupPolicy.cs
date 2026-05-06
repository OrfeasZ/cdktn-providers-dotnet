using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiByValue(fqn: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicy")]
    public class MysqlMysqlDbSystemBackupPolicy : oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicy
    {
        private object? _copyPolicies;

        /// <summary>copy_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_policies MysqlMysqlDbSystem#copy_policies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "copyPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CopyPolicies
        {
            get => _copyPolicies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyCopyPolicies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyCopyPolicies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _copyPolicies = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#defined_tags MysqlMysqlDbSystem#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#freeform_tags MysqlMysqlDbSystem#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        private object? _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnabled
        {
            get => _isEnabled;
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
                _isEnabled = value;
            }
        }

        /// <summary>pitr_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#pitr_policy MysqlMysqlDbSystem#pitr_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pitrPolicy", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyPitrPolicy\"}", isOptional: true)]
        public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyPitrPolicy? PitrPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#retention_in_days MysqlMysqlDbSystem#retention_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#soft_delete MysqlMysqlDbSystem#soft_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SoftDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WindowStartTime
        {
            get;
            set;
        }
    }
}
