using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Policy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubv2PolicyDataRecovery), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyDataRecovery")]
    public interface IResiliencehubv2PolicyDataRecovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/resiliencehubv2_policy#time_between_backups_in_minutes Resiliencehubv2Policy#time_between_backups_in_minutes}.</summary>
        [JsiiProperty(name: "timeBetweenBackupsInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double TimeBetweenBackupsInMinutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubv2PolicyDataRecovery), fullyQualifiedName: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyDataRecovery")]
        internal sealed class _Proxy : DeputyBase, aws.Resiliencehubv2Policy.IResiliencehubv2PolicyDataRecovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/resiliencehubv2_policy#time_between_backups_in_minutes Resiliencehubv2Policy#time_between_backups_in_minutes}.</summary>
            [JsiiProperty(name: "timeBetweenBackupsInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeBetweenBackupsInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
