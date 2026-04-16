using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketAcl
{
    [JsiiInterface(nativeType: typeof(IObjectBucketAclAccessControlPolicyGrantGrantee), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee")]
    public interface IObjectBucketAclAccessControlPolicyGrantGrantee
    {
        /// <summary>The project ID owner of the grantee.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#id ObjectBucketAcl#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of grantee. Valid values: `CanonicalUser`, `Group`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#type ObjectBucketAcl#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>The uri of the grantee if you are granting permissions to a predefined group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#uri ObjectBucketAcl#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketAclAccessControlPolicyGrantGrantee), fullyQualifiedName: "scaleway.objectBucketAcl.ObjectBucketAclAccessControlPolicyGrantGrantee")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketAcl.IObjectBucketAclAccessControlPolicyGrantGrantee
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The project ID owner of the grantee.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#id ObjectBucketAcl#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of grantee. Valid values: `CanonicalUser`, `Group`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#type ObjectBucketAcl#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The uri of the grantee if you are granting permissions to a predefined group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_acl#uri ObjectBucketAcl#uri}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
