using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfigDefaultSubscribeAuthMode), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode")]
    public interface IAppsyncApiEventConfigDefaultSubscribeAuthMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#auth_type AppsyncApi#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfigDefaultSubscribeAuthMode), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_api#auth_type AppsyncApi#auth_type}.</summary>
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
