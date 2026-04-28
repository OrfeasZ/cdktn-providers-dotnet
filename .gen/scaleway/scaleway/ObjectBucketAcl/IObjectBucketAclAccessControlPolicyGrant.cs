using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    [JsiiInterface(nativeType: typeof(IObjectBucketAclAccessControlPolicyGrant), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant")]
    public interface IObjectBucketAclAccessControlPolicyGrant
    {
        /// <summary>Logging permissions assigned to the grantee for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#permission ObjectBucketAcl#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#grantee ObjectBucketAcl#grantee}
        /// </remarks>
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee? Grantee
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketAclAccessControlPolicyGrant), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Logging permissions assigned to the grantee for the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#permission ObjectBucketAcl#permission}
            /// </remarks>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>grantee block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#grantee ObjectBucketAcl#grantee}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
            public scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee? Grantee
            {
                get => GetInstanceProperty<scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee?>();
            }
        }
    }
}
