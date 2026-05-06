using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChannelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fetchError", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsFetchErrorList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsFetchErrorList FetchError
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrorsFetchErrorList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrors\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.IDataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrors? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembers.IDataOciDatabaseManagementManagedMySqlDatabaseHighAvailabilityMembersManagedMySqlDatabaseHighAvailabilityMemberCollectionStatusSummaryChannelFetchErrors?>();
            set => SetInstanceProperty(value);
        }
    }
}
