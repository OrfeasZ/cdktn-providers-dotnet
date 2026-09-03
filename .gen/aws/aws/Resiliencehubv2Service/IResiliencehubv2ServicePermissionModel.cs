using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2ServicePermissionModel), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModel")]
    public interface IResiliencehubv2ServicePermissionModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#invoker_role_name Resiliencehubv2Service#invoker_role_name}.</summary>
        [JsiiProperty(name: "invokerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        string InvokerRoleName
        {
            get;
        }

        /// <summary>cross_account_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#cross_account_role Resiliencehubv2Service#cross_account_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossAccountRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2ServicePermissionModel), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModel")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#invoker_role_name Resiliencehubv2Service#invoker_role_name}.</summary>
            [JsiiProperty(name: "invokerRoleName", typeJson: "{\"primitive\":\"string\"}")]
            public string InvokerRoleName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cross_account_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#cross_account_role Resiliencehubv2Service#cross_account_role}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossAccountRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CrossAccountRole
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
