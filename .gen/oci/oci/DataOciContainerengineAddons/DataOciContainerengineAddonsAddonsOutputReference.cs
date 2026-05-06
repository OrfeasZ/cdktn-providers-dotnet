using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineAddons
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineAddons.DataOciContainerengineAddonsAddonsOutputReference), fullyQualifiedName: "oci.dataOciContainerengineAddons.DataOciContainerengineAddonsAddonsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerengineAddonsAddonsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerengineAddonsAddonsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerengineAddonsAddonsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineAddonsAddonsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addonError", typeJson: "{\"fqn\":\"oci.dataOciContainerengineAddons.DataOciContainerengineAddonsAddonsAddonErrorList\"}")]
        public virtual oci.DataOciContainerengineAddons.DataOciContainerengineAddonsAddonsAddonErrorList AddonError
        {
            get => GetInstanceProperty<oci.DataOciContainerengineAddons.DataOciContainerengineAddonsAddonsAddonErrorList>()!;
        }

        [JsiiProperty(name: "addonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddonName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"fqn\":\"oci.dataOciContainerengineAddons.DataOciContainerengineAddonsAddonsConfigurationsList\"}")]
        public virtual oci.DataOciContainerengineAddons.DataOciContainerengineAddonsAddonsConfigurationsList Configurations
        {
            get => GetInstanceProperty<oci.DataOciContainerengineAddons.DataOciContainerengineAddonsAddonsConfigurationsList>()!;
        }

        [JsiiProperty(name: "currentInstalledVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentInstalledVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overrideExisting", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OverrideExisting
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "removeAddonResourcesOnDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoveAddonResourcesOnDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerengineAddons.DataOciContainerengineAddonsAddons\"}", isOptional: true)]
        public virtual oci.DataOciContainerengineAddons.IDataOciContainerengineAddonsAddons? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerengineAddons.IDataOciContainerengineAddonsAddons?>();
            set => SetInstanceProperty(value);
        }
    }
}
