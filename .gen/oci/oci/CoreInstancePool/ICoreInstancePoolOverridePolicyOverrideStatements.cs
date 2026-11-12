using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatements), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements")]
    public interface ICoreInstancePoolOverridePolicyOverrideStatements
    {
        /// <summary>override_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_options CoreInstancePool#override_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "overrideOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions\"},\"kind\":\"array\"}}]}}")]
        object OverrideOptions
        {
            get;
        }

        /// <summary>selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#selector CoreInstancePool#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsSelector\"}")]
        oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsSelector Selector
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatements), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatements")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>override_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#override_options CoreInstancePool#override_options}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "overrideOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptions\"},\"kind\":\"array\"}}]}}")]
            public object OverrideOptions
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#selector CoreInstancePool#selector}
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsSelector\"}")]
            public oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsSelector Selector
            {
                get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsSelector>()!;
            }
        }
    }
}
