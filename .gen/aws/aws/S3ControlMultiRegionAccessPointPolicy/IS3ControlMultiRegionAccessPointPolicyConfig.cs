using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPointPolicy
{
    [JsiiInterface(nativeType: typeof(IS3ControlMultiRegionAccessPointPolicyConfig), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyConfig")]
    public interface IS3ControlMultiRegionAccessPointPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#details S3ControlMultiRegionAccessPointPolicy#details}
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetails\"}")]
        aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails Details
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#account_id S3ControlMultiRegionAccessPointPolicy#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#id S3ControlMultiRegionAccessPointPolicy#id}.</summary>
        /// <remarks>
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

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#region S3ControlMultiRegionAccessPointPolicy#region}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#timeouts S3ControlMultiRegionAccessPointPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlMultiRegionAccessPointPolicyConfig), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#details S3ControlMultiRegionAccessPointPolicy#details}
            /// </remarks>
            [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetails\"}")]
            public aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails Details
            {
                get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#account_id S3ControlMultiRegionAccessPointPolicy#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#id S3ControlMultiRegionAccessPointPolicy#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#region S3ControlMultiRegionAccessPointPolicy#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3control_multi_region_access_point_policy#timeouts S3ControlMultiRegionAccessPointPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeouts\"}", isOptional: true)]
            public aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyTimeouts?>();
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
