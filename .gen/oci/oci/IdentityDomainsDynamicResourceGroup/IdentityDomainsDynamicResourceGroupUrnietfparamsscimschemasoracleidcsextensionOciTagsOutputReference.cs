using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsDynamicResourceGroup
{
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference), fullyQualifiedName: "oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefinedTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDefinedTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFreeformTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFreeformTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList\"}")]
        public virtual oci.IdentityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList DefinedTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTagsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList\"}")]
        public virtual oci.IdentityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList FreeformTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTagsList>()!;
        }

        [JsiiProperty(name: "tagSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TagSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsDefinedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DefinedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsFreeformTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FreeformTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.identityDomainsDynamicResourceGroup.IdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public virtual oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags? InternalValue
        {
            get => GetInstanceProperty<oci.IdentityDomainsDynamicResourceGroup.IIdentityDomainsDynamicResourceGroupUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
            set => SetInstanceProperty(value);
        }
    }
}
