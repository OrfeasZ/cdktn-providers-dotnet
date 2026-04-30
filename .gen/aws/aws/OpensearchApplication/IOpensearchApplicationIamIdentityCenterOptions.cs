using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchApplication
{
    [JsiiInterface(nativeType: typeof(IOpensearchApplicationIamIdentityCenterOptions), fullyQualifiedName: "aws.opensearchApplication.OpensearchApplicationIamIdentityCenterOptions")]
    public interface IOpensearchApplicationIamIdentityCenterOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#enabled OpensearchApplication#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#iam_identity_center_instance_arn OpensearchApplication#iam_identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "iamIdentityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamIdentityCenterInstanceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#iam_role_for_identity_center_application_arn OpensearchApplication#iam_role_for_identity_center_application_arn}.</summary>
        [JsiiProperty(name: "iamRoleForIdentityCenterApplicationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamRoleForIdentityCenterApplicationArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchApplicationIamIdentityCenterOptions), fullyQualifiedName: "aws.opensearchApplication.OpensearchApplicationIamIdentityCenterOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchApplication.IOpensearchApplicationIamIdentityCenterOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#enabled OpensearchApplication#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#iam_identity_center_instance_arn OpensearchApplication#iam_identity_center_instance_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamIdentityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamIdentityCenterInstanceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#iam_role_for_identity_center_application_arn OpensearchApplication#iam_role_for_identity_center_application_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamRoleForIdentityCenterApplicationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamRoleForIdentityCenterApplicationArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
