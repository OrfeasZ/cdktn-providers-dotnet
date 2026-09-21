using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelTopicConfigurationRecordConverter), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfigurationRecordConverter")]
    public interface IMskChannelTopicConfigurationRecordConverter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#value_converter MskChannel#value_converter}.</summary>
        [JsiiProperty(name: "valueConverter", typeJson: "{\"primitive\":\"string\"}")]
        string ValueConverter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelTopicConfigurationRecordConverter), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfigurationRecordConverter")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelTopicConfigurationRecordConverter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#value_converter MskChannel#value_converter}.</summary>
            [JsiiProperty(name: "valueConverter", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueConverter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
