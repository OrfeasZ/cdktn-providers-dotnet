using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlConfigurationInitVariables), fullyQualifiedName: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariables")]
    public interface IMysqlMysqlConfigurationInitVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#lower_case_table_names MysqlMysqlConfiguration#lower_case_table_names}.</summary>
        [JsiiProperty(name: "lowerCaseTableNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LowerCaseTableNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlConfigurationInitVariables), fullyQualifiedName: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariables")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationInitVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_configuration#lower_case_table_names MysqlMysqlConfiguration#lower_case_table_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lowerCaseTableNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LowerCaseTableNames
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
