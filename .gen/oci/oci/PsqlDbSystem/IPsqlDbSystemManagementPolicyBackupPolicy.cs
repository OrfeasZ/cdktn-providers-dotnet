using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemManagementPolicyBackupPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy")]
    public interface IPsqlDbSystemManagementPolicyBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_start PsqlDbSystem#backup_start}.</summary>
        [JsiiProperty(name: "backupStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>copy_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#copy_policy PsqlDbSystem#copy_policy}
        /// </remarks>
        [JsiiProperty(name: "copyPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy? CopyPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_month PsqlDbSystem#days_of_the_month}.</summary>
        [JsiiProperty(name: "daysOfTheMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? DaysOfTheMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_week PsqlDbSystem#days_of_the_week}.</summary>
        [JsiiProperty(name: "daysOfTheWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DaysOfTheWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#retention_days PsqlDbSystem#retention_days}.</summary>
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemManagementPolicyBackupPolicy), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#backup_start PsqlDbSystem#backup_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>copy_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#copy_policy PsqlDbSystem#copy_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copyPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicy\"}", isOptional: true)]
            public oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy? CopyPolicy
            {
                get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_month PsqlDbSystem#days_of_the_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfTheMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? DaysOfTheMonth
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#days_of_the_week PsqlDbSystem#days_of_the_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfTheWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DaysOfTheWeek
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#retention_days PsqlDbSystem#retention_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
