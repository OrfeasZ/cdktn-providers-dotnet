using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    [JsiiInterface(nativeType: typeof(IMysqlMysqlConfigurationOptions), fullyQualifiedName: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationOptions")]
    public interface IMysqlMysqlConfigurationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#name MysqlMysqlConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#value MysqlMysqlConfiguration#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlMysqlConfigurationOptions), fullyQualifiedName: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationOptions")]
        internal sealed class _Proxy : DeputyBase, oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#name MysqlMysqlConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/mysql_mysql_configuration#value MysqlMysqlConfiguration#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
