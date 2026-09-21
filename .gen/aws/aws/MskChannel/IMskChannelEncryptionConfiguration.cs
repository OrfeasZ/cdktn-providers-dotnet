using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelEncryptionConfiguration), fullyQualifiedName: "aws.mskChannel.MskChannelEncryptionConfiguration")]
    public interface IMskChannelEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#kms_key_arn MskChannel#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelEncryptionConfiguration), fullyQualifiedName: "aws.mskChannel.MskChannelEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#kms_key_arn MskChannel#kms_key_arn}.</summary>
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
