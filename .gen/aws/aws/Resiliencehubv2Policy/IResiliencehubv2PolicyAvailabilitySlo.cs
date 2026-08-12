using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Policy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2PolicyAvailabilitySlo), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyAvailabilitySlo")]
    public interface IResiliencehubv2PolicyAvailabilitySlo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#target Resiliencehubv2Policy#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        double Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2PolicyAvailabilitySlo), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyAvailabilitySlo")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Policy.IResiliencehubv2PolicyAvailabilitySlo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/resiliencehubv2_policy#target Resiliencehubv2Policy#target}.</summary>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
            public double Target
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
