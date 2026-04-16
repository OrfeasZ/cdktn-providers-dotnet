using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    [JsiiInterface(nativeType: typeof(IObjectBucketAclAccessControlPolicy), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicy")]
    public interface IObjectBucketAclAccessControlPolicy
    {
        /// <summary>owner block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#owner ObjectBucketAcl#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwner\"}")]
        scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner Owner
        {
            get;
        }

        /// <summary>grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#grant ObjectBucketAcl#grant}
        /// </remarks>
        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Grant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketAclAccessControlPolicy), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>owner block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#owner ObjectBucketAcl#owner}
            /// </remarks>
            [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwner\"}")]
            public scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner Owner
            {
                get => GetInstanceProperty<scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner>()!;
            }

            /// <summary>grant block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#grant ObjectBucketAcl#grant}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Grant
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
