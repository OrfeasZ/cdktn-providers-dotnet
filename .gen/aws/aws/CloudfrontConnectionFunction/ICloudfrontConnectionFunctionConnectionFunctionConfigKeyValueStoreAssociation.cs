using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontConnectionFunction
{
    [JsiiInterface(nativeType: typeof(ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation), fullyQualifiedName: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation")]
    public interface ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#key_value_store_arn CloudfrontConnectionFunction#key_value_store_arn}.</summary>
        [JsiiProperty(name: "keyValueStoreArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyValueStoreArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation), fullyQualifiedName: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#key_value_store_arn CloudfrontConnectionFunction#key_value_store_arn}.</summary>
            [JsiiProperty(name: "keyValueStoreArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyValueStoreArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
