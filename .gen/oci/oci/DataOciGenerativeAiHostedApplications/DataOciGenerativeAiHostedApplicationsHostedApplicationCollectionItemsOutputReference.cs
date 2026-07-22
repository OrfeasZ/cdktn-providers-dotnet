using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiHostedApplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsEnvironmentVariablesList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsEnvironmentVariablesList EnvironmentVariables
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsEnvironmentVariablesList>()!;
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

        [JsiiProperty(name: "inboundAuthConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsInboundAuthConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsInboundAuthConfigList InboundAuthConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsInboundAuthConfigList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkingConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsNetworkingConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsNetworkingConfigList NetworkingConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsNetworkingConfigList>()!;
        }

        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsScalingConfigList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsScalingConfigList ScalingConfig
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsScalingConfigList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageConfigs", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsStorageConfigsList\"}")]
        public virtual oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsStorageConfigsList StorageConfigs
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItemsStorageConfigsList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiHostedApplications.DataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiHostedApplications.IDataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiHostedApplications.IDataOciGenerativeAiHostedApplicationsHostedApplicationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
