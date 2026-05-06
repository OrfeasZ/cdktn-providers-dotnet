using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "flowControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowControl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupAutoIncrement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupAutoIncrement
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionItemsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionItemsList>()!;
        }

        [JsiiProperty(name: "memberRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "singlePrimaryMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SinglePrimaryMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusSummary", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryList StatusSummary
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryList>()!;
        }

        [JsiiProperty(name: "transactionsInGtidExecuted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionsInGtidExecuted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollection\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.IDataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.IDataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
