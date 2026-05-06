using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementFleet
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementFleetCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementFleetCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementFleetCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementFleetCredentialsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsEntitySpecificsList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsEntitySpecificsList EntitySpecifics
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsEntitySpecificsList>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsPasswordList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsPasswordList Password
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsPasswordList>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsUserList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsUserList User
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentialsUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleet.DataOciFleetAppsManagementFleetCredentials\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementFleet.IDataOciFleetAppsManagementFleetCredentials? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleet.IDataOciFleetAppsManagementFleetCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
