using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    [JsiiInterface(nativeType: typeof(ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails), fullyQualifiedName: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails")]
    public interface ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#logging_query_type CloudGuardDataSource#logging_query_type}.</summary>
        [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}")]
        string LoggingQueryType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#key_entities_count CloudGuardDataSource#key_entities_count}.</summary>
        [JsiiProperty(name: "keyEntitiesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeyEntitiesCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails), fullyQualifiedName: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#logging_query_type CloudGuardDataSource#logging_query_type}.</summary>
            [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}")]
            public string LoggingQueryType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_data_source#key_entities_count CloudGuardDataSource#key_entities_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyEntitiesCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeyEntitiesCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
