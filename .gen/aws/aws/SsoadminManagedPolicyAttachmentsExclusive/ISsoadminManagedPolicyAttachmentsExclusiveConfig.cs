using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminManagedPolicyAttachmentsExclusive
{
    [JsiiInterface(nativeType: typeof(ISsoadminManagedPolicyAttachmentsExclusiveConfig), fullyQualifiedName: "aws.ssoadminManagedPolicyAttachmentsExclusive.SsoadminManagedPolicyAttachmentsExclusiveConfig")]
    public interface ISsoadminManagedPolicyAttachmentsExclusiveConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#instance_arn SsoadminManagedPolicyAttachmentsExclusive#instance_arn}.</summary>
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#managed_policy_arns SsoadminManagedPolicyAttachmentsExclusive#managed_policy_arns}.</summary>
        [JsiiProperty(name: "managedPolicyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ManagedPolicyArns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#permission_set_arn SsoadminManagedPolicyAttachmentsExclusive#permission_set_arn}.</summary>
        [JsiiProperty(name: "permissionSetArn", typeJson: "{\"primitive\":\"string\"}")]
        string PermissionSetArn
        {
            get;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#region SsoadminManagedPolicyAttachmentsExclusive#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#timeouts SsoadminManagedPolicyAttachmentsExclusive#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ssoadminManagedPolicyAttachmentsExclusive.SsoadminManagedPolicyAttachmentsExclusiveTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SsoadminManagedPolicyAttachmentsExclusive.ISsoadminManagedPolicyAttachmentsExclusiveTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminManagedPolicyAttachmentsExclusiveConfig), fullyQualifiedName: "aws.ssoadminManagedPolicyAttachmentsExclusive.SsoadminManagedPolicyAttachmentsExclusiveConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminManagedPolicyAttachmentsExclusive.ISsoadminManagedPolicyAttachmentsExclusiveConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#instance_arn SsoadminManagedPolicyAttachmentsExclusive#instance_arn}.</summary>
            [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#managed_policy_arns SsoadminManagedPolicyAttachmentsExclusive#managed_policy_arns}.</summary>
            [JsiiProperty(name: "managedPolicyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ManagedPolicyArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#permission_set_arn SsoadminManagedPolicyAttachmentsExclusive#permission_set_arn}.</summary>
            [JsiiProperty(name: "permissionSetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string PermissionSetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#region SsoadminManagedPolicyAttachmentsExclusive#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ssoadmin_managed_policy_attachments_exclusive#timeouts SsoadminManagedPolicyAttachmentsExclusive#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ssoadminManagedPolicyAttachmentsExclusive.SsoadminManagedPolicyAttachmentsExclusiveTimeouts\"}", isOptional: true)]
            public aws.SsoadminManagedPolicyAttachmentsExclusive.ISsoadminManagedPolicyAttachmentsExclusiveTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.SsoadminManagedPolicyAttachmentsExclusive.ISsoadminManagedPolicyAttachmentsExclusiveTimeouts?>();
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
