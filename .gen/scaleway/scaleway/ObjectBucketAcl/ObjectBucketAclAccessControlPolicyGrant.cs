using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant")]
    public class ObjectBucketAclAccessControlPolicyGrant : scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant
    {
        /// <summary>Logging permissions assigned to the grantee for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#permission ObjectBucketAcl#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }

        /// <summary>grantee block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_acl#grantee ObjectBucketAcl#grantee}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee\"}", isOptional: true)]
        public scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee? Grantee
        {
            get;
            set;
        }
    }
}
