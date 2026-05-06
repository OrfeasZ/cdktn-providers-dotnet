using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementProvision
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementProvisionDeployedResourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceInstanceList", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesResourceInstanceListStructList\"}")]
        public virtual oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesResourceInstanceListStructList ResourceInstanceList
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResourcesResourceInstanceListStructList>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementProvision.DataOciFleetAppsManagementProvisionDeployedResources\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementProvision.IDataOciFleetAppsManagementProvisionDeployedResources? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementProvision.IDataOciFleetAppsManagementProvisionDeployedResources?>();
            set => SetInstanceProperty(value);
        }
    }
}
