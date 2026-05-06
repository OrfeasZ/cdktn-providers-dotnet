using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementRunbooks
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnFailure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationPreferences", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesNotificationPreferencesList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesNotificationPreferencesList NotificationPreferences
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesNotificationPreferencesList>()!;
        }

        [JsiiProperty(name: "pauseDetails", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesPauseDetailsList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesPauseDetailsList PauseDetails
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesPauseDetailsList>()!;
        }

        [JsiiProperty(name: "preCondition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreCondition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runOn", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesRunOnList\"}")]
        public virtual oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesRunOnList RunOn
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsPropertiesRunOnList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementRunbooks.DataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsProperties\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementRunbooks.IDataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsProperties? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementRunbooks.IDataOciFleetAppsManagementRunbooksRunbookCollectionItemsRunbookVersionGroupsProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
