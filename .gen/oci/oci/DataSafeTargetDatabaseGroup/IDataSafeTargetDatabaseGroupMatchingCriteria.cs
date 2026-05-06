using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabaseGroup
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabaseGroupMatchingCriteria), fullyQualifiedName: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteria")]
    public interface IDataSafeTargetDatabaseGroupMatchingCriteria
    {
        /// <summary>include block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#include DataSafeTargetDatabaseGroup#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude\"}")]
        oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude Include
        {
            get;
        }

        /// <summary>exclude block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#exclude DataSafeTargetDatabaseGroup#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude? Exclude
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabaseGroupMatchingCriteria), fullyQualifiedName: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteria")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>include block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#include DataSafeTargetDatabaseGroup#include}
            /// </remarks>
            [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude\"}")]
            public oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude Include
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude>()!;
            }

            /// <summary>exclude block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#exclude DataSafeTargetDatabaseGroup#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude\"}", isOptional: true)]
            public oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude? Exclude
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude?>();
            }
        }
    }
}
