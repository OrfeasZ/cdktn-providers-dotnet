using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ShieldDrtAccessLogBucketAssociation
{
    [JsiiInterface(nativeType: typeof(IShieldDrtAccessLogBucketAssociationConfig), fullyQualifiedName: "aws.shieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationConfig")]
    public interface IShieldDrtAccessLogBucketAssociationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#log_bucket ShieldDrtAccessLogBucketAssociation#log_bucket}.</summary>
        [JsiiProperty(name: "logBucket", typeJson: "{\"primitive\":\"string\"}")]
        string LogBucket
        {
            get;
        }

        /// <summary>Unused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#role_arn_association_id ShieldDrtAccessLogBucketAssociation#role_arn_association_id}
        /// </remarks>
        [JsiiProperty(name: "roleArnAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArnAssociationId
        {
            get;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#timeouts ShieldDrtAccessLogBucketAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.shieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ShieldDrtAccessLogBucketAssociation.IShieldDrtAccessLogBucketAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShieldDrtAccessLogBucketAssociationConfig), fullyQualifiedName: "aws.shieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ShieldDrtAccessLogBucketAssociation.IShieldDrtAccessLogBucketAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#log_bucket ShieldDrtAccessLogBucketAssociation#log_bucket}.</summary>
            [JsiiProperty(name: "logBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string LogBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Unused.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#role_arn_association_id ShieldDrtAccessLogBucketAssociation#role_arn_association_id}
            /// </remarks>
            [JsiiProperty(name: "roleArnAssociationId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArnAssociationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/shield_drt_access_log_bucket_association#timeouts ShieldDrtAccessLogBucketAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.shieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationTimeouts\"}", isOptional: true)]
            public aws.ShieldDrtAccessLogBucketAssociation.IShieldDrtAccessLogBucketAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ShieldDrtAccessLogBucketAssociation.IShieldDrtAccessLogBucketAssociationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
