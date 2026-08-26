using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2ServicePermissionModelCrossAccountRole), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole")]
    public interface IResiliencehubv2ServicePermissionModelCrossAccountRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#cross_account_role_arn Resiliencehubv2Service#cross_account_role_arn}.</summary>
        [JsiiProperty(name: "crossAccountRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string CrossAccountRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#external_id Resiliencehubv2Service#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2ServicePermissionModelCrossAccountRole), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#cross_account_role_arn Resiliencehubv2Service#cross_account_role_arn}.</summary>
            [JsiiProperty(name: "crossAccountRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CrossAccountRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#external_id Resiliencehubv2Service#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
