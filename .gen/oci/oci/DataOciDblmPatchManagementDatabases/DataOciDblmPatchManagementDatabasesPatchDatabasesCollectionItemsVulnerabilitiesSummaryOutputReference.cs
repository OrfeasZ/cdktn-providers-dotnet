using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDblmPatchManagementDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference), fullyQualifiedName: "oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "critical", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Critical
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "high", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double High
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "info", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Info
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "low", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Low
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Medium
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummary\"}", isOptional: true)]
        public virtual oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummary? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsVulnerabilitiesSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}
