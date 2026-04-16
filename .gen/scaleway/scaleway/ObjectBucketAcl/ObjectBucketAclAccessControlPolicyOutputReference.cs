using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    [JsiiClass(nativeType: typeof(scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyOutputReference), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObjectBucketAclAccessControlPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObjectBucketAclAccessControlPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObjectBucketAclAccessControlPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectBucketAclAccessControlPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrant(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOwner", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwner\"}}]")]
        public virtual void PutOwner(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrant")]
        public virtual void ResetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grant", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantList\"}")]
        public virtual scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyGrantList Grant
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyGrantList>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwnerOutputReference\"}")]
        public virtual scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyOwnerOutputReference Owner
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyOwnerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GrantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwner\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner? OwnerInput
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicy\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicy? InternalValue
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
