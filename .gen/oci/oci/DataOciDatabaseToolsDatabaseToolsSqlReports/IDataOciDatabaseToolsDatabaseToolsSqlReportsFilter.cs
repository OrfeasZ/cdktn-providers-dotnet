using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsDatabaseToolsSqlReports
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseToolsDatabaseToolsSqlReportsFilter), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsSqlReports.DataOciDatabaseToolsDatabaseToolsSqlReportsFilter")]
    public interface IDataOciDatabaseToolsDatabaseToolsSqlReportsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#name DataOciDatabaseToolsDatabaseToolsSqlReports#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#values DataOciDatabaseToolsDatabaseToolsSqlReports#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#regex DataOciDatabaseToolsDatabaseToolsSqlReports#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseToolsDatabaseToolsSqlReportsFilter), fullyQualifiedName: "oci.dataOciDatabaseToolsDatabaseToolsSqlReports.DataOciDatabaseToolsDatabaseToolsSqlReportsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseToolsDatabaseToolsSqlReports.IDataOciDatabaseToolsDatabaseToolsSqlReportsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#name DataOciDatabaseToolsDatabaseToolsSqlReports#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#values DataOciDatabaseToolsDatabaseToolsSqlReports#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/data-sources/database_tools_database_tools_sql_reports#regex DataOciDatabaseToolsDatabaseToolsSqlReports#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
