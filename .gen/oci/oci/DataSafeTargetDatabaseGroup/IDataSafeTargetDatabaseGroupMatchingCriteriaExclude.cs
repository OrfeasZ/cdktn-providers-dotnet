using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabaseGroup
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabaseGroupMatchingCriteriaExclude), fullyQualifiedName: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude")]
    public interface IDataSafeTargetDatabaseGroupMatchingCriteriaExclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#target_database_ids DataSafeTargetDatabaseGroup#target_database_ids}.</summary>
        [JsiiProperty(name: "targetDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TargetDatabaseIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabaseGroupMatchingCriteriaExclude), fullyQualifiedName: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#target_database_ids DataSafeTargetDatabaseGroup#target_database_ids}.</summary>
            [JsiiProperty(name: "targetDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TargetDatabaseIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
