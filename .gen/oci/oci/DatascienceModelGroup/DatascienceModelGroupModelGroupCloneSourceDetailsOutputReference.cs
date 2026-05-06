using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupModelGroupCloneSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putModifyModelGroupDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}}]")]
        public virtual void PutModifyModelGroupDetails(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPatchModelGroupMemberModelDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails\"}}]")]
        public virtual void PutPatchModelGroupMemberModelDetails(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetModifyModelGroupDetails")]
        public virtual void ResetModifyModelGroupDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchModelGroupMemberModelDetails")]
        public virtual void ResetPatchModelGroupMemberModelDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "modifyModelGroupDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference ModifyModelGroupDetails
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "patchModelGroupMemberModelDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsOutputReference\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsOutputReference PatchModelGroupMemberModelDetails
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelGroupCloneSourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelGroupCloneSourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifyModelGroupDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails? ModifyModelGroupDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchModelGroupMemberModelDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails? PatchModelGroupMemberModelDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "modelGroupCloneSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelGroupCloneSourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
