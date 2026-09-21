using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelTopicConfigurationRecordSchema), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfigurationRecordSchema")]
    public interface IMskChannelTopicConfigurationRecordSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#gsr_arn MskChannel#gsr_arn}.</summary>
        [JsiiProperty(name: "gsrArn", typeJson: "{\"primitive\":\"string\"}")]
        string GsrArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelTopicConfigurationRecordSchema), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfigurationRecordSchema")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelTopicConfigurationRecordSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#gsr_arn MskChannel#gsr_arn}.</summary>
            [JsiiProperty(name: "gsrArn", typeJson: "{\"primitive\":\"string\"}")]
            public string GsrArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
