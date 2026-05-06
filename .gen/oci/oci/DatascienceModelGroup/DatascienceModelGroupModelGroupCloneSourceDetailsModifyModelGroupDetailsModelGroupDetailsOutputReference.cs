using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomMetadataList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomMetadataList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBaseModelId")]
        public virtual void ResetBaseModelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomMetadataList")]
        public virtual void ResetCustomMetadataList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customMetadataList", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStructList\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStructList CustomMetadataList
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseModelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customMetadataListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetailsCustomMetadataListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomMetadataListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "baseModelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsModifyModelGroupDetailsModelGroupDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
