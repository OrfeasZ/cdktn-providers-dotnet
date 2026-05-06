using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmClusterIormConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudVmClusterIormConfigDbPlans), fullyQualifiedName: "oci.databaseCloudVmClusterIormConfig.DatabaseCloudVmClusterIormConfigDbPlans")]
    public interface IDatabaseCloudVmClusterIormConfigDbPlans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#db_name DatabaseCloudVmClusterIormConfig#db_name}.</summary>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        string DbName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#share DatabaseCloudVmClusterIormConfig#share}.</summary>
        [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
        double Share
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudVmClusterIormConfigDbPlans), fullyQualifiedName: "oci.databaseCloudVmClusterIormConfig.DatabaseCloudVmClusterIormConfigDbPlans")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudVmClusterIormConfig.IDatabaseCloudVmClusterIormConfigDbPlans
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#db_name DatabaseCloudVmClusterIormConfig#db_name}.</summary>
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
            public string DbName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster_iorm_config#share DatabaseCloudVmClusterIormConfig#share}.</summary>
            [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
            public double Share
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
