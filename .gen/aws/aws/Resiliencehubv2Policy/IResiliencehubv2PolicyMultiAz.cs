using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Policy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2PolicyMultiAz), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyMultiAz")]
    public interface IResiliencehubv2PolicyMultiAz
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#disaster_recovery_approach Resiliencehubv2Policy#disaster_recovery_approach}.</summary>
        [JsiiProperty(name: "disasterRecoveryApproach", typeJson: "{\"primitive\":\"string\"}")]
        string DisasterRecoveryApproach
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#rpo_in_minutes Resiliencehubv2Policy#rpo_in_minutes}.</summary>
        [JsiiProperty(name: "rpoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RpoInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#rto_in_minutes Resiliencehubv2Policy#rto_in_minutes}.</summary>
        [JsiiProperty(name: "rtoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RtoInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2PolicyMultiAz), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyMultiAz")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Policy.IResiliencehubv2PolicyMultiAz
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#disaster_recovery_approach Resiliencehubv2Policy#disaster_recovery_approach}.</summary>
            [JsiiProperty(name: "disasterRecoveryApproach", typeJson: "{\"primitive\":\"string\"}")]
            public string DisasterRecoveryApproach
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#rpo_in_minutes Resiliencehubv2Policy#rpo_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rpoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RpoInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#rto_in_minutes Resiliencehubv2Policy#rto_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rtoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RtoInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
