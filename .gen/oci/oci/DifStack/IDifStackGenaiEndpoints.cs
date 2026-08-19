using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackGenaiEndpoints), fullyQualifiedName: "oci.difStack.DifStackGenaiEndpoints")]
    public interface IDifStackGenaiEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/dif_stack#endpoint_name DifStack#endpoint_name}.</summary>
        [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/dif_stack#is_content_moderation_enabled DifStack#is_content_moderation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isContentModerationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsContentModerationEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackGenaiEndpoints), fullyQualifiedName: "oci.difStack.DifStackGenaiEndpoints")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackGenaiEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/dif_stack#endpoint_name DifStack#endpoint_name}.</summary>
            [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/dif_stack#is_content_moderation_enabled DifStack#is_content_moderation_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isContentModerationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsContentModerationEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
