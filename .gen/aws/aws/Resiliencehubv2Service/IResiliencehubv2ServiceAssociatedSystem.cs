using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2ServiceAssociatedSystem), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServiceAssociatedSystem")]
    public interface IResiliencehubv2ServiceAssociatedSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#system_arn Resiliencehubv2Service#system_arn}.</summary>
        [JsiiProperty(name: "systemArn", typeJson: "{\"primitive\":\"string\"}")]
        string SystemArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#user_journey_ids Resiliencehubv2Service#user_journey_ids}.</summary>
        [JsiiProperty(name: "userJourneyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UserJourneyIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2ServiceAssociatedSystem), fullyQualifiedName: "aws.resiliencehubv2Service.Resiliencehubv2ServiceAssociatedSystem")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Service.IResiliencehubv2ServiceAssociatedSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#system_arn Resiliencehubv2Service#system_arn}.</summary>
            [JsiiProperty(name: "systemArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SystemArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#user_journey_ids Resiliencehubv2Service#user_journey_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userJourneyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UserJourneyIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
