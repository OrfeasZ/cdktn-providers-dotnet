using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModel")]
    public class Resiliencehubv2ServicePermissionModel : aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_service#invoker_role_name Resiliencehubv2Service#invoker_role_name}.</summary>
        [JsiiProperty(name: "invokerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        public string InvokerRoleName
        {
            get;
            set;
        }

        private object? _crossAccountRole;

        /// <summary>cross_account_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_service#cross_account_role Resiliencehubv2Service#cross_account_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CrossAccountRole
        {
            get => _crossAccountRole;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _crossAccountRole = value;
            }
        }
    }
}
