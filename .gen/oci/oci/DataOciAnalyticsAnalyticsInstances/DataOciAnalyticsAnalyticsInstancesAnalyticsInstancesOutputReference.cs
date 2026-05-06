using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAnalyticsAnalyticsInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference), fullyQualifiedName: "oci.dataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesCapacityList\"}")]
        public virtual oci.DataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesCapacityList Capacity
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesCapacityList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailNotification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailNotification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "featureBundle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureBundle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAccessToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesNetworkEndpointDetailsList\"}")]
        public virtual oci.DataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesNetworkEndpointDetailsList NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstancesNetworkEndpointDetailsList>()!;
        }

        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUrl
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "updateChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateChannel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstances.DataOciAnalyticsAnalyticsInstancesAnalyticsInstances\"}", isOptional: true)]
        public virtual oci.DataOciAnalyticsAnalyticsInstances.IDataOciAnalyticsAnalyticsInstancesAnalyticsInstances? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstances.IDataOciAnalyticsAnalyticsInstancesAnalyticsInstances?>();
            set => SetInstanceProperty(value);
        }
    }
}
