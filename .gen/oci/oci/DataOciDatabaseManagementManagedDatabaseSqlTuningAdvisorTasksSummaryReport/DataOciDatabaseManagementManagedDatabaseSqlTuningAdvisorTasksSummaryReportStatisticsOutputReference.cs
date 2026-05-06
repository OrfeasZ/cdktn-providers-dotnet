using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "findingBenefits", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingBenefitsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingBenefitsList FindingBenefits
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingBenefitsList>()!;
        }

        [JsiiProperty(name: "findingCounts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingCountsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingCountsList FindingCounts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsFindingCountsList>()!;
        }

        [JsiiProperty(name: "statementCounts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsStatementCountsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsStatementCountsList StatementCounts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatisticsStatementCountsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatistics\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatistics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReport.IDataOciDatabaseManagementManagedDatabaseSqlTuningAdvisorTasksSummaryReportStatistics?>();
            set => SetInstanceProperty(value);
        }
    }
}
