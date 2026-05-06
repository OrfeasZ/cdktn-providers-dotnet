using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalDatabaseConnector
{
    [JsiiInterface(nativeType: typeof(IDatabaseExternalDatabaseConnectorConnectionString), fullyQualifiedName: "oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionString")]
    public interface IDatabaseExternalDatabaseConnectorConnectionString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#hostname DatabaseExternalDatabaseConnector#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#port DatabaseExternalDatabaseConnector#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#protocol DatabaseExternalDatabaseConnector#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#service DatabaseExternalDatabaseConnector#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        string Service
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExternalDatabaseConnectorConnectionString), fullyQualifiedName: "oci.databaseExternalDatabaseConnector.DatabaseExternalDatabaseConnectorConnectionString")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExternalDatabaseConnector.IDatabaseExternalDatabaseConnectorConnectionString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#hostname DatabaseExternalDatabaseConnector#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#port DatabaseExternalDatabaseConnector#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#protocol DatabaseExternalDatabaseConnector#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_external_database_connector#service DatabaseExternalDatabaseConnector#service}.</summary>
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
            public string Service
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
