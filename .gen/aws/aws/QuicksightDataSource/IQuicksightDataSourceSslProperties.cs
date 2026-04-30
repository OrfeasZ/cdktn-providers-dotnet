using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceSslProperties), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceSslProperties")]
    public interface IQuicksightDataSourceSslProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/quicksight_data_source#disable_ssl QuicksightDataSource#disable_ssl}.</summary>
        [JsiiProperty(name: "disableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DisableSsl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceSslProperties), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceSslProperties")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceSslProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/quicksight_data_source#disable_ssl QuicksightDataSource#disable_ssl}.</summary>
            [JsiiProperty(name: "disableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DisableSsl
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
