using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putModelGroupDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails\"}}]")]
        public virtual void PutModelGroupDetails(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelGroupDetails")]
        public virtual void ResetModelGroupDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelGroupVersionHistoryId")]
        public virtual void ResetModelGroupVersionHistoryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionLabel")]
        public virtual void ResetVersionLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "modelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference ModelGroupDetails
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelGroupDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails? ModelGroupDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelGroupVersionHistoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelGroupVersionHistoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelGroupVersionHistoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelGroupVersionHistoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
