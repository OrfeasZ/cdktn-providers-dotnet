using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsSqlReport
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsSqlReportColumns), fullyQualifiedName: "oci.databaseToolsDatabaseToolsSqlReport.DatabaseToolsDatabaseToolsSqlReportColumns")]
    public interface IDatabaseToolsDatabaseToolsSqlReportColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#description DatabaseToolsDatabaseToolsSqlReport#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#name DatabaseToolsDatabaseToolsSqlReport#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#type DatabaseToolsDatabaseToolsSqlReport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsSqlReportColumns), fullyQualifiedName: "oci.databaseToolsDatabaseToolsSqlReport.DatabaseToolsDatabaseToolsSqlReportColumns")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsSqlReport.IDatabaseToolsDatabaseToolsSqlReportColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#description DatabaseToolsDatabaseToolsSqlReport#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#name DatabaseToolsDatabaseToolsSqlReport#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_tools_database_tools_sql_report#type DatabaseToolsDatabaseToolsSqlReport#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
