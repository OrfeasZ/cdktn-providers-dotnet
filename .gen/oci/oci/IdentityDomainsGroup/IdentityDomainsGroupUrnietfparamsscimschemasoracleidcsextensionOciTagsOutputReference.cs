using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefinedTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDefinedTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFreeformTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFreeformTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList\"}")]
        public virtual oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList DefinedTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList\"}")]
        public virtual oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList FreeformTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList>()!;
        }

        [JsiiProperty(name: "tagSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TagSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DefinedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FreeformTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
            set => SetInstanceProperty(value);
        }
    }
}
