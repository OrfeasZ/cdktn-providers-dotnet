using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerInstancesContainerInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference), fullyQualifiedName: "oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Arguments
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerInstanceId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap EnvironmentVariables
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "exitCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExitCode
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksList HealthChecks
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersHealthChecksList>()!;
        }

        [JsiiProperty(name: "imageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isResourcePrincipalDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsResourcePrincipalDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersResourceConfigList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersResourceConfigList ResourceConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersResourceConfigList>()!;
        }

        [JsiiProperty(name: "securityContext", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersSecurityContextList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersSecurityContextList SecurityContext
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersSecurityContextList>()!;
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

        [JsiiProperty(name: "timeTerminated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeTerminated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeMounts", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersVolumeMountsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersVolumeMountsList VolumeMounts
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainersVolumeMountsList>()!;
        }

        [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkingDirectory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstances.DataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainers\"}", isOptional: true)]
        public virtual oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstances.IDataOciContainerInstancesContainerInstancesContainerInstanceCollectionItemsContainers?>();
            set => SetInstanceProperty(value);
        }
    }
}
