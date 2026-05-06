using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerInstancesContainerInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "containerRestartPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRestartPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersList Containers
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsDnsConfigList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsDnsConfigList DnsConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsDnsConfigList>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gracefulShutdownTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracefulShutdownTimeoutInSeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsImagePullSecretsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsImagePullSecretsList ImagePullSecrets
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsImagePullSecretsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsShapeConfigList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsShapeConfigList>()!;
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

        [JsiiProperty(name: "vnics", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVnicsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVnicsList Vnics
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVnicsList>()!;
        }

        [JsiiProperty(name: "volumeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVolumesList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVolumesList Volumes
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsVolumesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
