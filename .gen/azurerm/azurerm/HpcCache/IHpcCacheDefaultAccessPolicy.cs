using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiInterface(nativeType: typeof(IHpcCacheDefaultAccessPolicy), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDefaultAccessPolicy")]
    public interface IHpcCacheDefaultAccessPolicy
    {
        /// <summary>access_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hpc_cache#access_rule HpcCache#access_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HpcCache.IHpcCacheDefaultAccessPolicyAccessRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "accessRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicyAccessRule\"},\"kind\":\"array\"}}]}}")]
        object AccessRule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHpcCacheDefaultAccessPolicy), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDefaultAccessPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.HpcCache.IHpcCacheDefaultAccessPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hpc_cache#access_rule HpcCache#access_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HpcCache.IHpcCacheDefaultAccessPolicyAccessRule" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "accessRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDefaultAccessPolicyAccessRule\"},\"kind\":\"array\"}}]}}")]
            public object AccessRule
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
