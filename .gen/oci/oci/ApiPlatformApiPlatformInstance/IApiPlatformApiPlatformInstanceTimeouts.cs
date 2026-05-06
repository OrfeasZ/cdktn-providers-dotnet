using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiPlatformApiPlatformInstance
{
    [JsiiInterface(nativeType: typeof(IApiPlatformApiPlatformInstanceTimeouts), fullyQualifiedName: "oci.apiPlatformApiPlatformInstance.ApiPlatformApiPlatformInstanceTimeouts")]
    public interface IApiPlatformApiPlatformInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#create ApiPlatformApiPlatformInstance#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#delete ApiPlatformApiPlatformInstance#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiPlatformApiPlatformInstanceTimeouts), fullyQualifiedName: "oci.apiPlatformApiPlatformInstance.ApiPlatformApiPlatformInstanceTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.ApiPlatformApiPlatformInstance.IApiPlatformApiPlatformInstanceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#create ApiPlatformApiPlatformInstance#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/api_platform_api_platform_instance#delete ApiPlatformApiPlatformInstance#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
