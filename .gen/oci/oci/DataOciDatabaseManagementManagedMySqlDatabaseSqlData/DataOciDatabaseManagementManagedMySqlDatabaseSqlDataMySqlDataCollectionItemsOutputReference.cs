using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseSqlData
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseSqlData.DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseSqlData.DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "avgTimerWait", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvgTimerWait
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "countStar", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CountStar
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Digest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "digestText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DigestText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "heatWaveOffloaded", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeatWaveOffloaded
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "heatWaveOutOfMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeatWaveOutOfMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxControlledMemory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxControlledMemory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxTimerWait", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTimerWait
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxTotalMemory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxTotalMemory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minTimerWait", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinTimerWait
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "quantile95", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantile95
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "quantile99", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantile99
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "quantile999", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantile999
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sumCpuTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SumCpuTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sumCreatedTempDiskTables", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumCreatedTempDiskTables
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumCreatedTempTables", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumCreatedTempTables
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumErrors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumErrors
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumLockTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumLockTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumNoGoodIndexUsed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumNoGoodIndexUsed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumNoIndexUsed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumNoIndexUsed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumRowsAffected", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumRowsAffected
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumRowsExamined", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumRowsExamined
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumRowsSent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumRowsSent
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSelectFullJoin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSelectFullJoin
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSelectFullRangeJoin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSelectFullRangeJoin
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSelectRange", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSelectRange
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSelectRangeCheck", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSelectRangeCheck
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSelectScan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSelectScan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSortMergePasses", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSortMergePasses
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSortRange", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSortRange
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSortRows", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSortRows
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumSortScan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumSortScan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumTimerWait", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumTimerWait
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sumWarnings", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SumWarnings
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseSqlData.DataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseSqlData.IDataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseSqlData.IDataOciDatabaseManagementManagedMySqlDatabaseSqlDataMySqlDataCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
