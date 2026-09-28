using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.UpdateResource
{
    [JsiiInterface(nativeType: typeof(IUpdateResourceReadOverride), fullyQualifiedName: "azapi.updateResource.UpdateResourceReadOverride")]
    public interface IUpdateResourceReadOverride
    {
        /// <summary>The name of the action appended to the resource ID, for example `list`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/resources/update_resource#action UpdateResource#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>The HTTP method used to read the resource. The only supported value is `POST`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/resources/update_resource#method UpdateResource#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        string Method
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IUpdateResourceReadOverride), fullyQualifiedName: "azapi.updateResource.UpdateResourceReadOverride")]
        internal sealed class _Proxy : DeputyBase, azapi.UpdateResource.IUpdateResourceReadOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the action appended to the resource ID, for example `list`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/resources/update_resource#action UpdateResource#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The HTTP method used to read the resource. The only supported value is `POST`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.13.0/docs/resources/update_resource#method UpdateResource#method}
            /// </remarks>
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
            public string Method
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
