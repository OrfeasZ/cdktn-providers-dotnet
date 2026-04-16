using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    [JsiiClass(nativeType: typeof(scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyGrantOutputReference), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ObjectBucketAclAccessControlPolicyGrantOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ObjectBucketAclAccessControlPolicyGrantOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ObjectBucketAclAccessControlPolicyGrantOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectBucketAclAccessControlPolicyGrantOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrantee", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee\"}}]")]
        public virtual void PutGrantee(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrantee")]
        public virtual void ResetGrantee()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGranteeOutputReference\"}")]
        public virtual scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGranteeOutputReference Grantee
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGranteeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "granteeInput", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee? GranteeInput
        {
            get => GetInstanceProperty<scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PermissionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permission
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"}]}}", isOptional: true)]
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
                        case scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
