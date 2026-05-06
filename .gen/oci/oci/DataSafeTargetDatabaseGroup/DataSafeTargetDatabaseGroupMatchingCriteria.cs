using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabaseGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteria")]
    public class DataSafeTargetDatabaseGroupMatchingCriteria : oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteria
    {
        /// <summary>include block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#include DataSafeTargetDatabaseGroup#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude\"}")]
        public oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude Include
        {
            get;
            set;
        }

        /// <summary>exclude block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#exclude DataSafeTargetDatabaseGroup#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaExclude\"}", isOptional: true)]
        public oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaExclude? Exclude
        {
            get;
            set;
        }
    }
}
