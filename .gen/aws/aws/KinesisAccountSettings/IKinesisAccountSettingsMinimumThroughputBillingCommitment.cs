using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAccountSettings
{
    [JsiiInterface(nativeType: typeof(IKinesisAccountSettingsMinimumThroughputBillingCommitment), fullyQualifiedName: "aws.kinesisAccountSettings.KinesisAccountSettingsMinimumThroughputBillingCommitment")]
    public interface IKinesisAccountSettingsMinimumThroughputBillingCommitment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/kinesis_account_settings#status KinesisAccountSettings#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAccountSettingsMinimumThroughputBillingCommitment), fullyQualifiedName: "aws.kinesisAccountSettings.KinesisAccountSettingsMinimumThroughputBillingCommitment")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisAccountSettings.IKinesisAccountSettingsMinimumThroughputBillingCommitment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/kinesis_account_settings#status KinesisAccountSettings#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
