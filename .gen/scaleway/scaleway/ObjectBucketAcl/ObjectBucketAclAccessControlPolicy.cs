using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicy")]
    public class ObjectBucketAclAccessControlPolicy : scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicy
    {
        /// <summary>owner block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#owner ObjectBucketAcl#owner}
        /// </remarks>
        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyOwner\"}")]
        public scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyOwner Owner
        {
            get;
            set;
        }

        private object? _grant;

        /// <summary>grant block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#grant ObjectBucketAcl#grant}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Grant
        {
            get => _grant;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrant).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grant = value;
            }
        }
    }
}
