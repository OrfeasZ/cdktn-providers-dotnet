using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsSqlReport
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsSqlReportLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsSqlReport.DatabaseToolsDatabaseToolsSqlReportLocks")]
    public interface IDatabaseToolsDatabaseToolsSqlReportLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#type DatabaseToolsDatabaseToolsSqlReport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#message DatabaseToolsDatabaseToolsSqlReport#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#related_resource_id DatabaseToolsDatabaseToolsSqlReport#related_resource_id}.</summary>
        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelatedResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#time_created DatabaseToolsDatabaseToolsSqlReport#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsSqlReportLocks), fullyQualifiedName: "oci.databaseToolsDatabaseToolsSqlReport.DatabaseToolsDatabaseToolsSqlReportLocks")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsSqlReport.IDatabaseToolsDatabaseToolsSqlReportLocks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#type DatabaseToolsDatabaseToolsSqlReport#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#message DatabaseToolsDatabaseToolsSqlReport#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#related_resource_id DatabaseToolsDatabaseToolsSqlReport#related_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelatedResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_tools_database_tools_sql_report#time_created DatabaseToolsDatabaseToolsSqlReport#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
