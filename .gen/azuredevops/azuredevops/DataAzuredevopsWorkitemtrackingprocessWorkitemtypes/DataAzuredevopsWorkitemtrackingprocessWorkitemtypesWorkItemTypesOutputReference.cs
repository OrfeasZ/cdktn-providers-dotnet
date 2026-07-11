using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes
{
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes.DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtypes.DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Color
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Icon
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentWorkItemReferenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentWorkItemReferenceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtypes.DataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypes\"}", isOptional: true)]
        public virtual azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes.IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypes? InternalValue
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes.IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesWorkItemTypes?>();
            set => SetInstanceProperty(value);
        }
    }
}
