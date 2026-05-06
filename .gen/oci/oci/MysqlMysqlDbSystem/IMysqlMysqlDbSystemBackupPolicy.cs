using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlDbSystemBackupPolicy), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicy")]
    public interface IMysqlMysqlDbSystemBackupPolicy
    {
        /// <summary>copy_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_policies MysqlMysqlDbSystem#copy_policies}
        /// </remarks>
        [JsiiProperty(name: "copyPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyPolicies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#defined_tags MysqlMysqlDbSystem#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#freeform_tags MysqlMysqlDbSystem#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>pitr_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#pitr_policy MysqlMysqlDbSystem#pitr_policy}
        /// </remarks>
        [JsiiProperty(name: "pitrPolicy", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyPitrPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyPitrPolicy? PitrPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#retention_in_days MysqlMysqlDbSystem#retention_in_days}.</summary>
        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#soft_delete MysqlMysqlDbSystem#soft_delete}.</summary>
        [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SoftDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WindowStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlDbSystemBackupPolicy), fullyQualifiedName: "oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>copy_policies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#copy_policies MysqlMysqlDbSystem#copy_policies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copyPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyCopyPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CopyPolicies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#defined_tags MysqlMysqlDbSystem#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#freeform_tags MysqlMysqlDbSystem#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#is_enabled MysqlMysqlDbSystem#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pitr_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#pitr_policy MysqlMysqlDbSystem#pitr_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pitrPolicy", typeJson: "{\"fqn\":\"oci.mysqlMysqlDbSystem.MysqlMysqlDbSystemBackupPolicyPitrPolicy\"}", isOptional: true)]
            public oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyPitrPolicy? PitrPolicy
            {
                get => GetInstanceProperty<oci.MysqlMysqlDbSystem.IMysqlMysqlDbSystemBackupPolicyPitrPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#retention_in_days MysqlMysqlDbSystem#retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#soft_delete MysqlMysqlDbSystem#soft_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SoftDelete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_db_system#window_start_time MysqlMysqlDbSystem#window_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "windowStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WindowStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
