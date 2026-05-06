using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelGroup.DatascienceModelGroupMemberModelEntriesOutputReference), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelGroupMemberModelEntriesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelGroupMemberModelEntriesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelGroupMemberModelEntriesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupMemberModelEntriesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMemberModelDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMemberModelDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMemberModelDetails")]
        public virtual void ResetMemberModelDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "memberModelDetails", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetailsList\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetailsList MemberModelDetails
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "memberModelDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MemberModelDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntries\"}", isOptional: true)]
        public virtual oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntries? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntries?>();
            set => SetInstanceProperty(value);
        }
    }
}
