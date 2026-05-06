using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataIormConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadataIormConfigDbPlans), fullyQualifiedName: "oci.databaseExadataIormConfig.DatabaseExadataIormConfigDbPlans")]
    public interface IDatabaseExadataIormConfigDbPlans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#db_name DatabaseExadataIormConfig#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        string DbName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#share DatabaseExadataIormConfig#share}.</summary>
        [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
        double Share
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadataIormConfigDbPlans), fullyQualifiedName: "oci.databaseExadataIormConfig.DatabaseExadataIormConfigDbPlans")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadataIormConfig.IDatabaseExadataIormConfigDbPlans
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#db_name DatabaseExadataIormConfig#db_name}.</summary>
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
            public string DbName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_iorm_config#share DatabaseExadataIormConfig#share}.</summary>
            [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
            public double Share
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
