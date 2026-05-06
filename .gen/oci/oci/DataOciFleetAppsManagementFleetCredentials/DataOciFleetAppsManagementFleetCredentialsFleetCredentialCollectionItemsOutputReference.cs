using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementFleetCredentials
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsEntitySpecificsList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsEntitySpecificsList EntitySpecifics
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsEntitySpecificsList>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsPasswordList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsPasswordList Password
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsPasswordList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsUserList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsUserList User
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItemsUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetCredentials.DataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementFleetCredentials.IDataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetCredentials.IDataOciFleetAppsManagementFleetCredentialsFleetCredentialCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
