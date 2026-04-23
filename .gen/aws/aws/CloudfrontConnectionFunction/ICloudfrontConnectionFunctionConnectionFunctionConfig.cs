using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontConnectionFunction
{
    [JsiiInterface(nativeType: typeof(ICloudfrontConnectionFunctionConnectionFunctionConfig), fullyQualifiedName: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfig")]
    public interface ICloudfrontConnectionFunctionConnectionFunctionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#comment CloudfrontConnectionFunction#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        string Comment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#runtime CloudfrontConnectionFunction#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        string Runtime
        {
            get;
        }

        /// <summary>key_value_store_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#key_value_store_association CloudfrontConnectionFunction#key_value_store_association}
        /// </remarks>
        [JsiiProperty(name: "keyValueStoreAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeyValueStoreAssociation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontConnectionFunctionConnectionFunctionConfig), fullyQualifiedName: "aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontConnectionFunction.ICloudfrontConnectionFunctionConnectionFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#comment CloudfrontConnectionFunction#comment}.</summary>
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
            public string Comment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#runtime CloudfrontConnectionFunction#runtime}.</summary>
            [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Runtime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>key_value_store_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_connection_function#key_value_store_association CloudfrontConnectionFunction#key_value_store_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyValueStoreAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontConnectionFunction.CloudfrontConnectionFunctionConnectionFunctionConfigKeyValueStoreAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeyValueStoreAssociation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
