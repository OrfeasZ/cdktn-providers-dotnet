using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolOverridePolicy), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicy")]
    public interface ICoreInstancePoolOverridePolicy
    {
        /// <summary>override_statements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_statements CoreInstancePool#override_statements}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "overrideStatements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements\"},\"kind\":\"array\"}}]}}")]
        object OverrideStatements
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolOverridePolicy), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolOverridePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>override_statements block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_statements CoreInstancePool#override_statements}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "overrideStatements", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements\"},\"kind\":\"array\"}}]}}")]
            public object OverrideStatements
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
