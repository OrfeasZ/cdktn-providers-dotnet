using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference), fullyQualifiedName: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValues\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutValues(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValues[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValues).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValues).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "values", typeJson: "{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValuesList\"}")]
        public virtual oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValuesList Values
        {
            get => GetInstanceProperty<oci.DatascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValuesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valuesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItemsValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ValuesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupCloneSourceDetailsPatchModelGroupMemberModelDetailsItems).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
